using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class director : Form
    {
        public director()
        {
            InitializeComponent();
        }

        private void director_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "ы";
            label2.Text = "ъуъ";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "хы";
            label1.Text = "кхЪо";
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 kal = new Form1();
            kal.ShowDialog();
            this.Close();
        }

        private void button_dollars_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Некрассовкин")
            {
                MessageBox.Show("Долларов не будет, бухгалтер принял ислам");
            }
            else
            {
                MessageBox.Show("Доллары выплачены");
            }
        }

        private void button_fire_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Щищарин")
            {
                MessageBox.Show("Себя уволь псина тупая");
            }
            else
            {
                MessageBox.Show("Пишов домой бездарь");
            }
        }
    }
}