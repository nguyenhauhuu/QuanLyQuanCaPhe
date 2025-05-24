using DocumentFormat.OpenXml.Office2010.Excel;
using QuanLyQuanCaPhe.Data;
using QuanLyQuanCaPhe.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyQuanCaPhe.Data.HoaDonChiTiet;
using static QuanLyQuanCaPhe.Reports.QLQCPDataset;

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmChucNang : Form
    {
        QLQCPContext context; // Khởi tạo biến ngữ cảnh CSDL 
        int idBan;
        int idHD;
        int idTaiKhoan;
        BindingList<DanhSachHoaDonChiTiet> hoaDonChiTiet = new BindingList<DanhSachHoaDonChiTiet>();
        public frmChucNang()
        {
            InitializeComponent();
        }
        public frmChucNang(int maTaiKhoan)
        {
            InitializeComponent();
            idTaiKhoan = maTaiKhoan;
        }

        public void BatTatChucNang()
        {
            // Bật tắt chức năng khi Thêm hóa đơn 
            if (idHD == 0 && dgvDanhSachThucUong.Rows.Count == 0)
            {
                cboDanhMuc.Text = "";
                cboThucUong.Text = "";
                numSoLuong.ValueNumber = 1;
                txtMoTa.Text = "";
            }

            // Nút lưu và xóa chỉ sáng khi có sản phẩm 
            btnLuu.Enabled = dgvDanhSachThucUong.Rows.Count > 0;
            btnXoa.Enabled = dgvDanhSachThucUong.Rows.Count > 0;
        }
        public void LayDanhMucVaoComboBox()
        {
            cboDanhMuc.DataSource = context.DanhMuc.ToList();
            cboDanhMuc.ValueMember = "ID";
            cboDanhMuc.DisplayMember = "TenDanhMuc";
        }
        public void LayBanVaoComboBox()
        {
            var ban = context.Ban;
            var banDau = ban.Where(x => x.TrangThai != 1).ToList();
            var banDich = ban.ToList();
            cboBanDau.DataSource = banDau;
            cboBanDau.ValueMember = "ID";
            cboBanDau.DisplayMember = "TenBan";
            cboBanDich.DataSource = banDich;
            cboBanDich.ValueMember = "ID";
            cboBanDich.DisplayMember = "TenBan";
        }
        public void LoadDanhSachBan()
        {
            flpDanhSachBan.Controls.Clear();

            var danhSachBan = context.Ban.ToList();

            foreach (var ban in danhSachBan)
            {
                var btn = new Button();
                btn.Width = 100;
                btn.Height = 120;

                btn.Text = ban.TenBan+"\n"+ (ban.TrangThai == 0 ? "Trống" : "Đang phục vụ");
                btn.TextAlign = ContentAlignment.BottomLeft;
                btn.Font = new Font("Segoe UI", 10);



                Image rawImg = ban.TrangThai == 1 ? Properties.Resources.ban_trong : Properties.Resources.ban_dang_phuc_vu;
                btn.Image = new Bitmap(rawImg, new Size(70, 70)); // resize ảnh
                btn.ImageAlign = ContentAlignment.TopCenter;




                btn.Tag = ban.ID;

                btn.Click += BtnBan_Click!;

                flpDanhSachBan.Controls.Add(btn);
            }

        }

        private void BtnBan_Click(object sender, EventArgs e)
        {
            Button? btn = sender as Button;
            idBan = (int)btn!.Tag!;
            frmChucNang_Load(sender, e);
        }

        private void frmChucNang_Load(object sender, EventArgs e)
        {
            context = new QLQCPContext();
            dgvDanhSachThucUong.AutoGenerateColumns = false;
            LayDanhMucVaoComboBox();
            LayBanVaoComboBox();
            LoadDanhSachBan();
            var ban = context.Ban.Find(idBan);
            string tenBan = ban?.TenBan ?? "";
            groupBox.Text = tenBan;

            var hd = context.HoaDon.Select(r => new
            {
                r.ID,
                r.TaiKhoanID,
                r.BanID,
                r.NgayLap,
                r.GiamGia,
                r.TrangThaiThanhToan,
                // Tính tổng tiền = tổng giá tất cả món trong hóa đơn
                TongTien = context.HoaDonChiTiet
                      .Where(ct => ct.HoaDonID == r.ID)
                      .Sum(ct => ct.SoLuong * ct.DonGia),

                // Tính tổng thanh toán = tổng tiền trừ đi phần giảm giá (%)
                TongThanhToan = context.HoaDonChiTiet
                      .Where(ct => ct.HoaDonID == r.ID)
                      .Sum(ct => ct.SoLuong * ct.DonGia) * (1 - r.GiamGia / 100m)

            }).FirstOrDefault(h => h.BanID == idBan && h.TrangThaiThanhToan == 0);
            idHD = hd?.ID ?? 0;
            if (idHD != 0)
            {
                idHD = hd!.ID;
                var ct = context.HoaDonChiTiet.Where(r => r.HoaDonID == idHD).Select(r => new DanhSachHoaDonChiTiet
                {
                    ID = r.ID,
                    HoaDonID = r.HoaDonID,
                    ThucUongID = r.ThucUongID,
                    TenThucUong = r.ThucUong.TenThucUong,
                    SoLuong = r.SoLuong,
                    GhiChu = r.GhiChu,
                    DonGia = r.DonGia,
                    ThanhTien = r.SoLuong * r.DonGia
                }).ToList();
                hoaDonChiTiet = new BindingList<DanhSachHoaDonChiTiet>(ct);
            }
            else
            {
                hoaDonChiTiet = new BindingList<DanhSachHoaDonChiTiet>();
            }
            numGiamGia.Value = Convert.ToDecimal(hd?.GiamGia);
            txtTongTien.Text = hd?.TongThanhToan.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
            dgvDanhSachThucUong.DataSource = hoaDonChiTiet;
            BatTatChucNang();
        }

        private void cboDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDanhMuc.SelectedValue is int danhMucID)
            {
                var dsThucUong = context.ThucUong
                    .Where(tu => tu.DanhMucID == danhMucID)
                    .ToList();

                cboThucUong.DataSource = dsThucUong;
                cboThucUong.ValueMember = "ID";
                cboThucUong.DisplayMember = "TenThucUong";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int idThucUong = Convert.ToInt32(cboThucUong.SelectedValue!.ToString());
            var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.ThucUongID == idThucUong);

            int soLuong = Convert.ToInt32(numSoLuong.ValueNumber);
            decimal donGia = context.ThucUong.FirstOrDefault(x => x.ID == idThucUong)!.DonGia;
            decimal thanhTien = soLuong * donGia;
            string ghiChu = txtMoTa.Text;
            // Nếu đã tồn tại sản phẩm thì cập nhật thông tin  
            if (chiTiet != null)
            {
                chiTiet.SoLuong = soLuong;
                chiTiet.ThanhTien = thanhTien;
                chiTiet.DonGia = donGia;
                chiTiet.GhiChu = ghiChu;
                dgvDanhSachThucUong.Refresh();
            }
            else // Nếu chưa có sản phẩm thì thêm vào 
            {
                // Nếu chưa có sản phẩm nào 
                DanhSachHoaDonChiTiet ct = new DanhSachHoaDonChiTiet
                {
                    ID = 0,
                    HoaDonID = idHD,
                    ThucUongID = idThucUong,
                    TenThucUong = cboThucUong.Text,
                    SoLuong = soLuong,
                    DonGia = donGia,
                    ThanhTien = thanhTien,
                    GhiChu = ghiChu
                };
                hoaDonChiTiet.Add(ct);
            }
            BatTatChucNang();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (idHD != 0) // Đã tồn tại chi tiết thì chỉ cập nhật 
            {
                HoaDon hd = context.HoaDon.Find(idHD)!;
                if (hd != null)
                {
                    // Cập nhật lại hóa đơn 
                    hd.TaiKhoanID = idTaiKhoan;
                    hd.BanID = idBan;
                    context.HoaDon.Update(hd);

                    // Xóa chi tiết cũ 
                    var old = context.HoaDonChiTiet.Where(r => r.HoaDonID == idHD).ToList();
                    context.HoaDonChiTiet.RemoveRange(old);

                    // Thêm lại chi tiết mới 
                    foreach (var item in hoaDonChiTiet.ToList())
                    {
                        HoaDonChiTiet ct = new HoaDonChiTiet();
                        ct.HoaDonID = idHD;
                        ct.ThucUongID = item.ThucUongID;
                        ct.DonGia = item.DonGia;
                        ct.SoLuong = item.SoLuong;
                        ct.GhiChu = item.GhiChu;
                        context.HoaDonChiTiet.Add(ct);
                    }

                    context.SaveChanges();
                    Logger.GhiLog($"Tài khoản ID {idTaiKhoan} đã cập nhật hóa đơn{idHD}");

                }
            }
            else // Thêm mới 
            {
                // Thêm hóa đơn 
                HoaDon hd = new HoaDon();
                hd.TaiKhoanID = idTaiKhoan;
                hd.NgayLap = DateTime.Now;
                decimal tongTien = 0;
                foreach (var ct in hoaDonChiTiet)
                {
                    var thucUong = context.ThucUong.Find(ct.ThucUongID);
                    if (thucUong != null)
                    {
                        tongTien += ct.SoLuong * thucUong.DonGia;
                    }
                }
                hd.GiamGia = numGiamGia.Value;
                hd.BanID = idBan;
                context.HoaDon.Add(hd);
                context.SaveChanges();

                // Thêm chi tiết 
                foreach (var item in hoaDonChiTiet.ToList())
                {
                    HoaDonChiTiet ct = new HoaDonChiTiet();
                    ct.HoaDonID = hd.ID;
                    ct.ThucUongID = item.ThucUongID;
                    ct.DonGia = item.DonGia;
                    ct.SoLuong = item.SoLuong;
                    ct.GhiChu = item.GhiChu;
                    context.HoaDonChiTiet.Add(ct);
                }
                context.SaveChanges();

                Ban ban = context.Ban.Find(idBan)!;
                ban.TrangThai = 1;
                context.Ban.Update(ban);
                context.SaveChanges();
                Logger.GhiLog($"Tài khoản ID {idTaiKhoan} đã thêm hóa đơn{idHD}");



            }
            MessageBox.Show("Đã lưu thành công!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmChucNang_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachThucUong.CurrentRow != null)
            {
                int idThucUong = Convert.ToInt32(dgvDanhSachThucUong.CurrentRow.Cells["ThucUongID"].Value.ToString());
                var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.ThucUongID == idThucUong)!;
                if (chiTiet != null)
                {
                    hoaDonChiTiet.Remove(chiTiet);
                }
                BatTatChucNang();
                Logger.GhiLog($"Tài khoản ID {idTaiKhoan} đã xóa {chiTiet.TenThucUong}");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            int? idBanDau = Convert.ToInt32(cboBanDau.SelectedValue);
            int idBanDich = Convert.ToInt32(cboBanDich.SelectedValue);
            string tenBanDau = cboBanDau.Text;
            string tenBanDich = cboBanDich.Text;
            var banDau = context.Ban.Find(idBanDau);
            var banDich = context.Ban.Find(idBanDich);
            if (idBanDau == null)
            {
                MessageBox.Show($"Vui lòng chọn bàn cần chuyển");
                return;
            }
            else if (banDich?.TrangThai != 0)
            {
                MessageBox.Show($"{tenBanDich} đã có người!");
                return;
            }

            DialogResult result = MessageBox.Show(
                                    $"Bạn có chắc muốn chuyển {tenBanDau} sang {tenBanDich} không?",
                                    "Xác nhận",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question
                                );

            if (result == DialogResult.Yes)
            {
                var hd = context.HoaDon.FirstOrDefault(h => h.BanID == idBanDau && h.TrangThaiThanhToan == 0);
                hd!.BanID = idBanDich;
                context.HoaDon.Update(hd);
                context.SaveChanges();


                banDau!.TrangThai = 0;
                context.Ban.Update(banDau);
                banDich!.TrangThai = 1;
                context.Ban.Update(banDich);

                context.SaveChanges();

                MessageBox.Show("Chuyển bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmChucNang_Load(sender, e);
                Logger.GhiLog($"Tài khoản ID {idTaiKhoan} đã chuyển {tenBanDau} sang {tenBanDich} ");

            }
        }

        private void btnGopBan_Click(object sender, EventArgs e)
        {
            int idBanDau = Convert.ToInt32(cboBanDau.SelectedValue);
            int idBanDich = Convert.ToInt32(cboBanDich.SelectedValue);

            string tenBanDau = cboBanDau.Text;
            string tenBanDich = cboBanDich.Text;


            var hoaDonDau = context.HoaDon.FirstOrDefault(h => h.BanID == idBanDau && h.TrangThaiThanhToan == 0);
            var hoaDonDich = context.HoaDon.FirstOrDefault(h => h.BanID == idBanDich && h.TrangThaiThanhToan == 0);

            if (hoaDonDau == null || hoaDonDich == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn cho bàn đầu hoặc bàn đích");
                return;
            }
            if (idBanDau == idBanDich)
            {
                MessageBox.Show("Bàn đầu và bàn đích không được trùng nhau.");
                return;
            }
            var result = MessageBox.Show($"Bạn có chắc chắn muốn gộp bàn {tenBanDau} và {tenBanDich} không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;



            var chiTietHoaDonDau = context.HoaDonChiTiet.Where(r => r.HoaDonID == hoaDonDau.ID).ToList();

            foreach (var ct in chiTietHoaDonDau)
            {
                var chiTietTrung = context.HoaDonChiTiet
                    .FirstOrDefault(c => c.HoaDonID == hoaDonDich.ID && c.ThucUongID == ct.ThucUongID);

                if (chiTietTrung != null)
                {
                    chiTietTrung.SoLuong += ct.SoLuong;
                    context.HoaDonChiTiet.Remove(ct); // xóa chi tiết từ hóa đơn đầu
                }
                else
                {
                    ct.HoaDonID = hoaDonDich.ID;
                    context.HoaDonChiTiet.Update(ct);
                }
            }

            var banDau = context.Ban.FirstOrDefault(b => b.ID == idBanDau);
            if (banDau != null)
            {
                banDau.TrangThai = 0;
            }

            context.HoaDon.Remove(hoaDonDau);

            context.SaveChanges();

            MessageBox.Show("Gộp bàn thành công!");
            Logger.GhiLog($"Tài khoản ID {idTaiKhoan} đã gộp {tenBanDau} và {tenBanDich} ");


            frmChucNang_Load(sender, e);
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (idHD != 0)
            {
                frmXacNhanThanhToan xacNhanThanhToan = new frmXacNhanThanhToan(idHD);
                xacNhanThanhToan.ShowDialog();
                frmChucNang_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bàn để tính tiền.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmChucNang_Activated(object sender, EventArgs e)
        {
            frmChucNang_Load(sender, e);
        }
    }
}
