using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplicationListViewApp.Models;
using WindowsFormsApplicationListViewApp.ViewModel;

namespace WindowsFormsApplicationListViewApp.DAL
{
  public  class StockInGateway
    {
      static string connectionString = @"Server=NASIR\MSSQLSERVER1; Database=StockManagement; Integrated Security=true";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private string query;
      public StockInGateway()
        {
            connection = new SqlConnection(connectionString);
        }


      public List<ItemWithCompany> GetAllItemCompany()
      {

          query = "select * from ItemWithCompany";
          command = new SqlCommand(query, connection);         
          connection.Open();
          reader = command.ExecuteReader();
          List<ItemWithCompany> items = new List<ItemWithCompany>();
          while (reader.Read())
          {

              ItemWithCompany aItem = new ItemWithCompany();
              aItem.ItemName = reader["ItemName"].ToString();
              aItem.Id = (int) reader["Id"];
              aItem.ReorderLevel = (int) reader["ReorderLevel"];
              aItem.CompanyName = reader["CompanyName"].ToString();

              items.Add(aItem);
          }
          reader.Close();
          connection.Close();
          return items;
      }
      public List<StockWithItem> GetAllQuantity()
      {

          query = "select * from [dbo].[StockWithItem]";
          command = new SqlCommand(query, connection);         
          connection.Open();
          reader = command.ExecuteReader();
          List<StockWithItem> items = new List<StockWithItem>();
          while (reader.Read())
          {

              StockWithItem aItem = new StockWithItem();
              aItem.Name = reader["Name"].ToString();
              aItem.Quantity = (int) reader["Quantity"];

              items.Add(aItem);
          }
          reader.Close();
          connection.Close();
          return items;
      }

      public int GetReorderLevel(SetupItem aItem)
      {
          int q = 0;
          query ="select ReorderLevel from t_Item where Id='"+aItem.Id+"'";
          command=new SqlCommand(query,connection);
          connection.Open();
          reader = command.ExecuteReader();
          
          while (reader.Read())
          {
              
           q= (int) reader["ReorderLevel"];
          }
          reader.Close();
          connection.Close();

          return q;
      }
      public int GetAvailableQuantity(StockIn aStockIn)
      {
          int q = 0;
          query = "select Quantity from t_Stock where ItemId='" + aStockIn.ItemId + "'";
          command = new SqlCommand(query, connection);
          connection.Open();
          reader = command.ExecuteReader();

          while (reader.Read())
          {

              q = (int)reader["Quantity"];
          }
          reader.Close();
          connection.Close();

          return q;
      }
      public int UpdateQuantity(StockIn aStockIn)
      {
          query = "UPDATE t_Stock SET Quantity = '" + aStockIn.Quantity + "' WHERE ItemId = '" +aStockIn.ItemId + "'";
          command = new SqlCommand(query, connection);
          connection.Open();
          int rowAffected = command.ExecuteNonQuery();
          command.Connection.Close();
          return rowAffected;
      }

      
    }

    
}
