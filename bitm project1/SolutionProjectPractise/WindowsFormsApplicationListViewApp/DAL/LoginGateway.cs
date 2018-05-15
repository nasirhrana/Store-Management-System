using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationListViewApp.DAL
{
    public class LoginGateway
    {
        static string connectionString = @"Server=NASIR; Database=StockManagement; Integrated Security=true";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private string query;
        public LoginGateway()
        {
            connection = new SqlConnection(connectionString);
        }

        public string Login(Login aLogin)
        {
            string msg;
            string query = "SELECT * FROM Login WHERE Username= '" + aLogin.Username + "' and Password='" + aLogin.Password + "' ";
            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            reader.Read();
            if (reader.Read())
            {
                msg = "1";
            }
            else
            {
                msg = "username and password incorrect";
            }
            return msg;

        }
    }
}
