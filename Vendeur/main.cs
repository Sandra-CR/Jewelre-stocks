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

namespace Jewelre_BTS_SIO
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment fermer l'application ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            int vendeurId = Session.VendeurId;
            string NomE = Methods.GetEntreprise(vendeurId);
            profilTSM.Text = NomE;
            panelBgc.SendToBack();
        }

        private void viewBaguesTSM_Click(object sender, EventArgs e)
        {
            viewBague Vb = new viewBague();
            Vb.MdiParent = this;
            Vb.Show();
        }
    }
}
