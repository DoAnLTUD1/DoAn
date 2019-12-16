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
    public class ProductBUS
    {
        public DataTable LoadProduct()
        {
            try
            {
                ProductDAO dao = new ProductDAO();
                return dao.LoadProduct();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ThemSP(ProductDTO sp)
        {
            ProductDAO dao = new ProductDAO();
            return dao.ThemSP(sp);
        }
        public int Xoa(string ma)
        {
            try
            {
                ProductDAO dao = new ProductDAO();
                return dao.Xoa(ma);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Sua(ProductDTO sp)
        {
            try
            {
                ProductDAO dao = new ProductDAO();
                return dao.Sua(sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
