using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Makao_game
{
    public partial class Makao : Form
    {
        private int howManyPlayers;
        private int whosTurn;

        private List<Player> playerList = new List<Player>();
        private Stack<Card> stack;
        internal Croupier croupier;

        public Makao()
        {
            InitializeComponent();
            croupier = new Croupier(ref playerList, ref stack);

            //imiona przypadkowe
            playerList.Add(new Player("Michal", ref croupier));
            playerList.Add(new Player("Maciek", ref croupier));
            playerList.Add(new Player("Mateusz", ref croupier));

            croupier.DealBegginingHand();
            croupier.startStack();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            playerList[0].PlaceOnStack();
            UpdateTextBoxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateTextBoxes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playerList[0].PickACard((int)numericUpDown1.Value);
            UpdateTextBoxes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            playerList[0].AddCardToPrepared((int)numericUpDown2.Value);
            UpdateTextBoxes();
        }

        private void PrintHand(Player player)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText(player.sName + " cards in hand:\n");
            int cardID = 0;
            foreach (var card in player.Hand)
            {
                richTextBox1.AppendText(cardID+". " + card.Value + " of " + card.Suit + "\n");
                cardID++;
            }
            richTextBox1.Focus();
        }

        private void PrintPrepared(Player player)
        {
            richTextBox2.Clear();
            richTextBox2.AppendText(player.sName + " cards to be placed:\n");
            foreach (var card in player.ToPlaceOnStack)
            {
                richTextBox2.AppendText(card.Value + " of " + card.Suit + "\n");
            }
            richTextBox1.Focus();
        }

        private void PrintStack()
        {
            richTextBox3.Clear();
            richTextBox3.AppendText("Cards on stack:\n");
            foreach (var card in croupier.stackReference)
            {
                richTextBox3.AppendText(card.Value + " of " + card.Suit + "\n");
            }
        }

        private void UpdateTextBoxes()
        {
            PrintHand(playerList[0]);
            PrintPrepared(playerList[0]);
            PrintStack();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            playerList[0].ReturnCardsToHand();
            UpdateTextBoxes();
        }
    }
}
