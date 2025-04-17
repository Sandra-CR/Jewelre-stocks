using Jewelre_BTS_SIO.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jewelre_BTS_SIO.Connexion
{
    public partial class connexionAdmin : Form
    {
        public connexionAdmin()
        {
            InitializeComponent();
        }

        // Redigirer vers la connexion vendeur
        private void btnVendeurToggle_Click(object sender, EventArgs e)
        {
            this.Hide();
            connexionVendeur Cv = new connexionVendeur();
            Cv.Closed += (s, args) => this.Close();
            Cv.Show();
        }

        // Vider les cases dans la page
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            textIdentifiant.Clear();
            textMdp.Clear();
            checkMdp.Checked = false;
        }

        // Afficher le mot de passe
        private void checkMdp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMdp.Checked == true)
            {
                textMdp.PasswordChar = '\0';
            }
            else
            {
                textMdp.PasswordChar = '*';
            }
        }

        // Se connecter
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string Email = textIdentifiant.Text;
            string Mdp = textMdp.Text;

            if (Email != "" && Mdp != "")
            {
                string storedHash = Connexion.MdpAdmin(Email);
                if (storedHash != null)
                {
                    if (Methods.VerifyPassword(Mdp, storedHash))
                    {
                        int adminId = Connexion.GetIdAdmin(Email);
                        Session.AdminId = adminId;

                        this.Hide();
                        AdminMain Am = new AdminMain();
                        Am.Closed += (s, args) => this.Close();
                        Am.Show();
                    }
                    else
                    { MessageBox.Show("Adresse ou mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                { MessageBox.Show("Adresse mail introuvable", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            { MessageBox.Show("Veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

    }
}
