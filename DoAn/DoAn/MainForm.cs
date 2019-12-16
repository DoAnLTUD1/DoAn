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

namespace DoAn
{
    public partial class MainForm : Form
    {
        public int xxx;
        public MainForm(UserDTO us)
        {
            xxx = us.Permission;
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

            MenuAd.Visible = false;
            LoginForm form = new LoginForm();
            form.ShowDialog();
            if(xxx == 1){
                MenuAd.Visible = true;
            }
            else
                MenuAd.Visible = true;
        }

        private void MenuItemThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QuanLyHH_Click(object sender, EventArgs e)
        {
            SanPham form = new SanPham();
            form.ShowDialog();
        }
    }
}
