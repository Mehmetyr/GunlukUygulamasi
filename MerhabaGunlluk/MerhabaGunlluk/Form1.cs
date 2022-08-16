using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerhabaGunlluk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            TSCB_Size.Text = richTextBox1.Font.Size.ToString();

            FontFamily[] fonts = FontFamily.Families;
           
            foreach (FontFamily family in fonts )
            {
                TSMI_Font.Items.Add(family.Name);
                
            }
            TSMI_Font.SelectedItem = richTextBox1.Font.FontFamily.Name;
            saveFileDialog1.Filter = "Zengin Metin Biçimi |* rtf";
        }

        private void aÇToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                richTextBox1.LoadFile(path);
            }
        }

        private void TSMI_kadet_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                richTextBox1.SaveFile(path);
                MessageBox.Show("Kayıt İşlemi başarıyla gerçekleştirildi", "Kaydedildi");
            }
           
        }

        private void TSMI_fontAyarları_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                //richTextBox1.Font = fontDialog1.Font;
                richTextBox1.SelectionFont = fontDialog1.Font;//Sadece Sçilen yeri değiştirmek için
            }
        }

        private void TSMI_renkAyarları_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
                TSMI_Color.ForeColor = colorDialog1.Color;
            }
        }

        private void TSMI_Font_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontFamily[] fonts = FontFamily.Families;
            int index = TSMI_Font.SelectedIndex;
            float size = float.Parse(TSCB_Size.Text);
            richTextBox1.SelectionFont = new Font(fonts[index], richTextBox1.Font.Size);
        }

        private void TSCB_Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontFamily[] fonts = FontFamily.Families;
            int index = TSMI_Font.SelectedIndex;
            float size = float.Parse(TSCB_Size.Text);
            richTextBox1.SelectionFont = new Font(fonts[index],size );

        }

        private void TSMI_Color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
                TSMI_Color.ForeColor = colorDialog1.Color;
            }
        }

        private void TSMI_Bold_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Bold)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.Font.Size, FontStyle.Regular);
                TSMI_Bold.BackColor = SystemColors.Control;
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.Font.Size, FontStyle.Bold);
                TSMI_Bold.BackColor = Color.Silver;
            }
        }

        private void TSMI_Italic_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Italic)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.Font.Size, FontStyle.Regular);
                TSMI_Italic.BackColor = SystemColors.Control;
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.Font.Size, FontStyle.Italic);
                TSMI_Italic.BackColor = Color.Silver;
            }
        }

        private void TSMI_Underline_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Underline)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.Font.Size, FontStyle.Regular);
                TSMI_Underline.BackColor = SystemColors.Control;
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.Font.Size, FontStyle.Underline);
                TSMI_Underline.BackColor = Color.Silver;
            }
        }
    }
}
