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

        public Game(List<string> playernames)
        {
            InitializeComponent();

            Setup(playernames);
        }

        private void Setup(List<string> playernames)
        {
            foreach (string name in playernames)
                players.Add(new Player(name));


        }
    }
}
