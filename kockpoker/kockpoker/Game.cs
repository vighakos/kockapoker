using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kockpoker
{
    public partial class Game : Form
    {
        static List<Player> players = new List<Player>();
        static Player currentPlayer;

        public Game(List<string> playernames)
        {
            InitializeComponent();

            Setup(playernames);
        }

        private void Setup(List<string> playernames)
        {
            foreach (string name in playernames)
                players.Add(new Player(name));
            
            currentPlayer = players[0];
        }

        private void rollBtn_Click(object sender, EventArgs e)
        {
            List<int> numbers = currentPlayer.Throw;
            rollChoiceCbox.Items.Clear();

            foreach (int szam in numbers)
            {
                rollChoiceCbox.Items.Add(szam);
            }
            
            rollChoiceCbox.SelectedIndex = 0;
            
            currentPlayer.Rolls--;
            if (currentPlayer.Rolls == 0)
            {
                rollBtn.Enabled = false;
            }
        }

        private void endRoundBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
