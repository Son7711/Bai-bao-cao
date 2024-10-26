using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlyview
{
    public partial class Form2 : Form
    {
        public List<TaiKhoan> lstTaiKhoan;

        public Form2(List<TaiKhoan> taiKhoans)
        {
            InitializeComponent();
            lstTaiKhoan = taiKhoans;
            CapNhatDanhSachTaiKhoan(); // Cập nhật danh sách tài khoản khi Form2 được mở
        }

        public Form2()
        {
        }

        private void CapNhatDanhSachTaiKhoan()
        {
            listBoxTaiKhoan.Items.Clear(); // Xóa danh sách cũ
            foreach (var tk in lstTaiKhoan)
            {
                listBoxTaiKhoan.Items.Add(tk.TenTaiKhoan); // Thêm tên tài khoản vào ListBox
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void listBoxTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi chọn một tài khoản trong ListBox, hiển thị thông tin tài khoản vào TextBox
            if (listBoxTaiKhoan.SelectedItem != null)
            {
                var taiKhoan = lstTaiKhoan.FirstOrDefault(tk => tk.TenTaiKhoan == listBoxTaiKhoan.SelectedItem.ToString());
                if (taiKhoan != null)
                {
                    tbTaiKhoan.Text = taiKhoan.TenTaiKhoan;
                    tbMatKhau.Text = taiKhoan.MatKhau;
                }
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu tài khoản trùng lặp
            if (lstTaiKhoan.Any(tk => tk.TenTaiKhoan == tbTaiKhoan.Text))
            {
                MessageBox.Show("Tài khoản đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thêm tài khoản mới
            lstTaiKhoan.Add(new TaiKhoan { TenTaiKhoan = tbTaiKhoan.Text, MatKhau = tbMatKhau.Text });
            MessageBox.Show("Thêm tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tbTaiKhoan.Clear();
            tbMatKhau.Clear();
            CapNhatDanhSachTaiKhoan(); // Cập nhật lại danh sách tài khoản sau khi thêm mới
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có tài khoản nào được chọn trong ListBox hay không
            if (listBoxTaiKhoan.SelectedItem != null)
            {
                var taiKhoanCanXoa = lstTaiKhoan.FirstOrDefault(tk => tk.TenTaiKhoan == listBoxTaiKhoan.SelectedItem.ToString());
                if (taiKhoanCanXoa != null)
                {
                    lstTaiKhoan.Remove(taiKhoanCanXoa);
                    MessageBox.Show("Xóa tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tbTaiKhoan.Clear();
                    tbMatKhau.Clear();
                    CapNhatDanhSachTaiKhoan(); // Cập nhật lại danh sách tài khoản sau khi xóa
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
