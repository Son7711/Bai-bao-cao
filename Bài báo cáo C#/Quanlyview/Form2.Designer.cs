namespace Quanlyview
{
    partial class Form2
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
            btThem = new Button();
            btXoa = new Button();
            tbTaiKhoan = new TextBox();
            tbMatKhau = new TextBox();
            label1 = new Label();
            label2 = new Label();
            listBoxTaiKhoan = new ListBox();
            openFileDialog1 = new OpenFileDialog();
            btThoat = new Button();
            SuspendLayout();
            // 
            // btThem
            // 
            btThem.Location = new Point(206, 325);
            btThem.Name = "btThem";
            btThem.Size = new Size(94, 29);
            btThem.TabIndex = 0;
            btThem.Text = "them";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // btXoa
            // 
            btXoa.Location = new Point(242, 34);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(94, 29);
            btXoa.TabIndex = 1;
            btXoa.Text = "xoa";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // tbTaiKhoan
            // 
            tbTaiKhoan.Location = new Point(175, 235);
            tbTaiKhoan.Name = "tbTaiKhoan";
            tbTaiKhoan.Size = new Size(125, 27);
            tbTaiKhoan.TabIndex = 2;
            // 
            // tbMatKhau
            // 
            tbMatKhau.Location = new Point(175, 282);
            tbMatKhau.Name = "tbMatKhau";
            tbMatKhau.Size = new Size(125, 27);
            tbMatKhau.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 238);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 4;
            label1.Text = "Tên tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 282);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Mật khẩu";
            // 
            // listBoxTaiKhoan
            // 
            listBoxTaiKhoan.FormattingEnabled = true;
            listBoxTaiKhoan.Location = new Point(62, 34);
            listBoxTaiKhoan.Name = "listBoxTaiKhoan";
            listBoxTaiKhoan.Size = new Size(174, 144);
            listBoxTaiKhoan.TabIndex = 6;
            listBoxTaiKhoan.SelectedIndexChanged += listBoxTaiKhoan_SelectedIndexChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btThoat
            // 
            btThoat.Location = new Point(265, 397);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(94, 29);
            btThoat.TabIndex = 7;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 438);
            Controls.Add(btThoat);
            Controls.Add(listBoxTaiKhoan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbMatKhau);
            Controls.Add(tbTaiKhoan);
            Controls.Add(btXoa);
            Controls.Add(btThem);
            Name = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btThem;
        private Button btXoa;
        private TextBox tbTaiKhoan;
        private TextBox tbMatKhau;
        private Label label1;
        private Label label2;
        private ListBox listBoxTaiKhoan;
        private OpenFileDialog openFileDialog1;
        private Button btThoat;
    }
}