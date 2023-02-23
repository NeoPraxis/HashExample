using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HashExample
{
    public partial class FormHashExample : Form
    {
        public FormHashExample()
        {
            InitializeComponent();
        }
        KMCHashTable myHash = new KMCHashTable(5);
        private void FormHashExample_Load(object sender, EventArgs e)
        {

        }

        private void DisplayHashTable()
        {
            foreach (int value in myHash)
            {
                listBoxHashTable.Items.Add(value);
            }
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            DisplayHashTable();
        }

        private void buttonRehash_Click(object sender, EventArgs e)
        {
            listBoxHashTable.Items.Add(String.Empty);
            listBoxHashTable.Items.Add("Rehash");
            myHash = new KMCHashTable(200, myHash);
            DisplayHashTable();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int keyValue;
            keyValue = Convert.ToInt32(textBoxAdd.Text);
            myHash.Add(keyValue);
            listBoxHashTable.Items.Clear();
            DisplayHashTable();
        }

        private void textBoxAdd_TextChanged(object sender, EventArgs e)
        {
            
            //DisplayHashTable();

        }
    }
}
