using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static BT_B4.Form1;

namespace BT_B4
{
    public partial class Form2 : Form
    {
        public string MSNV { get; set; }
        public string Name { get; set; }
        public string Luong { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string msnv, string name, string luong) 
        {
            InitializeComponent();
            
            MSNV = msnv;
            Name = name;
            Luong = luong;

            txt_msnv.Text = msnv;
            txt_name.Text = name;
            txt_luong.Text = luong;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
 
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            MSNV = txt_msnv.Text;
            Name = txt_name.Text;
            Luong = txt_luong.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
