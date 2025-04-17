namespace Jewelre_BTS_SIO.Admin
{
    partial class AdminMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.UsersTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAdminTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.gererAdminTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.addAdminTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.viewVendeurTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.viewClientTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUsersTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProduitsTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBagueTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEarringsTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBraceletTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCollectionTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAvisTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.profilTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsersTSM,
            this.viewProduitsTSM,
            this.viewAvisTSM,
            this.toolStripMenuItem1,
            this.profilTSM});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(40, 5, 0, 5);
            this.menuStrip.Size = new System.Drawing.Size(1319, 37);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // UsersTSM
            // 
            this.UsersTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAdminTSM,
            this.viewVendeurTSM,
            this.viewClientTSM,
            this.viewUsersTSM});
            this.UsersTSM.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersTSM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            this.UsersTSM.Name = "UsersTSM";
            this.UsersTSM.Size = new System.Drawing.Size(116, 27);
            this.UsersTSM.Text = "Utilisateurs";
            // 
            // viewAdminTSM
            // 
            this.viewAdminTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gererAdminTSM,
            this.addAdminTSM});
            this.viewAdminTSM.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAdminTSM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            this.viewAdminTSM.Name = "viewAdminTSM";
            this.viewAdminTSM.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.viewAdminTSM.Size = new System.Drawing.Size(176, 26);
            this.viewAdminTSM.Text = "Administrateurs";
            this.viewAdminTSM.Click += new System.EventHandler(this.viewAdminTSM_Click);
            // 
            // gererAdminTSM
            // 
            this.gererAdminTSM.Name = "gererAdminTSM";
            this.gererAdminTSM.Size = new System.Drawing.Size(122, 22);
            this.gererAdminTSM.Text = "Gérer";
            this.gererAdminTSM.Click += new System.EventHandler(this.gererAdminTSM_Click);
            // 
            // addAdminTSM
            // 
            this.addAdminTSM.Name = "addAdminTSM";
            this.addAdminTSM.Size = new System.Drawing.Size(122, 22);
            this.addAdminTSM.Text = "Ajouter";
            this.addAdminTSM.Click += new System.EventHandler(this.addAdminTSM_Click);
            // 
            // viewVendeurTSM
            // 
            this.viewVendeurTSM.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewVendeurTSM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            this.viewVendeurTSM.Name = "viewVendeurTSM";
            this.viewVendeurTSM.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.viewVendeurTSM.Size = new System.Drawing.Size(176, 26);
            this.viewVendeurTSM.Text = "Fournisseurs";
            this.viewVendeurTSM.Click += new System.EventHandler(this.viewVendeurTSM_Click);
            // 
            // viewClientTSM
            // 
            this.viewClientTSM.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewClientTSM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            this.viewClientTSM.Name = "viewClientTSM";
            this.viewClientTSM.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.viewClientTSM.Size = new System.Drawing.Size(176, 26);
            this.viewClientTSM.Text = "Clients";
            this.viewClientTSM.Click += new System.EventHandler(this.viewClientTSM_Click);
            // 
            // viewUsersTSM
            // 
            this.viewUsersTSM.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewUsersTSM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            this.viewUsersTSM.Name = "viewUsersTSM";
            this.viewUsersTSM.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.viewUsersTSM.Size = new System.Drawing.Size(176, 26);
            this.viewUsersTSM.Text = "Voir tous";
            this.viewUsersTSM.Click += new System.EventHandler(this.viewUsersTSM_Click);
            // 
            // viewProduitsTSM
            // 
            this.viewProduitsTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBagueTSM,
            this.viewEarringsTSM,
            this.viewBraceletTSM,
            this.toolStripMenuItem6,
            this.viewCollectionTSM});
            this.viewProduitsTSM.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProduitsTSM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            this.viewProduitsTSM.Name = "viewProduitsTSM";
            this.viewProduitsTSM.Size = new System.Drawing.Size(91, 27);
            this.viewProduitsTSM.Text = "Produits";
            // 
            // viewBagueTSM
            // 
            this.viewBagueTSM.BackColor = System.Drawing.SystemColors.Control;
            this.viewBagueTSM.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBagueTSM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            this.viewBagueTSM.Name = "viewBagueTSM";
            this.viewBagueTSM.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.viewBagueTSM.Size = new System.Drawing.Size(180, 26);
            this.viewBagueTSM.Text = "Bague";
            this.viewBagueTSM.Click += new System.EventHandler(this.viewBagueTSM_Click);
            // 
            // viewEarringsTSM
            // 
            this.viewEarringsTSM.BackColor = System.Drawing.SystemColors.Control;
            this.viewEarringsTSM.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewEarringsTSM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            this.viewEarringsTSM.Name = "viewEarringsTSM";
            this.viewEarringsTSM.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.viewEarringsTSM.Size = new System.Drawing.Size(180, 26);
            this.viewEarringsTSM.Text = "Boucles d\'oreille";
            this.viewEarringsTSM.Click += new System.EventHandler(this.viewEarringsTSM_Click);
            // 
            // viewBraceletTSM
            // 
            this.viewBraceletTSM.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBraceletTSM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            this.viewBraceletTSM.Name = "viewBraceletTSM";
            this.viewBraceletTSM.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.viewBraceletTSM.Size = new System.Drawing.Size(180, 26);
            this.viewBraceletTSM.Text = "Bracelet";
            this.viewBraceletTSM.Click += new System.EventHandler(this.viewBraceletTSM_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 26);
            this.toolStripMenuItem6.Text = "Collier";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // viewCollectionTSM
            // 
            this.viewCollectionTSM.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCollectionTSM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            this.viewCollectionTSM.Name = "viewCollectionTSM";
            this.viewCollectionTSM.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.viewCollectionTSM.Size = new System.Drawing.Size(180, 26);
            this.viewCollectionTSM.Text = "Collection";
            this.viewCollectionTSM.Click += new System.EventHandler(this.viewCollectionTSM_Click);
            // 
            // viewAvisTSM
            // 
            this.viewAvisTSM.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAvisTSM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            this.viewAvisTSM.Name = "viewAvisTSM";
            this.viewAvisTSM.Size = new System.Drawing.Size(56, 27);
            this.viewAvisTSM.Text = "Avis";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 27);
            // 
            // profilTSM
            // 
            this.profilTSM.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.profilTSM.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilTSM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            this.profilTSM.Margin = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.profilTSM.Name = "profilTSM";
            this.profilTSM.Size = new System.Drawing.Size(67, 27);
            this.profilTSM.Text = "Profil";
            // 
            // btnMini
            // 
            this.btnMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMini.BackColor = System.Drawing.Color.DarkGray;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMini.ForeColor = System.Drawing.Color.White;
            this.btnMini.Location = new System.Drawing.Point(1225, 0);
            this.btnMini.Margin = new System.Windows.Forms.Padding(0);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(47, 37);
            this.btnMini.TabIndex = 5;
            this.btnMini.Text = "_";
            this.btnMini.UseVisualStyleBackColor = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1272, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 37);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Jewelre_BTS_SIO.Properties.Resources.jewelre;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1319, 768);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMini);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "AdminMain";
            this.Text = "AdminMain";
            this.Load += new System.EventHandler(this.AdminMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem UsersTSM;
        private System.Windows.Forms.ToolStripMenuItem viewAdminTSM;
        private System.Windows.Forms.ToolStripMenuItem viewVendeurTSM;
        private System.Windows.Forms.ToolStripMenuItem viewClientTSM;
        private System.Windows.Forms.ToolStripMenuItem viewAvisTSM;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem profilTSM;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolStripMenuItem viewProduitsTSM;
        private System.Windows.Forms.ToolStripMenuItem viewBagueTSM;
        private System.Windows.Forms.ToolStripMenuItem viewEarringsTSM;
        private System.Windows.Forms.ToolStripMenuItem viewBraceletTSM;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem viewCollectionTSM;
        private System.Windows.Forms.ToolStripMenuItem gererAdminTSM;
        private System.Windows.Forms.ToolStripMenuItem addAdminTSM;
        private System.Windows.Forms.ToolStripMenuItem viewUsersTSM;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}