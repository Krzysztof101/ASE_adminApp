namespace ASE_admin_app
{
    partial class UserControlEditBooks
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
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonBooks = new System.Windows.Forms.Button();
            this.labeldDesc = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelTitleDesc = new System.Windows.Forms.Label();
            this.labelPriceDesc = new System.Windows.Forms.Label();
            this.buttonCommit = new System.Windows.Forms.Button();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantityDesc = new System.Windows.Forms.Label();
            this.dateTimeStartSelling = new System.Windows.Forms.DateTimePicker();
            this.checkBoxDeleted = new System.Windows.Forms.CheckBox();
            this.labelStartSellingDesc = new System.Windows.Forms.Label();
            this.panelGeneralData = new System.Windows.Forms.Panel();
            this.listBoxThisBookAuthors = new System.Windows.Forms.ListBox();
            this.listBoxOtherAuthors = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxThisBookCategories = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxOtherCategories = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxThisBookBonuses = new System.Windows.Forms.ListBox();
            this.buttonMoveCategory = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeBonusStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBonusEnd = new System.Windows.Forms.DateTimePicker();
            this.textBoxBonusScore = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonBonusAdd = new System.Windows.Forms.Button();
            this.panelBonus = new System.Windows.Forms.Panel();
            this.buttonDeleteBonus = new System.Windows.Forms.Button();
            this.buttonMoveAuthor = new System.Windows.Forms.Button();
            this.panelGeneralData.SuspendLayout();
            this.panelBonus.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(27, 11);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(69, 17);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "Add Book";
            // 
            // buttonBooks
            // 
            this.buttonBooks.Location = new System.Drawing.Point(470, 600);
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.Size = new System.Drawing.Size(75, 23);
            this.buttonBooks.TabIndex = 1;
            this.buttonBooks.Text = "Books";
            this.buttonBooks.UseVisualStyleBackColor = true;
            this.buttonBooks.Click += new System.EventHandler(this.buttonBooks_Click);
            // 
            // labeldDesc
            // 
            this.labeldDesc.AutoSize = true;
            this.labeldDesc.Location = new System.Drawing.Point(185, 9);
            this.labeldDesc.Name = "labeldDesc";
            this.labeldDesc.Size = new System.Drawing.Size(27, 17);
            this.labeldDesc.TabIndex = 2;
            this.labeldDesc.Text = "id: ";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(215, 9);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(24, 17);
            this.labelID.TabIndex = 3;
            this.labelID.Text = "<>";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(218, 29);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(239, 22);
            this.textBoxTitle.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(218, 57);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(239, 22);
            this.textBoxPrice.TabIndex = 5;
            // 
            // labelTitleDesc
            // 
            this.labelTitleDesc.AutoSize = true;
            this.labelTitleDesc.Location = new System.Drawing.Point(177, 32);
            this.labelTitleDesc.Name = "labelTitleDesc";
            this.labelTitleDesc.Size = new System.Drawing.Size(35, 17);
            this.labelTitleDesc.TabIndex = 6;
            this.labelTitleDesc.Text = "Title";
            // 
            // labelPriceDesc
            // 
            this.labelPriceDesc.AutoSize = true;
            this.labelPriceDesc.Location = new System.Drawing.Point(172, 60);
            this.labelPriceDesc.Name = "labelPriceDesc";
            this.labelPriceDesc.Size = new System.Drawing.Size(40, 17);
            this.labelPriceDesc.TabIndex = 7;
            this.labelPriceDesc.Text = "Price";
            // 
            // buttonCommit
            // 
            this.buttonCommit.Location = new System.Drawing.Point(470, 571);
            this.buttonCommit.Name = "buttonCommit";
            this.buttonCommit.Size = new System.Drawing.Size(75, 23);
            this.buttonCommit.TabIndex = 8;
            this.buttonCommit.Text = "Commit";
            this.buttonCommit.UseVisualStyleBackColor = true;
            this.buttonCommit.Click += new System.EventHandler(this.buttonCommit_Click);
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Location = new System.Drawing.Point(218, 85);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(239, 22);
            this.textBoxDiscount.TabIndex = 9;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(7, 88);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(205, 17);
            this.labelDiscount.TabIndex = 10;
            this.labelDiscount.Text = "Price minus discount in procent";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(218, 113);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(239, 22);
            this.textBoxQuantity.TabIndex = 11;
            // 
            // labelQuantityDesc
            // 
            this.labelQuantityDesc.AutoSize = true;
            this.labelQuantityDesc.Location = new System.Drawing.Point(151, 116);
            this.labelQuantityDesc.Name = "labelQuantityDesc";
            this.labelQuantityDesc.Size = new System.Drawing.Size(61, 17);
            this.labelQuantityDesc.TabIndex = 12;
            this.labelQuantityDesc.Text = "Quantity";
            // 
            // dateTimeStartSelling
            // 
            this.dateTimeStartSelling.Location = new System.Drawing.Point(218, 141);
            this.dateTimeStartSelling.Name = "dateTimeStartSelling";
            this.dateTimeStartSelling.Size = new System.Drawing.Size(239, 22);
            this.dateTimeStartSelling.TabIndex = 13;
            // 
            // checkBoxDeleted
            // 
            this.checkBoxDeleted.AutoSize = true;
            this.checkBoxDeleted.Location = new System.Drawing.Point(218, 169);
            this.checkBoxDeleted.Name = "checkBoxDeleted";
            this.checkBoxDeleted.Size = new System.Drawing.Size(79, 21);
            this.checkBoxDeleted.TabIndex = 15;
            this.checkBoxDeleted.Text = "Deleted";
            this.checkBoxDeleted.UseVisualStyleBackColor = true;
            // 
            // labelStartSellingDesc
            // 
            this.labelStartSellingDesc.AutoSize = true;
            this.labelStartSellingDesc.Location = new System.Drawing.Point(100, 146);
            this.labelStartSellingDesc.Name = "labelStartSellingDesc";
            this.labelStartSellingDesc.Size = new System.Drawing.Size(112, 17);
            this.labelStartSellingDesc.TabIndex = 16;
            this.labelStartSellingDesc.Text = "start selling date";
            // 
            // panelGeneralData
            // 
            this.panelGeneralData.Controls.Add(this.labelTitleDesc);
            this.panelGeneralData.Controls.Add(this.labelStartSellingDesc);
            this.panelGeneralData.Controls.Add(this.labeldDesc);
            this.panelGeneralData.Controls.Add(this.checkBoxDeleted);
            this.panelGeneralData.Controls.Add(this.labelID);
            this.panelGeneralData.Controls.Add(this.dateTimeStartSelling);
            this.panelGeneralData.Controls.Add(this.textBoxTitle);
            this.panelGeneralData.Controls.Add(this.labelQuantityDesc);
            this.panelGeneralData.Controls.Add(this.textBoxPrice);
            this.panelGeneralData.Controls.Add(this.textBoxQuantity);
            this.panelGeneralData.Controls.Add(this.labelPriceDesc);
            this.panelGeneralData.Controls.Add(this.labelDiscount);
            this.panelGeneralData.Controls.Add(this.textBoxDiscount);
            this.panelGeneralData.Location = new System.Drawing.Point(3, 31);
            this.panelGeneralData.Name = "panelGeneralData";
            this.panelGeneralData.Size = new System.Drawing.Size(461, 192);
            this.panelGeneralData.TabIndex = 17;
            // 
            // listBoxThisBookAuthors
            // 
            this.listBoxThisBookAuthors.FormattingEnabled = true;
            this.listBoxThisBookAuthors.ItemHeight = 16;
            this.listBoxThisBookAuthors.Location = new System.Drawing.Point(3, 246);
            this.listBoxThisBookAuthors.Name = "listBoxThisBookAuthors";
            this.listBoxThisBookAuthors.Size = new System.Drawing.Size(461, 116);
            this.listBoxThisBookAuthors.TabIndex = 18;
            this.listBoxThisBookAuthors.Click += new System.EventHandler(this.listBoxThisBookAuthors_Click);
            this.listBoxThisBookAuthors.SelectedIndexChanged += new System.EventHandler(this.listBoxThisBookAuthors_SelectedIndexChanged);
            // 
            // listBoxOtherAuthors
            // 
            this.listBoxOtherAuthors.FormattingEnabled = true;
            this.listBoxOtherAuthors.ItemHeight = 16;
            this.listBoxOtherAuthors.Location = new System.Drawing.Point(3, 427);
            this.listBoxOtherAuthors.Name = "listBoxOtherAuthors";
            this.listBoxOtherAuthors.Size = new System.Drawing.Size(461, 196);
            this.listBoxOtherAuthors.TabIndex = 19;
            this.listBoxOtherAuthors.Click += new System.EventHandler(this.listBoxOtherAuthors_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "This book authors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Other authors";
            // 
            // listBoxThisBookCategories
            // 
            this.listBoxThisBookCategories.FormattingEnabled = true;
            this.listBoxThisBookCategories.ItemHeight = 16;
            this.listBoxThisBookCategories.Location = new System.Drawing.Point(470, 31);
            this.listBoxThisBookCategories.Name = "listBoxThisBookCategories";
            this.listBoxThisBookCategories.Size = new System.Drawing.Size(205, 180);
            this.listBoxThisBookCategories.TabIndex = 22;
            this.listBoxThisBookCategories.Click += new System.EventHandler(this.listBoxThisBookCategories_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "This book categories";
            // 
            // listBoxOtherCategories
            // 
            this.listBoxOtherCategories.FormattingEnabled = true;
            this.listBoxOtherCategories.ItemHeight = 16;
            this.listBoxOtherCategories.Location = new System.Drawing.Point(790, 31);
            this.listBoxOtherCategories.Name = "listBoxOtherCategories";
            this.listBoxOtherCategories.Size = new System.Drawing.Size(205, 180);
            this.listBoxOtherCategories.TabIndex = 24;
            this.listBoxOtherCategories.Click += new System.EventHandler(this.listBoxOtherCategories_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(796, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Other categories";
            // 
            // listBoxThisBookBonuses
            // 
            this.listBoxThisBookBonuses.FormattingEnabled = true;
            this.listBoxThisBookBonuses.ItemHeight = 16;
            this.listBoxThisBookBonuses.Location = new System.Drawing.Point(6, 25);
            this.listBoxThisBookBonuses.Name = "listBoxThisBookBonuses";
            this.listBoxThisBookBonuses.Size = new System.Drawing.Size(516, 196);
            this.listBoxThisBookBonuses.TabIndex = 26;
            // 
            // buttonMoveCategory
            // 
            this.buttonMoveCategory.Location = new System.Drawing.Point(695, 93);
            this.buttonMoveCategory.Name = "buttonMoveCategory";
            this.buttonMoveCategory.Size = new System.Drawing.Size(75, 43);
            this.buttonMoveCategory.TabIndex = 27;
            this.buttonMoveCategory.Text = "Move category";
            this.buttonMoveCategory.UseVisualStyleBackColor = true;
            this.buttonMoveCategory.Click += new System.EventHandler(this.buttonMoveCategory_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "This book bonuses";
            // 
            // dateTimeBonusStart
            // 
            this.dateTimeBonusStart.Location = new System.Drawing.Point(262, 238);
            this.dateTimeBonusStart.Name = "dateTimeBonusStart";
            this.dateTimeBonusStart.Size = new System.Drawing.Size(259, 22);
            this.dateTimeBonusStart.TabIndex = 29;
            // 
            // dateTimeBonusEnd
            // 
            this.dateTimeBonusEnd.Location = new System.Drawing.Point(262, 266);
            this.dateTimeBonusEnd.Name = "dateTimeBonusEnd";
            this.dateTimeBonusEnd.Size = new System.Drawing.Size(259, 22);
            this.dateTimeBonusEnd.TabIndex = 30;
            // 
            // textBoxBonusScore
            // 
            this.textBoxBonusScore.Location = new System.Drawing.Point(262, 294);
            this.textBoxBonusScore.Name = "textBoxBonusScore";
            this.textBoxBonusScore.Size = new System.Drawing.Size(128, 22);
            this.textBoxBonusScore.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Bonus period start";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Bonus period end";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Score";
            // 
            // buttonBonusAdd
            // 
            this.buttonBonusAdd.Location = new System.Drawing.Point(396, 293);
            this.buttonBonusAdd.Name = "buttonBonusAdd";
            this.buttonBonusAdd.Size = new System.Drawing.Size(125, 23);
            this.buttonBonusAdd.TabIndex = 35;
            this.buttonBonusAdd.Text = "Add bonus";
            this.buttonBonusAdd.UseVisualStyleBackColor = true;
            this.buttonBonusAdd.Click += new System.EventHandler(this.buttonBonusAdd_Click);
            // 
            // panelBonus
            // 
            this.panelBonus.Controls.Add(this.buttonDeleteBonus);
            this.panelBonus.Controls.Add(this.listBoxThisBookBonuses);
            this.panelBonus.Controls.Add(this.buttonBonusAdd);
            this.panelBonus.Controls.Add(this.label5);
            this.panelBonus.Controls.Add(this.label8);
            this.panelBonus.Controls.Add(this.dateTimeBonusStart);
            this.panelBonus.Controls.Add(this.label7);
            this.panelBonus.Controls.Add(this.dateTimeBonusEnd);
            this.panelBonus.Controls.Add(this.label6);
            this.panelBonus.Controls.Add(this.textBoxBonusScore);
            this.panelBonus.Location = new System.Drawing.Point(471, 221);
            this.panelBonus.Name = "panelBonus";
            this.panelBonus.Size = new System.Drawing.Size(531, 321);
            this.panelBonus.TabIndex = 36;
            // 
            // buttonDeleteBonus
            // 
            this.buttonDeleteBonus.Location = new System.Drawing.Point(6, 254);
            this.buttonDeleteBonus.Name = "buttonDeleteBonus";
            this.buttonDeleteBonus.Size = new System.Drawing.Size(75, 60);
            this.buttonDeleteBonus.TabIndex = 37;
            this.buttonDeleteBonus.Text = "Delete bonus";
            this.buttonDeleteBonus.UseVisualStyleBackColor = true;
            this.buttonDeleteBonus.Click += new System.EventHandler(this.buttonDeleteBonus_Click);
            // 
            // buttonMoveAuthor
            // 
            this.buttonMoveAuthor.Location = new System.Drawing.Point(183, 371);
            this.buttonMoveAuthor.Name = "buttonMoveAuthor";
            this.buttonMoveAuthor.Size = new System.Drawing.Size(75, 51);
            this.buttonMoveAuthor.TabIndex = 37;
            this.buttonMoveAuthor.Text = "Move author";
            this.buttonMoveAuthor.UseVisualStyleBackColor = true;
            this.buttonMoveAuthor.Click += new System.EventHandler(this.buttonMoveAuthor_Click);
            // 
            // UserControlEditBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonMoveAuthor);
            this.Controls.Add(this.panelBonus);
            this.Controls.Add(this.buttonMoveCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxOtherCategories);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxThisBookCategories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxOtherAuthors);
            this.Controls.Add(this.listBoxThisBookAuthors);
            this.Controls.Add(this.panelGeneralData);
            this.Controls.Add(this.buttonCommit);
            this.Controls.Add(this.buttonBooks);
            this.Controls.Add(this.labelDescription);
            this.Name = "UserControlEditBooks";
            this.Size = new System.Drawing.Size(1012, 638);
            this.panelGeneralData.ResumeLayout(false);
            this.panelGeneralData.PerformLayout();
            this.panelBonus.ResumeLayout(false);
            this.panelBonus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonBooks;
        private System.Windows.Forms.Label labeldDesc;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelTitleDesc;
        private System.Windows.Forms.Label labelPriceDesc;
        private System.Windows.Forms.Button buttonCommit;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelQuantityDesc;
        private System.Windows.Forms.DateTimePicker dateTimeStartSelling;
        private System.Windows.Forms.CheckBox checkBoxDeleted;
        private System.Windows.Forms.Label labelStartSellingDesc;
        private System.Windows.Forms.Panel panelGeneralData;
        private System.Windows.Forms.ListBox listBoxThisBookAuthors;
        private System.Windows.Forms.ListBox listBoxOtherAuthors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxThisBookCategories;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxOtherCategories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxThisBookBonuses;
        private System.Windows.Forms.Button buttonMoveCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeBonusStart;
        private System.Windows.Forms.DateTimePicker dateTimeBonusEnd;
        private System.Windows.Forms.TextBox textBoxBonusScore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonBonusAdd;
        private System.Windows.Forms.Panel panelBonus;
        private System.Windows.Forms.Button buttonDeleteBonus;
        private System.Windows.Forms.Button buttonMoveAuthor;
    }
}
