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
            this.SuspendLayout();
            // 
            // listBoxHashTable
            // 
            this.listBoxHashTable.FormattingEnabled = true;
            this.listBoxHashTable.ItemHeight = 16;
            this.listBoxHashTable.Location = new System.Drawing.Point(12, 12);
            this.listBoxHashTable.Name = "listBoxHashTable";
            this.listBoxHashTable.Size = new System.Drawing.Size(250, 420);
            this.listBoxHashTable.TabIndex = 0;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(342, 13);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(92, 29);
            this.buttonGo.TabIndex = 1;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // buttonRehash
            // 
            this.buttonRehash.Location = new System.Drawing.Point(342, 48);
            this.buttonRehash.Name = "buttonRehash";
            this.buttonRehash.Size = new System.Drawing.Size(92, 29);
            this.buttonRehash.TabIndex = 2;
            this.buttonRehash.Text = "Rehash";
            this.buttonRehash.UseVisualStyleBackColor = true;
            this.buttonRehash.Click += new System.EventHandler(this.buttonRehash_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(342, 140);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(92, 29);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add Value";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(268, 143);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(68, 22);
            this.textBoxAdd.TabIndex = 4;
            this.textBoxAdd.TextChanged += new System.EventHandler(this.textBoxAdd_TextChanged);
            // 
            // FormHashExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 450);
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
    }
}

