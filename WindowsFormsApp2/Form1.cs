using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Font font;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            for(int i=5;i<=72;++i)
            {
                comboBox1.Items.Add(i);
            }
            font = richTextBox1.Font;
            comboBox1.Text=font.Size.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle fontStyle1,fontStyle2,fontStyle3,fontStyle4;
            fontStyle1=FontStyle.Regular;
            fontStyle2=FontStyle.Regular;
            fontStyle3=FontStyle.Regular;
            fontStyle4=FontStyle.Regular;
            if (checkBox1.Checked)
            {
                fontStyle1 = FontStyle.Bold;
            }
            if(checkBox2.Checked)
            {
                fontStyle2 = FontStyle.Italic;
            }
            if(checkBox3.Checked)
            {
                fontStyle3 = FontStyle.Underline;
            }
            if(checkBox4.Checked)
            {
                fontStyle4 = FontStyle.Strikeout;
            }
            font = new Font(font, fontStyle1|fontStyle2| fontStyle3| fontStyle4);
            richTextBox1.Font=font;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string fontFamily = font.FontFamily.Name; ;
            if (radioButton1.Checked) fontFamily = radioButton1.Text;
            else if (radioButton2.Checked) fontFamily = radioButton2.Text;
            else if (radioButton3.Checked) fontFamily = radioButton3.Text;
            else fontFamily = radioButton4.Text;
            font=new Font(fontFamily,font.Size,font.Style);
            richTextBox1.Font=font;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Color color = richTextBox1.ForeColor;
            if (radioButton5.Checked) color = Color.Red;
            else if (radioButton6.Checked) color = Color.Green;
            else if (radioButton7.Checked) color = Color.Blue;
            else color = Color.Black;
            richTextBox1 .ForeColor = color;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            float size = Convert.ToSingle(comboBox1.Text);
            font = new Font(font.FontFamily, size);
            richTextBox1.Font = font;
        }
    }
}
