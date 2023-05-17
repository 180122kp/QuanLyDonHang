using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDonHang.Class;


namespace QuanLyDonHang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Functions.Connect();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
          Functions.Disconnect(); //Đóng kết nối
            Application.Exit(); //Thoát
        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            frmDMChatLieu frm = new frmDMChatLieu(); //Khởi tạo đối tượng
            frm.ShowDialog(); //Hiển thị
        }

        private void mnuFindHoaDon_Click(object sender, EventArgs e)
        {
            frmTimHDBan frmTim = new frmTimHDBan();//Khởi tạo đối tượng
            frmTim.ShowDialog(); //Hiển thị
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frmDMHang frm = new frmDMHang();
            frm.ShowDialog();
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frmHDBan = new frmHoaDonBan();//Khởi tạo đối tượng
            frmHDBan.ShowDialog(); //Hiển thị
        }
    }
}
