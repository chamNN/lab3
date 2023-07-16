using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace onTapLab3
{
    public partial class frm_onTaplab3 : Form
    {
        public frm_onTaplab3()
        {
            InitializeComponent();
        }

        string ketNoi = "Data Source=LAPTOP-JAKJA372\\TAIMAIKHONGDUOC;Initial Catalog=onTapLab_LT3;Integrated Security=True";
        SqlConnection conn = null;

        private void frm_onTaplab3_Load(object sender, EventArgs e)
        {
            ColumnHeader masv = new ColumnHeader();
            masv.Text = "Mã Sinh Viên";
            masv.Width = 100;

            ColumnHeader tensv = new ColumnHeader();
            tensv.Text = "Họ và tên Tên";
            masv.Width = 150;
            
            ColumnHeader gioiTinh = new ColumnHeader();
            gioiTinh.Text = "Giới Tính";
            gioiTinh.Width = 80; 
            
            ColumnHeader diaChi = new ColumnHeader();
            diaChi.Text = "Địa Chỉ";
            diaChi.Width = 200;

            lstv_danhSachLop.Columns.Add(masv);
            lstv_danhSachLop.Columns.Add(tensv);
            lstv_danhSachLop.Columns.Add(gioiTinh);
            lstv_danhSachLop.Columns.Add(diaChi);

            try
            {
                conn = new SqlConnection(ketNoi);
                conn.Open();

                string xuatLop = @"SELECT * FROM lop";

                SqlCommand cmd = new SqlCommand(xuatLop, conn);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    string TenLop = rdr["tenLop"].ToString();
                    lstB_chonLop.Items.Add(TenLop);
                }

                rdr.Close();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            


        }

        private void lstB_chonLop_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

        private void lstv_danhSachLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_xuatThongTin_Click(object sender, EventArgs e)
        {
            lstv_danhSachLop.Items.Clear();
            if(lstB_chonLop.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một lớp.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string CMB_tenLop = lstB_chonLop.SelectedItem.ToString();
            try
            {


                using (conn = new SqlConnection(ketNoi))
                {
                    conn.Open();


                    /*string xuatSinhVien = @"SELECT sinhVien.maSV, sinhVien.hoTen, sinhVien.gioiTinh, sinhVien.diaChi FROM sinhVien
                                      INNER JOIN lop ON sinhVien.MaLop = lop.MaLop
                                      WHERE lop.tenLop = @TenLop";*/

                    string xuatRa = @"SELECT sinhVien.maSV, sinhVien.hoTen, sinhVien.gioiTinh, sinhVien.diaChi FROM sinhVien, lop WHERE lop.tenLop = @TenLop AND sinhVien.maLop = lop.maLop";
                    SqlCommand cmd = new SqlCommand(xuatRa, conn);
                    cmd.Parameters.AddWithValue("@TenLop", CMB_tenLop);

                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        string masv = rdr["maSV"].ToString();
                        string hoten = rdr["hoTen"].ToString();
                        string GioiTinh = rdr["gioiTinh"].ToString();
                        string DiaChi = rdr["diaChi"].ToString();

                        ListViewItem item = new ListViewItem();
                        item.Text = masv;
                        item.SubItems.Add(hoten);
                        item.SubItems.Add(GioiTinh);
                        item.SubItems.Add(DiaChi);
                        lstv_danhSachLop.Items.Add(item);
                        lstv_danhSachLop.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                        lstv_danhSachLop.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    }
                    rdr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một sinh viên trong ListView chưa
            if (lstv_danhSachLop.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Xác nhận xóa sinh viên
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            try
            {
                using (SqlConnection connection = new SqlConnection(ketNoi))
                {
                    connection.Open();

                    // Lấy mã sinh viên của sinh viên được chọn trong ListView
                    string maSV = lstv_danhSachLop.SelectedItems[0].Text;

                    // Xóa sinh viên khỏi CSDL
                    string sql = "DELETE FROM SinhVien WHERE maSV = @MaSV";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@MaSV", maSV);
                    command.ExecuteNonQuery();

                    // Xóa sinh viên khỏi ListView
                    lstv_danhSachLop.SelectedItems[0].Remove();

                    MessageBox.Show("Đã xóa sinh viên thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
