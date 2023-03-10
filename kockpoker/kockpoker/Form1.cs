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
        }

        private void Teszt()
        {
            Form game = new Game(new List<string> { "egy", "ketto", "harmo" });
            this.Hide();
            game.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teszt();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
