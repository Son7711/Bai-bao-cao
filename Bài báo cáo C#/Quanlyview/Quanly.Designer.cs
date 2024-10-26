﻿namespace Quanlyview
{
    partial class Quanly
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
            components = new System.ComponentModel.Container();
            dgvEmployee = new DataGridView();
            label5 = new Label();
            groupBox1 = new GroupBox();
            label13 = new Label();
            btClear = new Button();
            label12 = new Label();
            tbEmail = new TextBox();
            tbSDT = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btSelectImage = new Button();
            pbEmployeeImage = new PictureBox();
            tbMaduan = new TextBox();
            cbMaphongban = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            tbAddress = new TextBox();
            btDelete = new Button();
            btEdit = new Button();
            btAddNew = new Button();
            ckGender = new CheckBox();
            tbName = new TextBox();
            tbId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            groupBox4 = new GroupBox();
            button3 = new Button();
            button4 = new Button();
            btThoat = new Button();
            btDangXuat = new Button();
            groupBox2 = new GroupBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btSearch = new Button();
            tbSearchName = new TextBox();
            cbSortOptions = new ComboBox();
            btSort = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEmployeeImage).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.BackgroundColor = SystemColors.ButtonHighlight;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(57, 493);
            dgvEmployee.Margin = new Padding(3, 4, 3, 4);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.Size = new Size(931, 168);
            dgvEmployee.TabIndex = 2;
            dgvEmployee.RowEnter += dgvEmployee_RowEnter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(387, 86);
            label5.Name = "label5";
            label5.Size = new Size(226, 35);
            label5.TabIndex = 13;
            label5.Text = "Quản lý nhân viên";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(btClear);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(tbEmail);
            groupBox1.Controls.Add(tbSDT);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(btSelectImage);
            groupBox1.Controls.Add(pbEmployeeImage);
            groupBox1.Controls.Add(tbMaduan);
            groupBox1.Controls.Add(cbMaphongban);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbAddress);
            groupBox1.Controls.Add(btDelete);
            groupBox1.Controls.Add(btEdit);
            groupBox1.Controls.Add(btAddNew);
            groupBox1.Controls.Add(ckGender);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(tbId);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(116, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(807, 289);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin cá nhân";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(673, 255);
            label13.Name = "label13";
            label13.Size = new Size(46, 18);
            label13.TabIndex = 59;
            label13.Text = "Clear";
            // 
            // btClear
            // 
            btClear.Location = new Point(593, 246);
            btClear.Margin = new Padding(3, 4, 3, 4);
            btClear.Name = "btClear";
            btClear.Size = new Size(63, 36);
            btClear.TabIndex = 58;
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(378, 41);
            label12.Name = "label12";
            label12.Size = new Size(46, 18);
            label12.TabIndex = 57;
            label12.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(431, 38);
            tbEmail.Margin = new Padding(3, 4, 3, 4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(200, 25);
            tbEmail.TabIndex = 56;
            // 
            // tbSDT
            // 
            tbSDT.Location = new Point(90, 183);
            tbSDT.Margin = new Padding(3, 4, 3, 4);
            tbSDT.Name = "tbSDT";
            tbSDT.Size = new Size(185, 25);
            tbSDT.TabIndex = 55;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(45, 187);
            label11.Name = "label11";
            label11.Size = new Size(39, 18);
            label11.TabIndex = 54;
            label11.Text = "SDT";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(518, 255);
            label10.Name = "label10";
            label10.Size = new Size(35, 18);
            label10.TabIndex = 53;
            label10.Text = "Xóa";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(363, 255);
            label9.Name = "label9";
            label9.Size = new Size(37, 18);
            label9.TabIndex = 52;
            label9.Text = "Sửa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 255);
            label4.Name = "label4";
            label4.Size = new Size(48, 18);
            label4.TabIndex = 51;
            label4.Text = "Thêm";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(90, 119);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(185, 25);
            dateTimePicker1.TabIndex = 50;
            // 
            // btSelectImage
            // 
            btSelectImage.Location = new Point(659, 33);
            btSelectImage.Margin = new Padding(3, 4, 3, 4);
            btSelectImage.Name = "btSelectImage";
            btSelectImage.Size = new Size(104, 35);
            btSelectImage.TabIndex = 49;
            btSelectImage.Text = "Chọn ảnh...";
            btSelectImage.UseVisualStyleBackColor = true;
            btSelectImage.Click += btSelectImage_Click_1;
            // 
            // pbEmployeeImage
            // 
            pbEmployeeImage.BackColor = Color.White;
            pbEmployeeImage.Location = new Point(659, 79);
            pbEmployeeImage.Margin = new Padding(3, 4, 3, 4);
            pbEmployeeImage.Name = "pbEmployeeImage";
            pbEmployeeImage.Size = new Size(104, 129);
            pbEmployeeImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEmployeeImage.TabIndex = 48;
            pbEmployeeImage.TabStop = false;
            // 
            // tbMaduan
            // 
            tbMaduan.Location = new Point(430, 183);
            tbMaduan.Margin = new Padding(3, 4, 3, 4);
            tbMaduan.Name = "tbMaduan";
            tbMaduan.Size = new Size(201, 25);
            tbMaduan.TabIndex = 47;
            // 
            // cbMaphongban
            // 
            cbMaphongban.FormattingEnabled = true;
            cbMaphongban.Items.AddRange(new object[] { "Hành chính", "Nhân sự", "Giám sát" });
            cbMaphongban.Location = new Point(430, 133);
            cbMaphongban.Margin = new Padding(3, 4, 3, 4);
            cbMaphongban.Name = "cbMaphongban";
            cbMaphongban.Size = new Size(201, 26);
            cbMaphongban.TabIndex = 46;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(366, 91);
            label8.Name = "label8";
            label8.Size = new Size(56, 18);
            label8.TabIndex = 45;
            label8.Text = "Địa chỉ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(313, 136);
            label7.Name = "label7";
            label7.Size = new Size(108, 18);
            label7.TabIndex = 44;
            label7.Text = "Mã phòng ban";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(350, 183);
            label6.Name = "label6";
            label6.Size = new Size(74, 18);
            label6.TabIndex = 43;
            label6.Text = "Mã dự án";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(430, 88);
            tbAddress.Margin = new Padding(3, 4, 3, 4);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(201, 25);
            tbAddress.TabIndex = 42;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(438, 246);
            btDelete.Margin = new Padding(3, 4, 3, 4);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(63, 36);
            btDelete.TabIndex = 41;
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click_1;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(285, 246);
            btEdit.Margin = new Padding(3, 4, 3, 4);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(63, 36);
            btEdit.TabIndex = 40;
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click_1;
            // 
            // btAddNew
            // 
            btAddNew.Location = new Point(131, 246);
            btAddNew.Margin = new Padding(3, 4, 3, 4);
            btAddNew.Name = "btAddNew";
            btAddNew.Size = new Size(63, 36);
            btAddNew.TabIndex = 39;
            btAddNew.UseVisualStyleBackColor = true;
            btAddNew.Click += btAddNew_Click_1;
            // 
            // ckGender
            // 
            ckGender.AutoSize = true;
            ckGender.Checked = true;
            ckGender.CheckState = CheckState.Checked;
            ckGender.Location = new Point(214, 150);
            ckGender.Margin = new Padding(3, 4, 3, 4);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(61, 22);
            ckGender.TabIndex = 38;
            ckGender.Text = "Nam";
            ckGender.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            tbName.Location = new Point(90, 79);
            tbName.Margin = new Padding(3, 4, 3, 4);
            tbName.Name = "tbName";
            tbName.Size = new Size(185, 25);
            tbName.TabIndex = 37;
            // 
            // tbId
            // 
            tbId.Location = new Point(90, 38);
            tbId.Margin = new Padding(3, 4, 3, 4);
            tbId.Name = "tbId";
            tbId.Size = new Size(185, 25);
            tbId.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 121);
            label3.Name = "label3";
            label3.Size = new Size(39, 18);
            label3.TabIndex = 35;
            label3.Text = "Tuổi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 79);
            label2.Name = "label2";
            label2.Size = new Size(36, 18);
            label2.TabIndex = 34;
            label2.Text = "Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 38);
            label1.Name = "label1";
            label1.Size = new Size(29, 18);
            label1.TabIndex = 33;
            label1.Text = "Mã";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(button2);
            groupBox3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(207, 114);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh mục";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            button1.Location = new Point(14, 29);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(187, 29);
            button1.TabIndex = 3;
            button1.Text = "Quản lí Nhân viên";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            button2.Location = new Point(14, 66);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(187, 29);
            button2.TabIndex = 2;
            button2.Text = "Tài khoản quản trị";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button3);
            groupBox4.Controls.Add(button4);
            groupBox4.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(26, 706);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(272, 73);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "Xem thêm";
            // 
            // button3
            // 
            button3.Location = new Point(139, 27);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(119, 29);
            button3.TabIndex = 3;
            button3.Text = "Trợ giúp ?";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(18, 27);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(115, 29);
            button4.TabIndex = 2;
            button4.Text = "Giới thiệu";
            button4.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(139, 25);
            btThoat.Margin = new Padding(3, 4, 3, 4);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(68, 29);
            btThoat.TabIndex = 2;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click_1;
            // 
            // btDangXuat
            // 
            btDangXuat.Location = new Point(17, 25);
            btDangXuat.Margin = new Padding(3, 4, 3, 4);
            btDangXuat.Name = "btDangXuat";
            btDangXuat.Size = new Size(102, 29);
            btDangXuat.TabIndex = 3;
            btDangXuat.Text = "Đăng xuất";
            btDangXuat.UseVisualStyleBackColor = true;
            btDangXuat.Click += btDangXuat_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btDangXuat);
            groupBox2.Controls.Add(btThoat);
            groupBox2.Location = new Point(765, 706);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(223, 71);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Trạng thái";
            // 
            // btSearch
            // 
            btSearch.Location = new Point(859, 457);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(88, 29);
            btSearch.TabIndex = 18;
            btSearch.Text = "Tìm kiếm ";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // tbSearchName
            // 
            tbSearchName.Location = new Point(658, 459);
            tbSearchName.Margin = new Padding(3, 4, 3, 4);
            tbSearchName.Name = "tbSearchName";
            tbSearchName.Size = new Size(185, 25);
            tbSearchName.TabIndex = 58;
            // 
            // cbSortOptions
            // 
            cbSortOptions.FormattingEnabled = true;
            cbSortOptions.Location = new Point(62, 457);
            cbSortOptions.Name = "cbSortOptions";
            cbSortOptions.Size = new Size(151, 26);
            cbSortOptions.TabIndex = 59;
            cbSortOptions.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btSort
            // 
            btSort.Location = new Point(232, 455);
            btSort.Name = "btSort";
            btSort.Size = new Size(94, 29);
            btSort.TabIndex = 60;
            btSort.Text = "Sắp xếp";
            btSort.UseVisualStyleBackColor = true;
            btSort.Click += btSort_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // Quanly
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1003, 791);
            Controls.Add(btSort);
            Controls.Add(cbSortOptions);
            Controls.Add(tbSearchName);
            Controls.Add(btSearch);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(dgvEmployee);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Quanly";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quanly";
            FormClosed += Quanly_FormClosed;
            Load += Quanly_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbEmployeeImage).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvEmployee;
        private Label label5;
        private GroupBox groupBox1;
        private Label label12;
        private TextBox tbEmail;
        private TextBox tbSDT;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Button btSelectImage;
        private PictureBox pbEmployeeImage;
        private TextBox tbMaduan;
        private ComboBox cbMaphongban;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox tbAddress;
        private Button btDelete;
        private Button btEdit;
        private Button btAddNew;
        private CheckBox ckGender;
        private TextBox tbName;
        private TextBox tbId;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Button button1;
        private Button button2;
        private GroupBox groupBox4;
        private Button button4;
        private Button button3;
        private Button btThoat;
        private Button btDangXuat;
        private GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btSearch;
        private TextBox tbSearchName;
        private ComboBox cbSortOptions;
        private Button btSort;
        private ContextMenuStrip contextMenuStrip1;
        private Label label13;
        private Button btClear;
    }
}