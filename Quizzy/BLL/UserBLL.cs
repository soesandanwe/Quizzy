using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quizzy.DAL;
namespace Quizzy.BLL
{
    public class UserBLL
    {
        public DataTable getUser()
        {
            try
            {
                UserDAL userDAL = new UserDAL();
                return userDAL.GetAllUser();
            }
            catch 
            {

                throw;
            }
        }
    }
}
