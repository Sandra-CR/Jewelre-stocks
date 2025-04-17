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
    public partial class GererUser : Form
    {
        public GererUser()
        {
            InitializeComponent();
        }

        private void GererUser_Load(object sender, EventArgs e)
        {
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            adminToggle.BackColor = Color.FromArgb(174, 149, 118);
            DGV.DataSource = Admin.AfficherAdmin();
        }
        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminToggle_Click(object sender, EventArgs e)
        {
            adminToggle.BackColor = Color.FromArgb(174, 149, 118);
            vendeurToggle.BackColor = Color.Silver;
            clientToggle.BackColor = Color.Silver;

            searchBar.Text = null;
            DGV.DataSource = Admin.AfficherAdmin();
        }
        private void vendeurToggle_Click(object sender, EventArgs e)
        {
            adminToggle.BackColor = Color.Silver;
            vendeurToggle.BackColor = Color.FromArgb(174, 149, 118);
            clientToggle.BackColor = Color.Silver;

            searchBar.Text = null;
            DGV.DataSource = Admin.AfficherVendeur();
        }
        private void clientToggle_Click(object sender, EventArgs e)
        {
            adminToggle.BackColor = Color.Silver;
            vendeurToggle.BackColor = Color.Silver;
            clientToggle.BackColor = Color.FromArgb(174, 149, 118);

            searchBar.Text = null;
            DGV.DataSource = Admin.AfficherClient();
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            string Content = searchBar.Text;
            if (Content == "")
            {
                btnEffacer.Visible = false;
                if (adminToggle.BackColor == Color.FromArgb(174, 149, 118))
                { DGV.DataSource = Admin.AfficherAdmin(); }
                else if (vendeurToggle.BackColor == Color.FromArgb(174, 149, 118))
                { DGV.DataSource = Admin.AfficherVendeur(); }
                else if (clientToggle.BackColor == Color.FromArgb(174, 149, 118))
                { DGV.DataSource = Admin.AfficherClient(); }
            }
            else
            {
                btnEffacer.Visible = true;
                if (adminToggle.BackColor == Color.FromArgb(174, 149, 118))
                {
                    string Sql = "SELECT id, nom, email FROM administrateur WHERE id LIKE @Content OR nom LIKE @Content OR email LIKE @Content";
                    DGV.DataSource = Methods.Rechercher(Sql, Content);
                }
                else if (vendeurToggle.BackColor == Color.FromArgb(174, 149, 118))
                {
                    string Sql = "SELECT id, entreprise, email, pays, date_creation FROM fournisseur WHERE id LIKE @Content OR entreprise LIKE @Content OR email LIKE @Content OR pays LIKE @Content";
                    DGV.DataSource = Methods.Rechercher(Sql, Content);
                }
                else if (clientToggle.BackColor == Color.FromArgb(174, 149, 118))
                {
                    string Sql = "SELECT id, pseudo, nom, prenom, email, date_creation FROM client WHERE id LIKE @Content OR " +
                      "pseudo LIKE @Content OR nom LIKE @Content OR prenom LIKE @Content OR email LIKE @Content";
                    DGV.DataSource = Methods.Rechercher(Sql, Content);
                }
            }
        }
        private void btnEffacer_Click(object sender, EventArgs e)
        {
            searchBar.Text = null;
        }

        private void actualiserBtn_Click(object sender, EventArgs e)
        {
            if (adminToggle.BackColor == Color.FromArgb(174, 149, 118))
            { DGV.DataSource = Admin.AfficherAdmin(); }
            else if (vendeurToggle.BackColor == Color.FromArgb(174, 149, 118))
            { DGV.DataSource = Admin.AfficherVendeur(); }
            else if (clientToggle.BackColor == Color.FromArgb(174, 149, 118))
            { DGV.DataSource = Admin.AfficherClient(); }
        }

        private void supprBtn_Click(object sender, EventArgs e)
        {
            if (DGV.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une ligne avant de supprimer", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool Result = false;
                int Id = Int32.Parse(DGV.CurrentRow.Cells[0].Value.ToString());
                if (Id != 0)
                {
                    if (adminToggle.BackColor == Color.FromArgb(174, 149, 118))
                    {
                        string Sql = "DELETE FROM administrateur WHERE id = @Id";
                        Result = Methods.Supprimer(Sql, Id);
                    } 
                    else if (vendeurToggle.BackColor == Color.FromArgb(174, 149, 118))
                    {
                        string Sql = "DELETE FROM fournisseur WHERE id = @Id";
                        Result = Methods.Supprimer(Sql, Id);
                    } 
                    else if (clientToggle.BackColor == Color.FromArgb(174, 149, 118))
                    {
                        string Sql = "DELETE FROM client WHERE id = @Id";
                        Result = Methods.Supprimer(Sql, Id);
                    } 

                    if (Result)
                    {
                        MessageBox.Show("Ce profil fournisseur a été supprimé avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DGV.DataSource = Admin.AfficherVendeur();
                    }
                    else
                    { MessageBox.Show("Une erreur est survenue lors de la suppression, veuillez réessayer ultérieurement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                { MessageBox.Show("Vous ne pouvez pas supprimer l'utilisateur 0", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                if (adminToggle.BackColor == Color.FromArgb(174, 149, 118))
                { 
                    DGV.DataSource = Admin.AfficherAdmin(); 
                }
            }

        }

    }
}
