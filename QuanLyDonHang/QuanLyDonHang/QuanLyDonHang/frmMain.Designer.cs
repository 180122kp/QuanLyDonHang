
namespace QuanLyDonHang
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChatLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDonBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCHangTon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHienTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mnuDanhMuc,
            this.mnuHoaDon,
            this.mnuTimKiem,
            this.mnuBaoCao,
            this.mnuTroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Tập tin";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThoat});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(77, 26);
            this.toolStripMenuItem1.Text = "Tập tin";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Image = global::QuanLyDonHang.Properties.Resources.cancel_uv1fc9acq2uh_16;
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(138, 26);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChatLieu,
            this.mnuNhanVien,
            this.mnuKhachHang,
            this.mnuHangHoa});
            this.mnuDanhMuc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(100, 26);
            this.mnuDanhMuc.Text = "Danh mục";
            // 
            // mnuChatLieu
            // 
            this.mnuChatLieu.Image = global::QuanLyDonHang.Properties.Resources.substance_gwff5vkp4x5k_16;
            this.mnuChatLieu.Name = "mnuChatLieu";
            this.mnuChatLieu.Size = new System.Drawing.Size(182, 26);
            this.mnuChatLieu.Text = "Chất liệu";
            this.mnuChatLieu.Click += new System.EventHandler(this.mnuChatLieu_Click);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Image = global::QuanLyDonHang.Properties.Resources.people_lqs6qumex1hm_16;
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(182, 26);
            this.mnuNhanVien.Text = "Nhân viên";
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Image = global::QuanLyDonHang.Properties.Resources.client_wqe87rvltc8s_16;
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(182, 26);
            this.mnuKhachHang.Text = "Khách hàng";
            // 
            // mnuHangHoa
            // 
            this.mnuHangHoa.Image = global::QuanLyDonHang.Properties.Resources.goods_6hqd09mtbi6b_16;
            this.mnuHangHoa.Name = "mnuHangHoa";
            this.mnuHangHoa.Size = new System.Drawing.Size(182, 26);
            this.mnuHangHoa.Text = "Hàng hóa";
            this.mnuHangHoa.Click += new System.EventHandler(this.mnuHangHoa_Click);
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHoaDonBan});
            this.mnuHoaDon.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(89, 26);
            this.mnuHoaDon.Text = "Hóa đơn";
            // 
            // mnuHoaDonBan
            // 
            this.mnuHoaDonBan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mnuHoaDonBan.Image = global::QuanLyDonHang.Properties.Resources.add_3z372yqb5qw3_161;
            this.mnuHoaDonBan.Name = "mnuHoaDonBan";
            this.mnuHoaDonBan.Size = new System.Drawing.Size(224, 26);
            this.mnuHoaDonBan.Text = "Hóa đơn bán";
            this.mnuHoaDonBan.Click += new System.EventHandler(this.mnuHoaDonBan_Click);
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFindHoaDon,
            this.mnuFindHang,
            this.mnuFindKhachHang});
            this.mnuTimKiem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(96, 26);
            this.mnuTimKiem.Text = "Tìm kiếm";
            // 
            // mnuFindHoaDon
            // 
            this.mnuFindHoaDon.Image = global::QuanLyDonHang.Properties.Resources.search_p15fsatt0mex_16;
            this.mnuFindHoaDon.Name = "mnuFindHoaDon";
            this.mnuFindHoaDon.Size = new System.Drawing.Size(182, 26);
            this.mnuFindHoaDon.Text = "Hóa đơn";
            this.mnuFindHoaDon.Click += new System.EventHandler(this.mnuFindHoaDon_Click);
            // 
            // mnuFindHang
            // 
            this.mnuFindHang.Image = global::QuanLyDonHang.Properties.Resources.goods_6hqd09mtbi6b_16;
            this.mnuFindHang.Name = "mnuFindHang";
            this.mnuFindHang.Size = new System.Drawing.Size(182, 26);
            this.mnuFindHang.Text = "Hàng";
            // 
            // mnuFindKhachHang
            // 
            this.mnuFindKhachHang.Image = global::QuanLyDonHang.Properties.Resources.client_wqe87rvltc8s_16;
            this.mnuFindKhachHang.Name = "mnuFindKhachHang";
            this.mnuFindKhachHang.Size = new System.Drawing.Size(182, 26);
            this.mnuFindKhachHang.Text = "Khách hàng";
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBCHangTon,
            this.mnuBCDoanhThu});
            this.mnuBaoCao.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(86, 26);
            this.mnuBaoCao.Text = "Báo cáo";
            // 
            // mnuBCHangTon
            // 
            this.mnuBCHangTon.Image = global::QuanLyDonHang.Properties.Resources.inventory_h8len05hcz8d_16;
            this.mnuBCHangTon.Name = "mnuBCHangTon";
            this.mnuBCHangTon.Size = new System.Drawing.Size(235, 26);
            this.mnuBCHangTon.Text = "Báo cáo hàng tồn";
            // 
            // mnuBCDoanhThu
            // 
            this.mnuBCDoanhThu.Image = global::QuanLyDonHang.Properties.Resources.turnover_ejq4dvvs2cem_16;
            this.mnuBCDoanhThu.Name = "mnuBCDoanhThu";
            this.mnuBCDoanhThu.Size = new System.Drawing.Size(235, 26);
            this.mnuBCDoanhThu.Text = "Báo cáo doanh thu";
            // 
            // mnuTroGiup
            // 
            this.mnuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHienTroGiup});
            this.mnuTroGiup.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnuTroGiup.Name = "mnuTroGiup";
            this.mnuTroGiup.Size = new System.Drawing.Size(88, 26);
            this.mnuTroGiup.Text = "Trợ giúp";
            // 
            // mnuHienTroGiup
            // 
            this.mnuHienTroGiup.Image = global::QuanLyDonHang.Properties.Resources.help_m72m0yuiu5zk_16;
            this.mnuHienTroGiup.Name = "mnuHienTroGiup";
            this.mnuHienTroGiup.Size = new System.Drawing.Size(214, 26);
            this.mnuHienTroGiup.Text = "Hiển thị trợ giúp";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::QuanLyDonHang.Properties.Resources.anhnenQLDH;
            this.ClientSize = new System.Drawing.Size(978, 503);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Quản lý đơn hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuChatLieu;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuHangHoa;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDonBan;
        private System.Windows.Forms.ToolStripMenuItem mnuFindHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuFindHang;
        private System.Windows.Forms.ToolStripMenuItem mnuFindKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuBCHangTon;
        private System.Windows.Forms.ToolStripMenuItem mnuBCDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem mnuHienTroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
    }
}

