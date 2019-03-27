using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muistipeli
{
    public partial class MainForm : Form
    {
        Point dot = new Point(0, 0);
        Label CardHolder = new Label();
        PictureBox[] GameCard;
        List<Point> points = new List<Point>();
        PictureBox[] CoverCard;
        int i = 0;
        PictureBox ekaKuva;
        PictureBox tokaKuva;
        Random noppa = new Random();
        int indeksi, arvottu;
        List<int> kortit = new List<int>();//lista korteista jotka laitetaan pelipöydälle
        string player1; // pelaaja nro 1 
        string player2;//pejaaja nro 2
        int amount;//korttien määrä
        int row, col;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateCardHolder();
            GameBoardCheck();
            CreateCards(amount);
            CreateGrid();
        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Reset();
            CreateCardHolder();
            GameBoardCheck();
            CreateCards(amount);
            CreateGrid();
        }
    
   
    private void Reset()
        {
            CardHolder.Dispose();
            CardHolder = new Label();
            /*
            foreach (PictureBox pic in CardHolder.Controls.OfType<PictureBox>())
            {
                if ((string)pic.Tag == null)
                {
                    pic.Dispose();
                }
                else
                {
                    pic.Dispose();
                }

            } */   /*
                pic.Controls.Remove(CardHolder);
                CardHolder.Controls.Remove(pic);
                Controls.Remove(pic);*/


            /*
            foreach (PictureBox pic in CardHolder)
            {
                if ((string)pic.Tag == null)
                {
                    pic.Dispose();
                }
                else
                {
                    pic.Dispose();
                }

                */
            /* pic.Controls.Remove(CardHolder);
             CardHolder.Controls.Remove(pic);
             Controls.Remove(pic);

         */

        }

    private void CreateCardHolder()
        {
            
           
            CardHolder.Parent = gameGroupBox;
            CardHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
           | System.Windows.Forms.AnchorStyles.Left)
           | System.Windows.Forms.AnchorStyles.Right)));
            CardHolder.BackColor = System.Drawing.Color.Silver;
            
            
            CardHolder.Location = new System.Drawing.Point(5, 16);
            CardHolder.Name = "CardHolder";
            CardHolder.Size = new System.Drawing.Size(1079, 765);
            
            
            // CardHolder.TabIndex = 0;
        }


        private void pelaajat()
        {
            player1 = txtBoxPlayer1.Text;
            player2 = txtBoxPlayer2.Text;
        }

        private void CreateCards (int nro)
        {
            for (i = 1; i <= nro; i++)
            {
                kortit.Add(i);
                kortit.Add(i);
            }

        }

        private void CreateGrid()
        {
            for (int y = 0; y < row; y++)
            {
                for (i = 0; i < col; i++)
                {
                    indeksi = noppa.Next(0, kortit.Count);
                    arvottu = kortit[indeksi];
                    kortit.Remove(arvottu);
                    CoverCard[i + (y * col)] = new PictureBox();
                    CreateCoverCard(CoverCard[i + (y * col)], arvottu);
                    GameCard[i + (y * col)] = new PictureBox();
                    CreateGameCard(GameCard[i + (y * col)], arvottu);
                    dot.X = dot.X + 153;
                }
                dot.Y = dot.Y + 153;
                dot.X = 0;

            }

        }

        private void CreateCoverCard(PictureBox CoverCard, int nro)
        {
            CoverCard.Size = new System.Drawing.Size(150, 150);
            CoverCard.Image = Properties.Resources.thinkingsmiley;
            CoverCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            CoverCard.Tag = "car" + nro;
            CoverCard.Parent = CardHolder;
            CoverCard.Location = dot;
            CoverCard.MouseClick += CardHolder_Click;
        }

        private void CreateGameCard(PictureBox GameCard, int nro)
        {
            GameCard.Size = new Size(150, 150);
            GameCard.Image = (Image)Properties.Resources.ResourceManager.GetObject("car" + nro);
            GameCard.SizeMode = PictureBoxSizeMode.StretchImage;
            GameCard.Parent = CardHolder;
            GameCard.Location = dot;
        }

        private void CardHolder_Click(object sender, EventArgs e)
        {
            // if (ekaKuva.Visible != false && tokaKuva.Visible != false)
            // return;
            
            PictureBox napsautus = sender as PictureBox;

            if (napsautus.Visible == false)


            if (napsautus == null)
                return;

            //if (napsautus.Visible == true)
              //  return;

            if (ekaKuva == null)
            {
                ekaKuva = napsautus;
                ekaKuva.Visible = false;
                return;
            }
            if (tokaKuva == null)
            {
                tokaKuva = napsautus;
                tokaKuva.Visible = false;
                
            }
          if (ekaKuva.Tag.ToString() == tokaKuva.Tag.ToString())
            {
                int counter= 0;
                ekaKuva = null;
                tokaKuva = null;
                counter++;
               
            bool voitto = true;
          foreach(PictureBox kortti in CoverCard)
            {
                if (kortti.Visible == true)
                {
                    voitto = false;
                    break;
                }
            }
            if (voitto)
            {
                MessageBox.Show("Pelaaja  voitti. Pistein ");
            }
                return;
            }

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            ekaKuva.Visible = true;
            tokaKuva.Visible = true;
            ekaKuva = null;
            tokaKuva = null;
        }
        private void Players ()
        {
            if (rdBtnYksin.Checked==true)
            {


            }

        }

        private void GameBoardCheck ()
        {
            if (rdBtn8.Checked == true)
            {
                amount = 4;
                row = 4;
                col = 2;
                GameCard = new PictureBox[8];
                CoverCard = new PictureBox[8];
            }

            if (rdBtn16.Checked == true)
            {
                amount = 8; 
                row = 4;
                col = 4;
                GameCard = new PictureBox[16];
                CoverCard = new PictureBox[16];
            }

            if (rdBnt30.Checked == true) 
            {
                amount = 15;
                row = 5;
                col = 6;
                GameCard = new PictureBox[30];
                CoverCard = new PictureBox[30];
            }

        }

        private void txBoxPlayer1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdBtn8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
