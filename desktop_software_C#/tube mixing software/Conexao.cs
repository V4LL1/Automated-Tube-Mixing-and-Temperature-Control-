using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace tube_mixing_software { 
    public class Conexao
    {
        private static string connectionString = "server=localhost;user=root;database=mydb;port=3306;";
        private static MySqlConnection conn = new MySqlConnection(connectionString);

        public static MySqlConnection ObterConexao()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        public static void FecharConexao()
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }
}
