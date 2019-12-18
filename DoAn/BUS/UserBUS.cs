using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class UserBUS
    {
        public DataTable DangNhap(UserDTO dto)
        {
            try
            {
                UserDAO dao = new UserDAO();
                return dao.DangNhap(dto);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataTable LoadUs()
        {
            try
            {
                UserDAO dao = new UserDAO();
                return dao.LoadUs();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
