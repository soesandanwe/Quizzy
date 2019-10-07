using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Quizzy.DAL
{
    public class UserDAL
    {
        DataTable dtUser = new DataTable();
        public DataTable GetAllUser()
        {
            Connection conn = new Connection();
            if(ConnectionState.Closed==conn.con.State)
            {
                conn.con.Open();
            }

            SqlCommand cmd = new SqlCommand("Select * From [User]",conn.con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dtUser.Load(rd);
                return dtUser;
            }
            catch
            {
                throw;
            }
            
            
        }
    }
}
