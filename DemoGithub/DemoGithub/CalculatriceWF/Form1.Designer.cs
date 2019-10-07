namespace CalculatriceWF
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkedListBoxOperations = new System.Windows.Forms.CheckedListBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBoxOperations
            // 
            this.checkedListBoxOperations.FormattingEnabled = true;
            this.checkedListBoxOperations.Items.AddRange(new object[] {
            "addition",
            "soustraction",
            "multiplication",
            "division"});
            this.checkedListBoxOperations.Location = new System.Drawing.Point(46, 46);
            this.checkedListBoxOperations.Name = "checkedListBoxOperations";
            this.checkedListBoxOperations.Size = new System.Drawing.Size(120, 94);
            this.checkedListBoxOperations.TabIndex = 0;
            this.checkedListBoxOperations.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxOperations_ItemCheck);
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Location = new System.Drawing.Point(46, 158);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(0, 13);
            this.lblResultat.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.checkedListBoxOperations);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxOperations;
        private System.Windows.Forms.Label lblResultat;
    }
}

