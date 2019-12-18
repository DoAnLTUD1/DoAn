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
                string str = "SELECT * FROM Users WHERE UserName = @UserName and Password = @Password";
                provider.Connect();
                DataTable dt = provider.Select(CommandType.Text, str,
                    new SqlParameter { ParameterName = "@UserName", Value = dto.UserName },
                    new SqlParameter { ParameterName = "@Password", Value = dto.Password });
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
        public DataTable LoadUs()
        {

            Provider provider = new Provider();
            try
            {
                string str = "SELECT ID, Username, Password, Name FROM Users, Per_Name WHERE Permission = ID_per";
                provider.Connect();
                DataTable dt = provider.Select(CommandType.Text, str);
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
