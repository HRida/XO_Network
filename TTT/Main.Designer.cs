namespace TTT
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pt1 = new System.Windows.Forms.Label();
            this.pt2 = new System.Windows.Forms.Label();
            this.pt3 = new System.Windows.Forms.Label();
            this.pt4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MediumBlue;
            this.button1.Location = new System.Drawing.Point(298, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.MediumBlue;
            this.button2.Location = new System.Drawing.Point(296, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 50);
            this.button2.TabIndex = 0;
            this.button2.Text = "Start Game";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(303, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loading ";
            // 
            // pt1
            // 
            this.pt1.AutoSize = true;
            this.pt1.BackColor = System.Drawing.Color.Transparent;
            this.pt1.Font = new System.Drawing.Font("Tempus Sans ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pt1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pt1.Location = new System.Drawing.Point(386, 381);
            this.pt1.Name = "pt1";
            this.pt1.Size = new System.Drawing.Size(32, 49);
            this.pt1.TabIndex = 2;
            this.pt1.Text = ".";
            // 
            // pt2
            // 
            this.pt2.AutoSize = true;
            this.pt2.BackColor = System.Drawing.Color.Transparent;
            this.pt2.Font = new System.Drawing.Font("Tempus Sans ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pt2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pt2.Location = new System.Drawing.Point(403, 382);
            this.pt2.Name = "pt2";
            this.pt2.Size = new System.Drawing.Size(32, 49);
            this.pt2.TabIndex = 2;
            this.pt2.Text = ".";
            // 
            // pt3
            // 
            this.pt3.AutoSize = true;
            this.pt3.BackColor = System.Drawing.Color.Transparent;
            this.pt3.Font = new System.Drawing.Font("Tempus Sans ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pt3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pt3.Location = new System.Drawing.Point(422, 382);
            this.pt3.Name = "pt3";
            this.pt3.Size = new System.Drawing.Size(32, 49);
            this.pt3.TabIndex = 2;
            this.pt3.Text = ".";
            // 
            // pt4
            // 
            this.pt4.AutoSize = true;
            this.pt4.BackColor = System.Drawing.Color.Transparent;
            this.pt4.Font = new System.Drawing.Font("Tempus Sans ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pt4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pt4.Location = new System.Drawing.Point(442, 382);
            this.pt4.Name = "pt4";
            this.pt4.Size = new System.Drawing.Size(32, 49);
            this.pt4.TabIndex = 2;
            this.pt4.Text = ".";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(263, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 23);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(263, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 23);
            this.panel2.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TTT.Properties.Resources.main;
            this.ClientSize = new System.Drawing.Size(731, 555);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pt4);
            this.Controls.Add(this.pt3);
            this.Controls.Add(this.pt2);
            this.Controls.Add(this.pt1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Name = "Main";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pt1;
        private System.Windows.Forms.Label pt2;
        private System.Windows.Forms.Label pt3;
        private System.Windows.Forms.Label pt4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}