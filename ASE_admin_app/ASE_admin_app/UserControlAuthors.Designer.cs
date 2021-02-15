namespace ASE_admin_app
{
    partial class UserControlAuthors
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
            this.buttonMainPanel = new System.Windows.Forms.Button();
            this.buttonEditAuthor = new System.Windows.Forms.Button();
            this.buttonNewAuthor = new System.Windows.Forms.Button();
            this.listBoxAuthors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Authors";
            // 
            // buttonMainPanel
            // 
            this.buttonMainPanel.Location = new System.Drawing.Point(26, 220);
            this.buttonMainPanel.Name = "buttonMainPanel";
            this.buttonMainPanel.Size = new System.Drawing.Size(184, 23);
            this.buttonMainPanel.TabIndex = 1;
            this.buttonMainPanel.Text = "Main Panel";
            this.buttonMainPanel.UseVisualStyleBackColor = true;
            this.buttonMainPanel.Click += new System.EventHandler(this.buttonMainPanel_Click);
            // 
            // buttonEditAuthor
            // 
            this.buttonEditAuthor.Location = new System.Drawing.Point(26, 278);
            this.buttonEditAuthor.Name = "buttonEditAuthor";
            this.buttonEditAuthor.Size = new System.Drawing.Size(184, 23);
            this.buttonEditAuthor.TabIndex = 2;
            this.buttonEditAuthor.Text = "EditAuthor";
            this.buttonEditAuthor.UseVisualStyleBackColor = true;
            this.buttonEditAuthor.Click += new System.EventHandler(this.buttonEditAuthor_Click);
            // 
            // buttonNewAuthor
            // 
            this.buttonNewAuthor.Location = new System.Drawing.Point(26, 249);
            this.buttonNewAuthor.Name = "buttonNewAuthor";
            this.buttonNewAuthor.Size = new System.Drawing.Size(184, 23);
            this.buttonNewAuthor.TabIndex = 3;
            this.buttonNewAuthor.Text = "New Author";
            this.buttonNewAuthor.UseVisualStyleBackColor = true;
            this.buttonNewAuthor.Click += new System.EventHandler(this.buttonNewAuthor_Click);
            // 
            // listBoxAuthors
            // 
            this.listBoxAuthors.FormattingEnabled = true;
            this.listBoxAuthors.ItemHeight = 16;
            this.listBoxAuthors.Location = new System.Drawing.Point(26, 49);
            this.listBoxAuthors.Name = "listBoxAuthors";
            this.listBoxAuthors.Size = new System.Drawing.Size(184, 164);
            this.listBoxAuthors.TabIndex = 4;
            // 
            // UserControlAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxAuthors);
            this.Controls.Add(this.buttonNewAuthor);
            this.Controls.Add(this.buttonEditAuthor);
            this.Controls.Add(this.buttonMainPanel);
            this.Controls.Add(this.label1);
            this.Name = "UserControlAuthors";
            this.Size = new System.Drawing.Size(262, 345);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMainPanel;
        private System.Windows.Forms.Button buttonEditAuthor;
        private System.Windows.Forms.Button buttonNewAuthor;
        private System.Windows.Forms.ListBox listBoxAuthors;
    }
}
