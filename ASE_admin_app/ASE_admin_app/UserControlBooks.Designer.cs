namespace ASE_admin_app
{
    partial class UserControlBooks
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEditBook = new System.Windows.Forms.Button();
            this.buttonMainPanel = new System.Windows.Forms.Button();
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.listBoxBonuses = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonNewBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Books";
            // 
            // buttonEditBook
            // 
            this.buttonEditBook.Location = new System.Drawing.Point(95, 378);
            this.buttonEditBook.Name = "buttonEditBook";
            this.buttonEditBook.Size = new System.Drawing.Size(77, 23);
            this.buttonEditBook.TabIndex = 1;
            this.buttonEditBook.Text = "Edit Book";
            this.buttonEditBook.UseVisualStyleBackColor = true;
            this.buttonEditBook.Click += new System.EventHandler(this.buttonEditBook_Click);
            // 
            // buttonMainPanel
            // 
            this.buttonMainPanel.Location = new System.Drawing.Point(3, 378);
            this.buttonMainPanel.Name = "buttonMainPanel";
            this.buttonMainPanel.Size = new System.Drawing.Size(86, 23);
            this.buttonMainPanel.TabIndex = 2;
            this.buttonMainPanel.Text = "Main Panel";
            this.buttonMainPanel.UseVisualStyleBackColor = true;
            this.buttonMainPanel.Click += new System.EventHandler(this.buttonMainPanel_Click);
            // 
            // listBoxBooks
            // 
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.ItemHeight = 16;
            this.listBoxBooks.Location = new System.Drawing.Point(3, 35);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(262, 340);
            this.listBoxBooks.TabIndex = 3;
            this.listBoxBooks.SelectedIndexChanged += new System.EventHandler(this.listBoxBooks_SelectedIndexChanged);
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.ItemHeight = 16;
            this.listBoxData.Location = new System.Drawing.Point(271, 35);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(590, 148);
            this.listBoxData.TabIndex = 6;
            // 
            // listBoxBonuses
            // 
            this.listBoxBonuses.FormattingEnabled = true;
            this.listBoxBonuses.ItemHeight = 16;
            this.listBoxBonuses.Location = new System.Drawing.Point(271, 227);
            this.listBoxBonuses.Name = "listBoxBonuses";
            this.listBoxBonuses.Size = new System.Drawing.Size(590, 148);
            this.listBoxBonuses.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bonuses";
            // 
            // buttonNewBook
            // 
            this.buttonNewBook.Location = new System.Drawing.Point(178, 378);
            this.buttonNewBook.Name = "buttonNewBook";
            this.buttonNewBook.Size = new System.Drawing.Size(87, 23);
            this.buttonNewBook.TabIndex = 12;
            this.buttonNewBook.Text = "New Book";
            this.buttonNewBook.UseVisualStyleBackColor = true;
            this.buttonNewBook.Click += new System.EventHandler(this.buttonNewBook_Click);
            // 
            // UserControlBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonNewBook);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxBonuses);
            this.Controls.Add(this.listBoxData);
            this.Controls.Add(this.listBoxBooks);
            this.Controls.Add(this.buttonMainPanel);
            this.Controls.Add(this.buttonEditBook);
            this.Controls.Add(this.label1);
            this.Name = "UserControlBooks";
            this.Size = new System.Drawing.Size(864, 404);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEditBook;
        private System.Windows.Forms.Button buttonMainPanel;
        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.ListBox listBoxBonuses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonNewBook;
    }
}
