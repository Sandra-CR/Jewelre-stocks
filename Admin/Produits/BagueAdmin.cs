using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jewelre_BTS_SIO.Admin.Produits
{
    public partial class BagueAdmin : Form
    {
        public BagueAdmin()
        {
            InitializeComponent();
        }

        private void BagueAdmin_Load(object sender, EventArgs e)
        {
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DGV.DataSource = Admin.AfficherBague();
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
                DGV.DataSource = Admin.AfficherBague();
            }
            else
            {
                btnEffacer.Visible = true;
                string Sql = "SELECT id, prix, en_vente, matiere_p, couleur_p, titrage, matiere_s, couleur_s, motif, id_genre, id_fournisseur FROM produit " +
                    "WHERE type_produit = 'Bague' AND (" +
                    "id LIKE @Content OR " +
                    "prix LIKE @Content OR " +
                    "en_vente LIKE @Content OR " +
                    "matiere_p LIKE @Content OR " +
                    "couleur_p LIKE @Content OR " +
                    "matiere_s LIKE @Content OR " +
                    "couleur_s LIKE @Content OR " +
                    "motif LIKE @Content OR " +
                    "id_genre LIKE @Content OR " +
                    "id_fournisseur LIKE @Content)";
                DGV.DataSource = Methods.Rechercher(Sql, Content);
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            searchBar.Text = null;
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = Int32.Parse(DGV.CurrentRow.Cells[0].Value.ToString());
            DGV2.DataSource = Methods.AfficherSupplements(Id);
            DGV3.DataSource = Methods.AfficherTaillesBague(Id);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            searchBar.Text = null;
            btnEffacer.Visible = false;
            DGV.DataSource = Admin.AfficherBague();
            DGV2.DataSource = null;
            DGV3.DataSource = null;
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
                string Sql = "DELETE FROM produit WHERE id = @Id";
                bool Result = Methods.Supprimer(Sql, Id);
                if (Result == true)
                {
                    MessageBox.Show("Ce produit a été supprimé avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DGV.DataSource = Admin.AfficherBague();
                    DGV2.DataSource = null; DGV3.DataSource = null;
                }
                else
                {
                    MessageBox.Show("Une erreur est survenue lors de la suppression, veuillez réessayer ultérieurement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
