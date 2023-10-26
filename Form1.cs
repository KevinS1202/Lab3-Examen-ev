using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Int32 val = Convert.ToInt32(textBox1.Text);
            Int32 val2 = Convert.ToInt32(textBox2.Text);
            if (val > 0 && val <= 100 || val2 > 0 && val2 <= 100)

            if ((val + val2) < 100) MessageBox.Show("Отказ в приеме на учебу");
            else if ((val + val2) >= 100 && (val + val2) < 150)
                MessageBox.Show("Ваш доход будет в ночь");

            else if ((val + val2) >= 100 && (val + val2) >= 150)
                MessageBox.Show("Ваш доход будет в утром");

           


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
