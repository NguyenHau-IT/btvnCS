using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void LvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStudent.SelectedItems.Count > 0)
            {
                var selectedItem = lvStudent.SelectedItems[0];
                txtL.Text = selectedItem.SubItems[0].Text;
                txtF.Text = selectedItem.SubItems[1].Text;
                txtP.Text = selectedItem.SubItems[2].Text;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Thêm một mục mới vào ListView
            ListViewItem item = new ListViewItem(txtL.Text);
            item.SubItems.Add(txtF.Text);
            item.SubItems.Add(txtP.Text);

            lvStudent.Items.Add(item);

            ClearTextBoxes();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lvStudent.SelectedItems.Count > 0)
            {
                lvStudent.Items.Remove(lvStudent.SelectedItems[0]);
                ClearTextBoxes();
                MessageBox.Show("Đã xóa mục được chọn!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa!", "Cảnh báo");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (lvStudent.SelectedItems.Count > 0)
            {
                var selectedItem = lvStudent.SelectedItems[0];

                selectedItem.SubItems[0].Text = txtL.Text;
                selectedItem.SubItems[1].Text = txtF.Text;
                selectedItem.SubItems[2].Text = txtP.Text;

                MessageBox.Show("Đã sửa thành công!", "Thông báo");
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để sửa!", "Cảnh báo");
            }
        }

        private void ClearTextBoxes()
        {
            txtL.Text = string.Empty;
            txtF.Text = string.Empty;
            txtP.Text = string.Empty;
        }

    }
}
