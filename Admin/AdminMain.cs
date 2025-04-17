using Jewelre_BTS_SIO.Admin.Produits;
using Jewelre_BTS_SIO.Vendeur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jewelre_BTS_SIO.Admin
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        // Fonction au chargement de la page
        private void AdminMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            int AdminId = Session.AdminId;
            if (AdminId == 0)
            {
                profilTSM.Text = "Administrateur Sup";
                viewAdminTSM.Visible = true;
            }
            else
            {
                profilTSM.Text = "Administrateur";
                viewAdminTSM.Visible = false;
            }
        }

        // Reduire la fenetre
        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Fermer l'application
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment fermer l'application ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // --------------------------------------------------- //
        // --------------- PARTIE UTILISATEUR ---------------- //
        // --------------------------------------------------- //

        // Tous les utilisateurs
        private void viewUsersTSM_Click(object sender, EventArgs e)
        {
            GererUser Ga = new GererUser();
            Ga.MdiParent = this;
            Ga.Show();
        }

        // View Administrateurs 
        private void viewAdminTSM_Click(object sender, EventArgs e)
        {
            GererAdmin Ga = new GererAdmin();
            Ga.MdiParent = this;
            Ga.Show();
        }

        // Add Administrateur
        private void addAdminTSM_Click(object sender, EventArgs e)
        {
            AddAdmin Aa = new AddAdmin();
            Aa.MdiParent = this;
            Aa.Show();
        }

        // View Administrateur
        private void gererAdminTSM_Click(object sender, EventArgs e)
        {
            GererAdmin Ga = new GererAdmin();
            Ga.MdiParent = this;
            Ga.Show();
        }

        // View Vendeurs
        private void viewVendeurTSM_Click(object sender, EventArgs e)
        {
            GererVendeur Gv = new GererVendeur();
            Gv.MdiParent = this;
            Gv.Show();
        }

        // Vieww Clients
        private void viewClientTSM_Click(object sender, EventArgs e)
        {
            GererClient Gc = new GererClient();
            Gc.MdiParent = this;
            Gc.Show();
        }


        // --------------------------------------------------- //
        // ---------------- PARTIE PRODUITS ------------------ //
        // --------------------------------------------------- //

        // View Bagues
        private void viewBagueTSM_Click(object sender, EventArgs e)
        {
            BagueAdmin Ba = new BagueAdmin();
            Ba.MdiParent = this;
            Ba.Show();
        }

        // View Boucles d'oreilles
        private void viewEarringsTSM_Click(object sender, EventArgs e)
        {
            EarringsAdmin Ea = new EarringsAdmin();
            Ea.MdiParent = this;
            Ea.Show();
        }

        // View Bracelets
        private void viewBraceletTSM_Click(object sender, EventArgs e)
        {
            BraceletAdmin Ba = new BraceletAdmin();
            Ba.MdiParent = this;
            Ba.Show();
        }

        // View Colliers
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            CollierAdmin Ca = new CollierAdmin();
            Ca.MdiParent = this;
            Ca.Show();
        }

        private void viewCollectionTSM_Click(object sender, EventArgs e)
        {
            CollectionAdmin Ca = new CollectionAdmin();
            Ca.MdiParent = this;
            Ca.Show();
        }
    }
}
