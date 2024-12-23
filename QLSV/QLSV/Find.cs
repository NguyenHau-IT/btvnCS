using QLSV.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();
        }

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

                dgvStudent.DataSource = listStu;

                // Đảm bảo các cột trong DataGridView hiển thị đúng
                dgvStudent.Columns["STUDENTID"].HeaderText = "MSSV";
                dgvStudent.Columns["FULLNAME"].HeaderText = "Họ và Tên";
                dgvStudent.Columns["AVERAGESCORE"].HeaderText = "Điểm Trung Bình";
                dgvStudent.Columns["FACULTYID"].HeaderText = "Faculty ID";
                dgvStudent.Columns["FACULTYID"].Visible = false;
                dgvStudent.Columns["FacultyName"].HeaderText = "Khoa";
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

        private void btnFind_Click(object sender, EventArgs e)
        {
            using (var context = new Model1())
            {
                if (string.IsNullOrEmpty(txtStudentId.Text))
                {
                    if (string.IsNullOrEmpty(txtFullName.Text))
                    {
                        var facultyId = cmbFacultyId.SelectedValue; // Lấy giá trị của SelectedValue
                        if (facultyId != null)
                        {
                            var student = context.STUDENTs
                                .Where(s => s.FACULTYID == facultyId) // So sánh với giá trị đúng loại
                                .Select(s => new
                                {
                                    s.STUDENTID,
                                    s.FULLNAME,
                                    s.AVERAGESCORE,
                                    s.FACULTYID,
                                    FacultyName = s.FACULTY.FACULTYNAME
                                })
                                .ToList();

                            if (student.Count > 0)
                            {
                                dgvStudent.DataSource = student;
                                txtFind.Text = student.Count.ToString();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy sinh viên.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Chọn khoa hợp lệ.");
                        }

                    }
                    else
                    {
                        string name = txtFullName.Text;
                        var student = context.STUDENTs
                            .Where(s => s.FULLNAME == name)
                            .Select(s => new
                            {
                                s.STUDENTID,
                                s.FULLNAME,
                                s.AVERAGESCORE,
                                s.FACULTYID,
                                FacultyName = s.FACULTY.FACULTYNAME // Quan hệ liên bảng
                            })
                            .ToList();

                        if (student != null)
                        {
                            dgvStudent.DataSource = student;
                            txtFind.Text = student.Count.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sinh viên.");
                        }
                    }
                }
                else
                {
                    string studentid = txtStudentId.Text;
                    var student = context.STUDENTs
                        .Where(s => s.STUDENTID == studentid)
                        .Select(s => new
                        {
                            s.STUDENTID,
                            s.FULLNAME,
                            s.AVERAGESCORE,
                            s.FACULTYID,
                            FacultyName = s.FACULTY.FACULTYNAME // Quan hệ liên bảng
                        })
                        .ToList();

                    if (student != null)
                    {
                        dgvStudent.DataSource = student;
                        txtFind.Text = student.Count.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên.");
                    }
                }
            }

        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem hàng được chọn có hợp lệ không
            {
                DataGridViewRow row = dgvStudent.Rows[e.RowIndex];

                // Hiển thị dữ liệu lên TextBox
                txtStudentId.Text = row.Cells["STUDENTID"].Value.ToString();
                txtFullName.Text = row.Cells["FULLNAME"].Value.ToString();
                txtAverageScore.Text = row.Cells["AVERAGESCORE"].Value.ToString();

                // Hiển thị FacultyID tương ứng trong ComboBox
                string facultyId = row.Cells["FACULTYID"].Value.ToString();
                cmbFacultyId.SelectedValue = facultyId;
            }
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteStudent();
        }

        private void Faculty_Load(object sender, EventArgs e)
        {
            LoadStudentData();
            LoadFacultyData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
