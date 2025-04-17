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
    public partial class GererVendeur : Form
    {
        public GererVendeur()
        {
            InitializeComponent();
        }

        private void GererVendeur_Load(object sender, EventArgs e)
        {
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV.DataSource = Admin.AfficherVendeur();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            string Content = searchBar.Text;
            if (Content == "")
            {
                btnEffacer.Visible = false;
                DGV.DataSource = Admin.AfficherVendeur();
            }
            else
            {
                btnEffacer.Visible = true;
                string Sql = "SELECT id, entreprise, email, pays, date_creation FROM fournisseur WHERE id LIKE @Content OR entreprise LIKE @Content OR email LIKE @Content OR pays LIKE @Content";
                DGV.DataSource = Methods.Rechercher(Sql, Content);
            }
        }
        private void btnEffacer_Click(object sender, EventArgs e)
        {
            searchBar.Text = null;
        }

        private void actualiserBtn_Click(object sender, EventArgs e)
        {
            searchBar.Text = null;
            DGV.DataSource = Admin.AfficherVendeur();
        }

        private void supprBtn_Click(object sender, EventArgs e)
        {
            if (DGV.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une ligne avant de supprimer", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int Id = Int32.Parse(DGV.CurrentRow.Cells[0].Value.ToString());
                if (Id != 0)
                {
                    string Sql = "DELETE FROM fournisseur WHERE id = @Id";
                    bool Result = Methods.Supprimer(Sql, Id);
                    if (Result == true)
                    {
                        MessageBox.Show("Ce profil fournisseur a été supprimé avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DGV.DataSource = Admin.AfficherVendeur();
                    }
                    else
                    {
                        MessageBox.Show("Une erreur est survenue lors de la suppression, veuillez réessayer ultérieurement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vous ne pouvez pas supprimer le fournisseur 0", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
}
