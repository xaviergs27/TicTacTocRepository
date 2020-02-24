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

        PictureBox[] TableauPictureBox = new PictureBox[9];

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap imageGrille = new Bitmap(pbGrille.Size.Width, pbGrille.Size.Height);
            //Bitmap imageX = new Bitmap(pb1.Size.Width, pb1.Size.Height);
            Grille maGrille = new Grille();
            Grille maGrilleX = new Grille();

            TableauPictureBox[0] = pb1;
            TableauPictureBox[1] = pb2;
            TableauPictureBox[2] = pb3;
            TableauPictureBox[3] = pb4;
            TableauPictureBox[4] = pb5;
            TableauPictureBox[5] = pb6;
            TableauPictureBox[6] = pb7;
            TableauPictureBox[7] = pb8;
            TableauPictureBox[8] = pb9;


            maGrille.DessinerGrille(imageGrille);
            //maGrilleX.DessinerX(imageX);
            pbGrille.Image = imageGrille;
            //pb1.Image = imageX;

            

            

        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Pb1_Click(object sender, EventArgs e)
        {
            Grille maGrilleX = new Grille();
            PictureBox ImageCourante;
            ImageCourante = (PictureBox)sender;
            Bitmap imageX = new Bitmap(ImageCourante.Size.Width, ImageCourante.Size.Height);
            cb1.Checked = true;
            maGrilleX.DessinerX(imageX);
            ImageCourante.Image = imageX;
        }
    }
}
