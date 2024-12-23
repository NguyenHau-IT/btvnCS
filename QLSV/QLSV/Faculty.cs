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
    public partial class Faculty : Form
    {
        public Faculty()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new Model1())
            {
                var faculty = new FACULTY
                {
                    FACULTYID = txtID.Text.Trim(),
                    FACULTYNAME = txtName.Text.Trim(),
                    TOTALPROFESSER = int.Parse(txtPFS.Text)
                };

                if (!context.FACULTies.Any(f => f.FACULTYID == faculty.FACULTYID))
                {
                    context.FACULTies.Add(faculty);
                    context.SaveChanges();
                    MessageBox.Show("Thêm khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("mã khoa đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new Model1())
            {
                var facultyID = txtID.Text.Trim();
                var faculty = context.FACULTies.FirstOrDefault(f => f.FACULTYID == facultyID);

                if (faculty != null)
                {
                    context.FACULTies.Remove(faculty);
                    context.SaveChanges();
                    MessageBox.Show("Xóa khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khoa để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (var context = new Model1())
            {
                var facultyID = txtID.Text.Trim();
                var faculty = context.FACULTies.FirstOrDefault(f => f.FACULTYID == facultyID);

                if (faculty != null)
                {
                    faculty.FACULTYNAME = txtName.Text.Trim();
                    faculty.TOTALPROFESSER = int.Parse(txtPFS.Text);

                    context.SaveChanges();
                    MessageBox.Show("Sửa thông tin khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khoa để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            LoadData();
        }

        private void Faculty_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (var context = new Model1())
            {
                var listStu = context.FACULTies
                    .Select(s => new
                    {
                        s.FACULTYID,
                        s.FACULTYNAME,
                        s.TOTALPROFESSER
                    })
                    .ToList();

                dgvFaculty.DataSource = listStu;

                dgvFaculty.Columns["FACULTYID"].HeaderText = "Mã kho";
                dgvFaculty.Columns["FACULTYNAME"].HeaderText = "Khoa";
                dgvFaculty.Columns["TOTALPROFESSER"].HeaderText = "Tổng số GS";
            }
        }

        private void dgvFaculty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvFaculty.Rows[e.RowIndex];

                txtID.Text = row.Cells["FACULTYID"].Value.ToString();
                txtName.Text = row.Cells["FACULTYNAME"].Value.ToString();
                txtPFS.Text = row.Cells["TOTALPROFESSER"].Value.ToString();
            }
        }
    }
}
