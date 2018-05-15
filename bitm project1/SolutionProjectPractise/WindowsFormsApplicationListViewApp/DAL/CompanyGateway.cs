using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplicationListViewApp.Models;

namespace WindowsFormsApplicationListViewApp.DAL
{
   public class CompanyGateway
   {
        static string connectionString = @"Server=NASIR\MSSQLSERVER1; Database=StockManagement; Integrated Security=true";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private string query;
        public CompanyGateway()
        {
            connection = new SqlConnection(connectionString);
        }
      public List<SetupCompany> GetAllCompany()
        {
            string query = "SELECT * FROM t_Company";
            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            List<SetupCompany> companyList = new List<SetupCompany>();
            while (reader.Read())
            {
                object id = reader[0];
                object name1 = reader[1];
                SetupCompany aCatagory = new SetupCompany
                {
                    Id = (int)id,
                    Name = (string)name1,
                };
                companyList.Add(aCatagory);
            }
            connection.Close();
            return companyList;
        }

       
        public string message;
        public string SaveCompany(SetupCompany aCompany)
        {
            string query = "INSERT INTO t_Company (Name) VALUES('" + aCompany.Name + "')";

             command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            if (rowAffected > 0)
             {
                  message = "save successfully";
             }
             else
             {
                   message = "failed to save";
             }                  
            return message;   
       }
        public bool IsCompanyNameExist(SetupCompany aCompany)
        {
            string query = "SELECT * FROM t_Company WHERE Name= '" + aCompany.Name + "'";
            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            reader.Read();
            bool isExist = reader.HasRows;
            reader.Close();
            connection.Close();
            return isExist;
        }

        
    }
}
