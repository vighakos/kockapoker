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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Form game = new Game(new List<string> { "egy", "ketto", "harmo"});

            game.ShowDialog();
        }
    }
}
