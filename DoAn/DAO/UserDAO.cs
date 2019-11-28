using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class UserDAO
    {

        public DataTable DangNhap(UserDTO dto)
        {
            
            Provider provider = new Provider();
            try
            {
                string str = "SELECT UserName FROM Users WHERE UserName = @UserName and Passwords = @Passwords";
                provider.Connect();
                DataTable dt = provider.Select(CommandType.Text, str,
                    new SqlParameter { ParameterName = "@UserName", Value = dto.UserName },
                    new SqlParameter { ParameterName = "@Passwords", Value = dto.Passwords });
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }
    }
}
