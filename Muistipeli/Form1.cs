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
        Point dot = new Point(0,0);
       
        PictureBox[] GameCard=new PictureBox[30];
        List<Point> points = new List<Point>();
        PictureBox[] CoverCard = new PictureBox[30];
        int i = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Random noppa = new Random();
            int indeksi, arvottu;
            List<int> kortit = new List<int>();
            for(i=1;i<=15; i++)
            {
                kortit.Add(i);
                kortit.Add(i);
            }

            for (int y = 0; y < 5; y++)
            {
                for (i = 0; i < 6; i++)
                {
                    indeksi = noppa.Next(0, kortit.Count);
                    arvottu = kortit[indeksi];
                    kortit.Remove(arvottu);

                    CoverCard[i] = new PictureBox();
                    CreateCoverCard(CoverCard[i]);
                    GameCard[i] = new PictureBox();
                    CreateGameCard(GameCard[i], arvottu);
                    dot.X = dot.X + 153;
                }
                dot.Y = dot.Y + 153;
                dot.X = 0;
            }
        }

        private  void CreateCoverCard (PictureBox CoverCard)
            {         
            CoverCard.Size = new System.Drawing.Size(150,150);
            CoverCard.Image = Properties.Resources.thinkingsmiley;
            CoverCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            CoverCard.Parent = CardHolder;
            CoverCard.Location = dot;
            CoverCard.MouseClick += CardHolder_Click ;
            }

     private void CreateGameCard (PictureBox GameCard, int nro)
        {
            GameCard.Size = new Size(150, 150);
           // string kuva = "Properties.Resources.car" + 1;
            GameCard.Image = (Image)Properties.Resources.ResourceManager.GetObject("car" + nro); ;
            GameCard.SizeMode = PictureBoxSizeMode.StretchImage;
            GameCard.Parent = CardHolder;
            GameCard.Location = dot;
            //GameCard.MouseClik +=

        }

    private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void btnStart_Click(object sender, EventArgs e)
        {
            
        }
        
        private void CardHolder_Click(object sender, EventArgs e)
        {
            PictureBox card = (PictureBox)sender;
            card.Visible = false;
        }
    }
}
