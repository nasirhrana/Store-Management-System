using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplicationListViewApp.Models;

namespace WindowsFormsApplicationListViewApp.DAL
{
   public class ReportGateway
    {
       public List<Report> ViewSwals(Report aProjectModels)
       {
           string connection = @"Data Source=NASIR\MSSQLSERVER1;Initial Catalog=StockManagement;Integrated Security=True";
           string query = @"SELECT * FROM Sell Where Date BETWEEN '" + aProjectModels.FromDateTime + "' and '" +
                          aProjectModels.ToDateTime + "'";
           SqlConnection con = new SqlConnection(connection);
           SqlCommand com = new SqlCommand(query, con);
           con.Open();
           SqlDataReader reader = com.ExecuteReader();
           List<Report> viewSale = new List<Report>();
           while (reader.Read())
           {
               Report report = new Report();
               report.ItemName = reader["ItemName"].ToString();
               report.Quantity = Convert.ToInt32(reader["Quantity"]);
               viewSale.Add(report);

           }
           con.Close();
           return viewSale;



       }
    }
}
