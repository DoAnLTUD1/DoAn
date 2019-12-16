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
    public class ProductDAO
    {
        public DataTable LoadProduct()
        {
            Provider provider = new Provider();
            try
            {
                string sqlstr = "Select * From Products";
                provider.Connect();
                DataTable dt = provider.Select(CommandType.Text, sqlstr);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }

        public int ThemSP(ProductDTO sp)
        {
            try
            {
                string str = "insert into Products values(@id, @tensp, @giatien, @soluong, @nsx, @donvitinh)";
                Provider provider = new Provider();
                provider.Connect();
                int nRow = provider.ExecuteNonQuery(CommandType.Text, str,
                    new SqlParameter { ParameterName = "@id", Value = sp.ID },
                    new SqlParameter { ParameterName = "@tensp", Value = sp.TenSP },
                    new SqlParameter { ParameterName = "@giatien", Value = sp.GiaTien },
                    new SqlParameter { ParameterName = "@soluong", Value = sp.SoLuong },
                    new SqlParameter { ParameterName = "@nsx", Value = sp.NSX },
                    new SqlParameter { ParameterName = "@donvitinh", Value = sp.DonViTinh });
                return nRow;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public int Xoa(string ma)
        {
            try
            {
                Provider provider = new Provider();
                provider.Connect();
                string str = "DELETE FROM Products WHERE ID = @id";
                int nRow = provider.ExecuteNonQuery(CommandType.Text, str,
                    new SqlParameter { ParameterName = "@id", Value = ma });
                return nRow;
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
                Provider provider = new Provider();
                provider.Connect();
                string str = "Update Products set TenSP = @TenSP, GiaTien = @GiaTien, SoLuong = @SoLuong, NSX = @NSX, DonViTinh = @DonViTinh where ID = @id";
                int nRow = provider.ExecuteNonQuery(CommandType.Text, str,
                    new SqlParameter { ParameterName = "@id", Value = sp.ID },
                    new SqlParameter { ParameterName = "@TenSP", Value = sp.TenSP },
                    new SqlParameter { ParameterName = "@GiaTien", Value = sp.GiaTien },
                    new SqlParameter { ParameterName = "@SoLuong", Value = sp.SoLuong },
                    new SqlParameter { ParameterName = "@NSX", Value = sp.NSX },
                    new SqlParameter { ParameterName = "@DonViTinh", Value = sp.DonViTinh });
                return nRow;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
