using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class MainForm : Form
    {
        string id;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            MenuAd.Visible = false;
            MenuUser.Visible = false;
            LoginForm form = new LoginForm(id);
            form.ShowDialog();
            if (id == "0")
            {
                MenuAd.Visible = true;
            }
            else
                MenuUser.Visible = true;

        }

        private void MenuItemThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuThoatUser_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Run(new MainForm());
        }

        private void MenuItemThemHH_Click(object sender, EventArgs e)
        {
            SanPham form = new SanPham();
            form.ShowDialog();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SanPham form = new SanPham();   
            form.ShowDialog();
        }
    }
}
