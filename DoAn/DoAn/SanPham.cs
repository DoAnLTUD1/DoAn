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
    public partial class SanPham : Form
    {
        ProductDTO RowSelected;
        public SanPham()
        {
            InitializeComponent();
        }

        private void btnSP_Dong_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void SanPham_Load(object sender, EventArgs e)
        {
            LoadDATA();
        }

        public void LoadDATA()
        {
            try
            {
                ProductBUS bus = new ProductBUS();
                DataTable dt = bus.LoadProduct();
                dgvSanPham.DataSource = dt;


                if (dt.Rows.Count > 0)
                {
                    string ma = dt.Rows[dt.Rows.Count - 1]["MaSP"].ToString();
                    int num = int.Parse(ma.Substring(2)) + 1;
                    tbxID.Text = "SP" + num.ToString("0000");
                    tbxTenSP.Text = "";
                    tbxGiaTien.Text = "";
                    tbxSoLuong.Text = "";
                    tbxNSX.Text = "";
                    tbxDonViTinh.Text = "";

                    dgvSanPham.Rows[0].Selected = true;
                    RowSelected = new ProductDTO();
                    RowSelected.MaSP = dgvSanPham.SelectedRows[0].Cells["MaSP"].Value.ToString();
                    RowSelected.TenSP = dgvSanPham.SelectedRows[0].Cells["TenSP"].Value.ToString();
                    RowSelected.GiaTien = double.Parse(dgvSanPham.SelectedRows[0].Cells["GiaTien"].Value.ToString());
                    RowSelected.NSX = dgvSanPham.SelectedRows[0].Cells["NSX"].Value.ToString();
                    RowSelected.SoLuong = int.Parse(dgvSanPham.SelectedRows[0].Cells["SoLuong"].Value.ToString());
                    RowSelected.DonViTinh = dgvSanPham.SelectedRows[0].Cells["DonViTinh"].Value.ToString();
                }
                else
                {
                    tbxID.Text = "SP0001";
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                RowSelected = new ProductDTO();
                RowSelected.MaSP = dgvSanPham.SelectedRows[0].Cells["MaSP"].Value.ToString();
                RowSelected.TenSP = dgvSanPham.SelectedRows[0].Cells["TenSP"].Value.ToString();
                RowSelected.GiaTien = double.Parse(dgvSanPham.SelectedRows[0].Cells["GiaTien"].Value.ToString());
                RowSelected.NSX = dgvSanPham.SelectedRows[0].Cells["NSX"].Value.ToString();
                RowSelected.SoLuong = int.Parse(dgvSanPham.SelectedRows[0].Cells["SoLuong"].Value.ToString());
                RowSelected.DonViTinh = dgvSanPham.SelectedRows[0].Cells["DonViTinh"].Value.ToString();

                tbxID.Text = RowSelected.MaSP;
                tbxTenSP.Text = RowSelected.TenSP;
                tbxGiaTien.Text = RowSelected.GiaTien.ToString();
                tbxNSX.Text = RowSelected.NSX;
                tbxSoLuong.Text = RowSelected.SoLuong.ToString();
                tbxDonViTinh.Text = RowSelected.DonViTinh;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDATA();
        }

        private void btnSP_Them_Click(object sender, EventArgs e)
        {
            try
            {
                ProductDTO sp = new ProductDTO();
                if(tbxTenSP.Text != "" && tbxGiaTien.Text!= ""&& tbxSoLuong.Text != ""&&tbxNSX.Text!=""&&tbxDonViTinh.Text!="")
                {
                    sp.MaSP = tbxID.Text;
                    sp.TenSP = tbxTenSP.Text;
                    sp.GiaTien = double.Parse(tbxGiaTien.Text);
                    sp.SoLuong = int.Parse(tbxSoLuong.Text);
                    sp.NSX = tbxNSX.Text;
                    sp.DonViTinh = tbxDonViTinh.Text;

                    ProductBUS bus = new ProductBUS();
                    bus.ThemSP(sp);
                }
                else
                {
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin!!!");
                }


                LoadDATA();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void btnSP_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                ProductDTO sp = new ProductDTO();
                sp.MaSP = RowSelected.MaSP;
                ProductBUS bus = new ProductBUS();
                bus.Xoa(sp.MaSP);
                LoadDATA();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnSP_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                ProductDTO sp = new ProductDTO();
                sp.MaSP = tbxID.Text;
                sp.TenSP = tbxTenSP.Text;
                sp.GiaTien = int.Parse(tbxGiaTien.Text);
                sp.SoLuong = int.Parse(tbxSoLuong.Text);
                sp.NSX = tbxNSX.Text;
                sp.DonViTinh = tbxDonViTinh.Text;

                ProductBUS bus = new ProductBUS();
                bus.Sua(sp);

                LoadDATA();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
