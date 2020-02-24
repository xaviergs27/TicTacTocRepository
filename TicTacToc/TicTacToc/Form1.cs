using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap imageGrille = new Bitmap(pbGrille.Size.Width, pbGrille.Size.Height);
            Bitmap imageX = new Bitmap(pb1.Size.Width, pb1.Size.Height);
            Grille maGrille = new Grille(0, 0 ,0 ,400);

            

            maGrille.DessinerGrille(imageGrille);
            maGrille.DessinerX(imageX);
            pbGrille.Image = imageGrille;
            pb1.Image = imageX;
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
