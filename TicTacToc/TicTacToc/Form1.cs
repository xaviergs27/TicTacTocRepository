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

        bool Tour = true;
        int compteur_tour = 0;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void appelleForm(Form NomDeFormulaire)
        {
            NomDeFormulaire.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


        private void Button_click(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
            }
            
        }

        private void VerificationGagnant()
        {            
            bool Gagnant = false;

            //Check pour Horizontal

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                Gagnant = true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                Gagnant = true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                Gagnant = true;
            }

            //Check pour Vertical

            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                Gagnant = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                Gagnant = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                Gagnant = true;
            }

            //Check pour Diagonale

            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                Gagnant = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
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
                MessageBox.Show(gagnant +" a gagné !");
                desactiverBoutons();
            }
            else
            {
                if (compteur_tour == 9)
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
            this.Hide();
            appelleForm(new Grille4x4());
            

        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
