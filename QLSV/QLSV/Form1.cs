using QLSV.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Hàm tải danh sách sinh viên từ database
        private void LoadStudentData()
        {
            using (var context = new Model1())
            {
                var listStu = context.STUDENTs
                    .Select(s => new
                    {
                        s.STUDENTID,
                        s.FULLNAME,
                        s.AVERAGESCORE,
                        s.FACULTYID,
                        FacultyName = s.FACULTY.FACULTYNAME
                    })
                    .ToList();

                dgv_1.DataSource = listStu;

                // Đảm bảo các cột trong DataGridView hiển thị đúng
                dgv_1.Columns["FACULTYID"].HeaderText = "Faculty ID";
                dgv_1.Columns["FacultyName"].HeaderText = "Faculty Name";
            }
        }



        // Hàm thêm sinh viên mới
        private void AddStudent()
        {
            using (var context = new Model1())
            {
                var newStudent = new STUDENT
                {
                    STUDENTID = txtStudentId.Text.Trim(),
                    FULLNAME = txtFullName.Text.Trim(),
                    AVERAGESCORE = float.Parse(txtAverageScore.Text.Trim()),
                    FACULTYID = cmbFacultyId.SelectedValue.ToString() // Lấy ID khoa từ ComboBox
                };

                if (!context.STUDENTs.Any(s => s.STUDENTID == newStudent.STUDENTID))
                {
                    context.STUDENTs.Add(newStudent);
                    context.SaveChanges();
                    MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Student ID đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            LoadStudentData(); // Cập nhật DataGridView
        }

        private void EditStudent()
        {
            using (var context = new Model1())
            {
                var studentId = txtStudentId.Text.Trim();
                var student = context.STUDENTs.FirstOrDefault(s => s.STUDENTID == studentId);

                if (student != null)
                {
                    student.FULLNAME = txtFullName.Text.Trim();
                    student.AVERAGESCORE = float.Parse(txtAverageScore.Text.Trim());
                    student.FACULTYID = cmbFacultyId.SelectedValue.ToString(); // Lấy ID khoa từ ComboBox

                    context.SaveChanges();
                    MessageBox.Show("Sửa thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            LoadStudentData(); // Cập nhật DataGridView
        }

        private void DeleteStudent()
        {
            using (var context = new Model1())
            {
                var studentId = txtStudentId.Text.Trim();
                var student = context.STUDENTs.FirstOrDefault(s => s.STUDENTID == studentId);

                if (student != null)
                {
                    context.STUDENTs.Remove(student);
                    context.SaveChanges();
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            LoadStudentData(); // Cập nhật DataGridView
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteStudent();
        }

        private void dgv_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem hàng được chọn có hợp lệ không
            {
                DataGridViewRow row = dgv_1.Rows[e.RowIndex];

                // Hiển thị dữ liệu lên TextBox
                txtStudentId.Text = row.Cells["STUDENTID"].Value.ToString();
                txtFullName.Text = row.Cells["FULLNAME"].Value.ToString();
                txtAverageScore.Text = row.Cells["AVERAGESCORE"].Value.ToString();

                // Hiển thị FacultyID tương ứng trong ComboBox
                string facultyId = row.Cells["FACULTYID"].Value.ToString();
                cmbFacultyId.SelectedValue = facultyId;
            }
        }



        private void LoadFacultyData()
        {
            using (var context = new Model1())
            {
                // Lấy danh sách khoa từ bảng FACULTY
                var faculties = context.FACULTies.ToList();

                // Gán dữ liệu vào ComboBox
                cmbFacultyId.DataSource = faculties;
                cmbFacultyId.DisplayMember = "FACULTYNAME"; // Hiển thị tên khoa
                cmbFacultyId.ValueMember = "FACULTYID";    // Giá trị ẩn là ID khoa
            }
        }


        // Sự kiện khi Form được tải
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudentData(); // Tải danh sách sinh viên lên DataGridView
            LoadFacultyData(); // Tải danh sách khoa vào ComboBox
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditStudent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Nếu người dùng chọn "Yes", thoát ứng dụng
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Đóng ứng dụng
            }
        }


        // Thêm sự kiện nút thêm sinh viên (nếu cần)
    }
}
