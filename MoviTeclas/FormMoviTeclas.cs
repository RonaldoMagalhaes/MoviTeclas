using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviTeclas
{
    public partial class FormMoviTeclas : Form
    {
        public FormMoviTeclas()
        {
            InitializeComponent();
        }

        private void FormMoviTeclas_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                if(ImgLogo.Location.X > -90)
                {
                    ImgLogo.Left -= 10;
                }
                else
                {
                    ImgLogo.Left = 615;
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                if (ImgLogo.Location.Y > -94)
                {
                    ImgLogo.Top -= 10;
                }
                else
                {
                    ImgLogo.Top = 514;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (ImgLogo.Location.X < 615)
                {
                    ImgLogo.Left += 10;
                }
                else
                {
                    ImgLogo.Left = -99;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (ImgLogo.Location.Y < 514)
                {
                    ImgLogo.Top += 10;
                }
                else
                {
                    ImgLogo.Top = -99;
                }
            }


        }
    }
}
