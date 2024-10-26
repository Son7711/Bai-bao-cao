using Quanlyview;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Quanlyview
{
    public partial class Quanly : Form
    {
        public List<Employee> lstEmp = new List<Employee>();
        private BindingSource bs = new BindingSource();
        public bool isThoat = true;
        public event EventHandler DangXuat;

        private string employeeImagePath = string.Empty; // Store the image path

        public Quanly()
        {
            InitializeComponent();
            SetupImageList();

            //ngày sinh
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd MMMM yyyy";
            dateTimePicker1.ShowUpDown = true; // Hiển thị theo dạng lên/xuống
        }

        private void Quanly_Load(object sender, EventArgs e)
        {
            lstEmp = GetData();
            bs.DataSource = lstEmp; // Khởi tạo DataSource ở đây
            dgvEmployee.DataSource = bs; // Đặt DataSource cho DataGridView
            SetupDataGridView();
            dgvEmployee.CellBeginEdit += dgvEmployee_CellBeginEdit; // Đăng ký sự kiện

            dateTimePicker1.Value = DateTime.Now; // Set the default date to now

            cbSortOptions.Items.Add("Sắp xếp theo tên");
            cbSortOptions.Items.Add("Sắp xếp theo ID");
            cbSortOptions.SelectedIndex = 0; // Mặc định chọn "Sắp xếp theo tên"
        }


        public List<Employee> GetData()
        {
            // Sample data can be added here if needed
            return lstEmp;
        }

        private void SetupDataGridView()
        {
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployee.Columns[0].HeaderText = "Mã";
            dgvEmployee.Columns[1].HeaderText = "Tên";
            dgvEmployee.Columns[2].HeaderText = "Ngày Sinh";
            dgvEmployee.Columns[3].HeaderText = "SĐT";
            dgvEmployee.Columns[4].HeaderText = "Email";
            dgvEmployee.Columns[5].HeaderText = "Giới Tính";
            dgvEmployee.Columns[6].HeaderText = "Địa Chỉ";
            dgvEmployee.Columns[7].HeaderText = "Mã Dự Án";
            dgvEmployee.Columns[8].HeaderText = "Mã Phòng Ban";
            dgvEmployee.Columns[9].HeaderText = "Ảnh";

            // Thiết lập DataGridView là chỉ đọc
            dgvEmployee.ReadOnly = true;
        }

        private void dgvEmployee_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Hiển thị thông báo lỗi khi người dùng cố gắng sửa đổi ô
            MessageBox.Show("Lỗi: Không được thay đổi thông tin dưới bảng.");
            e.Cancel = true; // Hủy bỏ việc chỉnh sửa
        }



        private void Quanly_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat) Application.Exit();
        }



        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            // Lấy nhân viên từ danh sách dựa trên chỉ số hàng
            Employee em = lstEmp[e.RowIndex];
            if (em.Id != 0) // Giả sử ID là int và 0 là giá trị không hợp lệ
            {
                // Điền thông tin nhân viên vào các TextBox
                tbId.Text = em.Id.ToString();
                tbName.Text = em.Name;
                ckGender.Checked = em.Gender;
                tbSDT.Text = em.SDT;
                tbEmail.Text = em.Email;
                tbAddress.Text = em.Address;
                tbMaduan.Text = em.Maduan;
                cbMaphongban.Text = em.Maphongban;

                // Kiểm tra trước khi gán giá trị cho DateTimePicker
                if (em.BirthDate != DateTime.MinValue)
                {
                    dateTimePicker1.Value = em.BirthDate;
                }
                else
                {
                    dateTimePicker1.Value = DateTime.Now; // Giá trị mặc định
                }

                // Load ảnh nhân viên nếu có
                if (!string.IsNullOrEmpty(em.ImagePath) && System.IO.File.Exists(em.ImagePath))
                {
                    pbEmployeeImage.Image = Image.FromFile(em.ImagePath);
                }
                else
                {
                    pbEmployeeImage.Image = null; // Không có ảnh
                }
            }
            else
            {
                // Nếu ID không có giá trị, làm trống các ô nhập liệu
                ClearInputFields();
            }
        }



        private void dgvEmployee_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Lấy tên cột mà người dùng nhấn vào
            string columnName = dgvEmployee.Columns[e.ColumnIndex].DataPropertyName;

            // Sắp xếp theo cột được nhấn (có thể đổi lại thành ASC hoặc DESC)
            var sortedList = lstEmp.OrderBy(emp => emp.GetType().GetProperty(columnName).GetValue(emp, null)).ToList();

            // Cập nhật lại DataSource
            bs.DataSource = sortedList;
            bs.ResetBindings(false);
        }



        private void ClearInputFields()
        {
            tbId.Text = "";
            tbName.Text = "";
            tbAddress.Text = "";
            tbSDT.Text = "";
            tbEmail.Text = "";
            tbAddress.Text = "";
            tbMaduan.Text = "";
            cbMaphongban.Text = "";
            ckGender.Checked = false;
            pbEmployeeImage.Image = null;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void SetupImageList()
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(24, 24);

            imageList.Images.Add(Image.FromFile("Images/addnv.png"));
            imageList.Images.Add(Image.FromFile("Images/editnv.png"));
            imageList.Images.Add(Image.FromFile("Images/deletenv.png"));
            imageList.Images.Add(Image.FromFile("Images/clear.png"));

            btAddNew.ImageList = imageList;
            btAddNew.ImageIndex = 0;

            btEdit.ImageList = imageList;
            btEdit.ImageIndex = 1;

            btDelete.ImageList = imageList;
            btDelete.ImageIndex = 2;

            btClear.ImageList = imageList;
            btClear.ImageIndex = 3;
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.Text = dateTimePicker1.Value.ToString("dd MMMM yyyy");
        }







        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void btDangXuat_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DangXuat?.Invoke(this, EventArgs.Empty); // Gọi sự kiện đăng xuất nếu người dùng chọn Yes
            }
        }


        private void btThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btAddNew_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem các trường có hợp lệ không
                if (string.IsNullOrWhiteSpace(tbId.Text) || string.IsNullOrWhiteSpace(tbName.Text) ||
                    string.IsNullOrWhiteSpace(tbSDT.Text) || string.IsNullOrWhiteSpace(tbEmail.Text) ||
                    string.IsNullOrWhiteSpace(tbAddress.Text) || string.IsNullOrWhiteSpace(tbMaduan.Text)
                    || string.IsNullOrWhiteSpace(cbMaphongban.Text) )
                {
                    MessageBox.Show("Lỗi: Vui lòng điền đầy đủ thông tin ID, Tên, SĐT, Email, Địa chỉ, Mã dự án và Mã phòng ban");
                    return;
                }

                int newId = int.Parse(tbId.Text);
                if (lstEmp.Any(emp => emp.Id == newId))
                {
                    MessageBox.Show("Lỗi: ID đã tồn tại. Vui lòng nhập ID khác.");
                    return;
                }

                // Kiểm tra tên có chứa ký tự không hợp lệ
                if (!System.Text.RegularExpressions.Regex.IsMatch(tbName.Text, @"^[\p{L} .'-]+$"))
                {
                    MessageBox.Show("Lỗi: Tên không được chứa số hoặc ký tự đặc biệt.");
                    return;
                }


                // Kiểm tra SĐT có 10 số và bắt đầu bằng số 0
                if (!System.Text.RegularExpressions.Regex.IsMatch(tbSDT.Text, @"^0\d{9}$"))
                {
                    MessageBox.Show("Lỗi: SĐT phải là 10 số và bắt đầu bằng số 0.");
                    return;
                }

                // Kiểm tra định dạng email
                if (!System.Text.RegularExpressions.Regex.IsMatch(tbEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("Lỗi: Vui lòng nhập địa chỉ email hợp lệ.");
                    return;
                }

                // Thêm nhân viên mới
                Employee newEmp = new Employee
                {
                    Id = newId,
                    Name = tbName.Text,
                    Gender = ckGender.Checked,
                    SDT = tbSDT.Text,
                    Email = tbEmail.Text,
                    Address = tbAddress.Text,
                    Maduan = tbMaduan.Text,
                    Maphongban = cbMaphongban.Text,
                    ImagePath = employeeImagePath,
                    BirthDate = dateTimePicker1.Value.Date
                };

                lstEmp.Add(newEmp);
                bs.DataSource = lstEmp;  // Cập nhật lại DataSource
                bs.ResetBindings(false);  // Làm mới BindingSource để hiển thị

                ClearInputFields();
                MessageBox.Show("Thêm nhân viên thành công!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi: Vui lòng nhập số nguyên hợp lệ cho ID.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }



        private void btEdit_Click_1(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow == null) return;

            int idx = dgvEmployee.CurrentRow.Index;
            Employee em = lstEmp[idx];

            try
            {
                int newId = int.Parse(tbId.Text);

                // Kiểm tra xem ID mới có bị trùng nhưng bỏ qua chính nhân viên hiện tại
                if (lstEmp.Any(emp => emp.Id == newId && emp != em))
                {
                    MessageBox.Show("Lỗi: ID đã tồn tại. Vui lòng nhập ID khác.");
                    return;
                }

                // Kiểm tra xem các trường có hợp lệ không
                if (string.IsNullOrWhiteSpace(tbId.Text) || string.IsNullOrWhiteSpace(tbName.Text) || string.IsNullOrWhiteSpace(tbSDT.Text) || string.IsNullOrWhiteSpace(tbEmail.Text))
                {
                    MessageBox.Show("Lỗi: Vui lòng điền đầy đủ thông tin ID, Tên, SĐT và Email.");
                    return;
                }

                // Kiểm tra SĐT có 10 số và bắt đầu bằng số 0
                if (!System.Text.RegularExpressions.Regex.IsMatch(tbSDT.Text, @"^0\d{9}$"))
                {
                    MessageBox.Show("Lỗi: SĐT phải là 10 số và bắt đầu bằng số 0.");
                    return;
                }

                // Kiểm tra định dạng email
                if (!System.Text.RegularExpressions.Regex.IsMatch(tbEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("Lỗi: Vui lòng nhập địa chỉ email hợp lệ.");
                    return;
                }

                // Cập nhật thông tin nhân viên
                em.Id = newId;
                em.Name = tbName.Text;
                em.Gender = ckGender.Checked;
                em.SDT = tbSDT.Text; // SĐT là chuỗi, không cần chuyển đổi thành int
                em.Email = tbEmail.Text;
                em.Address = tbAddress.Text;
                em.Maduan = tbMaduan.Text;
                em.Maphongban = cbMaphongban.Text;
                em.ImagePath = employeeImagePath;
                em.BirthDate = dateTimePicker1.Value.Date;

                bs.ResetBindings(false);
                ClearInputFields();

                MessageBox.Show("Cập nhật nhân viên thành công!"); // Thông báo cập nhật thành công
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi: Vui lòng nhập số nguyên hợp lệ cho ID.");
            }
        }


        private void btDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow == null) return;

            // Hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?",
                                                  "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            // Nếu người dùng chọn Yes
            if (result == DialogResult.Yes)
            {
                int idx = dgvEmployee.CurrentRow.Index;
                lstEmp.RemoveAt(idx);  // Xóa nhân viên khỏi danh sách
                bs.ResetBindings(false);  // Cập nhật lại bindings
                ClearInputFields();
                MessageBox.Show("Xóa nhân viên thành công!");  // Thông báo thành công
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btSelectImage_Click_1(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    employeeImagePath = ofd.FileName;
                    pbEmployeeImage.Image = Image.FromFile(employeeImagePath);
                }
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {

            string searchName = tbSearchName.Text.ToLower(); // Chuyển tên về chữ thường để dễ so sánh

            // Lọc danh sách nhân viên theo tên
            var filteredList = lstEmp.Where(emp => emp.Name.ToLower().Contains(searchName)).ToList();

            // Cập nhật lại DataSource của DataGridView
            bs.DataSource = filteredList;
            bs.ResetBindings(false);

            // Nếu không có kết quả nào
            if (filteredList.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên nào với tên này.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btSort_Click(object sender, EventArgs e)
        {

            List<Employee> sortedList;

            if (cbSortOptions.SelectedItem.ToString() == "Sắp xếp theo tên")
            {
                // Sắp xếp danh sách nhân viên theo tên
                sortedList = lstEmp.OrderBy(emp => emp.Name).ToList();
            }
            else
            {
                // Sắp xếp danh sách nhân viên theo ID
                sortedList = lstEmp.OrderBy(emp => emp.Id).ToList();
            }

            // Cập nhật lại DataSource của DataGridView
            bs.DataSource = sortedList; // Cập nhật DataSource sau khi sắp xếp
            bs.ResetBindings(false); // Đảm bảo DataGridView được làm mới

            MessageBox.Show("Danh sách đã được sắp xếp.");
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btClear_Click_Click(object sender, EventArgs e)
        {
            ClearInputFields(); // Gọi hàm đã có để làm trống các ô nhập liệu

        }
    }
}

