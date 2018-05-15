using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplicationListViewApp.Models;

namespace WindowsFormsApplicationListViewApp
{
    class DataAccess : CommonDataAccess 
    {
        public List<SetupCatagory> GetAll()
        {            
            connection.Open();
     
            string selectQuery = "select * from t_Catagory";
            command = new SqlCommand(selectQuery, connection);

            SqlDataReader reader = command.ExecuteReader();
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

         int count = 0;
        
        public  string message;
        public string Save(SetupCatagory catagory)
        {

           connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from t_Catagory",connection);
            DataTable table=new DataTable();
            adapter.Fill(table);
            foreach (DataRow item in table.Rows)
            {
                if (catagory.Name==item["Name"].ToString())
                {
                    count = count + 1;
                    message = "data is exist";
                }
            }
            if (count==0)
            {
                string query = string.Format("insert into t_Catagory values('{0}')", catagory.Name);
                command = new SqlCommand(query, connection);

                connection.Close();
                message = "data is saved";
            }
            return message;


        }

        public string Update(SetupCatagory category1)
        {
            try
            {
                command = new SqlCommand("update t_Catagory set Name=@name where Id=@id+1", connection);
                connection.Open();
                command.Parameters.AddWithValue("@id", category1.Id);
                command.Parameters.AddWithValue("@name", category1.Name);
                var rowAffected= command.ExecuteNonQuery();
                connection.Close();
                if (rowAffected>0)
                {
                    message = "updated";
                }
                else
                {
                    message = "failed to update";
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;

            }
            return message;

        }
    }
}
