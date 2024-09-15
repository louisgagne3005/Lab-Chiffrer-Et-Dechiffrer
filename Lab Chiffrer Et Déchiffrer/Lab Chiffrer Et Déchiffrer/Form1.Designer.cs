namespace ChiffrerEtDechiffrer
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
            this.texteUtilisateur = new System.Windows.Forms.TextBox();
            this.etiquetteMessageAChiffrer = new System.Windows.Forms.Label();
            this.etiquetteChoixAlgorithme = new System.Windows.Forms.Label();
            this.algorithme = new System.Windows.Forms.ComboBox();
            this.etiquetteCleChiffrement = new System.Windows.Forms.Label();
            this.cles = new System.Windows.Forms.TextBox();
            this.tailleCle = new System.Windows.Forms.Label();
            this.chiffrer = new System.Windows.Forms.Button();
            this.etiquetteMessageChiffre = new System.Windows.Forms.Label();
            this.texteTransforme = new System.Windows.Forms.TextBox();
            this.dechiffrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texteUtilisateur
            // 
            this.texteUtilisateur.AcceptsReturn = true;
            this.texteUtilisateur.AcceptsTab = true;
            this.texteUtilisateur.Location = new System.Drawing.Point(12, 28);
            this.texteUtilisateur.Multiline = true;
            this.texteUtilisateur.Name = "texteUtilisateur";
            this.texteUtilisateur.Size = new System.Drawing.Size(1142, 176);
            this.texteUtilisateur.TabIndex = 0;
            // 
            // etiquetteMessageAChiffrer
            // 
            this.etiquetteMessageAChiffrer.AutoSize = true;
            this.etiquetteMessageAChiffrer.Location = new System.Drawing.Point(9, 9);
            this.etiquetteMessageAChiffrer.Name = "etiquetteMessageAChiffrer";
            this.etiquetteMessageAChiffrer.Size = new System.Drawing.Size(117, 16);
            this.etiquetteMessageAChiffrer.TabIndex = 1;
            this.etiquetteMessageAChiffrer.Text = "Message à chiffrer";
            // 
            // etiquetteChoixAlgorithme
            // 
            this.etiquetteChoixAlgorithme.AutoSize = true;
            this.etiquetteChoixAlgorithme.Location = new System.Drawing.Point(9, 207);
            this.etiquetteChoixAlgorithme.Name = "etiquetteChoixAlgorithme";
            this.etiquetteChoixAlgorithme.Size = new System.Drawing.Size(131, 16);
            this.etiquetteChoixAlgorithme.TabIndex = 2;
            this.etiquetteChoixAlgorithme.Text = "Choix de l\'algorithme";
            // 
            // algorithme
            // 
            this.algorithme.FormattingEnabled = true;
            this.algorithme.Location = new System.Drawing.Point(12, 226);
            this.algorithme.Name = "algorithme";
            this.algorithme.Size = new System.Drawing.Size(128, 24);
            this.algorithme.TabIndex = 3;
            this.algorithme.SelectedIndexChanged += new System.EventHandler(this.algorithme_SelectedIndexChanged);
            // 
            // etiquetteCleChiffrement
            // 
            this.etiquetteCleChiffrement.AutoSize = true;
            this.etiquetteCleChiffrement.Location = new System.Drawing.Point(9, 268);
            this.etiquetteCleChiffrement.Name = "etiquetteCleChiffrement";
            this.etiquetteCleChiffrement.Size = new System.Drawing.Size(191, 16);
            this.etiquetteCleChiffrement.TabIndex = 5;
            this.etiquetteCleChiffrement.Text = "Clé de chiffrement du message";
            // 
            // cles
            // 
            this.cles.AcceptsReturn = true;
            this.cles.AcceptsTab = true;
            this.cles.Location = new System.Drawing.Point(12, 287);
            this.cles.Multiline = true;
            this.cles.Name = "cles";
            this.cles.ReadOnly = true;
            this.cles.Size = new System.Drawing.Size(1142, 104);
            this.cles.TabIndex = 6;
            // 
            // tailleCle
            // 
            this.tailleCle.AutoSize = true;
            this.tailleCle.Location = new System.Drawing.Point(989, 394);
            this.tailleCle.Name = "tailleCle";
            this.tailleCle.Size = new System.Drawing.Size(156, 16);
            this.tailleCle.TabIndex = 7;
            this.tailleCle.Text = "Taille de la clé : 1024 bits";
            // 
            // chiffrer
            // 
            this.chiffrer.Location = new System.Drawing.Point(288, 210);
            this.chiffrer.Name = "chiffrer";
            this.chiffrer.Size = new System.Drawing.Size(430, 54);
            this.chiffrer.TabIndex = 13;
            this.chiffrer.Text = "Chiffrer";
            this.chiffrer.UseVisualStyleBackColor = true;
            this.chiffrer.Click += new System.EventHandler(this.chiffrer_Click);
            // 
            // etiquetteMessageChiffre
            // 
            this.etiquetteMessageChiffre.AutoSize = true;
            this.etiquetteMessageChiffre.Location = new System.Drawing.Point(12, 403);
            this.etiquetteMessageChiffre.Name = "etiquetteMessageChiffre";
            this.etiquetteMessageChiffre.Size = new System.Drawing.Size(102, 16);
            this.etiquetteMessageChiffre.TabIndex = 15;
            this.etiquetteMessageChiffre.Text = "Message chiffré";
            // 
            // texteTransforme
            // 
            this.texteTransforme.AcceptsReturn = true;
            this.texteTransforme.AcceptsTab = true;
            this.texteTransforme.Location = new System.Drawing.Point(12, 422);
            this.texteTransforme.Multiline = true;
            this.texteTransforme.Name = "texteTransforme";
            this.texteTransforme.ReadOnly = true;
            this.texteTransforme.Size = new System.Drawing.Size(1142, 323);
            this.texteTransforme.TabIndex = 16;
            // 
            // dechiffrer
            // 
            this.dechiffrer.Location = new System.Drawing.Point(724, 210);
            this.dechiffrer.Name = "dechiffrer";
            this.dechiffrer.Size = new System.Drawing.Size(430, 54);
            this.dechiffrer.TabIndex = 17;
            this.dechiffrer.Text = "Déchiffrer";
            this.dechiffrer.UseVisualStyleBackColor = true;
            this.dechiffrer.Click += new System.EventHandler(this.dechiffrer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 757);
            this.Controls.Add(this.dechiffrer);
            this.Controls.Add(this.texteTransforme);
            this.Controls.Add(this.etiquetteMessageChiffre);
            this.Controls.Add(this.chiffrer);
            this.Controls.Add(this.tailleCle);
            this.Controls.Add(this.cles);
            this.Controls.Add(this.etiquetteCleChiffrement);
            this.Controls.Add(this.algorithme);
            this.Controls.Add(this.etiquetteChoixAlgorithme);
            this.Controls.Add(this.etiquetteMessageAChiffrer);
            this.Controls.Add(this.texteUtilisateur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texteUtilisateur;
        private System.Windows.Forms.Label etiquetteMessageAChiffrer;
        private System.Windows.Forms.Label etiquetteChoixAlgorithme;
        private System.Windows.Forms.ComboBox algorithme;
        private System.Windows.Forms.Label etiquetteCleChiffrement;
        private System.Windows.Forms.TextBox cles;
        private System.Windows.Forms.Label tailleCle;
        private System.Windows.Forms.Button chiffrer;
        private System.Windows.Forms.Label etiquetteMessageChiffre;
        private System.Windows.Forms.TextBox texteTransforme;
        private System.Windows.Forms.Button dechiffrer;
    }
}

