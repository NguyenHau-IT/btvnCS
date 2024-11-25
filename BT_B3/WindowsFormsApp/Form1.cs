using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHo_Click(object sender, EventArgs e)
        {
            String Ho = txtHo.Text;
            if (Ho =="")
            {
                MessageBox.Show("Vui Long Nhap Ho");
            }    
            lblHoTen.Text = Ho;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            String Ten = txtTen.Text;
            if (Ten == "")
            {
                MessageBox.Show("Vui Long Nhap Ten");
            }
            lblHoTen.Text = Ten;
        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            String Ho = txtHo.Text;
            String Ten = txtTen.Text;
            if (Ho == "" && Ten =="")
            {
                MessageBox.Show("Vui Long Nhap Ho va Ten");
            }
            lblHoTen.Text = Ho + " " + Ten;
        }

        private void Out_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Thật Sự Muốn Thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblHoTen_DoubleClick(object sender, EventArgs e)
        {
            lblHoTen.Text = string.Empty;
        }
    }
}
