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
    public partial class inscriptionVendeur : Form
    {
        public inscriptionVendeur()
        {
            InitializeComponent();
        }

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

        private void btnInscription_Click(object sender, EventArgs e)
        {
            string NomE = textNomE.Text;
            string Email = textEmail.Text;
            string Mdp = textMdp.Text;
            string MdpC = textMdpC.Text;

            if (NomE != "" && Email != "" && Mdp != "" && MdpC != "")
            {
                var NomEPris = Methods.EntrepriseUnique(NomE);
                if (NomEPris == null)
                {
                    var EmailPris = Methods.EmailVendeurUnique(Email);
                    if (EmailPris == null)
                    {
                        var MdpComplexe = Methods.ConditionsPassword(Mdp);
                        if (MdpComplexe == true)
                        {
                            var MdpValide = Methods.ConfirmMdp(Mdp, MdpC);
                            if (MdpValide == true)
                            {
                                string MdpHash = Methods.HashPassword(Mdp);
                                int Result = Methods.InscriptionVendeur(NomE, Email, MdpHash);
                                if (Result == 1)
                                {
                                    MessageBox.Show("Vous êtes à présent inscrit", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Hide();
                                    connexionVendeur Cv = new connexionVendeur();
                                    Cv.Closed += (s, args) => this.Close();
                                    Cv.Show();
                                }
                                else
                                { MessageBox.Show("Une erreur est survenue lors de l'inscription, veuillez réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            }
                            else
                            { MessageBox.Show("Les deux mots de passe entrés ne sont pas identiques", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        }
                        else
                        { MessageBox.Show("Veuillez include au moins 8 caractères, 1 majuscule et 1 caractère special dans votre mot de passe", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else
                    { MessageBox.Show("Cette adresse mail est déjà inscrite sur notre plateforme", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                { MessageBox.Show("Cette entreprise est déjà inscrite sur notre plateforme", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            { MessageBox.Show("Veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void linkConnexion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            connexionVendeur Cv = new connexionVendeur();
            Cv.Closed += (s, args) => this.Close();
            Cv.Show();
        }
    }
}
