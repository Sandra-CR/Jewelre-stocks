namespace Jewelre_BTS_SIO.Connexion
{
    partial class inscriptionVendeur
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
            this.checkMdp = new System.Windows.Forms.CheckBox();
            this.labelMdp = new System.Windows.Forms.Label();
            this.btnInscription = new System.Windows.Forms.Button();
            this.textMdp = new System.Windows.Forms.TextBox();
            this.labelNomE = new System.Windows.Forms.Label();
            this.textNomE = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textMdpC = new System.Windows.Forms.TextBox();
            this.linkConnexion = new System.Windows.Forms.LinkLabel();
            this.labelInscription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkMdp
            // 
            this.checkMdp.AutoSize = true;
            this.checkMdp.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMdp.Location = new System.Drawing.Point(51, 357);
            this.checkMdp.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.checkMdp.Name = "checkMdp";
            this.checkMdp.Size = new System.Drawing.Size(187, 22);
            this.checkMdp.TabIndex = 39;
            this.checkMdp.Text = "Afficher les mots de passe";
            this.checkMdp.UseVisualStyleBackColor = true;
            this.checkMdp.CheckedChanged += new System.EventHandler(this.checkMdp_CheckedChanged);
            // 
            // labelMdp
            // 
            this.labelMdp.AutoSize = true;
            this.labelMdp.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            this.labelMdp.Location = new System.Drawing.Point(37, 261);
            this.labelMdp.Name = "labelMdp";
            this.labelMdp.Size = new System.Drawing.Size(126, 23);
            this.labelMdp.TabIndex = 38;
            this.labelMdp.Text = "Mots de passe";
            // 
            // btnInscription
            // 
            this.btnInscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            this.btnInscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscription.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscription.ForeColor = System.Drawing.Color.White;
            this.btnInscription.Location = new System.Drawing.Point(38, 414);
            this.btnInscription.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(348, 48);
            this.btnInscription.TabIndex = 34;
            this.btnInscription.Text = "Je m\'inscris sur Jewelr-e";
            this.btnInscription.UseVisualStyleBackColor = false;
            this.btnInscription.Click += new System.EventHandler(this.btnInscription_Click);
            // 
            // textMdp
            // 
            this.textMdp.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            this.textMdp.Location = new System.Drawing.Point(38, 287);
            this.textMdp.Name = "textMdp";
            this.textMdp.PasswordChar = '*';
            this.textMdp.Size = new System.Drawing.Size(348, 28);
            this.textMdp.TabIndex = 37;
            // 
            // labelNomE
            // 
            this.labelNomE.AutoSize = true;
            this.labelNomE.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            this.labelNomE.Location = new System.Drawing.Point(37, 116);
            this.labelNomE.Name = "labelNomE";
            this.labelNomE.Size = new System.Drawing.Size(153, 23);
            this.labelNomE.TabIndex = 36;
            this.labelNomE.Text = "Nom d\'entreprise";
            // 
            // textNomE
            // 
            this.textNomE.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            this.textNomE.Location = new System.Drawing.Point(38, 142);
            this.textNomE.Name = "textNomE";
            this.textNomE.Size = new System.Drawing.Size(348, 28);
            this.textNomE.TabIndex = 35;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.White;
            this.title.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            this.title.Location = new System.Drawing.Point(109, 52);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(213, 42);
            this.title.TabIndex = 33;
            this.title.Text = "INSCRIPTION";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            this.labelEmail.Location = new System.Drawing.Point(37, 188);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(112, 23);
            this.labelEmail.TabIndex = 41;
            this.labelEmail.Text = "Adresse mail";
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            this.textEmail.Location = new System.Drawing.Point(38, 214);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(348, 28);
            this.textEmail.TabIndex = 40;
            // 
            // textMdpC
            // 
            this.textMdpC.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMdpC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            this.textMdpC.Location = new System.Drawing.Point(38, 321);
            this.textMdpC.Name = "textMdpC";
            this.textMdpC.PasswordChar = '*';
            this.textMdpC.Size = new System.Drawing.Size(348, 28);
            this.textMdpC.TabIndex = 42;
            // 
            // linkConnexion
            // 
            this.linkConnexion.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            this.linkConnexion.AutoSize = true;
            this.linkConnexion.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkConnexion.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            this.linkConnexion.Location = new System.Drawing.Point(241, 478);
            this.linkConnexion.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.linkConnexion.Name = "linkConnexion";
            this.linkConnexion.Size = new System.Drawing.Size(92, 18);
            this.linkConnexion.TabIndex = 44;
            this.linkConnexion.TabStop = true;
            this.linkConnexion.Text = "Se connecter";
            this.linkConnexion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkConnexion_LinkClicked);
            // 
            // labelInscription
            // 
            this.labelInscription.AutoSize = true;
            this.labelInscription.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInscription.Location = new System.Drawing.Point(96, 478);
            this.labelInscription.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelInscription.Name = "labelInscription";
            this.labelInscription.Size = new System.Drawing.Size(145, 18);
            this.labelInscription.TabIndex = 43;
            this.labelInscription.Text = "Vous êtes déjà inscrit ?";
            // 
            // inscriptionVendeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 555);
            this.Controls.Add(this.linkConnexion);
            this.Controls.Add(this.labelInscription);
            this.Controls.Add(this.textMdpC);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.checkMdp);
            this.Controls.Add(this.labelMdp);
            this.Controls.Add(this.btnInscription);
            this.Controls.Add(this.textMdp);
            this.Controls.Add(this.labelNomE);
            this.Controls.Add(this.textNomE);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inscriptionVendeur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inscriptionVendeur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkMdp;
        private System.Windows.Forms.Label labelMdp;
        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.TextBox textMdp;
        private System.Windows.Forms.Label labelNomE;
        private System.Windows.Forms.TextBox textNomE;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textMdpC;
        private System.Windows.Forms.LinkLabel linkConnexion;
        private System.Windows.Forms.Label labelInscription;
    }
}