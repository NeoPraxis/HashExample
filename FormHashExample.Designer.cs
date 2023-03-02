namespace HashExample
{
    partial class FormHashExample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxHashTable = new System.Windows.Forms.ListBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonRehash = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxDelete = new System.Windows.Forms.TextBox();
            this.textBoxHashSize = new System.Windows.Forms.TextBox();
            this.textBoxRehash = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxHashTable
            // 
            this.listBoxHashTable.FormattingEnabled = true;
            this.listBoxHashTable.ItemHeight = 16;
            this.listBoxHashTable.Location = new System.Drawing.Point(12, 12);
            this.listBoxHashTable.Name = "listBoxHashTable";
            this.listBoxHashTable.Size = new System.Drawing.Size(120, 340);
            this.listBoxHashTable.TabIndex = 0;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(218, 12);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(92, 29);
            this.buttonGo.TabIndex = 1;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // buttonRehash
            // 
            this.buttonRehash.Location = new System.Drawing.Point(218, 47);
            this.buttonRehash.Name = "buttonRehash";
            this.buttonRehash.Size = new System.Drawing.Size(92, 29);
            this.buttonRehash.TabIndex = 2;
            this.buttonRehash.Text = "Rehash";
            this.buttonRehash.UseVisualStyleBackColor = true;
            this.buttonRehash.Click += new System.EventHandler(this.buttonRehash_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(218, 82);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(92, 29);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add Value";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(144, 85);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(68, 22);
            this.textBoxAdd.TabIndex = 4;
            this.textBoxAdd.TextChanged += new System.EventHandler(this.textBoxAdd_TextChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(144, 120);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(68, 22);
            this.textBoxSearch.TabIndex = 5;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(218, 117);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(92, 29);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(218, 152);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(92, 29);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxDelete
            // 
            this.textBoxDelete.Location = new System.Drawing.Point(144, 155);
            this.textBoxDelete.Name = "textBoxDelete";
            this.textBoxDelete.Size = new System.Drawing.Size(68, 22);
            this.textBoxDelete.TabIndex = 8;
            // 
            // textBoxHashSize
            // 
            this.textBoxHashSize.Location = new System.Drawing.Point(144, 15);
            this.textBoxHashSize.Name = "textBoxHashSize";
            this.textBoxHashSize.Size = new System.Drawing.Size(68, 22);
            this.textBoxHashSize.TabIndex = 9;
            // 
            // textBoxRehash
            // 
            this.textBoxRehash.Location = new System.Drawing.Point(144, 50);
            this.textBoxRehash.Name = "textBoxRehash";
            this.textBoxRehash.Size = new System.Drawing.Size(68, 22);
            this.textBoxRehash.TabIndex = 10;
            // 
            // FormHashExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 368);
            this.Controls.Add(this.textBoxRehash);
            this.Controls.Add(this.textBoxHashSize);
            this.Controls.Add(this.textBoxDelete);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.textBoxAdd);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRehash);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.listBoxHashTable);
            this.Name = "FormHashExample";
            this.Text = "FormHashExample";
            this.Load += new System.EventHandler(this.FormHashExample_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxHashTable;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonRehash;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxDelete;
        private System.Windows.Forms.TextBox textBoxHashSize;
        private System.Windows.Forms.TextBox textBoxRehash;
    }
}

