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
    public class CatagoryGateway
    {
        static string connectionString = @"Server=NASIR\MSSQLSERVER1; Database=StockManagement; Integrated Security=true";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private string query;
        public CatagoryGateway()
        {
            connection = new SqlConnection(connectionString);
        }
        public List<SetupCatagory> GetAllCatagory()
        {
             string query = "SELECT * FROM t_Catagory";
              command = new SqlCommand(query, connection);
             connection.Open();
              reader = command.ExecuteReader();
            List<SetupCatagory> catagoriList = new List<SetupCatagory>();
            while (reader.Read())
            {
                object id = reader[0];
                object name1 = reader[1];
                SetupCatagory aCatagory = new SetupCatagory
                {
                    Id = (int)id,
                    Name = (string)name1,
                };
                catagoriList.Add(aCatagory);
            }
            connection.Close();
            return catagoriList;
        }
        public string message;
        public string SaveCatagory(SetupCatagory aCatagory)
        {
            string query = "INSERT INTO t_Catagory (Name) VALUES('" + aCatagory.Name + "')";

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



        public bool IsCatagoryNameExist(SetupCatagory aCatagory)
        {
            string query = "SELECT * FROM t_Catagory WHERE Name= '" +aCatagory.Name + "' AND Id<>'"+ aCatagory.Id+"'";
            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            reader.Read();
            bool isExist = reader.HasRows;
            reader.Close();
            connection.Close();
            return isExist;
        }

        public int UpdateCatagory(SetupCatagory aCatagory)
        {
            query = "UPDATE t_Catagory SET Name = '" + aCatagory.Name + "' WHERE Id = '" + aCatagory.Id + "'";
            command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            command.Connection.Close();
            return rowAffected;
        }

        public int DeleteCatagory(SetupCatagory aCatagory)
        {

            query = "delete from t_Catagory  WHERE Id = '" + aCatagory.Id + "'";
            command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            command.Connection.Close();
            return rowAffected;

        }








   }
}
