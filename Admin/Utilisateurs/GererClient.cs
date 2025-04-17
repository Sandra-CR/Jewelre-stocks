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
    public partial class GererClient : Form
    {
        public GererClient()
        {
            InitializeComponent();
        }

        // Fonction au chargement de la page
        private void GererClient_Load(object sender, EventArgs e)
        {
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV.DataSource = Admin.AfficherClient();
        }

        // Reduire la fenetre
        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Fermer la fenetre
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Faire une recherche
        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            string Content = searchBar.Text;
            if (Content == "")
            {
                btnEffacer.Visible = false;
                DGV.DataSource = Admin.AfficherClient();
            }
            else
            {
                btnEffacer.Visible = true;
                string Sql = "SELECT id, pseudo, nom, prenom, email, date_creation FROM client WHERE id LIKE @Content OR " +
                    "pseudo LIKE @Content OR nom LIKE @Content OR prenom LIKE @Content OR email LIKE @Content";
                DGV.DataSource = Methods.Rechercher(Sql, Content);
            }
        }

        // Effacer le contenu de la recherche
        private void btnEffacer_Click(object sender, EventArgs e)
        {
            searchBar.Text = null;
        }

        // Bouton actualiser
        private void actualiserBtn_Click(object sender, EventArgs e)
        {
            searchBar.Text = null;
            DGV.DataSource = Admin.AfficherClient();
        }

        // Supprimer un utilisateur
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
                    string Sql = "DELETE FROM client WHERE id = @Id";
                    bool Result = Methods.Supprimer(Sql, Id);
                    if (Result == true)
                    {
                        MessageBox.Show("Ce profil client a été supprimé avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DGV.DataSource = Admin.AfficherClient();
                    }
                    else
                    {
                        MessageBox.Show("Une erreur est survenue lors de la suppression, veuillez réessayer ultérieurement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vous ne pouvez pas supprimer le client 0", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
}
