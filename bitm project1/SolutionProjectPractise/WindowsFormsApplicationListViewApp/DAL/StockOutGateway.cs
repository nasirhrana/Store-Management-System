using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplicationListViewApp.BLL;
using WindowsFormsApplicationListViewApp.Models;

namespace WindowsFormsApplicationListViewApp.DAL
{
   public class StockOutGateway
    {
       static string connectionString = @"Server=NASIR\MSSQLSERVER1; Database=StockManagement; Integrated Security=true";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private string query;
        public StockOutGateway()
        {
            connection = new SqlConnection(connectionString);
        }

       private string message;
        public string SaveCatagory(Sell aCatagory)
        {
            string query = "INSERT INTO Sell (ItemName,Quantiry,Date) VALUES('" + aCatagory.ItemName + "','"+aCatagory.Quantity+"','"+DateTime.Now+"')";

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
        public string Update(StockOut aCatagory)
        {
            string message1="";
           
            query = "UPDATE t_Stock SET Quantity = '" + aCatagory.Quantity + "' WHERE ItemId = '" + aCatagory.Id + "'";
            command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            command.Connection.Close();
            if (rowAffected>0)
            {
                message1 = "Updated";
            }
            else
            {
                message1 = "not updated";
            }
            return message1;
        }
            
    }
}
