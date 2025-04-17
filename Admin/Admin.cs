using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewelre_BTS_SIO.Admin
{
    internal class Admin
    {
        // --------------------------------------------------- //
        // --------------- PARTIE AJOUT ADMIN ---------------- //
        // --------------------------------------------------- //
        public static int Inscription(string Email, string Mdp)
        {
            string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;

            MySqlConnection Conn = new MySqlConnection(StrConn);
            MySqlCommand Cmd = null;
            string Sql = "INSERT INTO administrateur (nom, email, mdp) values ('Administrateur', @email, @mdp)";
            try
            {
                Conn.Open();
                Cmd = new MySqlCommand(Sql, Conn);
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
        // --------------- PARTIE UTILISATEURS --------------- //
        // --------------------------------------------------- //

        public static DataTable AfficherAdmin()
        {
            string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;
            MySqlConnection Conn = new MySqlConnection(StrConn);
            Conn.Open();
            string QueryString = "SELECT id, nom, email FROM administrateur WHERE 1";
            DataTable Dt = new DataTable();
            MySqlDataAdapter Adapter = new MySqlDataAdapter();
            Adapter.SelectCommand = new MySqlCommand(QueryString, Conn);
            Adapter.Fill(Dt);
            Conn.Close();
            Adapter.Dispose();
            return Dt;
        }
        public static DataTable AfficherVendeur()
        {
            string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;
            MySqlConnection Conn = new MySqlConnection(StrConn);
            Conn.Open();
            string QueryString = "SELECT id, entreprise, email, pays, date_creation FROM fournisseur WHERE 1";
            DataTable Dt = new DataTable();
            MySqlDataAdapter Adapter = new MySqlDataAdapter();
            Adapter.SelectCommand = new MySqlCommand(QueryString, Conn);
            Adapter.Fill(Dt);
            Conn.Close();
            Adapter.Dispose();
            return Dt;
        }
        public static DataTable AfficherClient()
        {
            string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;
            MySqlConnection Conn = new MySqlConnection(StrConn);
            Conn.Open();
            string QueryString = "SELECT id, pseudo, nom, prenom, email, date_creation, id_genre FROM client WHERE 1";
            DataTable Dt = new DataTable();
            MySqlDataAdapter Adapter = new MySqlDataAdapter();
            Adapter.SelectCommand = new MySqlCommand(QueryString, Conn);
            Adapter.Fill(Dt);
            Conn.Close();
            Adapter.Dispose();
            return Dt;
        }


        // --------------------------------------------------- //
        // ----------------- PARTIE PRODUITS ----------------- //
        // --------------------------------------------------- //

        public static DataTable AfficherBague()
        {
            string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;
            MySqlConnection Conn = new MySqlConnection(StrConn);
            Conn.Open();
            string QueryString = "SELECT id, prix, en_vente, matiere_p, couleur_p, titrage, matiere_s, couleur_s, motif, id_genre, id_fournisseur FROM produit WHERE type_produit = 'Bague'";
            DataTable Dt = new DataTable();
            MySqlDataAdapter Adapter = new MySqlDataAdapter();
            Adapter.SelectCommand = new MySqlCommand(QueryString, Conn);
            Adapter.Fill(Dt);
            Conn.Close();
            Adapter.Dispose();
            return Dt;
        }
        public static DataTable AfficherEarrings()
        {
            string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;
            MySqlConnection Conn = new MySqlConnection(StrConn);
            Conn.Open();
            string Type = "Boucles d''oreilles";
            string QueryString = "SELECT id, prix, en_vente, matiere_p, couleur_p, titrage, matiere_s, couleur_s, motif, fermoir, id_genre, id_fournisseur FROM produit WHERE type_produit = '" + Type + "'";
            DataTable Dt = new DataTable();
            MySqlDataAdapter Adapter = new MySqlDataAdapter();
            Adapter.SelectCommand = new MySqlCommand(QueryString, Conn);
            Adapter.Fill(Dt);
            Conn.Close();
            Adapter.Dispose();
            return Dt;
        }
        public static DataTable AfficherBracelet()
        {
            string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;
            MySqlConnection Conn = new MySqlConnection(StrConn);
            Conn.Open();
            string Type = "Bracelet";
            string QueryString = "SELECT id, prix, en_vente, matiere_p, couleur_p, titrage, matiere_s, couleur_s, motif, chaine, fermoir, id_genre, id_fournisseur FROM produit WHERE type_produit = '" + Type + "'";
            DataTable Dt = new DataTable();
            MySqlDataAdapter Adapter = new MySqlDataAdapter();
            Adapter.SelectCommand = new MySqlCommand(QueryString, Conn);
            Adapter.Fill(Dt);
            Conn.Close();
            Adapter.Dispose();
            return Dt;
        }
        public static DataTable AfficherCollier()
        {
            string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;
            MySqlConnection Conn = new MySqlConnection(StrConn);
            Conn.Open();
            string Type = "Collier";
            string QueryString = "SELECT id, prix, en_vente, matiere_p, couleur_p, titrage, matiere_s, couleur_s, chaine, fermoir, id_genre, id_fournisseur FROM produit WHERE type_produit = '" + Type + "'";
            DataTable Dt = new DataTable();
            MySqlDataAdapter Adapter = new MySqlDataAdapter();
            Adapter.SelectCommand = new MySqlCommand(QueryString, Conn);
            Adapter.Fill(Dt);
            Conn.Close();
            Adapter.Dispose();
            return Dt;
        }
        public static DataTable AfficherCollection()
        {
            string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;
            MySqlConnection Conn = new MySqlConnection(StrConn);
            Conn.Open();
            string QueryString = "SELECT id, titre, date_sortie FROM collection WHERE 1";
            DataTable Dt = new DataTable();
            MySqlDataAdapter Adapter = new MySqlDataAdapter();
            Adapter.SelectCommand = new MySqlCommand(QueryString, Conn);
            Adapter.Fill(Dt);
            Conn.Close();
            Adapter.Dispose();
            return Dt;
        }

    }
}
