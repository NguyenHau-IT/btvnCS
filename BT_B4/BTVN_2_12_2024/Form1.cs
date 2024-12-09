using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_B4
{
    public partial class Form1 : Form
    {
        public delegate void UpdateNhanVienDelegate(string MSNV, string Name, string Luong);

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtg_quanlysinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtg_quanlyNV.Columns.Add("MSNV", "Mã Nhân Viên");
            dtg_quanlyNV.Columns.Add("Name", "Tên Nhân Viên");
            dtg_quanlyNV.Columns.Add("Luong", "Lương CB");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dtg_quanlyNV.Rows.Add(frm.MSNV, frm.Name, frm.Luong);
            }    
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dtg_quanlyNV.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtg_quanlyNV.SelectedRows[0];

                Form2 frm = new Form2(selectedRow.Cells[0].Value.ToString(), selectedRow.Cells[1].Value.ToString(), selectedRow.Cells[2].Value.ToString());
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    selectedRow.Cells[0].Value = frm.MSNV;
                    selectedRow.Cells[1].Value = frm.Name;
                    selectedRow.Cells[2].Value = frm.Luong;
                }    
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dtg_quanlyNV.SelectedRows.Count > 0)
            {
                dtg_quanlyNV.Rows.RemoveAt(dtg_quanlyNV.SelectedRows[0].Index);
            }
        }

        private void dtg_quanlyNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow row = dtg_quanlyNV.Rows[e.RowIndex]; 
            row.Cells[0].Value.ToString();
            row.Cells[1].Value.ToString();
            row.Cells[2].Value.ToString();
        }
    }
}
