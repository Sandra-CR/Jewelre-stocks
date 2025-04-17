namespace Jewelre_BTS_SIO.Admin
{
    partial class GererUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.panelSearchBar = new System.Windows.Forms.Panel();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.actualiserBtn = new System.Windows.Forms.Button();
            this.supprBtn = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.vendeurToggle = new System.Windows.Forms.Button();
            this.clientToggle = new System.Windows.Forms.Button();
            this.adminToggle = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Label();
            this.panelSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMini
            // 
            this.btnMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMini.BackColor = System.Drawing.Color.DarkGray;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMini.ForeColor = System.Drawing.Color.White;
            this.btnMini.Location = new System.Drawing.Point(718, 0);
            this.btnMini.Margin = new System.Windows.Forms.Padding(0);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(42, 31);
            this.btnMini.TabIndex = 32;
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
            this.btnClose.Location = new System.Drawing.Point(760, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 31);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.White;
            this.title.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            this.title.Location = new System.Drawing.Point(183, 54);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.title.Size = new System.Drawing.Size(434, 49);
            this.title.TabIndex = 31;
            this.title.Text = "TABLEAU DES UTILISATEURS";
            // 
            // panelSearchBar
            // 
            this.panelSearchBar.BackColor = System.Drawing.Color.White;
            this.panelSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearchBar.Controls.Add(this.btnEffacer);
            this.panelSearchBar.Controls.Add(this.searchBar);
            this.panelSearchBar.Location = new System.Drawing.Point(23, 183);
            this.panelSearchBar.Name = "panelSearchBar";
            this.panelSearchBar.Size = new System.Drawing.Size(752, 31);
            this.panelSearchBar.TabIndex = 37;
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.Color.White;
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            this.searchBar.Location = new System.Drawing.Point(6, 5);
            this.searchBar.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(712, 19);
            this.searchBar.TabIndex = 11;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // actualiserBtn
            // 
            this.actualiserBtn.BackColor = System.Drawing.Color.DarkGray;
            this.actualiserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actualiserBtn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualiserBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.actualiserBtn.Location = new System.Drawing.Point(499, 704);
            this.actualiserBtn.Name = "actualiserBtn";
            this.actualiserBtn.Size = new System.Drawing.Size(135, 40);
            this.actualiserBtn.TabIndex = 36;
            this.actualiserBtn.Text = "Actualiser";
            this.actualiserBtn.UseVisualStyleBackColor = false;
            this.actualiserBtn.Click += new System.EventHandler(this.actualiserBtn_Click);
            // 
            // supprBtn
            // 
            this.supprBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.supprBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprBtn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprBtn.ForeColor = System.Drawing.Color.White;
            this.supprBtn.Location = new System.Drawing.Point(640, 704);
            this.supprBtn.Name = "supprBtn";
            this.supprBtn.Size = new System.Drawing.Size(135, 40);
            this.supprBtn.TabIndex = 35;
            this.supprBtn.Text = "Supprimer";
            this.supprBtn.UseVisualStyleBackColor = false;
            this.supprBtn.Click += new System.EventHandler(this.supprBtn_Click);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGV.GridColor = System.Drawing.Color.White;
            this.DGV.Location = new System.Drawing.Point(23, 220);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV.Size = new System.Drawing.Size(752, 466);
            this.DGV.TabIndex = 34;
            // 
            // vendeurToggle
            // 
            this.vendeurToggle.BackColor = System.Drawing.Color.Silver;
            this.vendeurToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vendeurToggle.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendeurToggle.ForeColor = System.Drawing.Color.White;
            this.vendeurToggle.Location = new System.Drawing.Point(274, 121);
            this.vendeurToggle.Margin = new System.Windows.Forms.Padding(0);
            this.vendeurToggle.Name = "vendeurToggle";
            this.vendeurToggle.Size = new System.Drawing.Size(251, 40);
            this.vendeurToggle.TabIndex = 38;
            this.vendeurToggle.Text = "Fournisseurs";
            this.vendeurToggle.UseVisualStyleBackColor = false;
            this.vendeurToggle.Click += new System.EventHandler(this.vendeurToggle_Click);
            // 
            // clientToggle
            // 
            this.clientToggle.BackColor = System.Drawing.Color.Silver;
            this.clientToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientToggle.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientToggle.ForeColor = System.Drawing.Color.White;
            this.clientToggle.Location = new System.Drawing.Point(525, 121);
            this.clientToggle.Margin = new System.Windows.Forms.Padding(0);
            this.clientToggle.Name = "clientToggle";
            this.clientToggle.Size = new System.Drawing.Size(251, 40);
            this.clientToggle.TabIndex = 39;
            this.clientToggle.Text = "Clients";
            this.clientToggle.UseVisualStyleBackColor = false;
            this.clientToggle.Click += new System.EventHandler(this.clientToggle_Click);
            // 
            // adminToggle
            // 
            this.adminToggle.BackColor = System.Drawing.Color.Silver;
            this.adminToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminToggle.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminToggle.ForeColor = System.Drawing.Color.White;
            this.adminToggle.Location = new System.Drawing.Point(23, 121);
            this.adminToggle.Margin = new System.Windows.Forms.Padding(0);
            this.adminToggle.Name = "adminToggle";
            this.adminToggle.Size = new System.Drawing.Size(251, 40);
            this.adminToggle.TabIndex = 40;
            this.adminToggle.Text = "Administrateurs";
            this.adminToggle.UseVisualStyleBackColor = false;
            this.adminToggle.Click += new System.EventHandler(this.adminToggle_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.AutoSize = true;
            this.btnEffacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEffacer.Location = new System.Drawing.Point(727, 5);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(20, 20);
            this.btnEffacer.TabIndex = 12;
            this.btnEffacer.Text = "X";
            this.btnEffacer.Visible = false;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // GererUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 776);
            this.Controls.Add(this.adminToggle);
            this.Controls.Add(this.clientToggle);
            this.Controls.Add(this.vendeurToggle);
            this.Controls.Add(this.panelSearchBar);
            this.Controls.Add(this.actualiserBtn);
            this.Controls.Add(this.supprBtn);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.btnMini);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GererUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GererUser";
            this.Load += new System.EventHandler(this.GererUser_Load);
            this.panelSearchBar.ResumeLayout(false);
            this.panelSearchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panelSearchBar;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Button actualiserBtn;
        private System.Windows.Forms.Button supprBtn;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button vendeurToggle;
        private System.Windows.Forms.Button clientToggle;
        private System.Windows.Forms.Button adminToggle;
        private System.Windows.Forms.Label btnEffacer;
    }
}