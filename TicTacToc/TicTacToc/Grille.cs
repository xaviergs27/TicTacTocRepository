﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TicTacToc
{
    class Grille
    {

        private float Largeur;
        private float Hauteur;
        private float Largeur2;
        private float Hauteur2;


        


        

        public void DessinerGrille(Bitmap imageGrille)
        {
            using (var g = Graphics.FromImage(imageGrille))
            {
                var pen = new Pen(Color.Black, 3);

                float x = (imageGrille.Size.Width - 125) - Convert.ToSingle(Largeur);
                float y = (imageGrille.Size.Height - 400) - Convert.ToSingle(Hauteur);

                float x2 = (imageGrille.Size.Width - 275) - Convert.ToSingle(Largeur);
                float y2 = (imageGrille.Size.Height - 400) - Convert.ToSingle(Hauteur);

                float x3 = (imageGrille.Size.Width - 400) - Convert.ToSingle(Largeur);
                float y3 = (imageGrille.Size.Height - 125) - Convert.ToSingle(Hauteur);

                float x4 = (imageGrille.Size.Width - 400) - Convert.ToSingle(Largeur);
                float y4 = (imageGrille.Size.Height - 275) - Convert.ToSingle(Hauteur);



                g.DrawLine(pen, x + 0, y + 0, x +  0, y + 400);
                g.DrawLine(pen, x2 + 0, y2 + 0, x2 + 0, y2 + 400);
                g.DrawLine(pen, x3 + 0, y3 + 0, x3 + 400, y3 + 0);
                g.DrawLine(pen, x4 + 0, y4 + 0, x4 + 400, y4 + 0);

            }
        }
        public void DessinerX(Bitmap imageX)
        {
            using ( var b = Graphics.FromImage(imageX))
            {
                var pen = new Pen(Color.Black, 2);

                float x = (imageX.Size.Width - 121);
                float y = (imageX.Size.Height - 115);

                float x2 = (imageX.Size.Width - 121);
                float y2 = (imageX.Size.Height - 115);

                b.DrawLine(pen, x, y, x + 121, y + 115);
                b.DrawLine(pen, x2, y2 + 115, x2 + 121, y2);
            }
        }

    }
}
