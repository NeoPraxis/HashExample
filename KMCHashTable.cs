/* ********************************************************************
 * Projct:      Hash Example
 * File:        KMCHashTable
 * Language:    C#
 * 
 * Desription:  This program will demonstrate a simple hastable
 *              
 * College:     Husson University
 * Course:      IT 325
 * 
 * Edit History:
 * Ver   Who Date       Notes
 * ----- --- ---------- -----------------------------------------------
 * 0.1   KMC 02/21/2023 - initial writing
 *                      - created properties
 *                      - wrote default constructor
 *                      - all code from class
 * 0.2   KMC 02/23/2022 - started hashtable HW implementation
 *                      - added buttons and UI
 *                      - added basic stubs
 * 0.3   GPW 02/24/2022 - Added logical and imported search function from search class code
 *                      - Fixed issue where delete would not delete last value
 *                      - Fixed issue where add would add 1 more value than the anticipated array
 *                      - Fixed issue where Search would return null for some reason
 * *******************************************************************/
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

        public const int NOT_FOUND = -1;
        #endregion constants

        #region data
        private int[] hashTable;

        // the number of USED spaces in the Hash Table
        public int NumberEntries { get; private set; }

        // The size of the hash table
        public int Size { get; private set; }
        // users value they enter
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
        /// Search the array between lower and upper index inclusive for the key value
        /// If found, return the first array index where the key value was found
        /// If not found, return NOT_FOUND
        /// </summary>
        /// <param name="data"></param>
        /// <param name="key"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public void Search(int keyValue)
        {
            int index = HashFunction(keyValue);


            // loop through the array searching for the desired key
            try
            {
                while (hashTable[index] != keyValue)
                {
                    index++;
                }

                if (hashTable[index] == keyValue)
                {
                    MessageBox.Show("Value is at Index: " + index.ToString());
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Value not found");
            }


        }
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
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("HashTable is full");
            }
        }
        /// <summary>
        /// This method deletes a value at the index the user selects
        /// </summary>
        /// <param name="keyValue"></param>
        public void Delete(int keyValue)
        {
            int index = HashFunction(keyValue);

            while (hashTable[index] != keyValue)
            {
                index++;
            }

            if (hashTable[index] == keyValue)
            {
                MessageBox.Show("Value at index: " + index.ToString() + ", is deleted.");
            }

            hashTable[index] = AVAILABLE;

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
