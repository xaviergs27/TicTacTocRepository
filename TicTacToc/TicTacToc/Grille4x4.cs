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
    public partial class Grille4x4 : Form
    {
        public Grille4x4()
        {
            InitializeComponent();
        }

        
        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.Show(); 
            
        }

        bool Tour = true;
        int compteur_tour = 0;

        private void Button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (Tour == true)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
            Tour = !Tour;
            b.Enabled = false;
            compteur_tour++;
            VerificationGagnant();
        }

        private void VerificationGagnant()
        {
            bool Gagnant = false;

            //Check pour Horizontal

            if ((A1.Text == A2.Text)&&(A2.Text == A3.Text)&&(A3.Text == A4.Text)&&(!A1.Enabled))
            {
                Gagnant = true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (B3.Text == B4.Text) && (!B1.Enabled))
            {
                Gagnant = true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (C3.Text == C4.Text) && (!C1.Enabled))
            {
                Gagnant = true;
            }
            else if ((D1.Text == D2.Text) && (D2.Text == D3.Text) && (D3.Text == D4.Text) && (!D1.Enabled))
            {
                Gagnant = true;
            }

            //Check pour Verticale

            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (C1.Text == D1.Text) && (!A1.Enabled))
            {
                Gagnant = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (C2.Text == D2.Text) && (!A2.Enabled))
            {
                Gagnant = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (C3.Text == D3.Text) && (!A3.Enabled))
            {
                Gagnant = true;
            }
            else if ((A4.Text == B4.Text) && (B4.Text == C4.Text) && (C4.Text == D4.Text) && (!A4.Enabled))
            {
                Gagnant = true;
            }

            //Check pour Diagonale

            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (C3.Text == D4.Text) && (!A1.Enabled))
            {
                Gagnant = true;
            }
            else if ((A4.Text == B3.Text) && (B3.Text == C2.Text) && (C2.Text == D1.Text) && (!A4.Enabled))
            {
                Gagnant = true;
            }

            if (Gagnant == true)
            {
                String gagnant = "";
                if (Tour == true)
                {
                    gagnant = "O";
                }
                else
                {
                    gagnant = "X";
                }
                MessageBox.Show(gagnant + " a gagné !");
                desactiverBoutons();
            }
            else
            {
                if (compteur_tour == 16)
                {
                    MessageBox.Show("Match Nul !");
                }
            }

        }
        private void desactiverBoutons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch (Exception)
            {

            }

        }

        private void x4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tour = true;
            compteur_tour = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch (Exception)
            {

            }
        }

        private void Grille4x4_FormClosed(object sender, FormClosedEventArgs e)
        {              
            Application.Exit();
        }
    }
}
