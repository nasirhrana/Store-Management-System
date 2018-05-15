using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationListViewApp
{
    public class CommonDataAccess
    {
        protected SqlConnection connection;
        protected SqlCommand command;
        public CommonDataAccess()
        {
           
            string connectionString = @"server=NASIR; database=StockManagement; Integrated security=true;";
            connection = new SqlConnection(connectionString);
        }
        
    }
}
