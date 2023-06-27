namespace PP1E
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TXTname = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TXTpin = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncorrect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXTname
            // 
            this.TXTname.Location = new System.Drawing.Point(43, 227);
            this.TXTname.Name = "TXTname";
            this.TXTname.Size = new System.Drawing.Size(100, 20);
            this.TXTname.TabIndex = 0;
            this.TXTname.Text = "ENTER NAME";
            this.TXTname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTname_KeyDown);
            this.TXTname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXTname_KeyUp);
            this.TXTname.MouseHover += new System.EventHandler(this.TXTname_MouseHover);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(149, 227);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 1;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 195);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TXTpin
            // 
            this.TXTpin.Location = new System.Drawing.Point(43, 254);
            this.TXTpin.Name = "TXTpin";
            this.TXTpin.Size = new System.Drawing.Size(100, 20);
            this.TXTpin.TabIndex = 3;
            this.TXTpin.Text = "PIN";
            
            this.TXTpin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTpin_KeyDown);
            this.TXTpin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXTpin_KeyUp);
            this.TXTpin.MouseHover += new System.EventHandler(this.TXTpin_MouseHover);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(149, 254);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 4;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(8, 19);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(77, 66);
            this.num1.TabIndex = 5;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(91, 19);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(77, 66);
            this.num2.TabIndex = 6;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num1_Click);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(178, 19);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(77, 66);
            this.num3.TabIndex = 7;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num1_Click);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(6, 91);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(77, 66);
            this.num4.TabIndex = 8;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num1_Click);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(91, 91);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(77, 66);
            this.num5.TabIndex = 9;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num1_Click);
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(178, 91);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(77, 66);
            this.num6.TabIndex = 10;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num1_Click);
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(8, 163);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(77, 66);
            this.num7.TabIndex = 11;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num1_Click);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(91, 163);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(77, 66);
            this.num8.TabIndex = 12;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num1_Click);
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(178, 163);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(77, 66);
            this.num9.TabIndex = 13;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num1_Click);
            // 
            // num0
            // 
            this.num0.Location = new System.Drawing.Point(91, 235);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(77, 66);
            this.num0.TabIndex = 14;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num1_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Red;
            this.btnclear.Location = new System.Drawing.Point(8, 235);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(77, 66);
            this.btnclear.TabIndex = 15;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btncorrect
            // 
            this.btncorrect.BackColor = System.Drawing.Color.Yellow;
            this.btncorrect.Location = new System.Drawing.Point(178, 235);
            this.btncorrect.Name = "btncorrect";
            this.btncorrect.Size = new System.Drawing.Size(77, 66);
            this.btncorrect.TabIndex = 16;
            this.btncorrect.Text = "CORRECT";
            this.btncorrect.UseVisualStyleBackColor = false;
            this.btncorrect.Click += new System.EventHandler(this.btncorrect_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.num1);
            this.groupBox1.Controls.Add(this.num0);
            this.groupBox1.Controls.Add(this.btncorrect);
            this.groupBox1.Controls.Add(this.num2);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.num3);
            this.groupBox1.Controls.Add(this.num4);
            this.groupBox1.Controls.Add(this.num9);
            this.groupBox1.Controls.Add(this.num5);
            this.groupBox1.Controls.Add(this.num8);
            this.groupBox1.Controls.Add(this.num6);
            this.groupBox1.Controls.Add(this.num7);
            this.groupBox1.Location = new System.Drawing.Point(302, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 305);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Keypad";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(575, 320);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.TXTpin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.TXTname);
            this.Name = "Login";
            this.Opacity = 0D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Activated += new System.EventHandler(this.Login_Activated);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTname;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TXTpin;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncorrect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

