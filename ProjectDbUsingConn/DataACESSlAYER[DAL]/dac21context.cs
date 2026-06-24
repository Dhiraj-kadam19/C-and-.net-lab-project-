using Microsoft.Data.SqlClient;
using ProjectDbUsingConn.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDbUsingConn.DataACESSlAYER_DAL_
{
    public  class dac21context
    {
        string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
             "Initial Catalog=dac21;Integrated Security=True;";
        public List<emp> SelectRecords()
        {

            SqlConnection con = new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand("select * from emp", con);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader(); 
            List<emp>list = new List<emp>();
            while (reader.Read())
            { 
                emp emp= new emp();
                int id = Convert.ToInt32(reader["ID"]);
                string? name = Convert.ToString(reader["Name"]);
                string? adress = Convert.ToString(reader["adress"]);

                list.Add(new emp() {id=id,name=name,adress=adress });
            }
            con.Close();
            return list;
        }
        
        public emp Selectrecords(int id)
        {
            return null;
        }
        public int InsertRecord(emp obj)
        {
            return 0;

        }
        public int UpdateRecord(emp obj)
        {
            return 0;
        }
        public int deleteRecord(int id)
        {
            return 0;
        }

       
    }
   
}
