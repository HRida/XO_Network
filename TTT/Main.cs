using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace TTT
{
    public partial class Main : Form
    {
        public Main(){
        
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Show();
            timer1.Start();
               
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            label1.Hide();
            pt1.Hide();
            pt2.Hide();
            pt3.Hide();
            pt4.Hide();
        }
        int x = 0;
        public void loading()
        {
        if(x==1)
            pt1.Show();
        if(x==2)
            pt2.Show();
        if (x == 3)
            pt3.Show();
        if (x == 4)
            pt4.Show();
        if (x == 6)
            pt4.Hide();
        if (x == 7)
            pt3.Hide();
        if (x == 8)
            pt2.Hide();
        if (x == 9)
        {
            pt1.Hide();
            timer1.Stop();
        }  
        
        
        
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
                x++;
                loading();
                if (x == 9)
                {
                    x = 0;
                   Form11 f = new Form11();
                   Form22 f2 = new Form22();
                    this.Hide();
                    f.Show();
                    f2.Show();
                }

        }
    }
}
