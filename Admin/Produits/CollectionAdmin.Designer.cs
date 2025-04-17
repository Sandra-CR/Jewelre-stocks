namespace Jewelre_BTS_SIO.Admin.Produits
{
    partial class CollectionAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.supprBtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEffacer2 = new System.Windows.Forms.Label();
            this.searchBar2 = new System.Windows.Forms.TextBox();
            this.panelSearchBar = new System.Windows.Forms.Panel();
            this.btnEffacer = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.DGV2 = new System.Windows.Forms.DataGridView();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.btnEnleverCollection = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // supprBtn
            // 
            this.supprBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.supprBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprBtn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprBtn.ForeColor = System.Drawing.Color.White;
            this.supprBtn.Location = new System.Drawing.Point(21, 676);
            this.supprBtn.Name = "supprBtn";
            this.supprBtn.Size = new System.Drawing.Size(356, 40);
            this.supprBtn.TabIndex = 36;
            this.supprBtn.Text = "Supprimer la collection";
            this.supprBtn.UseVisualStyleBackColor = false;
            this.supprBtn.Click += new System.EventHandler(this.supprBtn_Click);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.White;
            this.title.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            this.title.Location = new System.Drawing.Point(465, 31);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(402, 39);
            this.title.TabIndex = 31;
            this.title.Text = "GESTION DES COLLECTIONS";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(881, 676);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(142, 40);
            this.btnRefresh.TabIndex = 30;
            this.btnRefresh.Text = "Actualiser";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnMini
            // 
            this.btnMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMini.BackColor = System.Drawing.Color.DarkGray;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMini.ForeColor = System.Drawing.Color.White;
            this.btnMini.Location = new System.Drawing.Point(1196, 0);
            this.btnMini.Margin = new System.Windows.Forms.Padding(0);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(42, 31);
            this.btnMini.TabIndex = 28;
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
            this.btnClose.Location = new System.Drawing.Point(1238, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 31);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEffacer2);
            this.panel1.Controls.Add(this.searchBar2);
            this.panel1.Location = new System.Drawing.Point(396, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 31);
            this.panel1.TabIndex = 40;
            // 
            // btnEffacer2
            // 
            this.btnEffacer2.AutoSize = true;
            this.btnEffacer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEffacer2.Location = new System.Drawing.Point(837, 4);
            this.btnEffacer2.Name = "btnEffacer2";
            this.btnEffacer2.Size = new System.Drawing.Size(20, 20);
            this.btnEffacer2.TabIndex = 18;
            this.btnEffacer2.Text = "X";
            this.btnEffacer2.Visible = false;
            this.btnEffacer2.Click += new System.EventHandler(this.btnEffacer2_Click);
            // 
            // searchBar2
            // 
            this.searchBar2.BackColor = System.Drawing.Color.White;
            this.searchBar2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBar2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            this.searchBar2.Location = new System.Drawing.Point(6, 4);
            this.searchBar2.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.searchBar2.Name = "searchBar2";
            this.searchBar2.Size = new System.Drawing.Size(827, 19);
            this.searchBar2.TabIndex = 11;
            this.searchBar2.TextChanged += new System.EventHandler(this.searchBar2_TextChanged);
            // 
            // panelSearchBar
            // 
            this.panelSearchBar.BackColor = System.Drawing.Color.White;
            this.panelSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearchBar.Controls.Add(this.btnEffacer);
            this.panelSearchBar.Controls.Add(this.searchBar);
            this.panelSearchBar.Location = new System.Drawing.Point(21, 96);
            this.panelSearchBar.Name = "panelSearchBar";
            this.panelSearchBar.Size = new System.Drawing.Size(356, 31);
            this.panelSearchBar.TabIndex = 39;
            // 
            // btnEffacer
            // 
            this.btnEffacer.AutoSize = true;
            this.btnEffacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEffacer.Location = new System.Drawing.Point(331, 4);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(20, 20);
            this.btnEffacer.TabIndex = 18;
            this.btnEffacer.Text = "X";
            this.btnEffacer.Visible = false;
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.Color.White;
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            this.searchBar.Location = new System.Drawing.Point(6, 4);
            this.searchBar.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(321, 19);
            this.searchBar.TabIndex = 11;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // DGV2
            // 
            this.DGV2.AllowUserToAddRows = false;
            this.DGV2.AllowUserToDeleteRows = false;
            this.DGV2.AllowUserToOrderColumns = true;
            this.DGV2.AllowUserToResizeColumns = false;
            this.DGV2.AllowUserToResizeRows = false;
            this.DGV2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(228)))));
            this.DGV2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV2.DefaultCellStyle = dataGridViewCellStyle14;
            this.DGV2.GridColor = System.Drawing.Color.White;
            this.DGV2.Location = new System.Drawing.Point(396, 142);
            this.DGV2.Name = "DGV2";
            this.DGV2.ReadOnly = true;
            this.DGV2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV2.Size = new System.Drawing.Size(862, 517);
            this.DGV2.TabIndex = 38;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToOrderColumns = true;
            this.DGV.AllowUserToResizeColumns = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(228)))));
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle16;
            this.DGV.GridColor = System.Drawing.Color.White;
            this.DGV.Location = new System.Drawing.Point(21, 142);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV.Size = new System.Drawing.Size(356, 517);
            this.DGV.TabIndex = 37;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // btnEnleverCollection
            // 
            this.btnEnleverCollection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            this.btnEnleverCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnleverCollection.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnleverCollection.ForeColor = System.Drawing.Color.White;
            this.btnEnleverCollection.Location = new System.Drawing.Point(1029, 676);
            this.btnEnleverCollection.Name = "btnEnleverCollection";
            this.btnEnleverCollection.Size = new System.Drawing.Size(229, 40);
            this.btnEnleverCollection.TabIndex = 41;
            this.btnEnleverCollection.Text = "Enlever de la collection";
            this.btnEnleverCollection.UseVisualStyleBackColor = false;
            this.btnEnleverCollection.Click += new System.EventHandler(this.btnEnleverCollection_Click);
            // 
            // CollectionAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1279, 739);
            this.Controls.Add(this.btnEnleverCollection);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSearchBar);
            this.Controls.Add(this.DGV2);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.supprBtn);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnMini);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CollectionAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CollectionAdmin";
            this.Load += new System.EventHandler(this.CollectionAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSearchBar.ResumeLayout(false);
            this.panelSearchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button supprBtn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btnEffacer2;
        private System.Windows.Forms.TextBox searchBar2;
        private System.Windows.Forms.Panel panelSearchBar;
        private System.Windows.Forms.Label btnEffacer;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.DataGridView DGV2;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button btnEnleverCollection;
    }
}