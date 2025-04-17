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
    public partial class CollectionAdmin : Form
    {
        public CollectionAdmin()
        {
            InitializeComponent();
        }


        // Fonction au chargement de la page
        private void CollectionAdmin_Load(object sender, EventArgs e)
        {
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DGV.DataSource = Admin.AfficherCollection();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DGV.DataSource = Admin.AfficherCollection();

            searchBar.Text = null; searchBar2.Text = null;
            btnEffacer.Visible = false; btnEffacer2.Visible = false;
            DGV2.DataSource = null;
        }

        // Rechercher une collection
        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            string Content = searchBar.Text;
            if (Content == "")
            {
                btnEffacer.Visible = false;
                DGV.DataSource = Admin.AfficherCollection();
            }
            else
            {
                btnEffacer.Visible = true;
                string Sql = "SELECT id, titre, date_sortie FROM collection WHERE id LIKE @Content OR titre LIKE @Content";
                DGV.DataSource = Methods.Rechercher(Sql, Content);
            }
        }

        // Effacer le contenu de la recherche
        private void btnEffacer_Click(object sender, EventArgs e)
        {
            searchBar.Text = null;
        }

        private void searchBar2_TextChanged(object sender, EventArgs e)
        {
            int IdCollection = Int32.Parse(DGV.CurrentRow.Cells[0].Value.ToString());
            if (DGV.CurrentRow == null)
            {
                DGV2.DataSource = null;
            }
            else
            {
                string Content = searchBar2.Text;
                if (Content == "")
                {
                    btnEffacer2.Visible = false;
                    DGV2.DataSource = Methods.ProduitsCollection(IdCollection);
                }
                else
                {
                    btnEffacer.Visible = true;
                    string Sql = "SELECT id, type_produit, en_vente, matiere_p, couleur_p, motif, id_fournisseur FROM produit WHERE " +
                        "(id LIKE @Content OR type_produit LIKE @Content OR en_vente LIKE @Content OR matiere_p LIKE @Content " +
                        " OR couleur_p LIKE @Content OR motif LIKE @Content OR id_fournisseur LIKE @Content) AND id_collection = @Plus";
                    DGV2.DataSource = Methods.RechercherPlus(Sql, Content, IdCollection);
                }
            }
        }

        private void btnEffacer2_Click(object sender, EventArgs e)
        {
            int IdCollection = Int32.Parse(DGV.CurrentRow.Cells[0].Value.ToString());
            searchBar2.Text = null;
            if (DGV.CurrentRow == null) { DGV2.DataSource = null; }
            else { DGV2.DataSource = Methods.ProduitsCollection(IdCollection); }
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdCollection = Int32.Parse(DGV.CurrentRow.Cells[0].Value.ToString());
            DGV2.DataSource = Methods.ProduitsCollection(IdCollection);
        }

        private void supprBtn_Click(object sender, EventArgs e)
        {
            if (DGV.CurrentRow == null) { MessageBox.Show("Veuillez sélectionner une ligne avant de supprimer", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                int IdCollection = Int32.Parse(DGV.CurrentRow.Cells[0].Value.ToString());
                string Sql = "UPDATE produit SET id_collection = NULL WHERE id_collection = @Item";
                bool Result = Methods.ModifierItem(Sql, IdCollection);
                if (Result)
                {
                    string SqlSuppr = "DELETE FROM collection WHERE id = @Id";
                    bool Suppression = Methods.Supprimer(SqlSuppr, IdCollection);
                    if (Suppression)
                    {
                        MessageBox.Show("Ce produit a été supprimé avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DGV.DataSource = Admin.AfficherCollection();

                        searchBar.Text = null; searchBar2.Text = null;
                        btnEffacer.Visible = false; btnEffacer2.Visible = false;
                        DGV2.DataSource = null;
                    }
                    else { MessageBox.Show("Une erreur est survenue lors de la suppression, veuillez réessayer ultérieurement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("Une erreur est survenue lors de la suppression, veuillez réessayer ultérieurement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btnEnleverCollection_Click(object sender, EventArgs e)
        {
            if (DGV2.CurrentRow == null) { MessageBox.Show("Veuillez sélectionner une ligne avant de l'enlever de la collection", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                int IdCollection = Int32.Parse(DGV.CurrentRow.Cells[0].Value.ToString());
                int IdItem = Int32.Parse(DGV2.CurrentRow.Cells[0].Value.ToString());
                string Sql = "UPDATE produit SET id_collection = NULL WHERE id = @Id AND id_collection = @Item";
                bool Modification = Methods.ModifierItemPlus(Sql, IdItem, IdCollection);
                if (Modification)
                {
                    DGV2.DataSource = Methods.ProduitsCollection(IdCollection);

                    searchBar.Text = null; searchBar2.Text = null;
                    btnEffacer.Visible = false; btnEffacer2.Visible = false;
                }
                else { MessageBox.Show("Une erreur est survenue lors de la modification, veuillez réessayer ultérieurement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
    }
}
