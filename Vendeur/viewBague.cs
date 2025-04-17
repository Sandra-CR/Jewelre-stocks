using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Jewelre_BTS_SIO.Vendeur
{
    public partial class viewBague : Form
    {
        public viewBague()
        {
            InitializeComponent();
        }

        private void viewBague_Load(object sender, EventArgs e)
        {
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DGV.DataSource = Methods.AfficherBague();
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
            DGV.DataSource = Methods.AfficherBague();
            DGV2.DataSource = null;
            DGV3.DataSource = null;
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = Int32.Parse(DGV.CurrentRow.Cells[0].Value.ToString());
            DGV2.DataSource = Methods.AfficherSupplements(Id);
            DGV3.DataSource = Methods.AfficherTaillesBague(Id);
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            string Content = searchBar.Text;
            if ( Content == "" )
            {
                DGV.DataSource = Methods.AfficherBague();
            }
            else
            {     
                int VendeurId = Session.VendeurId;
                string Sql = "SELECT id, prix, en_vente, matiere_p, couleur_p, titrage, matiere_s, couleur_s, motif, id_genre FROM produit " +
                    "WHERE type_produit = 'Bague' AND id_fournisseur = @Plus AND (" +
                    "id LIKE @Content OR " +
                    "prix LIKE @Content OR " +
                    "en_vente LIKE @Content OR " +
                    "matiere_p LIKE @Content OR " +
                    "couleur_p LIKE @Content OR " +
                    "matiere_s LIKE @Content OR " +
                    "couleur_s LIKE @Content OR " +
                    "motif LIKE @Content OR " +
                    "id_genre LIKE @Content)";

                DGV.DataSource = Methods.RechercherPlus(Sql, Content, VendeurId);
                DGV2.DataSource = null;
                DGV3.DataSource = null;
            }
        }
        private void btnEffacer_Click(object sender, EventArgs e)
        {
            searchBar.Text = null;
        }

        private void modifToggle_Click(object sender, EventArgs e)
        {
            panelModif.Visible = true;
            int rowindex = DGV.CurrentCell.RowIndex;

            textPrix.Text = DGV.Rows[rowindex].Cells[1].Value.ToString();
            if (DGV.Rows[rowindex].Cells[2].Value.ToString() == "0") { comboEnvente.SelectedItem = "Non"; }
            else if (DGV.Rows[rowindex].Cells[2].Value.ToString() == "1") { comboEnvente.SelectedItem = "Oui"; }
            textMatierep.Text = DGV.Rows[rowindex].Cells[3].Value.ToString();
            textCouleurp.Text = DGV.Rows[rowindex].Cells[4].Value.ToString();
            textTitrage.Text = DGV.Rows[rowindex].Cells[5].Value.ToString();
            textMatieres.Text = DGV.Rows[rowindex].Cells[6].Value.ToString();
            textCouleurs.Text = DGV.Rows[rowindex].Cells[7].Value.ToString();
            textMotif.Text = DGV.Rows[rowindex].Cells[8].Value.ToString();
            if (DGV.Rows[rowindex].Cells[9].Value.ToString() == "1") { comboGenre.SelectedItem = "Femme";}
            else if (DGV.Rows[rowindex].Cells[9].Value.ToString() == "2") { comboGenre.SelectedItem = "Homme"; }

            if (DGV2.Rows.Count > 0)
            {
                checkPierrep.Checked = true;
                textPmatiere.Text = DGV2.Rows[0].Cells[1].Value?.ToString();
                textPcouleur.Text = DGV2.Rows[0].Cells[2].Value?.ToString();
                textPnombre.Text = DGV2.Rows[0].Cells[3].Value?.ToString();
                textPcaratage.Text = DGV2.Rows[0].Cells[4].Value?.ToString();
                textPsertis.Text = DGV2.Rows[0].Cells[5].Value?.ToString();

                if (DGV2.Rows.Count > 1)
                {
                    checkPierres.Checked = true;
                    textSmatiere.Text = DGV2.Rows[1].Cells[1].Value?.ToString();
                    textScouleur.Text = DGV2.Rows[1].Cells[2].Value?.ToString();
                    textSnombre.Text = DGV2.Rows[1].Cells[3].Value?.ToString();
                    textScaratage.Text = DGV2.Rows[1].Cells[4].Value?.ToString();
                    textSsertis.Text = DGV2.Rows[1].Cells[5].Value?.ToString();
                } 
                else 
                { 
                    checkPierres.Checked = false;
                    panelPierres.Visible = false;
                }
            }
            else
            {
                checkPierrep.Checked = false;
                checkPierres.Checked = false;
                panelPierrep.Visible = false;
                checkPierres.Visible = false;
                panelPierres.Visible = false;
            }
        }

        private void btnCloseModif_Click(object sender, EventArgs e)
        {
            panelModif.Visible = false;
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
                string Sql = "DELETE FROM administrateur WHERE id = @Id";
                bool Result = Methods.Supprimer(Sql, Id);
                if (Result == true)
                {
                    MessageBox.Show("Ce produit a été supprimé avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DGV.DataSource = Methods.AfficherBague();
                    DGV2.DataSource = null; DGV3.DataSource = null;
                }
                else
                {
                    MessageBox.Show("Une erreur est survenue lors de la suppression, veuillez réessayer ultérieurement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkPierrep_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPierrep.Checked == true)
            {
                panelPierrep.Visible = true;
                checkPierres.Visible = true;
                checkPierres.Checked = false;
                panelPierres.Visible = false;
            }
            else
            {
                panelPierrep.Visible = false;
                checkPierres.Visible = false;
                panelPierres.Visible = false;
            }
        }

        private void checkPierres_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPierres.Checked == true)
            {
                panelPierres.Visible = true;
            }
            else
            {
                panelPierres.Visible = false;
            }
        }

        private void btnApplyModif_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(DGV.CurrentRow.Cells[0].Value.ToString(), out int Id))
            { MessageBox.Show("ID invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (!float.TryParse(textPrix.Text, out float Prix))
            { MessageBox.Show("Prix invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            int Envente = comboEnvente.SelectedIndex;
            string Matierep = textMatierep.Text;
            string Couleurp = textCouleurp.Text;
            if (!int.TryParse(textTitrage.Text, out int Titrage))
            { MessageBox.Show("Titrage invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            string Matieres = textMatieres.Text;
            string Couleurs = textCouleurs.Text;
            string Motif = textMotif.Text;
            int Genre = comboGenre.SelectedIndex + 1;

            var Produit = Vendeur.ModifierBague(Id, Prix, Envente, Matierep, Couleurp, Titrage, Matieres, Couleurs, Motif, Genre);
            if (Produit == 1)
            {
                string Pmatiere = textPmatiere.Text;
                string Pcouleur = textPcouleur.Text;
                if (!int.TryParse(textPnombre.Text, out int Pnombre))
                { MessageBox.Show("Nombre de pierre principale invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                if (!int.TryParse(textPcaratage.Text, out int Pcaratage))
                { MessageBox.Show("Caratage de pierre principale invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                string Psertis = textPsertis.Text;

                var PierreP = Vendeur.ModifierPierre(Id, Pmatiere, Pcouleur, Pnombre, Pcaratage, Psertis);
                if (PierreP == 1)
                {
                    string Smatiere = textSmatiere.Text;
                    string Scouleur = textScouleur.Text;
                    if (!int.TryParse(textSnombre.Text, out int Snombre))
                    { MessageBox.Show("Nombre de pierre secondaire invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    if (!int.TryParse(textScaratage.Text, out int Scaratage))
                    { MessageBox.Show("Caratage de pierre secondaire invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    string Ssertis = textSsertis.Text;

                    var PierreS = Vendeur.ModifierPierre(Id, Smatiere, Scouleur, Snombre, Scaratage, Ssertis);
                    if (PierreS == 1)
                    {
                        MessageBox.Show("Les modifications ont été prises en compte", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DGV.DataSource = Methods.AfficherBague();
                        DGV2.DataSource = null; DGV3.DataSource = null;
                        panelModif.Visible = false;
                    }
                }
                
            }
            else
            { MessageBox.Show("Un problème est survenu lors des modifications...", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
