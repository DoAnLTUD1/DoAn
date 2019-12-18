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
        public static int xxx;
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(UserDTO us)
        {
            xxx = us.Permission;
 
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            MenuAd.Visible = false;
            LoginForm form = new LoginForm();
            form.ShowDialog();


            if (xxx == 1)
            {
                MenuAd.Visible = true;
                quảnLýToolStripMenuItem.Visible = true;
            }
            else
            {
                MenuAd.Visible = true;
                quảnLýToolStripMenuItem.Visible = false;
            }
        }

        private void ngườiDùngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                UsersForm user = new UsersForm();
                user.ShowDialog();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
