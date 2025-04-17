using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Xml;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Net.Http;
using BCrypt.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;

namespace Jewelre_BTS_SIO
{
    internal class Methods
    {
        // --------------------------------------------------- //
        // --------- INSCRIPTION ET AUTHENTIFICATION --------- //
        // --------------------------------------------------- //

        // --- Partie Generale --- //
        public static bool ConfirmMdp(string Mdp, string MdpC)
        {
            bool Result;
            if (Mdp != MdpC)
            { Result = false; }
            else
            { Result = true; }
            return Result;
        }

        public static bool ConditionsPassword(string Mdp)
        {
            if (Mdp.Length < 8)
            {
                return false;
            }

            if (!Regex.IsMatch(Mdp, @"[A-Z]"))
            {
                return false;
            }

            if (!Regex.IsMatch(Mdp, @"[\W_]"))
            {
                return false;
            }

            return true;
        }

        public static string HashPassword(string Mdp)
        {
            return BCrypt.Net.BCrypt.HashPassword(Mdp);
        }

        public static bool VerifyPassword(string Mdp, string storedHash)
        {
            if (string.IsNullOrEmpty(storedHash))
                return false;

            return BCrypt.Net.BCrypt.Verify(Mdp, storedHash);
        }


        // --- Partie Vendeur --- //
        public static object EntrepriseUnique(string NomE)
        {
            string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;
            MySqlConnection Conn = new MySqlConnection(StrConn);
            MySqlCommand Cmd = null;
            string Sql = "SELECT entreprise FROM fournisseur WHERE entreprise ='" + NomE + "'";
            Conn.Open();
            Cmd = new MySqlCommand(Sql, Conn);
            object Result = Cmd.ExecuteScalar();
            return Result;
        }
        public static object EmailVendeurUnique(string Email)
        {
            string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;
            MySqlConnection Conn = new MySqlConnection(StrConn);
            MySqlCommand Cmd = null;
            string Sql = "SELECT email FROM fournisseur WHERE email ='" + Email + "'";
            Conn.Open();
            Cmd = new MySqlCommand(Sql, Conn);
            object Result = Cmd.ExecuteScalar();
            return Result;
        }

        public static string AuthVendeur(string email)
        {
            string storedHash = null;
            string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;

            using (MySqlConnection Conn = new MySqlConnection(StrConn))
            {
                Conn.Open();
                string Sql = "SELECT mdp FROM fournisseur WHERE email = @Email";

                using (MySqlCommand Cmd = new MySqlCommand(Sql, Conn))
                {
                    Cmd.Parameters.AddWithValue("@Email", email);
                    object result = Cmd.ExecuteScalar();

                    if (result != null)
                        storedHash = result.ToString().Trim();
                }
            }
            return storedHash;
        }

        public static int GetIdVendeur(string Email)
        {
            int VendeurId;
            string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;

            using (MySqlConnection Conn = new MySqlConnection(StrConn))
            {
                Conn.Open();
                string Sql = "SELECT id FROM fournisseur WHERE email = @Email";

                using (MySqlCommand Cmd = new MySqlCommand(Sql, Conn))
                {
                    Cmd.Parameters.AddWithValue("@Email", Email);
                    int result = (int)Cmd.ExecuteScalar();

                    VendeurId = result;
                }
            }
            return VendeurId;
        }
        public static string GetEntreprise(int Id)
        {
            string NomE;
            string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;

            using (MySqlConnection Conn = new MySqlConnection(StrConn))
            {
                Conn.Open();
                string Sql = "SELECT entreprise FROM fournisseur WHERE id = @id";

                using (MySqlCommand Cmd = new MySqlCommand(Sql, Conn))
                {
                    Cmd.Parameters.AddWithValue("@id", Id);
                    string result = (string)Cmd.ExecuteScalar();

                    NomE = result;
                }
            }
            return NomE;
        }



        public static int InscriptionVendeur(string NomE, string Email, string Mdp)
        {
            string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;

            MySqlConnection Conn = new MySqlConnection(StrConn);
            MySqlCommand Cmd = null;
            string Sql = "INSERT INTO fournisseur (entreprise, email, date_creation, mdp) values (@nomE, @email, NOW(), @mdp)";
            try
            {
                Conn.Open();
                Cmd = new MySqlCommand(Sql, Conn);
                Cmd.Parameters.AddWithValue("nomE", NomE);
                Cmd.Parameters.AddWithValue("email", Email);
                Cmd.Parameters.AddWithValue("mdp", Mdp);
                return Cmd.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception();
            }
            finally
            {
                Cmd.Dispose();
                Conn.Close();
            }
        }



        // --------------------------------------------------- //
        // ------------------- RECHERCHE --------------------- //
        // --------------------------------------------------- //

        public static DataTable RechercherPlus(string Sql, string Content, int Plus)
        {
            string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;
            MySqlConnection Conn = new MySqlConnection(StrConn);
            Conn.Open();
            MySqlDataAdapter Adapter = new MySqlDataAdapter(Sql, Conn);
            Adapter.SelectCommand.Parameters.AddWithValue("@Plus", Plus);
            Adapter.SelectCommand.Parameters.AddWithValue("@Content", Content + "%");
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            Conn.Close();
            Adapter.Dispose();
            return Dt;
        }

        public static DataTable Rechercher(string Sql, string Content)
        {
            string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;
            MySqlConnection Conn = new MySqlConnection(StrConn);
            Conn.Open();
            MySqlDataAdapter Adapter = new MySqlDataAdapter(Sql, Conn);
            Adapter.SelectCommand.Parameters.AddWithValue("@Content", Content + "%");
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            Conn.Close();
            Adapter.Dispose();
            return Dt;
        }


