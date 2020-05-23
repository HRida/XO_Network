using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TTT
{
    public partial class Winnerc : Form
    {
        public Winnerc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Replay_Click(object sender, EventArgs e)
        {
            Form11 f = new Form11();
            this.Hide();
            f.Show();
        }
    }
}
