using Jewelre_BTS_SIO.Connexion;
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
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
        }
        // Fermer la fenetre
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Afficher les mots de passe
        private void checkMdp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMdp.Checked == true)
            {
                textMdp.PasswordChar = '\0';
                textMdpC.PasswordChar = '\0';
            }
            else
            {
                textMdp.PasswordChar = '*';
                textMdpC.PasswordChar = '*';
            }
        }

        // Inscription (ajout)
        private void btnInscription_Click(object sender, EventArgs e)
        {
            string Email = textEmail.Text;
            string Mdp = textMdp.Text;
            string MdpC = textMdpC.Text;

            if (Email != "" && Mdp != "")
            {
                var MdpComplexe = Methods.ConditionsPassword(Mdp);
                if (MdpComplexe == true)
                {
                    var MdpValide = Methods.ConfirmMdp(Mdp, MdpC);
                    if (MdpValide == true)
                    {
                        string MdpHash = Methods.HashPassword(Mdp);
                        int Result = Admin.Inscription(Email, MdpHash);
                        if (Result == 1)
                        {
                            MessageBox.Show("Un nouveau profil administrateur a été ajouté avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        { MessageBox.Show("Une erreur est survenue lors de l'inscription, veuillez réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else
                    {
                        { MessageBox.Show("Les deux mots de passe entrés ne sont pas identiques", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
                else
                { MessageBox.Show("Veuillez include au moins 8 caractères, 1 majuscule et 1 caractère special dans votre mot de passe", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            { MessageBox.Show("Veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

    }
}
