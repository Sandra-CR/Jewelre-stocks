namespace Jewelre_BTS_SIO.Connexion
{
    partial class connexionVendeur
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
            this.titleModif = new System.Windows.Forms.Label();
            this.btnVendeurToggle = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.textIdentifiant = new System.Windows.Forms.TextBox();
            this.panelChoice = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMdp = new System.Windows.Forms.Label();
            this.textMdp = new System.Windows.Forms.TextBox();
            this.checkMdp = new System.Windows.Forms.CheckBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.labelInscription = new System.Windows.Forms.Label();
            this.linkInscription = new System.Windows.Forms.LinkLabel();
            this.panelChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleModif
            // 
            this.titleModif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleModif.AutoSize = true;
            this.titleModif.BackColor = System.Drawing.Color.White;
            this.titleModif.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleModif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            this.titleModif.Location = new System.Drawing.Point(114, 54);
            this.titleModif.Name = "titleModif";
            this.titleModif.Size = new System.Drawing.Size(203, 42);
            this.titleModif.TabIndex = 14;
            this.titleModif.Text = "CONNEXION";
            // 
            // btnVendeurToggle
            // 
            this.btnVendeurToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            this.btnVendeurToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendeurToggle.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendeurToggle.ForeColor = System.Drawing.Color.White;
            this.btnVendeurToggle.Location = new System.Drawing.Point(3, 3);
            this.btnVendeurToggle.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btnVendeurToggle.Name = "btnVendeurToggle";
            this.btnVendeurToggle.Size = new System.Drawing.Size(158, 39);
            this.btnVendeurToggle.TabIndex = 15;
            this.btnVendeurToggle.Text = "Vendeur";
            this.btnVendeurToggle.UseVisualStyleBackColor = false;
            this.btnVendeurToggle.Click += new System.EventHandler(this.btnVendeurToggle_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.White;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.Silver;
            this.btnAdmin.Location = new System.Drawing.Point(161, 3);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(158, 39);
            this.btnAdmin.TabIndex = 16;
            this.btnAdmin.Text = "Administrateur";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // textIdentifiant
            // 
            this.textIdentifiant.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdentifiant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            this.textIdentifiant.Location = new System.Drawing.Point(38, 224);
            this.textIdentifiant.Name = "textIdentifiant";
            this.textIdentifiant.Size = new System.Drawing.Size(348, 28);
            this.textIdentifiant.TabIndex = 17;
            // 
            // panelChoice
            // 
            this.panelChoice.BackColor = System.Drawing.Color.White;
            this.panelChoice.Controls.Add(this.btnVendeurToggle);
            this.panelChoice.Controls.Add(this.btnAdmin);
            this.panelChoice.Location = new System.Drawing.Point(51, 114);
            this.panelChoice.Name = "panelChoice";
            this.panelChoice.Size = new System.Drawing.Size(322, 45);
            this.panelChoice.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(37, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nom d\'entreprise";
            // 
            // labelMdp
            // 
            this.labelMdp.AutoSize = true;
            this.labelMdp.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            this.labelMdp.Location = new System.Drawing.Point(37, 279);
            this.labelMdp.Name = "labelMdp";
            this.labelMdp.Size = new System.Drawing.Size(118, 23);
            this.labelMdp.TabIndex = 21;
            this.labelMdp.Text = "Mot de passe";
            // 
            // textMdp
            // 
            this.textMdp.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            this.textMdp.Location = new System.Drawing.Point(38, 305);
            this.textMdp.Name = "textMdp";
            this.textMdp.PasswordChar = '*';
            this.textMdp.Size = new System.Drawing.Size(348, 28);
            this.textMdp.TabIndex = 20;
            // 
            // checkMdp
            // 
            this.checkMdp.AutoSize = true;
            this.checkMdp.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMdp.Location = new System.Drawing.Point(51, 346);
            this.checkMdp.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.checkMdp.Name = "checkMdp";
            this.checkMdp.Size = new System.Drawing.Size(175, 22);
            this.checkMdp.TabIndex = 22;
            this.checkMdp.Text = "Afficher le mot de passe";
            this.checkMdp.UseVisualStyleBackColor = true;
            this.checkMdp.CheckedChanged += new System.EventHandler(this.checkMdp_CheckedChanged);
            // 
            // btnConnexion
            // 
            this.btnConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            this.btnConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnexion.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.ForeColor = System.Drawing.Color.White;
            this.btnConnexion.Location = new System.Drawing.Point(38, 416);
            this.btnConnexion.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(348, 48);
            this.btnConnexion.TabIndex = 17;
            this.btnConnexion.Text = "Je me connecte";
            this.btnConnexion.UseVisualStyleBackColor = false;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // labelInscription
            // 
            this.labelInscription.AutoSize = true;
            this.labelInscription.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInscription.Location = new System.Drawing.Point(99, 479);
            this.labelInscription.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelInscription.Name = "labelInscription";
            this.labelInscription.Size = new System.Drawing.Size(152, 18);
            this.labelInscription.TabIndex = 23;
            this.labelInscription.Text = "Vous n\'êtes pas inscrit ?";
            // 
            // linkInscription
            // 
            this.linkInscription.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            this.linkInscription.AutoSize = true;
            this.linkInscription.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkInscription.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            this.linkInscription.Location = new System.Drawing.Point(248, 479);
            this.linkInscription.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.linkInscription.Name = "linkInscription";
            this.linkInscription.Size = new System.Drawing.Size(69, 18);
            this.linkInscription.TabIndex = 24;
            this.linkInscription.TabStop = true;
            this.linkInscription.Text = "S\'inscrire";
            this.linkInscription.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkInscription_LinkClicked);
            // 
            // connexionVendeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 555);
            this.Controls.Add(this.linkInscription);
            this.Controls.Add(this.labelInscription);
            this.Controls.Add(this.checkMdp);
            this.Controls.Add(this.labelMdp);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.textMdp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelChoice);
            this.Controls.Add(this.textIdentifiant);
            this.Controls.Add(this.titleModif);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "connexionVendeur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "connexion";
            this.panelChoice.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleModif;
        private System.Windows.Forms.Button btnVendeurToggle;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.TextBox textIdentifiant;
        private System.Windows.Forms.FlowLayoutPanel panelChoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMdp;
        private System.Windows.Forms.TextBox textMdp;
        private System.Windows.Forms.CheckBox checkMdp;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label labelInscription;
        private System.Windows.Forms.LinkLabel linkInscription;
    }
}