namespace ASE_admin_app
{
    partial class UserControlRecommendationsSystem
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
            this.listBoxModules = new System.Windows.Forms.ListBox();
            this.listBoxSubmultiplicators = new System.Windows.Forms.ListBox();
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.textBoxSub = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.buttonSetMain = new System.Windows.Forms.Button();
            this.buttonSetSub = new System.Windows.Forms.Button();
            this.buttonMainPanel = new System.Windows.Forms.Button();
            this.buttonCommit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxModules
            // 
            this.listBoxModules.FormattingEnabled = true;
            this.listBoxModules.ItemHeight = 16;
            this.listBoxModules.Location = new System.Drawing.Point(14, 35);
            this.listBoxModules.Name = "listBoxModules";
            this.listBoxModules.Size = new System.Drawing.Size(169, 212);
            this.listBoxModules.TabIndex = 0;
            this.listBoxModules.SelectedIndexChanged += new System.EventHandler(this.listBoxModules_SelectedIndexChanged);
            // 
            // listBoxSubmultiplicators
            // 
            this.listBoxSubmultiplicators.FormattingEnabled = true;
            this.listBoxSubmultiplicators.ItemHeight = 16;
            this.listBoxSubmultiplicators.Location = new System.Drawing.Point(189, 35);
            this.listBoxSubmultiplicators.Name = "listBoxSubmultiplicators";
            this.listBoxSubmultiplicators.Size = new System.Drawing.Size(169, 212);
            this.listBoxSubmultiplicators.TabIndex = 1;
            this.listBoxSubmultiplicators.SelectedIndexChanged += new System.EventHandler(this.listBoxSubmultiplicators_SelectedIndexChanged);
            // 
            // textBoxMain
            // 
            this.textBoxMain.Location = new System.Drawing.Point(14, 282);
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.Size = new System.Drawing.Size(100, 22);
            this.textBoxMain.TabIndex = 2;
            // 
            // textBoxSub
            // 
            this.textBoxSub.Location = new System.Drawing.Point(258, 282);
            this.textBoxSub.Name = "textBoxSub";
            this.textBoxSub.Size = new System.Drawing.Size(100, 22);
            this.textBoxSub.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "set main multiplicator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "set subMultiplicator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Modules";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "SubMultiplicators";
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Location = new System.Drawing.Point(131, 282);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(98, 21);
            this.checkBoxActive.TabIndex = 8;
            this.checkBoxActive.Text = "checkBox1";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            this.checkBoxActive.CheckedChanged += new System.EventHandler(this.checkBoxActive_CheckedChanged);
            // 
            // buttonSetMain
            // 
            this.buttonSetMain.Location = new System.Drawing.Point(14, 310);
            this.buttonSetMain.Name = "buttonSetMain";
            this.buttonSetMain.Size = new System.Drawing.Size(100, 23);
            this.buttonSetMain.TabIndex = 9;
            this.buttonSetMain.Text = "set";
            this.buttonSetMain.UseVisualStyleBackColor = true;
            this.buttonSetMain.Click += new System.EventHandler(this.buttonSetMain_Click);
            // 
            // buttonSetSub
            // 
            this.buttonSetSub.Location = new System.Drawing.Point(258, 310);
            this.buttonSetSub.Name = "buttonSetSub";
            this.buttonSetSub.Size = new System.Drawing.Size(100, 23);
            this.buttonSetSub.TabIndex = 10;
            this.buttonSetSub.Text = "set";
            this.buttonSetSub.UseVisualStyleBackColor = true;
            this.buttonSetSub.Click += new System.EventHandler(this.buttonSetSub_Click);
            // 
            // buttonMainPanel
            // 
            this.buttonMainPanel.Location = new System.Drawing.Point(14, 373);
            this.buttonMainPanel.Name = "buttonMainPanel";
            this.buttonMainPanel.Size = new System.Drawing.Size(100, 23);
            this.buttonMainPanel.TabIndex = 11;
            this.buttonMainPanel.Text = "Main panel";
            this.buttonMainPanel.UseVisualStyleBackColor = true;
            this.buttonMainPanel.Click += new System.EventHandler(this.buttonMainPanel_Click_1);
            // 
            // buttonCommit
            // 
            this.buttonCommit.Location = new System.Drawing.Point(120, 373);
            this.buttonCommit.Name = "buttonCommit";
            this.buttonCommit.Size = new System.Drawing.Size(75, 23);
            this.buttonCommit.TabIndex = 12;
            this.buttonCommit.Text = "commit";
            this.buttonCommit.UseVisualStyleBackColor = true;
            this.buttonCommit.Click += new System.EventHandler(this.buttonCommit_Click);
            // 
            // UserControlRecommendationsSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCommit);
            this.Controls.Add(this.buttonMainPanel);
            this.Controls.Add(this.buttonSetSub);
            this.Controls.Add(this.buttonSetMain);
            this.Controls.Add(this.checkBoxActive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSub);
            this.Controls.Add(this.textBoxMain);
            this.Controls.Add(this.listBoxSubmultiplicators);
            this.Controls.Add(this.listBoxModules);
            this.Name = "UserControlRecommendationsSystem";
            this.Size = new System.Drawing.Size(371, 399);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxModules;
        private System.Windows.Forms.ListBox listBoxSubmultiplicators;
        private System.Windows.Forms.TextBox textBoxMain;
        private System.Windows.Forms.TextBox textBoxSub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.Button buttonSetMain;
        private System.Windows.Forms.Button buttonSetSub;
        private System.Windows.Forms.Button buttonMainPanel;
        private System.Windows.Forms.Button buttonCommit;
    }
}
