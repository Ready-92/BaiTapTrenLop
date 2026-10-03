namespace quan_ly_sinh_vien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            dataGridViewStudents = new DataGridView();
            labelTotal = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            textBox6 = new TextBox();
            label11 = new Label();
            comboBox3 = new ComboBox();
            label10 = new Label();
            tukhoa = new Label();
            textBox5 = new TextBox();
            Đóng = new Button();
            Làmmoi = new Button();
            Sửa = new Button();
            Xoá = new Button();
            Thêm = new Button();
            label9 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            radioButton2 = new RadioButton();
            label5 = new Label();
            radioButton1 = new RadioButton();
            label4 = new Label();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            labelDanhSach = new Label();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(Đóng);
            groupBox1.Controls.Add(Làmmoi);
            groupBox1.Controls.Add(Sửa);
            groupBox1.Controls.Add(Xoá);
            groupBox1.Controls.Add(Thêm);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(2, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1027, 552);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(labelTotal);
            panel2.Controls.Add(dataGridViewStudents);
            panel2.Location = new Point(33, 337);
            panel2.Name = "panel2";
            panel2.Size = new Size(904, 194);
            panel2.TabIndex = 28;
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.Dock = DockStyle.Fill;
            dataGridViewStudents.Location = new Point(0, 25);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.Size = new Size(902, 167);
            dataGridViewStudents.TabIndex = 30;
            dataGridViewStudents.ReadOnly = true;
            dataGridViewStudents.AllowUserToAddRows = false;
            dataGridViewStudents.AllowUserToDeleteRows = false;
            dataGridViewStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStudents.MultiSelect = false;
            dataGridViewStudents.RowHeadersVisible = false;
            dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Columns.Clear();
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colMaSV", HeaderText = "Mã SV", Width = 100 });
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colHoTen", HeaderText = "Họ và tên", Width = 180 });
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colNgaySinh", HeaderText = "Ngày sinh", Width = 90 });
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colGioiTinh", HeaderText = "Giới tính", Width = 60 });
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colEmail", HeaderText = "Email", Width = 180 });
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colDienThoai", HeaderText = "Điện thoại", Width = 110 });
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colDiem", HeaderText = "Điểm", Width = 60 });
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colLop", HeaderText = "Lớp", Width = 140 });
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colTrangThai", HeaderText = "Trạng thái", Width = 100 });
            // 
            // labelTotal
            // 
            labelTotal.Dock = DockStyle.Top;
            labelTotal.Location = new Point(0, 0);
            labelTotal.Name = "labelTotal";
            labelTotal.Padding = new Padding(0, 0, 8, 0);
            labelTotal.Size = new Size(902, 25);
            labelTotal.TabIndex = 29;
            labelTotal.Text = "Tổng số: 0 sinh viên";
            labelTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(tukhoa);
            panel1.Controls.Add(textBox5);
            panel1.Location = new Point(33, 248);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 64);
            panel1.TabIndex = 27;
            // 
            // button2
            // 
            button2.Location = new Point(795, 19);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 30;
            button2.Text = "&Tất cả";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(695, 19);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 29;
            button1.Text = "&Tìm";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(599, 20);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(79, 27);
            textBox6.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(530, 23);
            label11.Name = "label11";
            label11.Size = new Size(63, 20);
            label11.TabIndex = 21;
            label11.Text = "Điểm từ";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(355, 20);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(154, 28);
            comboBox3.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(315, 23);
            label10.Name = "label10";
            label10.Size = new Size(34, 20);
            label10.TabIndex = 3;
            label10.Text = "Lớp";
            // 
            // tukhoa
            // 
            tukhoa.AutoSize = true;
            tukhoa.Location = new Point(29, 23);
            tukhoa.Name = "tukhoa";
            tukhoa.Size = new Size(64, 20);
            tukhoa.TabIndex = 1;
            tukhoa.Text = "Từ Khoá";
            tukhoa.Click += label10_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(105, 20);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(189, 27);
            textBox5.TabIndex = 0;
            textBox5.Text = "Mã, Tên, Email, Phone";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // Đóng
            // 
            Đóng.Location = new Point(648, 171);
            Đóng.Name = "Đóng";
            Đóng.Size = new Size(94, 29);
            Đóng.TabIndex = 26;
            Đóng.Text = "&Đóng";
            Đóng.UseVisualStyleBackColor = true;
            // 
            // Làmmoi
            // 
            Làmmoi.Location = new Point(548, 171);
            Làmmoi.Name = "Làmmoi";
            Làmmoi.Size = new Size(94, 29);
            Làmmoi.TabIndex = 25;
            Làmmoi.Text = "&Làm mới";
            Làmmoi.UseVisualStyleBackColor = true;
            // 
            // Sửa
            // 
            Sửa.Location = new Point(348, 171);
            Sửa.Name = "Sửa";
            Sửa.Size = new Size(94, 29);
            Sửa.TabIndex = 24;
            Sửa.Text = "&Sửa";
            Sửa.UseVisualStyleBackColor = true;
            // 
            // Xoá
            // 
            Xoá.Location = new Point(448, 171);
            Xoá.Name = "Xoá";
            Xoá.Size = new Size(94, 29);
            Xoá.TabIndex = 23;
            Xoá.Text = "&Xoá";
            Xoá.UseVisualStyleBackColor = true;
            // 
            // Thêm
            // 
            Thêm.Location = new Point(248, 171);
            Thêm.Name = "Thêm";
            Thêm.Size = new Size(94, 29);
            Thêm.TabIndex = 22;
            Thêm.Text = "&Thêm";
            Thêm.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(523, 123);
            label9.Name = "label9";
            label9.Size = new Size(85, 20);
            label9.TabIndex = 21;
            label9.Text = "Trạng thái *";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(614, 120);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(129, 28);
            comboBox2.TabIndex = 20;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(614, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(129, 28);
            comboBox1.TabIndex = 19;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 1;
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown1.Location = new Point(614, 81);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(129, 27);
            numericUpDown1.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(525, 86);
            label8.Name = "label8";
            label8.Size = new Size(55, 20);
            label8.TabIndex = 17;
            label8.Text = "Điểm *";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(525, 49);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 15;
            label7.Text = "Lớp học *";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(294, 127);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 13;
            label6.Text = "Điện thoại *";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(388, 120);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(107, 27);
            textBox4.TabIndex = 12;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(433, 86);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 24);
            radioButton2.TabIndex = 11;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(294, 86);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 10;
            label5.Text = "Giới tính";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(370, 86);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 24);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(294, 49);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 8;
            label4.Text = "Họ tên *";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(370, 42);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(138, 81);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 27);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 86);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 5;
            label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 127);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 4;
            label2.Text = "Email *";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(138, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 49);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 2;
            label1.Text = "Mã SV *";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // labelDanhSach
            // 
            labelDanhSach.AutoSize = true;
            labelDanhSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelDanhSach.Location = new Point(33, 319);
            labelDanhSach.Name = "labelDanhSach";
            labelDanhSach.Size = new Size(160, 23);
            labelDanhSach.TabIndex = 31;
            labelDanhSach.Text = "Danh sách sinh viên";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 565);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label5;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox textBox4;
        private Label label2;
        private TextBox textBox2;
        private Button Làmmoi;
        private Button Sửa;
        private Button Xoá;
        private Button Thêm;
        private Label label9;
        private ComboBox comboBox2;
        private Button Đóng;
        private Panel panel1;
        private Label tukhoa;
        private TextBox textBox5;
        private Label label11;
        private ComboBox comboBox3;
        private Label label10;
        private Panel panel2;
        private Label labelDanhSach;
        private Label labelTotal;
        private DataGridView dataGridViewStudents;
        private Button button2;
        private Button button1;
        private TextBox textBox6;
    }
}
