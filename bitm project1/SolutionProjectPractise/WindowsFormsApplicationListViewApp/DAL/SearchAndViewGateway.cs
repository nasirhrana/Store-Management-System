using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplicationListViewApp.ViewModel;

namespace WindowsFormsApplicationListViewApp.DAL
{
    public class SearchAndViewGateway
    {


        private static string connectionString =
            @"Server=NASIR\MSSQLSERVER1; Database=StockManagement; Integrated Security=true";

        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private string query;

        public SearchAndViewGateway()
        {
            connection = new SqlConnection(connectionString);
        }
        public List<Search> GetAll(Search aSearch)
        {
            query = "select * from [dbo].[SearchAndView]";
            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            List<Search> items = new List<Search>();
            while (reader.Read())
            {

                Search aItem = new Search();
                aItem.ItemName = reader["ItemName"].ToString();
                aItem.CompanyName = reader["CompanyName"].ToString();
                aItem.CatagoryName = reader["CatagoryName"].ToString();
                aItem.ReorderLevel = (int)reader["ReorderLevel"];
                aItem.Quantity = (int)reader["Quantity"];

                items.Add(aItem);
            }
            reader.Close();
            connection.Close();
            return items;
        }
        public List<Company> GetAllCompany()
        {

            query = "select Name from [dbo].[t_Company]";
            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            List<Company> items = new List<Company>();
            while (reader.Read())
            {

                Company aItem = new Company();
                aItem.CompanyName = reader["Name"].ToString();
                

                items.Add(aItem);
            }
            reader.Close();
            connection.Close();
            return items;
        }
        public List<Catagory> GetAllCatagory()
        {

            query = "select Name from [dbo].[t_Catagory]";
            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            List<Catagory> items = new List<Catagory>();
            while (reader.Read())
            {

                Catagory aItem = new Catagory();
                aItem.CatagoryName = reader["Name"].ToString();


                items.Add(aItem);
            }
            reader.Close();
            connection.Close();
            return items;
        }
    }

}
