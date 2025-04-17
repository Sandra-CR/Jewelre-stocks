using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using Google.Protobuf.WellKnownTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Jewelre_BTS_SIO.Connexion
{
    public partial class connexionVendeur : Form
    {
        public connexionVendeur()
        {
            InitializeComponent();
        }

        private void btnVendeurToggle_Click(object sender, EventArgs e)
        {
            textIdentifiant.Clear();
            textMdp.Clear();
            checkMdp.Checked = false;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            connexionAdmin Ca = new connexionAdmin();
            Ca.Closed += (s, args) => this.Close();
            Ca.Show();
        }

        private void checkMdp_CheckedChanged(object sender, EventArgs e)
        {
            if ( checkMdp.Checked == true )
            {
                textMdp.PasswordChar = '\0';
            }
            else
            {
                textMdp.PasswordChar = '*';
            }
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string Email = textIdentifiant.Text;
            string Mdp = textMdp.Text;

            string storedHash = Methods.AuthVendeur(Email);
            if(storedHash != null)
            {
                if (Methods.VerifyPassword(Mdp, storedHash))
                {
                    int vendeurId = Methods.GetIdVendeur(Email);
                    Session.VendeurId = vendeurId;

                    this.Hide();
                    main M = new main();
                    M.Closed += (s, args) => this.Close();
                    M.Show();
                }
                else
                {
                    MessageBox.Show("Mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            else
            {
                MessageBox.Show("❌ L'adresse mail '" + Email +"' est introuvable");
            }

            
        }

        private void linkInscription_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            inscriptionVendeur Iv = new inscriptionVendeur();
            Iv.Closed += (s, args) => this.Close();
            Iv.Show();
        }
    }
}
