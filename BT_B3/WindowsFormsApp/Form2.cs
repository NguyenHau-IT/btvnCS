using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            string sex = radio_nam.Checked ? "Nam" : "Nữ";
            string Ngaysinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy hh:mm:ss tt");

            List<string> soThich = new List<string>();
            if (Sport.Checked) soThich.Add("Thể Thao");
            if (Phim.Checked) soThich.Add("Phim Ảnh");
            if (Dulich.Checked) soThich.Add("Du Lịch");

            string soThichChuoi = string.Join(", ", soThich);

            MessageBox.Show("Họ và Tên: " + txtTen.Text +
                            "\nGiới Tính: " + sex +
                            "\nNgày Sinh: " + Ngaysinh +
                            "\nSở Thích: " + soThichChuoi,
                            "Thông Tin Cá Nhân");
        }
    }
}
