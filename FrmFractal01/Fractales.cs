using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmFractal01
{
    public partial class Fractales : Form
    {
        public Fractales()
        {
            InitializeComponent();
        }

        private void Fractales_Load(object sender, EventArgs e)
        {
            mandelbrotSet();
            juliaSet();
            sierpinskiTriangle();
        }

        private void mandelbrotSet()
        {
            int width = PictureBoxMandelbrot.Width;
            int height = PictureBoxMandelbrot.Height;
            Bitmap bmp = new Bitmap(width, height);

            for (int row = 0; row < width; row++)
            {
                for (int col = 0; col < height; col++)
                {
                    double c_re = (col - width / 2.0) * 4.0 / width;
                    double c_im = (row - height / 2.0) * 4.0 / width;

                    int interacciones = 0;
                    double x = 0, y = 0;

                    while (interacciones < 1000 && ((x * x) + (y * y)) <= 4)
                    {
                        double x_temporal = x * x - y * y + c_re;
                        y = 2 * x * y + c_im;
                        x = x_temporal;
                        interacciones++;
                    }
                    bmp.SetPixel(col, row, interacciones < 1000 ? Color.Black : Color.Blue);
                    {
            int width = pictureBoxFractal2.Width;
                    }
                    else
                    {
                        bmp.SetPixel(col, row, Color.Blue);
                    }
                }
            }
            PictureBoxMandelbrot.Image = bmp;
        }

        private void PictureBoxMandelbrot_Click(object sender, EventArgs e)
        {

        }
    }
}
