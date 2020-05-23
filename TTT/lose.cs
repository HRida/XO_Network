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
    public partial class lose : Form
    {
        public lose()
        {
            InitializeComponent();
            this.Location = new Point(50, 300);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Replay_Click(object sender, EventArgs e)
        {
            Form22 f2 = new Form22();
            this.Hide();
            f2.Show();
           
        }
    }
}
