/* ********************************************************************
 * Projct:      Hash Example
 * File:        FormHashTable
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
 *                      - added basic buttons for class logic
 * 0.2   KMC 02/23/2023 - added all buttons needed for hw
 * *******************************************************************/
using System;
using System.Windows.Forms;

namespace HashExample
{
    public partial class FormHashExample : Form
    {
        public FormHashExample()
        {
            InitializeComponent();
        }
        // set hash size to 0 so the user can mutate it later
        int hashSize = 0;

        // for some reason we have to use 1 here or else the code does not work?
        KMCHashTable myHash = new KMCHashTable(1);
        private void FormHashExample_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This method displays the hash table
        /// </summary>
        private void DisplayHashTable()
        {


            foreach (int value in myHash)
            {
                listBoxHashTable.Items.Add(value);
            }
        }
        /// <summary>
        /// This button executes the code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGo_Click(object sender, EventArgs e)
        {
            try
            {
                hashSize = Convert.ToInt32(textBoxHashSize.Text);
                myHash = new KMCHashTable(hashSize);
                DisplayHashTable();
                textBoxHashSize.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Thus button rehashes the users hash table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRehash_Click(object sender, EventArgs e)
        {
            try
            {
                hashSize = Convert.ToInt32(textBoxRehash.Text);
                listBoxHashTable.Items.Add(String.Empty);
                listBoxHashTable.Items.Add("Rehash");
                myHash = new KMCHashTable(hashSize, myHash);
                DisplayHashTable();
                textBoxRehash.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This button adds a value to the hash table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int keyValue;
                keyValue = Convert.ToInt32(textBoxAdd.Text);
                myHash.Add(keyValue);
                listBoxHashTable.Items.Clear();
                DisplayHashTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        private void textBoxAdd_TextChanged(object sender, EventArgs e)
        {

            //DisplayHashTable();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This button searches the table and returns the index at where it is
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int keyValue;
                keyValue = Convert.ToInt32(textBoxSearch.Text);
                myHash.Search(keyValue);
                listBoxHashTable.Items.Clear();
                DisplayHashTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// This button deletes the user selected value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int keyValue;
                keyValue = Convert.ToInt32(textBoxDelete.Text);
                myHash.Delete(keyValue);
                listBoxHashTable.Items.Clear();
                DisplayHashTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
