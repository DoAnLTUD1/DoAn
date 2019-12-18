using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace DoAn
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            LoadUser();
        }
        UserDTO RowSelected;
        private void LoadUser()
        {
            try
            {
                UserBUS bus = new UserBUS();
                DataTable dt = bus.LoadUs();
                dgvUsers.DataSource = dt;


                //if (dt.Rows.Count > 0)
                //{
                //    dgvUsers.Rows[0].Selected = true;
                //    RowSelected = new UserDTO();
                //    RowSelected.UserID = dgvUsers.SelectedRows[0].Cells["ID"].Value.ToString();
                //    RowSelected.UserName = dgvUsers.SelectedRows[0].Cells["TenSP"].Value.ToString();
                //    RowSelected.Passwords = dgvUsers.SelectedRows[0].Cells["GiaTien"].Value.ToString();
                //    RowSelected.Permission = int.Parse(dgvUsers.SelectedRows[0].Cells["NSX"].Value.ToString());
                //}
                
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
