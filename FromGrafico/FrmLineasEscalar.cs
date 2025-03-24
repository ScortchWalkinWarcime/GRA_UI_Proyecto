using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromGrafico
{
    public partial class FrmLineasEscalar : Form
    {
        public FrmLineasEscalar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        Graphics graphics;
        int ex = 1, ey = 1;
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;

            Pen pen = new Pen(Color.Blue, 3);

            Rectangle rectangle = new Rectangle(50, 50, 50 + ex, 50 + ey);
            graphics.DrawRectangle(pen, rectangle);

        }

        private void FrmLineasEscalar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    //Increment
                    ex++;
                    ey++;
                    pictureBox1.Refresh();
                    break;

                case Keys.Down:
                    //Decremento}
                    if (ex > 1)
                    {
                        ex--;
                        ey--;
                        pictureBox1.Refresh();
                    }
                    break;
            }
        }

        private void FrmLineasEscalar_Load(object sender, EventArgs e)
        {

        }
    }
}
