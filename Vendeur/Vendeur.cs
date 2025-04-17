using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jewelre_BTS_SIO.Vendeur
{
    internal class Vendeur
    {
        public static int ModifierBague(int Id, float Prix, int Envente, string Matierep, string Couleurp, int Titrage, string Matieres, string Couleurs, string Motif, int Genre)
        {
            if (string.IsNullOrWhiteSpace(Matierep) || string.IsNullOrWhiteSpace(Couleurp) || Prix <= 0 || Genre <= 0)
            {
                MessageBox.Show("Vous devez remplir les champs obligatoires et avec des valeurs positives", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;
                MySqlConnection Conn = new MySqlConnection(StrConn);
                string Sql = "UPDATE produit SET prix = @prix, en_vente = @envente, matiere_p = @matierep, couleur_p = @couleurp, titrage = @titrage, matiere_s = @matieres, couleur_s = @couleurs, motif = @motif, id_genre = @genre WHERE id = @id";
                try
                {
                    MySqlCommand Cmd = new MySqlCommand(Sql, Conn);
                    Cmd.Parameters.AddWithValue("@id", Id);
                    Cmd.Parameters.AddWithValue("@prix", Prix);
                    Cmd.Parameters.AddWithValue("@envente", Envente);
                    Cmd.Parameters.AddWithValue("@matierep", Matierep);
                    Cmd.Parameters.AddWithValue("@couleurp", Couleurp);
                    Cmd.Parameters.AddWithValue("@titrage", Titrage);
                    Cmd.Parameters.AddWithValue("@matieres", Matieres);
                    Cmd.Parameters.AddWithValue("@couleurs", Couleurs);
                    Cmd.Parameters.AddWithValue("@motif", Motif);
                    Cmd.Parameters.AddWithValue("@genre", Genre);

                    Conn.Open();
                    return Cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur SQL : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                finally
                { Conn.Close(); }
            }
        }

        public static int ModifierPierre(int IdProduit, string Matiere, string Couleur, int Nombre, int Caratage, string Sertis)
        {
            if (string.IsNullOrWhiteSpace(Matiere) || string.IsNullOrWhiteSpace(Couleur) || Nombre <= 0 || Sertis == "")
            {
                MessageBox.Show("Vous devez remplir les champs obligatoires et avec des valeurs positives", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;
                MySqlConnection Conn = new MySqlConnection(StrConn);
                string Sql = "UPDATE produit_suplement SET matiere = @matiere, couleur = @couleur, nombre = @nombre, caratage = @caratage, sertis = @sertis WHERE id_produit = @id";
                try
                {
                    MySqlCommand Cmd = new MySqlCommand(Sql, Conn);
                    Cmd.Parameters.AddWithValue("@id", IdProduit);
                    Cmd.Parameters.AddWithValue("@matiere", Matiere);
                    Cmd.Parameters.AddWithValue("@couleur", Couleur);
                    Cmd.Parameters.AddWithValue("@nombre", Nombre);
                    Cmd.Parameters.AddWithValue("@caratage", Caratage);
                    Cmd.Parameters.AddWithValue("@sertis", Sertis);

                    Conn.Open();
                    return Cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur SQL : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                finally
                { Conn.Close(); }
            }

        }

    }
}
