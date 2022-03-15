using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        int igracbrkarta = 0;
        int kucabrkarta = 0;
        Random random = new Random();
        List<int> usedCards = new List<int>();
        List<PictureBox> bankerbox = new List<PictureBox>();
        List<PictureBox> playerbox = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            if (igracbrkarta > 1)
            {
                resultLabel.Text = String.Format
                ("Igra je već počela... ");
            }

            else
            {
                igracbrkarta = 0;
                kucabrkarta = 0;

                int randomCard1 = selectRandomCard();
                Card card1 = deck[randomCard1];
                usedCards.Add(randomCard1);
                int randomCard2 = selectRandomCard();


                while (usedCards.Contains(randomCard2))
                {
                    randomCard2 = selectRandomCard();
                }
                randomCard2 = 1 * randomCard2;

                Card card2 = deck[randomCard2];
                usedCards.Add(randomCard2);

                playercardList.Add(card1);
                playercardList.Add(card2);

                pictureBox1.ImageLocation = card1.Image;
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

                pictureBox2.ImageLocation = card2.Image;
                pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
                #endregion
                #region init banker
                int randomCard3 = selectRandomCard();
                while (usedCards.Contains(randomCard3))
                {
                    randomCard3 = selectRandomCard();
                }
                randomCard3 = 1 * randomCard3;
                Card card3 = deck[randomCard3];
                usedCards.Add(randomCard3);

                bankercardList.Add(card3);

                pictureBox4.ImageLocation = card3.Image;
                pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;

                sumPlayerCards();


                if (igracbrkarta == 21)
                {
                    resultLabel.Text = String.Format
                        ("The sum of your cards is: {0}, you win!", igracbrkarta);
                    MessageBox.Show("You win!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //resetGame();
                }


            }
        }
    }
}
