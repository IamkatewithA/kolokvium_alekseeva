using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace kolokvium_alekseeva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = numericUpDown1.Value.ToString();
            trackBar1.Maximum = Decimal.ToInt32(numericUpDown1.Value);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OK_button_Click(object sender, EventArgs e)
        {
            tabControl2.TabPages.Clear();
            int NumberOfPages = Decimal.ToInt32(numericUpDown1.Value);

            if(checkBox1.Checked) { 
                tabControl2.Multiline = false;
            }
            else
            {
                tabControl2.Multiline = true;
            }

            for (int i = 1; i <= NumberOfPages; i++) {
                TabPage newPage = new TabPage("P" + i.ToString());
                tabControl2.TabPages.Add(newPage);
                TextBox textBox = new TextBox();
               
                textBox.Location = new Point(27, 67);
                textBox.Size = new Size(200, 20);
                newPage.Controls.Add(textBox);
            }
            if(radioButton1.Checked) {

                tabControl2.TabPages[trackBar1.Value-1].Parent = null;
            }
            if (radioButton2.Checked)
            {
                tabControl2.TabPages[trackBar1.Value - 1].Parent = tabControl2;
            }
        }

        private void DoForAll_button_Click(object sender, EventArgs e)
        {
            int NumberOfPages = Decimal.ToInt32(numericUpDown1.Value);
            if (radioButton1.Checked)
            {
                tabControl2.Parent = null;
            }
            if (radioButton2.Checked)
            {
                tabControl2.Parent = tabControl1.TabPages[2]; // Установка родителя обратно на форму
                tabControl2.TabPages.Clear();
                for (int i = 1; i <= NumberOfPages; i++)
                {
                    TabPage newPage = new TabPage("P" + i.ToString());
                    tabControl2.TabPages.Add(newPage);
                    TextBox textBox = new TextBox();

                    textBox.Location = new Point(27, 67);
                    textBox.Size = new Size(200, 20);
                    newPage.Controls.Add(textBox);
                }
            }
        }
    }
}
