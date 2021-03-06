﻿using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TTT
{
    public partial class Form11 : Form
    {
        Int32 port = 9000;
        Int32 port2 = 9001;
        private int player = 1;
        Socket sck, sck2;
        static Socket acc, acc2;
        IPAddress ip;
        Thread rec;
        int rpos;

        public Form11()
        {
            InitializeComponent();
            pic[0] = 's';
            pic[1] = 'w';
            pic[2] = 'f';
            pic[3] = 'g';
            pic[4] = 'e';
            pic[5] = 't';
            pic[6] = 'u';
            pic[7] = 'p';
            pic[8] = 'l';

        }
        Boolean status = true;
        public void recV()
        {
            while (true)
            {
                try
                {

                    Thread.Sleep(500);//wait every loop iteration 500 ms
                    byte[] Buffer = new byte[255];//buffer array size=255
                    int rec = acc.Receive(Buffer, 0, Buffer.Length, 0);//put every ASCII code(every letter from the msg ) into the variable rec
                    Array.Resize(ref Buffer, rec);//resize the array to the size of the msg , every letter the array resize
                    rpos = Convert.ToInt32(Encoding.Default.GetString(Buffer));

                    status = true;
                    putchar(rpos);

                }
                catch
                {
                }

            }
        }
        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        Action updateLabel;
        public void putchar(int rpos)
        {
            if (rpos == 2)
            {
                updateLabel = () => p02.ImageLocation = Application.StartupPath + "\\images\\o.gif";
                p02.Invoke(updateLabel);
                pic[02] = 'o';
                updateLabel = () => p02.Enabled = false;
                p02.Invoke(updateLabel);
            }
            if (rpos == 0)
            {
                updateLabel = () => p00.ImageLocation = Application.StartupPath + "\\images\\o.gif";
                p00.Invoke(updateLabel);

                pic[00] = 'o';
                updateLabel = () => p00.Enabled = false;
                p00.Invoke(updateLabel);
            }
            if (rpos == 1)
            {
                updateLabel = () => p01.ImageLocation = Application.StartupPath + "\\images\\o.gif";
                p01.Invoke(updateLabel);

                pic[01] = 'o';
                updateLabel = () => p01.Enabled = false;
                p01.Invoke(updateLabel);
            }
            if (rpos == 3)
            {
                updateLabel = () => p03.ImageLocation = Application.StartupPath + "\\images\\o.gif";
                p03.Invoke(updateLabel);

                pic[03] = 'o';
                updateLabel = () => p03.Enabled = false;
                p03.Invoke(updateLabel);
            }
            if (rpos == 4)
            {
                updateLabel = () => p04.ImageLocation = Application.StartupPath + "\\images\\o.gif";
                p04.Invoke(updateLabel);

                pic[04] = 'o';
                updateLabel = () => p04.Enabled = false;
                p04.Invoke(updateLabel);
            }
            if (rpos == 5)
            {
                updateLabel = () => p05.ImageLocation = Application.StartupPath + "\\images\\o.gif";
                p05.Invoke(updateLabel);

                pic[05] = 'o';
                updateLabel = () => p05.Enabled = false;
                p05.Invoke(updateLabel);
            }
            if (rpos == 6)
            {
                updateLabel = () => p06.ImageLocation = Application.StartupPath + "\\images\\o.gif";
                p06.Invoke(updateLabel);

                pic[06] = 'o';
                updateLabel = () => p06.Enabled = false;
                p06.Invoke(updateLabel);
            }
            if (rpos == 7)
            {
                updateLabel = () => p07.ImageLocation = Application.StartupPath + "\\images\\o.gif";
                p07.Invoke(updateLabel);

                pic[07] = 'o';
                updateLabel = () => p07.Enabled = false;
                p07.Invoke(updateLabel);
            }
            if (rpos == 8)
            {
                updateLabel = () => p08.ImageLocation = Application.StartupPath + "\\images\\o.gif";
                p08.Invoke(updateLabel);

                pic[08] = 'o';
                updateLabel = () => p08.Enabled = false;
                p08.Invoke(updateLabel);
            }
        }
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        char[] pic = new char[9];

        private void p02_Click(object sender, EventArgs e)
        {
            if (status)
            {
                if (player == 1)
                {
                    p02.ImageLocation = Application.StartupPath + "\\images\\x.gif";


                    pic[02] = 'x';
                    p02.Enabled = false;
                }
                else
                {

                    p02.ImageLocation = Application.StartupPath + "\\images\\o.gif";


                    pic[02] = 'o';
                    p02.Enabled = false;

                }
                send("2");
            }
            status = false;
        }

        private void p00_Click(object sender, EventArgs e)
        {
            if (status)
            {
                if (player == 1)
                {
                    p00.ImageLocation = Application.StartupPath + "\\images\\x.gif";


                    pic[00] = 'x';
                    p00.Enabled = false;
                }
                else
                {
                    p00.ImageLocation = Application.StartupPath + "\\images\\o.gif";


                    pic[00] = 'o';
                    p00.Enabled = false;

                }
                send("0");
            }
            status = false;

        }

        private void p01_Click(object sender, EventArgs e)
        {
            if (status)
            {
                if (player == 1)
                {
                    p01.ImageLocation = Application.StartupPath + "\\images\\x.gif";


                    pic[01] = 'x';
                    p01.Enabled = false;
                }
                else
                {

                    p01.ImageLocation = Application.StartupPath + "\\images\\o.gif";


                    pic[01] = 'o';
                    p01.Enabled = false;

                }
                send("1");
            }
            status = false;

        }

        private void p03_Click(object sender, EventArgs e)
        {
            if (status)
            {
                if (player == 1)
                {
                    p03.ImageLocation = Application.StartupPath + "\\images\\x.gif";


                    pic[03] = 'x';
                    p03.Enabled = false;
                }
                else
                {

                    p03.ImageLocation = Application.StartupPath + "\\images\\o.gif";


                    pic[03] = 'o';
                    p03.Enabled = false;

                }
                send("3");
            }
            status = false;

        }

        private void p04_Click(object sender, EventArgs e)
        {
            if (status)
            {
                if (player == 1)
                {
                    p04.ImageLocation = Application.StartupPath + "\\images\\x.gif";


                    pic[04] = 'x';
                    p04.Enabled = false;
                }
                else
                {
                    p04.ImageLocation = Application.StartupPath + "\\images\\o.gif";


                    pic[04] = 'o';
                    p04.Enabled = false;

                }
                send("4");
            }
            status = false;

        }

        private void p05_Click(object sender, EventArgs e)
        {
            if (status)
            {
                if (player == 1)
                {
                    p05.ImageLocation = Application.StartupPath + "\\images\\x.gif";


                    pic[05] = 'x';
                    p05.Enabled = false;
                }
                else
                {

                    p05.ImageLocation = Application.StartupPath + "\\images\\o.gif";


                    pic[05] = 'o';
                    p05.Enabled = false;

                }
                send("5");
            }
            status = false;

        }

        private void p06_Click(object sender, EventArgs e)
        {
            if (status)
            {
                if (player == 1)
                {
                    p06.ImageLocation = Application.StartupPath + "\\images\\x.gif";


                    pic[06] = 'x';
                    p06.Enabled = false;
                }
                else
                {

                    p06.ImageLocation = Application.StartupPath + "\\images\\o.gif";


                    pic[06] = 'o';
                    p06.Enabled = false;

                }
                send("6");
            }
            status = false;

        }

        private void p07_Click(object sender, EventArgs e)
        {
            if (status)
            {
                if (player == 1)
                {
                    p07.ImageLocation = Application.StartupPath + "\\images\\x.gif";


                    pic[07] = 'x';
                    p07.Enabled = false;

                }
                else
                {

                    p07.ImageLocation = Application.StartupPath + "\\images\\o.gif";


                    pic[07] = 'o';
                    p07.Enabled = false;



                }
                send("7");
            }
            status = false;

        }

        private void p08_Click(object sender, EventArgs e)
        {
            if (status)
            {
                if (player == 1)
                {
                    p08.ImageLocation = Application.StartupPath + "\\images\\x.gif";


                    pic[08] = 'x';
                    p08.Enabled = false;
                }
                else
                {

                    p08.ImageLocation = Application.StartupPath + "\\images\\o.gif";

                    pic[08] = 'o';
                    p08.Enabled = false;

                }
                send("8");
            }
            status = false;

        }

        //  private string drawwin;
        Winnerc c = new Winnerc();
        lose l = new lose();
        int who = 0;
        public void winner()
        {
            while (true)
            {
                if (pic[00] == pic[01] && pic[01] == pic[02])
                {

                    p1 = p00;
                    p2 = p01;
                    p3 = p02;
                    test = () => timer1.Start();
                    this.Invoke(test);
                    test = () => p03.Enabled = false;
                    p03.Invoke(test);
                    test = () => p04.Enabled = false;
                    p04.Invoke(test);
                    test = () => p05.Enabled = false;
                    p05.Invoke(test);
                    test = () => p06.Enabled = false;
                    p06.Invoke(test);
                    test = () => p07.Enabled = false;
                    p07.Invoke(test);
                    test = () => p08.Enabled = false;
                    p08.Invoke(test);
                    if (pic[00] == 'x')
                    {
                        who = 1;
                    }
                    else if (pic[00] == 'o')
                    {
                        who = -1;
                    }
                    //MessageBox.Show("the winner is = " + pic[00]);
                    // drawwin = "1-3";
                    // //this.Invalidate();  // request a delayed Repaint by the normal MessageLoop system    
                    //  draw();
                    break;
                }
                if (pic[03] == pic[04] && pic[04] == pic[05])
                {
                    p1 = p03;
                    p2 = p04;
                    p3 = p05;
                    test = () => timer1.Start();
                    this.Invoke(test);
                    test = () => p00.Enabled = false;
                    p00.Invoke(test);
                    test = () => p01.Enabled = false;
                    p01.Invoke(test);
                    test = () => p02.Enabled = false;
                    p02.Invoke(test);
                    test = () => p06.Enabled = false;
                    p06.Invoke(test);
                    test = () => p07.Enabled = false;
                    p07.Invoke(test);
                    test = () => p08.Enabled = false;
                    p08.Invoke(test);
                    if (pic[03] == 'x')
                    {
                        who = 1;
                    }
                    else if (pic[03] == 'o')
                    {
                        who = -1;
                    }
                    // MessageBox.Show("the winner is = " + pic[03]);
                    // drawwin = "4-6";
                    //this.Invalidate();  // request a delayed Repaint by the normal MessageLoop system    
                    // draw();
                    break;
                }
                if (pic[06] == pic[07] && pic[07] == pic[08])
                {
                    p1 = p06;
                    p2 = p07;
                    p3 = p08;
                    test = () => timer1.Start();
                    this.Invoke(test);
                    test = () => p03.Enabled = false;
                    p03.Invoke(test);
                    test = () => p04.Enabled = false;
                    p04.Invoke(test);
                    test = () => p05.Enabled = false;
                    p05.Invoke(test);
                    test = () => p00.Enabled = false;
                    p00.Invoke(test);
                    test = () => p01.Enabled = false;
                    p01.Invoke(test);
                    test = () => p02.Enabled = false;
                    p02.Invoke(test);
                    if (pic[06] == 'x')
                    {
                        who = 1;
                    }
                    else if (pic[06] == 'o')
                    {
                        who = -1;
                    }
                    // MessageBox.Show("the winner is = " + pic[06]);
                    // drawwin = "7-9";
                    //this.Invalidate();  // request a delayed Repaint by the normal MessageLoop system    
                    //draw();
                    break;
                }
                if (pic[00] == pic[03] && pic[03] == pic[06])
                {
                    p1 = p00;
                    p2 = p03;
                    p3 = p06;
                    test = () => timer1.Start();
                    this.Invoke(test);
                    test = () => p01.Enabled = false;
                    p01.Invoke(test);
                    test = () => p04.Enabled = false;
                    p04.Invoke(test);
                    test = () => p05.Enabled = false;
                    p05.Invoke(test);
                    test = () => p02.Enabled = false;
                    p02.Invoke(test);
                    test = () => p07.Enabled = false;
                    p07.Invoke(test);
                    test = () => p08.Enabled = false;
                    p08.Invoke(test);
                    if (pic[00] == 'x')
                    {
                        who = 1;
                    }
                    else if (pic[00] == 'o')
                    {
                        who = -1;
                    }
                    // MessageBox.Show("the winner is = " + pic[00]);
                    //  drawwin = "1-7";
                    //this.Invalidate();  // request a delayed Repaint by the normal MessageLoop system    
                    // draw();
                    break;
                }
                if (pic[01] == pic[04] && pic[04] == pic[07])
                {
                    p1 = p01;
                    p2 = p04;
                    p3 = p07;
                    test = () => timer1.Start();
                    this.Invoke(test);
                    test = () => p03.Enabled = false;
                    p03.Invoke(test);
                    test = () => p00.Enabled = false;
                    p00.Invoke(test);
                    test = () => p05.Enabled = false;
                    p05.Invoke(test);
                    test = () => p06.Enabled = false;
                    p06.Invoke(test);
                    test = () => p02.Enabled = false;
                    p02.Invoke(test);
                    test = () => p08.Enabled = false;
                    p08.Invoke(test);
                    if (pic[01] == 'x')
                    {
                        who = 1;
                    }
                    else if (pic[01] == 'o')
                    {
                        who = -1;
                    }
                    // MessageBox.Show("the winner is = " + pic[01]);
                    // drawwin = "2-8";
                    //this.Invalidate();  // request a delayed Repaint by the normal MessageLoop system    
                    // draw();
                    break;
                }
                if (pic[02] == pic[05] && pic[05] == pic[08])
                {
                    p1 = p02;
                    p2 = p05;
                    p3 = p08;
                    test = () => timer1.Start();
                    this.Invoke(test);
                    test = () => p03.Enabled = false;
                    p03.Invoke(test);
                    test = () => p04.Enabled = false;
                    p04.Invoke(test);
                    test = () => p00.Enabled = false;
                    p00.Invoke(test);
                    test = () => p06.Enabled = false;
                    p06.Invoke(test);
                    test = () => p07.Enabled = false;
                    p07.Invoke(test);
                    test = () => p01.Enabled = false;
                    p01.Invoke(test);
                    if (pic[02] == 'x')
                    {
                        who = 1;
                    }
                    else if (pic[02] == 'o')
                    {
                        who = -1;
                    }
                    // MessageBox.Show("the winner is = " + pic[02]);
                    // drawwin = "3-9";
                    //this.Invalidate();  // request a delayed Repaint by the normal MessageLoop system    
                    //  draw();
                    break;
                }
                if (pic[00] == pic[04] && pic[04] == pic[08])
                {
                    p1 = p00;
                    p2 = p04;
                    p3 = p08;
                    test = () => timer1.Start();
                    this.Invoke(test);
                    test = () => p03.Enabled = false;
                    p03.Invoke(test);
                    test = () => p02.Enabled = false;
                    p02.Invoke(test);
                    test = () => p05.Enabled = false;
                    p05.Invoke(test);
                    test = () => p06.Enabled = false;
                    p06.Invoke(test);
                    test = () => p07.Enabled = false;
                    p07.Invoke(test);
                    test = () => p01.Enabled = false;
                    p01.Invoke(test);
                    if (pic[00] == 'x')
                    {
                        who = 1;
                    }
                    else if (pic[00] == 'o')
                    {
                        who = -1;
                    }
                    //MessageBox.Show("the winner is = " + pic[00]);
                    //drawwin = "1-9";
                    //this.Invalidate();  // request a delayed Repaint by the normal MessageLoop system    
                    // draw();
                    break;
                }
                if (pic[02] == pic[04] && pic[04] == pic[06])
                {
                    p1 = p02;
                    p2 = p04;
                    p3 = p06;
                    test = () => timer1.Start();
                    this.Invoke(test);
                    test = () => p03.Enabled = false;
                    p03.Invoke(test);
                    test = () => p08.Enabled = false;
                    p08.Invoke(test);
                    test = () => p00.Enabled = false;
                    p00.Invoke(test);
                    test = () => p05.Enabled = false;
                    p05.Invoke(test);
                    test = () => p07.Enabled = false;
                    p07.Invoke(test);
                    test = () => p01.Enabled = false;
                    p01.Invoke(test);
                    if (pic[02] == 'x')
                    {
                        who = 1;
                    }
                    else if (pic[02] == 'o')
                    {
                        who = -1;
                    }
                    // MessageBox.Show("the winner is = " + pic[02]);
                    // drawwin = "3-7";
                    //this.Invalidate();  // request a delayed Repaint by the normal MessageLoop system    
                    // draw();
                    break;
                }
            }
        }

        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //                             Start Game
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::


        public void StartGame()
        {

            rec = new Thread(recV);
            ip = IPAddress.Parse("127.0.0.1");
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//make a new socket to comm with clients
            sck2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//make a new socket to comm with clients

            sck.Bind(new IPEndPoint(ip, port));//bind take ip and port
            sck2.Bind(new IPEndPoint(ip, port2));//bind take ip and port
            sck.Listen(0);//we don't wont to listen to any one , so we use thread
            sck2.Listen(0);//we don't wont to listen to any one , so we use thread
            acc = sck.Accept();//wait connection from cleint
            acc2 = sck2.Accept();//wait connection from cleint

            rec.Start();//start the thread for receiving data and print it to the console at the realtime(after connecting to the cleint
            Thread win = new Thread(winner);
            win.Start();

        }
        public void send(string data)
        {
            try
            {
                byte[] sdata = Encoding.Default.GetBytes(data);//data save msg that user write it in the readline after convert it to ASCII
                acc.Send(sdata, 0, sdata.Length, 0);//send what is in sdata line by line
            }
            catch { }

        }
        Thread s;
        private void Form1_Load(object sender, EventArgs e)
        {

            s = new Thread(backmusic);
            s.Start();
            Thread s2 = new Thread(StartGame);
            s2.Start();
            Thread s3 = new Thread(recV2);
            s3.Start();


        }

        System.Media.SoundPlayer sp, sp2;

        public void backmusic()
        {
            sp = new System.Media.SoundPlayer(Application.StartupPath + "\\music\\audio1.wav");
            sp.PlaySync();

        }
        public void newmusic()
        {

            sp2 = new System.Media.SoundPlayer(Application.StartupPath + "\\music\\win.wav");
            sp2.PlaySync();
        }

        Action baby2;
        public void recV2()
        {
            while (true)
            {
                try
                {
                    Thread.Sleep(500);//wait every loop iteration 500 ms
                    byte[] Buffer = new byte[255];//buffer array size=255
                    int rec = acc2.Receive(Buffer, 0, Buffer.Length, 0);//put every ASCII code(every letter from the msg ) into the variable rec
                    Array.Resize(ref Buffer, rec);//resize the array to the size of the msg , every letter the array resize
                    baby2 = () => textBox2.Text += (Encoding.Default.GetString(Buffer)) + "\r\n";//write the msg on the console after convert it tostring using encoding
                    textBox2.Invoke(baby2);
                }
                catch { }
            }
        }


        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                try
                {
                    textBox2.Text += "Me :" + textBox1.Text + "\r\n";
                    byte[] sdata = Encoding.Default.GetBytes("Player 1: " + textBox1.Text);//data save msg that user write it in the readline after convert it to ASCII
                    acc2.Send(sdata, 0, sdata.Length, 0);//send what is in sdata line by line
                    textBox1.Clear();
                }
                catch { }
            }
        }
        public int fli = 1;
        Action test;
        public void flick(PictureBox p1, PictureBox p2, PictureBox p3)
        {
            if (fli % 2 == 0)
            {
                test = () => p1.BackColor = Color.Transparent;
                p1.Invoke(test);
                test = () => p2.BackColor = Color.Transparent;
                p2.Invoke(test);
                test = () => p3.BackColor = Color.Transparent;
                p3.Invoke(test);
            }
            else
            {
                test = () => p1.BackColor = Color.Gold;
                p1.Invoke(test);
                test = () => p2.BackColor = Color.Gold;
                p2.Invoke(test);
                test = () => p3.BackColor = Color.Gold;
                p3.Invoke(test);
            }
            if (fli == 15)
            {
                if (who == 1)
                {
                    rec.Abort();
                    sck.Close();
                    sck2.Close();
                    test = () => this.Hide();
                    this.Invoke(test);
                    c.Text = player.ToString();
                    c.Show();
                    who = 0;
                }
                else if (who == -1)
                {
                    rec.Abort();
                    sck.Close();
                    sck2.Close();
                    test = () => this.Hide();
                    this.Invoke(test);
                    test = () => l.Show();
                    l.Text = player.ToString();
                    // l.Invoke(test);
                    l.Show();
                    who = 0;
                }
            }
        }
        PictureBox p1, p2, p3;
        private void timer1_Tick(object sender, EventArgs e)
        {
            fli++;
            flick(p1, p2, p3);
        }
    }
}
        
       
