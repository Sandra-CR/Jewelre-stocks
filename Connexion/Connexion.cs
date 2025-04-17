using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewelre_BTS_SIO.Connexion
{
    internal class Connexion
    {
        // --------------------------------------------------- //
        // -------------- PARTIE ADMINISTRATEUR -------------- //
        // --------------------------------------------------- //
        public static string MdpAdmin(string email)
        {
            string storedHash = null;
            string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;

            using (MySqlConnection Conn = new MySqlConnection(StrConn))
            {
                Conn.Open();
                string Sql = "SELECT mdp FROM administrateur WHERE email = @Email";

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
        public static int GetIdAdmin(string Email)
        {
            int AdminId;
            string StrConn = ConfigurationManager.ConnectionStrings["Str"].ConnectionString;

            using (MySqlConnection Conn = new MySqlConnection(StrConn))
            {
                Conn.Open();
                string Sql = "SELECT id FROM administrateur WHERE email = @Email";

                using (MySqlCommand Cmd = new MySqlCommand(Sql, Conn))
                {
                    Cmd.Parameters.AddWithValue("@Email", Email);
                    int result = (int)Cmd.ExecuteScalar();

                    AdminId = result;
                }
            }
            return AdminId;
        }
    }
}