        // --------------------------------------------------- //
        // ------------------- AFFICHAGE --------------------- //
        // --------------------------------------------------- //
        
        // --- Partie Generale --- //
        public static DataTable AfficherSupplements(int Id)
        {
            string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;
            MySqlConnection Conn = new MySqlConnection(StrConn);
            string QueryString = "SELECT type_sup, nombre, matiere, couleur, caratage, sertis FROM produit_suplement WHERE id_produit = @Id";
            MySqlCommand Cmd = new MySqlCommand(QueryString, Conn);
            Cmd.Parameters.AddWithValue("@Id", Id);
            DataTable Dt = new DataTable();
            try
            {
                Conn.Open();
                MySqlDataAdapter Adapter = new MySqlDataAdapter(Cmd);
                Adapter.Fill(Dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                Conn.Close();
                Cmd.Dispose();
            }
            return Dt;
        }

        public static DataTable AfficherTaillesBague(int Id)
        {
            string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;
            MySqlConnection Conn = new MySqlConnection(StrConn);
            string QueryString = "SELECT tour_doigt, quantite, poids FROM produit_taille WHERE id_produit = @Id";
            MySqlCommand Cmd = new MySqlCommand(QueryString, Conn);
            Cmd.Parameters.AddWithValue("@Id", Id);
            DataTable Dt = new DataTable();
            try
            {
                Conn.Open();
                MySqlDataAdapter Adapter = new MySqlDataAdapter(Cmd);
                Adapter.Fill(Dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                Conn.Close();
                Cmd.Dispose();
            }
            return Dt;
        }
        public static DataTable AfficherTailles(int Id)
        {
            string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;
            MySqlConnection Conn = new MySqlConnection(StrConn);
            string QueryString = "SELECT longueur, largeur, quantite, poids FROM produit_taille WHERE id_produit = @Id";
            MySqlCommand Cmd = new MySqlCommand(QueryString, Conn);
            Cmd.Parameters.AddWithValue("@Id", Id);
            DataTable Dt = new DataTable();
            try
            {
                Conn.Open();
                MySqlDataAdapter Adapter = new MySqlDataAdapter(Cmd);
                Adapter.Fill(Dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                Conn.Close();
                Cmd.Dispose();
            }
            return Dt;
        }
        public static DataTable ProduitsCollection(int IdCollection)
        {
            string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;
            MySqlConnection Conn = new MySqlConnection(StrConn);
            string QueryString = "SELECT id, type_produit, en_vente, matiere_p, couleur_p, motif, id_fournisseur FROM produit WHERE id_collection = @IdCollection";
            MySqlCommand Cmd = new MySqlCommand(QueryString, Conn);
            Cmd.Parameters.AddWithValue("@IdCollection", IdCollection);
            DataTable Dt = new DataTable();
            try
            {
                Conn.Open();
                MySqlDataAdapter Adapter = new MySqlDataAdapter(Cmd);
                Adapter.Fill(Dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                Conn.Close();
                Cmd.Dispose();
            }
            return Dt;
        }


        // --- Partie Produits --- //
        public static DataTable AfficherBague()
        {
            int VendeurId = Session.VendeurId;
            string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;
            MySqlConnection Conn = new MySqlConnection(StrConn);
            Conn.Open();
            string QueryString = "SELECT id, prix, en_vente, matiere_p, couleur_p, titrage, matiere_s, couleur_s, motif, id_genre FROM produit WHERE id_fournisseur = " + VendeurId + " AND type_produit = 'Bague'";
            DataTable Dt = new DataTable();
            MySqlDataAdapter Adapter = new MySqlDataAdapter();
            Adapter.SelectCommand = new MySqlCommand(QueryString, Conn);
            Adapter.Fill(Dt);
            Conn.Close();
            Adapter.Dispose();
            return Dt;
        }



        // --------------------------------------------------- //
        // ------------------- SUPPRESSION ------------------- //
        // --------------------------------------------------- //
        public static bool ModifierItem(string Sql, int Item)
        {
            string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;
            MySqlConnection Conn = new MySqlConnection(StrConn);
            Conn.Open();
            MySqlCommand Cmd = new MySqlCommand(Sql, Conn);
            Cmd.Parameters.AddWithValue("@Item", Item);
            int rowsAffected = Cmd.ExecuteNonQuery();
            if (rowsAffected > 0) { return true; } else { return false; }
        }
        public static bool ModifierItemPlus(string Sql, int Id, int Item)
        {
            string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;
            MySqlConnection Conn = new MySqlConnection(StrConn);
            Conn.Open();
            MySqlCommand Cmd = new MySqlCommand(Sql, Conn);
            Cmd.Parameters.AddWithValue("@Id", Id);
            Cmd.Parameters.AddWithValue("@Item", Item);
            int rowsAffected = Cmd.ExecuteNonQuery();
            if (rowsAffected > 0) { return true; } else { return false; }
        }



        // --------------------------------------------------- //
        // ------------------- SUPPRESSION ------------------- //
        // --------------------------------------------------- //
        public static bool Supprimer(string Sql, int Id)
        {
            string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;
            MySqlConnection Conn = new MySqlConnection(StrConn);
            Conn.Open();
            MySqlCommand Cmd = new MySqlCommand(Sql, Conn);
            Cmd.Parameters.AddWithValue("@Id", Id);
            int rowsAffected = Cmd.ExecuteNonQuery();
            if (rowsAffected > 0) { return true; } else { return false; }
        }
    }
}
