using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Quizzy.DAL
{
    public class Connection
    {
        public SqlConnection con = new SqlConnection("Data Source=DESKTOP-F99LV0H\\SOESANDANWE;Initial Catalog=personalityquiz;Integrated Security=True");


    }
}
