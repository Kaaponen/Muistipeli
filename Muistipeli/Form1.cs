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
       
        PictureBox[] GameCard;
        Random location = new Random();
        List<Point> points = new List<Point>();
        bool again = false;
        PictureBox[] CoverCard = new PictureBox[16];
        int i = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            //  dot = ;

            for (int y = 0; y < 5; y++)
            {
                for (i = 0; i < 7; i++)
                {
                    CoverCard[i] = new PictureBox();
                    CreateCoverCard(CoverCard[i]);
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
