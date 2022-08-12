using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace EAPAPP
{
    internal class UserRepository : IUserRepository
    {
        public async Task<bool> Insert(User user)
        {
            using (IDbConnection db= new SqlConnection(AppHelper.ConnectionString))
            {
                var result=await db.ExecuteAsync(EAPAPP.Properties.Resources.InsertUser, new { Name = user.Name, Email = user.Email, Department = user.Department, DOB = user.DOB, Password = user.Password });
                return result > 0;
            }
        }
    }
}
