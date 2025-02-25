using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop.DataLayer
{
    internal class ConnectionDAL
    {
        public bool testConnection()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS; Initial Catalog=BarberShop; Integrated Security =True");
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Empleados";
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }catch { 
                return false;
            }
        }
    }
}
