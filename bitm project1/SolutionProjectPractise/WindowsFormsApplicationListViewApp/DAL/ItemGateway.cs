using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WindowsFormsApplicationListViewApp.Models;


namespace WindowsFormsApplicationListViewApp.DAL
{
  public  class ItemGateway
    {
        static string connectionString = @"Server=NASIR\MSSQLSERVER1; Database=StockManagement; Integrated Security=true";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private string query;
      public ItemGateway()
        {
            connection = new SqlConnection(connectionString);
        }

      public List<SetupCatagory> GetAllCatagory()
      {
          query = "select * from t_Catagory";
          command=new SqlCommand(query, connection);
          connection.Open();
          reader = command.ExecuteReader();

          List<SetupCatagory> aCatagories=new List<SetupCatagory>();
          while (reader.Read())
          {
              SetupCatagory aCatagory=new SetupCatagory();
              aCatagory.Id = (int) reader["Id"];
              aCatagory.Name = reader["Name"].ToString();

              aCatagories.Add(aCatagory);
          }
          reader.Close();
          connection.Close();
          return aCatagories;

      }
      public List<SetupCompany> GetAllCompany()
      {
          query = "select * from t_Company";
          command = new SqlCommand(query, connection);
          connection.Open();
          reader = command.ExecuteReader();

          List<SetupCompany> aCompanies = new List<SetupCompany>();
          while (reader.Read())
          {
              SetupCompany aCompany = new SetupCompany();
              aCompany.Id = (int)reader["Id"];
              aCompany.Name = reader["Name"].ToString();

              aCompanies.Add(aCompany);
          }
          reader.Close();
          connection.Close();
          return aCompanies;

      }
      
      public string message;
      public string SaveItem(SetupItem aItem)
      {
          
              string query = "INSERT INTO t_Item (Name,CatagoryNameId,CompanyNameId,ReorderLevel) VALUES('" + aItem.Name + "','" + aItem.CatagoryNameId + "','" + aItem.CompanyNameId + "','" + aItem.ReorderLevel + "')";

              command = new SqlCommand(query, connection);
              connection.Open();
              int rowAffected = command.ExecuteNonQuery();
              connection.Close();
              if (rowAffected > 0)
              {
                  message = "added successfully";
              }
              
          
 
          
          return message;
      }
      public bool IsItemNameExist(SetupItem aItem)
      {
          string query = "SELECT * FROM t_Item WHERE Name= '" + aItem.Name + "' and CompanyNameId='"+ aItem.CompanyNameId+"' and CatagoryNameId='"+ aItem.CatagoryNameId+"'";
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
