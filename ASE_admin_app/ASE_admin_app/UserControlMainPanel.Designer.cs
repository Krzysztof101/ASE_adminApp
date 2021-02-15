namespace ASE_admin_app
{
    partial class UserControlMainPanel
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
            this.buttonBooks = new System.Windows.Forms.Button();
            this.buttonAuthors = new System.Windows.Forms.Button();
            this.buttonRecommendationsSystem = new System.Windows.Forms.Button();
            this.buttonCategories = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBooks
            // 
            this.buttonBooks.Location = new System.Drawing.Point(102, 23);
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.Size = new System.Drawing.Size(166, 56);
            this.buttonBooks.TabIndex = 0;
            this.buttonBooks.Text = "Books";
            this.buttonBooks.UseVisualStyleBackColor = true;
            this.buttonBooks.Click += new System.EventHandler(this.buttonBooks_Click);
            // 
            // buttonAuthors
            // 
            this.buttonAuthors.Location = new System.Drawing.Point(102, 85);
            this.buttonAuthors.Name = "buttonAuthors";
            this.buttonAuthors.Size = new System.Drawing.Size(166, 56);
            this.buttonAuthors.TabIndex = 1;
            this.buttonAuthors.Text = "Authors";
            this.buttonAuthors.UseVisualStyleBackColor = true;
            this.buttonAuthors.Click += new System.EventHandler(this.buttonAuthors_Click);
            // 
            // buttonRecommendationsSystem
            // 
            this.buttonRecommendationsSystem.Location = new System.Drawing.Point(102, 214);
            this.buttonRecommendationsSystem.Name = "buttonRecommendationsSystem";
            this.buttonRecommendationsSystem.Size = new System.Drawing.Size(166, 56);
            this.buttonRecommendationsSystem.TabIndex = 2;
            this.buttonRecommendationsSystem.Text = "Recommendations System";
            this.buttonRecommendationsSystem.UseVisualStyleBackColor = true;
            this.buttonRecommendationsSystem.Click += new System.EventHandler(this.buttonRecommendationsSystem_Click);
            // 
            // buttonCategories
            // 
            this.buttonCategories.Location = new System.Drawing.Point(102, 147);
            this.buttonCategories.Name = "buttonCategories";
            this.buttonCategories.Size = new System.Drawing.Size(166, 56);
            this.buttonCategories.TabIndex = 3;
            this.buttonCategories.Text = "Categories";
            this.buttonCategories.UseVisualStyleBackColor = true;
            this.buttonCategories.Click += new System.EventHandler(this.buttonCategories_Click);
            // 
            // UserControlMainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCategories);
            this.Controls.Add(this.buttonRecommendationsSystem);
            this.Controls.Add(this.buttonAuthors);
            this.Controls.Add(this.buttonBooks);
            this.Name = "UserControlMainPanel";
            this.Size = new System.Drawing.Size(373, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBooks;
        private System.Windows.Forms.Button buttonAuthors;
        private System.Windows.Forms.Button buttonRecommendationsSystem;
        private System.Windows.Forms.Button buttonCategories;
    }
}
