// common header goes here
// change enumeration from string to int, to match data for outputs
// constructor chaining!!!
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HashExample
{
    internal class KMCHashTable : IEnumerable<int>
    {
        #region enum
        #endregion enum

        #region constants
        // index unused is an index that has NEVER been used
        public const int UNUSED = int.MinValue;
        // index available is an index that is CURRENTLY unused
        public const int AVAILABLE = int.MinValue + 1;
        // the hash table is full
        public const int FULL = int.MinValue;
        #endregion constants

        #region data
        private int[] hashTable;

        // the number of USED spaces in the Hash Table
        public int NumberEntries { get; private set; }

        // The size of the hash table
        public int Size { get; private set; }

        public int userEnteredValue { get; private set; }
        #endregion data

        #region properties
        #endregion properties

        #region constructor
        /// <summary>
        /// This routine will create a hashtable of the desired size, size must be greater than zero
        /// </summary>
        /// <param name="size"></param>
        /// <exception cref="ArgumentException"></exception>
        public KMCHashTable(int size, KMCHashTable oldHashTable = null)
        {
            if (size <= 0)
            {
                throw new ArgumentException("You must give a valid size greater than Zero");
            }
            if ((oldHashTable != null) && (size <= oldHashTable.NumberEntries))
            {
                throw new ArgumentOutOfRangeException("New hash table is too small");

            }

            this.hashTable = new int[size];
            this.NumberEntries = 0;
            this.Size = size;

            // initialize the hash table
            for (int index = 0; index <= hashTable.GetUpperBound(0); index++)
            {
                hashTable[index] = UNUSED;
            }

            // if there is an old hash table, then rehash the data

            if (oldHashTable != null)
            {
                foreach (int keyValue in oldHashTable)
                {
                    if (keyValue >= 0)
                    {
                        Add(keyValue);
                    }
                }
            }
        }
        #endregion constructor

        #region methods
        /// <summary>
        /// This method adds
        /// </summary>
        /// <param name="keyValue"></param>
        public void Add(int keyValue)
        {
            try
            {
                int index = HashFunction(keyValue);

                if (hashTable[index] == UNUSED || hashTable[index] == AVAILABLE)
                {
                    hashTable[index] = keyValue;
                }
            }
            catch (Exception)
            {
                throw new Exception("HashTable Is full");          
            }
        }

        /// <summary>
        /// This routine will generate the apropriate hash value for the input key.
        /// </summary>
        /// <param name="keyValue"></param>
        /// <returns></returns>
        public int HashFunction(int keyValue)
        {
            int visitCounter = 0;
            int firstAvailable = -1;
            int index = keyValue % Size;
            //int addUserValue = userEnteredValue;
            //Console.WriteLine(addUserValue);
            //
            while ((hashTable[index] != keyValue)
                && (hashTable[index] != UNUSED)
                && (visitCounter <= Size))
            {
                if ((firstAvailable == -1) && (hashTable[index] == AVAILABLE))
                {
                    // found the first available spot
                    firstAvailable = index;
                }

                // move to the next spot
                index++;

                // have we gone past the end of the array
                if (index == Size)
                {
                    index = 0;
                }

                // increment the counter
                visitCounter++;
            }
            if (hashTable[index] != keyValue)
            {
                if (firstAvailable != -1)
                {
                    index = firstAvailable;
                }
                else
                {
                    if (visitCounter >= Size)
                    {
                        index = FULL;
                    }
                }
            }
            return index;
        }

        /*public KMCHashTable(int size, KMCHashTable oldHashTable) : this(size)
        {
            *//*if (size <= 0)
            {
                throw new ArgumentOutOfRangeException("Size must be greater than zero");

            }*//*
            if (size < oldHashTable.NumberEntries)
            {
                throw new ArgumentOutOfRangeException("The hash table is too small");
            }

           *//* this.hashTable = new int[size];
            this.NumberEntries = 0;
            this.Size = size;*/

        /*for (int index = 0; index <= hashTable.GetUpperBound(0); index++)
        {
            hashTable[index] = UNUSED;
        }*//*

        foreach (int keyValue in oldHashTable)
        {
            if (keyValue >= 0)
            {
                Add(keyValue);

            }
        }
        *//*for (int index = 0; index < oldHashTable.Size; index++)
        {
            if (oldHashTable[index] > -1)
            {
                Add(oldHashTable[index]);
            }
        }*//*
    }*/
        #endregion methods

        #region enumeration
        public IEnumerator<int> GetEnumerator()
        {
            // start at the front of the hashtable, index = 0;
            for (int index = 0; index <= hashTable.GetUpperBound(0); index++)
            {
                // bad design
                //yield return String.Format("[{0}] = {1}", index.ToString(), hashTable[index].ToString());
                yield return hashTable[index];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion enumeration


    }
}
