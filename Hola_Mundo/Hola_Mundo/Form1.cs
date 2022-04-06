using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hola_Mundo
{
    public partial class Form1 : Form
    {
        Image uno = null;
        int x, y;
        int fx, fy;
        int img = 0;
        double vel = 0.01;
        int tiempo = 100;

        public Form1() {

            InitializeComponent();
            uno = Image.FromFile("Recursos\\");
            x = y = 0;
            fx = fy = 0;
            Tick.Enabled = true;
            Tick.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tick_Tick(object sender, EventArgs e)
        {
            img++;
            if (img > 3) img = 0;
            collisionCheck();
            lienzo.Invadate();
        }
        private void Lienzo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(uno, new Rectangle(x, y, 400, 500),
                fx + img * 250 fy, 200, 300 GraphicsUnit.Pixel);
        }

        private void collisionCheck()
        {

        }

        private void Lienzo_Click(object sender, EventArgs e)
        { }
    }
     
}
