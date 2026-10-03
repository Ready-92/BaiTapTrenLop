using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace quan_ly_sinh_vien
{
    public partial class Form1 : Form
    {
        private List<LopHoc> lopHocs = new();
        private List<SinhVien> sinhViens = new();

        public Form1()
        {
            InitializeComponent();

            // wire a few events
            Load += Form1_Load;
            textBox1.Leave += textBox1_Leave; // MaSV leave
            textBox1.Click += textBox1_Click;
            Thêm.Click += Thêm_Click;
            Làmmoi.Click += Làmmoi_Click;
            Sửa.Click += Sửa_Click;
            Xoá.Click += Xoá_Click;
            Đóng.Click += Đóng_Click;
            // search and list events
            button1.Click += button1_Click; // Tìm
            button2.Click += button2_Click; // Tất cả
            textBox5.TextChanged += textBox5_TextChanged;
            // placeholder behavior for keyword textbox
            textBox5.Enter += TextBox5_Enter;
            textBox5.Leave += TextBox5_Leave;
            dataGridViewStudents.CellDoubleClick += dataGridViewStudents_CellDoubleClick;
            FormClosing += Form1_FormClosing;
        }

        private void textBox1_Click(object? sender, EventArgs e)
        {
            // allow editing MaSV when user clicks the box (undo ReadOnly set when a student was loaded)
            try
            {
                if (textBox1.ReadOnly)
                {
                    textBox1.ReadOnly = false;
                    textBox1.SelectAll();
                }
            }
            catch { }
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            // set initial focus and button states
            ActiveControl = textBox1;
            textBox1.Focus();
            Thêm.Enabled = true;
            Sửa.Enabled = false;
            Xoá.Enabled = false;

            // sample data
            lopHocs = new List<LopHoc>
            {
                new LopHoc { Id = "L01", TenLop = "Kỹ thuật phần mềm 01" },
                new LopHoc { Id = "L02", TenLop = "Trí tuệ nhân tạo 01" },
                new LopHoc { Id = "L03", TenLop = "Khoa học dữ liệu 01" }
            };

            comboBox1.DataSource = lopHocs;
            comboBox1.DisplayMember = nameof(LopHoc.TenLop);
            comboBox1.ValueMember = nameof(LopHoc.Id);

            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new[] { "Đang học", "Tạm nghỉ", "Đã tốt nghiệp" });
            comboBox2.SelectedIndex = 0;

            // class filter combobox (comboBox3)
            var classFilter = new List<LopHoc> { new LopHoc { Id = "", TenLop = "Tất cả lớp" } };
            classFilter.AddRange(lopHocs);
            comboBox3.DataSource = classFilter;
            comboBox3.DisplayMember = nameof(LopHoc.TenLop);
            comboBox3.ValueMember = nameof(LopHoc.Id);

            // sample students
            sinhViens = new List<SinhVien>
            {
                new SinhVien { MaSV = "SV0001", HoTen = "Nguyễn Văn A", NgaySinh = new DateTime(2006,8,15), GioiTinh = true, Email = "an.nv@vju.ac.vn", DienThoai = "0912345678", Diem = 8.5, LopHocId = "L01", TrangThai = "Đang học" },
                new SinhVien { MaSV = "SV0002", HoTen = "Trần Thị B", NgaySinh = new DateTime(2006,1,22), GioiTinh = false, Email = "b.tt@vju.ac.vn", DienThoai = "0987654321", Diem = 9.0, LopHocId = "L02", TrangThai = "Đang học" }
            };

            // try load saved students
            LoadStudentsFromFile();
            RefreshStudentView();

            // ensure list panel is visible on top in case other controls overlap
            try { panel2.BringToFront(); } catch { }
            try { labelDanhSach.BringToFront(); } catch { }

            // placeholder color
            if (textBox5.Text == "Mã, Tên, Email, Phone") textBox5.ForeColor = System.Drawing.SystemColors.GrayText;
        }

        private string GetDataFilePath() => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sinhviens.json");

        private void LoadStudentsFromFile()
        {
            try
            {
                var path = GetDataFilePath();
                if (!File.Exists(path)) return;
                var json = File.ReadAllText(path);
                var data = JsonSerializer.Deserialize<List<SinhVien>>(json);
                if (data != null)
                    sinhViens = data;
            }
            catch
            {
                // ignore load errors for now
            }
        }

        private void SaveStudentsToFile()
        {
            try
            {
                var path = GetDataFilePath();
                var opt = new JsonSerializerOptions { WriteIndented = true };
                var json = JsonSerializer.Serialize(sinhViens, opt);
                File.WriteAllText(path, json);
            }
            catch
            {
                // ignore save errors for now
            }
        }

        private void RefreshStudentView()
        {
            if (dataGridViewStudents == null || labelTotal == null)
                return;

            UpdateStudentList(sinhViens);
        }

        private void dataGridViewStudents_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                var id = dataGridViewStudents.Rows[e.RowIndex].Cells[0].Value?.ToString();
                if (string.IsNullOrEmpty(id)) return;
                var sv = sinhViens.FirstOrDefault(x => string.Equals(x.MaSV, id, StringComparison.OrdinalIgnoreCase));
                if (sv != null) LoadStudentToForm(sv);
            }
            catch { }
        }

        private void LoadStudentToForm(SinhVien sv)
        {
            textBox1.Text = sv.MaSV;
            textBox3.Text = sv.HoTen;
            dateTimePicker1.Value = sv.NgaySinh;
            radioButton1.Checked = sv.GioiTinh;
            radioButton2.Checked = !sv.GioiTinh;
            textBox2.Text = sv.Email;
            textBox4.Text = sv.DienThoai;
            numericUpDown1.Value = (decimal)Math.Max(0, Math.Min(10, sv.Diem));
            comboBox1.SelectedValue = sv.LopHocId;
            comboBox2.SelectedItem = sv.TrangThai;

            textBox1.ReadOnly = true;
            Thêm.Enabled = false;
            Sửa.Enabled = true;
            Xoá.Enabled = true;
        }

        public void UpdateStudentList(IEnumerable<SinhVien> students)
        {
            if (dataGridViewStudents == null || labelTotal == null)
                return;

            // ensure grid is visible and on top
            try { dataGridViewStudents.Visible = true; dataGridViewStudents.BringToFront(); } catch { }
            try
            {
                dataGridViewStudents.Rows.Clear();
            }
            catch { }
            int count = 0;
            foreach (var s in students)
            {
                var lopName = lopHocs.FirstOrDefault(l => l.Id == s.LopHocId)?.TenLop ?? string.Empty;
                try
                {
                    dataGridViewStudents.Rows.Add(new object[]
                    {
                        s.MaSV,
                        s.HoTen,
                        s.NgaySinh.ToString("dd/MM/yyyy"),
                        s.GioiTinh.GetDisplayName(),
                        s.Email,
                        s.DienThoai,
                        s.Diem.ToString("0.0"),
                        lopName,
                        s.TrangThai
                    });
                }
                catch { }
                count++;
            }
            labelTotal.Text = $"Tổng số: {count} sinh viên";
            try { dataGridViewStudents.Refresh(); } catch { }
        }

        private void textBox1_Leave(object? sender, EventArgs e)
        {
            var id = textBox1.Text?.Trim();
            if (string.IsNullOrEmpty(id))
                return;

            var sv = sinhViens.FirstOrDefault(x => string.Equals(x.MaSV, id, StringComparison.OrdinalIgnoreCase));
            if (sv != null)
            {
                // populate fields
                textBox3.Text = sv.HoTen;
                dateTimePicker1.Value = sv.NgaySinh;
                radioButton1.Checked = sv.GioiTinh;
                radioButton2.Checked = !sv.GioiTinh;
                textBox2.Text = sv.Email;
                textBox4.Text = sv.DienThoai;
                numericUpDown1.Value = (decimal)Math.Max(0, Math.Min(10, sv.Diem));
                comboBox1.SelectedValue = sv.LopHocId;
                comboBox2.SelectedItem = sv.TrangThai;

                textBox1.ReadOnly = true;
                Thêm.Enabled = false;
                Sửa.Enabled = true;
                Xoá.Enabled = true;
            }
            else
            {
                // new student, clear other fields
                textBox3.Text = string.Empty;
                dateTimePicker1.Value = DateTime.Today.AddYears(-18);
                radioButton1.Checked = true;
                textBox2.Text = string.Empty;
                textBox4.Text = string.Empty;
                numericUpDown1.Value = 0;
                if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;

                textBox1.ReadOnly = false;
                Thêm.Enabled = true;
                Sửa.Enabled = false;
                Xoá.Enabled = false;
            }
        }

        private void Làmmoi_Click(object? sender, EventArgs e)
        {
            ClearForm();
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            // search / filter
            var kw = textBox5.Text?.Trim();
            double minScore = 0;
            if (!string.IsNullOrWhiteSpace(textBox6.Text)) double.TryParse(textBox6.Text, out minScore);
            var classId = comboBox3.SelectedValue?.ToString() ?? string.Empty;

            var q = sinhViens.AsEnumerable();
            if (!string.IsNullOrEmpty(kw) && kw != "Mã, Tên, Email, Phone")
            {
                q = q.Where(s => (s.MaSV ?? "").Contains(kw, StringComparison.OrdinalIgnoreCase)
                    || (s.HoTen ?? "").Contains(kw, StringComparison.OrdinalIgnoreCase)
                    || (s.Email ?? "").Contains(kw, StringComparison.OrdinalIgnoreCase)
                    || (s.DienThoai ?? "").Contains(kw, StringComparison.OrdinalIgnoreCase));
            }
            if (!string.IsNullOrEmpty(classId)) q = q.Where(s => s.LopHocId == classId);
            if (minScore > 0) q = q.Where(s => s.Diem >= minScore);

            UpdateStudentList(q);
        }

        private void button2_Click(object? sender, EventArgs e)
        {
            // show all
            textBox5.Text = string.Empty;
            comboBox3.SelectedIndex = 0;
            textBox6.Text = string.Empty;
            UpdateStudentList(sinhViens);
        }

        private void textBox5_TextChanged(object? sender, EventArgs e)
        {
            // live search
            if (string.IsNullOrWhiteSpace(textBox5.Text) || textBox5.Text == "Mã, Tên, Email, Phone")
            {
                UpdateStudentList(sinhViens);
                return;
            }
            // reuse button1 logic
            button1_Click(sender, e);
        }

        private void TextBox5_Enter(object? sender, EventArgs e)
        {
            if (textBox5.Text == "Mã, Tên, Email, Phone")
            {
                textBox5.Text = string.Empty;
                textBox5.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        private void TextBox5_Leave(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                textBox5.Text = "Mã, Tên, Email, Phone";
                textBox5.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void ClearForm()
        {
            textBox1.ReadOnly = false;
            textBox1.Text = string.Empty;
            textBox3.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Today.AddYears(-18);
            radioButton1.Checked = true;
            textBox2.Text = string.Empty;
            textBox4.Text = string.Empty;
            numericUpDown1.Value = 0;
            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            Thêm.Enabled = true;
            Sửa.Enabled = false;
            Xoá.Enabled = false;

            textBox1.Focus();
        }

        private void Thêm_Click(object? sender, EventArgs e)
        {
            var sv = ReadSinhVienFromForm();
            if (sv == null) return; // validation showed message

            if (sinhViens.Any(x => string.Equals(x.MaSV, sv.MaSV, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sinhViens.Add(sv);
            RefreshStudentView();
            MessageBox.Show("Thêm sinh viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
        }

        private void Sửa_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn sửa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            var sv = ReadSinhVienFromForm();
            if (sv == null) return;

            var existing = sinhViens.FirstOrDefault(x => string.Equals(x.MaSV, sv.MaSV, StringComparison.OrdinalIgnoreCase));
            if (existing == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // update
            existing.HoTen = sv.HoTen;
            existing.NgaySinh = sv.NgaySinh;
            existing.GioiTinh = sv.GioiTinh;
            existing.Email = sv.Email;
            existing.DienThoai = sv.DienThoai;
            existing.Diem = sv.Diem;
            existing.LopHocId = sv.LopHocId;
            existing.TrangThai = sv.TrangThai;

            RefreshStudentView();
            MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
        }

        private void Xoá_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            var id = textBox1.Text?.Trim();
            if (string.IsNullOrEmpty(id)) return;
            var existing = sinhViens.FirstOrDefault(x => string.Equals(x.MaSV, id, StringComparison.OrdinalIgnoreCase));
            if (existing != null)
            {
                sinhViens.Remove(existing);
                RefreshStudentView();
                MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
        }

        private void Đóng_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            SaveStudentsToFile();
        }

        private SinhVien? ReadSinhVienFromForm()
        {
            var sv = new SinhVien
            {
                MaSV = textBox1.Text?.Trim(),
                HoTen = textBox3.Text?.Trim(),
                NgaySinh = dateTimePicker1.Value.Date,
                GioiTinh = radioButton1.Checked,
                Email = textBox2.Text?.Trim(),
                DienThoai = textBox4.Text?.Trim(),
                Diem = (double)numericUpDown1.Value,
                LopHocId = comboBox1.SelectedValue?.ToString() ?? string.Empty,
                TrangThai = comboBox2.SelectedItem?.ToString() ?? string.Empty
            };

            if (!ModelValidator.TryValidate(sv, out var results))
            {
                var msg = string.Join(Environment.NewLine, results.Select(r => r.ErrorMessage));
                MessageBox.Show(msg, "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return sv;
        }

        // small helpers for existing empty handlers
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        // handeled above with nullable signature; remove duplicate
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
    }
    static class BoolExtensions
    {
        public static string GetDisplayName(this bool g)
            => g ? "Nam" : "Nữ";
    }
}
