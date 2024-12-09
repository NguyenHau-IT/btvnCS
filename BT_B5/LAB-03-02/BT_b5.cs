using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_b5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int size = 14;
        string font = "Tamoha";

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowColor = true;
            font.ShowApply = true;
            font.ShowEffects = true;
            font.ShowHelp = true;

            if (font.ShowDialog() != DialogResult.Cancel)
            {
                txt_type.ForeColor = font.Color;
                txt_type.Font = font.Font;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddFont();
            AddSize();
            lamMoiRich();
            cmb_font.SelectedItem = font;
            cmb_font.Text = font;
            cmb_size.SelectedItem = size;
        }

        private void AddFont()
        {
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                cmb_font.Items.Add(font.Name);
            }
        }

        private void AddSize()
        {
            List<int> listSize = new List<int> { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (var s in listSize)
            {
                cmb_size.Items.Add(s);
            }
        }

        private void lamMoiRich()
        {
            txt_type.Clear();
            txt_type.Font = new Font(font, size, FontStyle.Regular);
        }

        private void cmb_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            size = Int32.Parse(cmb_size.Text);
            txt_type.Font = new Font(font, size, FontStyle.Regular);
        }

        private void cmb_font_SelectedIndexChanged(object sender, EventArgs e)
        {
            font = cmb_font.Text;
            txt_type.Font = new Font(font, size);
        }

        private void cmb_font_TextChanged(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tạoVănBảnMớiCTRLNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lamMoiRich();
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            // Định nghĩa bộ lọc tệp
            open.Filter = "Text files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";

            if (open.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = open.FileName;

                // Xác định kiểu tải tệp dựa trên phần mở rộng
                if (selectedFileName.EndsWith(".txt"))
                {
                    txt_type.LoadFile(selectedFileName, RichTextBoxStreamType.PlainText);
                }
                else if (selectedFileName.EndsWith(".rtf"))
                {
                    txt_type.LoadFile(selectedFileName, RichTextBoxStreamType.RichText);
                }
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                lamMoiRich();
                e.Handled = true;
                return;
            }
            if (e.Control && e.KeyCode == Keys.O)
            {
               mởTậpTinToolStripMenuItem_Click(this, e);
                e.Handled = true;
                return;
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                toolStripButton2_Click(this, e);
                e.Handled = true;
                return;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog(); 
            saveFile.CheckFileExists = true;
            saveFile.Title = "Lưu tập tin văn bản";
            saveFile.DefaultExt = "rft";
            saveFile.Filter = "RichText files |*.rft";
            saveFile.RestoreDirectory = true;
            saveFile.AddExtension = true;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = saveFile.FileName;
                try
                {
                    txt_type.SaveFile(selectedFile, RichTextBoxStreamType.UnicodePlainText);
                    MessageBox.Show("Tập tin đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi trong quá trình lưu tập tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
            }    
        }

        private void btn_Bold_Click(object sender, EventArgs e)
        {
            if (txt_type.SelectionFont != null)
            {
                FontStyle newStyle = txt_type.SelectionFont.Bold
                    ? txt_type.SelectionFont.Style & ~FontStyle.Bold // Bỏ Bold
                    : txt_type.SelectionFont.Style | FontStyle.Bold; // Thêm Bold

                txt_type.SelectionFont = new Font(txt_type.SelectionFont, newStyle);
            }
        }
        private void btn_Italic_Click(object sender, EventArgs e)
        {
            if (txt_type.SelectionFont != null)
            {
                FontStyle newStyle = txt_type.SelectionFont.Italic
                    ? txt_type.SelectionFont.Style & ~FontStyle.Italic // Bỏ Italic
                    : txt_type.SelectionFont.Style | FontStyle.Italic; // Thêm Italic

                txt_type.SelectionFont = new Font(txt_type.SelectionFont, newStyle);
            }
        }
        private void btn_Underline_Click(object sender, EventArgs e)
        {
            if (txt_type.SelectionFont != null)
            {
                FontStyle newStyle = txt_type.SelectionFont.Underline
                    ? txt_type.SelectionFont.Style & ~FontStyle.Underline // Bỏ Underline
                    : txt_type.SelectionFont.Style | FontStyle.Underline; // Thêm Underline

                txt_type.SelectionFont = new Font(txt_type.SelectionFont, newStyle);
            }
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txt_type_TextChanged(object sender, EventArgs e)
        {
            string text = txt_type.Text;

            // Tính số ký tự
            int charCount = text.Length;

            // Tính số từ (chia theo khoảng trắng)
            int wordCount = string.IsNullOrWhiteSpace(text)
                            ? 0
                            : text.Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;

            // Hiển thị trên thanh trạng thái
            lblCharCount.Text = $"Ký tự: {charCount}";
            lblWordCount.Text = $"Từ: {wordCount}";
        }

        private void lưuNộiDungVănBảnCTRLSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.CheckFileExists = true;
            saveFile.Title = "Lưu tập tin văn bản";
            saveFile.DefaultExt = "rft";
            saveFile.Filter = "RichText files |*.rft";
            saveFile.RestoreDirectory = true;
            saveFile.AddExtension = true;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = saveFile.FileName;
                try
                {
                    txt_type.SaveFile(selectedFile, RichTextBoxStreamType.UnicodePlainText);
                    MessageBox.Show("Tập tin đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi trong quá trình lưu tập tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
