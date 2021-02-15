namespace ASE_admin_app
{
    partial class UserControlCategories
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
            this.buttonEditCategory = new System.Windows.Forms.Button();
            this.buttonMainPanel = new System.Windows.Forms.Button();
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEditCategory
            // 
            this.buttonEditCategory.Location = new System.Drawing.Point(18, 204);
            this.buttonEditCategory.Name = "buttonEditCategory";
            this.buttonEditCategory.Size = new System.Drawing.Size(205, 25);
            this.buttonEditCategory.TabIndex = 0;
            this.buttonEditCategory.Text = "Edit Category";
            this.buttonEditCategory.UseVisualStyleBackColor = true;
            this.buttonEditCategory.Click += new System.EventHandler(this.buttonEditCategory_Click);
            // 
            // buttonMainPanel
            // 
            this.buttonMainPanel.Location = new System.Drawing.Point(18, 235);
            this.buttonMainPanel.Name = "buttonMainPanel";
            this.buttonMainPanel.Size = new System.Drawing.Size(205, 25);
            this.buttonMainPanel.TabIndex = 1;
            this.buttonMainPanel.Text = "Main Panel";
            this.buttonMainPanel.UseVisualStyleBackColor = true;
            this.buttonMainPanel.Click += new System.EventHandler(this.buttonMainPanel_Click);
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.ItemHeight = 16;
            this.listBoxCategories.Location = new System.Drawing.Point(18, 3);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(205, 164);
            this.listBoxCategories.TabIndex = 2;
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(18, 173);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(205, 25);
            this.buttonAddCategory.TabIndex = 3;
            this.buttonAddCategory.Text = "Add new Category";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // UserControlCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAddCategory);
            this.Controls.Add(this.listBoxCategories);
            this.Controls.Add(this.buttonMainPanel);
            this.Controls.Add(this.buttonEditCategory);
            this.Name = "UserControlCategories";
            this.Size = new System.Drawing.Size(250, 270);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEditCategory;
        private System.Windows.Forms.Button buttonMainPanel;
        private System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.Button buttonAddCategory;
    }
}
