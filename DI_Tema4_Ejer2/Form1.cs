using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_Tema4_Ejer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("De verdad","Esto creo que es el titulo",MessageBoxButtons.YesNo,MessageBoxIcon.Hand) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            String red = textBox1.Text;
            String green = textBox2.Text;
            String blue = textBox3.Text;

            if(int.TryParse(red,out int r) && int.TryParse(green, out int g) && int.TryParse(blue, out int b))
            {
                if((r <= 255 && r>= 0) && (g <= 255 && g >= 0) && (b <= 255 && b >= 0)) {
                    this.BackColor = Color.FromArgb(r,g,b);
                }
                else
                {
                    label4.Text = "Num fuera rango";
                }
            }
            else
            {
                label4.Text = "No es un num tiiio";
            }

        }
    }
}
