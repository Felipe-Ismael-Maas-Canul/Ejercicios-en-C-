using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad4
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void text_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Length <= 0) return;
            bool isRight = Double.TryParse(txt.Text, out _);

            if (!isRight) {

                MessageBox.Show("Dato invalido");
                string res = "";
                for (int i = 0; i < txt.Text.Length; i++)
                {

                }
                if (txt.Text[i] >= '0' && txt.Text[i] <= '9')
                {
                    res += txt.Text[i];
                }
            }
            res.Text = res;
        }
    }
}