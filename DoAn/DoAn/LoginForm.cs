using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Data.SqlClient;

namespace DoAn
{
    public partial class LoginForm : Form
    {
        public string q;
        public LoginForm(string id)
        {
            id = q;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UserDTO dto = new UserDTO();
                UserBUS bus = new UserBUS();
                DataTable dt = new DataTable();


                dto.UserName = tbUserName.Text;
                dto.Passwords = tbPassword.Text;
                dt = bus.DangNhap(dto);

                //DataSet ds = new DataSet();
                //ds.Tables.Add(dt);
                if (dt.Rows.Count > 0)
                {
                    //if (ds.Tables[0].Rows[0]["Permission"].ToString().Equals('1'))
                    //{
                    //    q = "1";
                    //}
                    //else if (ds.Tables[0].Rows[0]["Permission"].ToString().Equals('0'))
                    //{
                    //    q = "0";
                    //}
                    Close();
                }
                  
                else MessageBox.Show("Tên Đăng Nhập Hoặc Mật Khẩu Không Đúng!!! \nVui Lòng Thử Lại!!!");
            }
            catch(Exception ex)
            {
                throw ex;   
            }
        }
    }
}
