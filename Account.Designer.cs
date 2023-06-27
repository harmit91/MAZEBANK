namespace PP1E
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.SelTrans = new System.Windows.Forms.GroupBox();
            this.CHKPayBill = new System.Windows.Forms.RadioButton();
            this.CHKtransfer = new System.Windows.Forms.RadioButton();
            this.CHKwithdraw = new System.Windows.Forms.RadioButton();
            this.CHKdeposit = new System.Windows.Forms.RadioButton();
            this.SelAccount = new System.Windows.Forms.GroupBox();
            this.CHKchequing = new System.Windows.Forms.RadioButton();
            this.CHKsavings = new System.Windows.Forms.RadioButton();
            this.SelKeypad = new System.Windows.Forms.GroupBox();
            this.BTNDotacc = new System.Windows.Forms.Button();
            this.BTNCorrectacc = new System.Windows.Forms.Button();
            this.BTNEnteracc = new System.Windows.Forms.Button();
            this.BTNClearacc = new System.Windows.Forms.Button();
            this.TXTaccEnterDisplay = new System.Windows.Forms.TextBox();
            this.BTN0acc = new System.Windows.Forms.Button();
            this.BTN9acc = new System.Windows.Forms.Button();
            this.BTN8acc = new System.Windows.Forms.Button();
            this.BTN7acc = new System.Windows.Forms.Button();
            this.BTN6acc = new System.Windows.Forms.Button();
            this.BTN5acc = new System.Windows.Forms.Button();
            this.BTN4acc = new System.Windows.Forms.Button();
            this.BTN3acc = new System.Windows.Forms.Button();
            this.BTN2acc = new System.Windows.Forms.Button();
            this.BTN1acc = new System.Windows.Forms.Button();
            this.BTNcloseacc = new System.Windows.Forms.Button();
            this.TXTaccinfo = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SelTrans.SuspendLayout();
            this.SelAccount.SuspendLayout();
            this.SelKeypad.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(575, 352);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // SelTrans
            // 
            this.SelTrans.Controls.Add(this.CHKPayBill);
            this.SelTrans.Controls.Add(this.CHKtransfer);
            this.SelTrans.Controls.Add(this.CHKwithdraw);
            this.SelTrans.Controls.Add(this.CHKdeposit);
            this.SelTrans.Location = new System.Drawing.Point(272, 145);
            this.SelTrans.Name = "SelTrans";
            this.SelTrans.Size = new System.Drawing.Size(102, 123);
            this.SelTrans.TabIndex = 6;
            this.SelTrans.TabStop = false;
            this.SelTrans.Text = "Select Transaction";
            // 
            // CHKPayBill
            // 
            this.CHKPayBill.AutoSize = true;
            this.CHKPayBill.Location = new System.Drawing.Point(7, 100);
            this.CHKPayBill.Name = "CHKPayBill";
            this.CHKPayBill.Size = new System.Drawing.Size(61, 17);
            this.CHKPayBill.TabIndex = 6;
            this.CHKPayBill.TabStop = true;
            this.CHKPayBill.Text = "PayBills";
            this.CHKPayBill.UseVisualStyleBackColor = true;
            // 
            // CHKtransfer
            // 
            this.CHKtransfer.AutoSize = true;
            this.CHKtransfer.Location = new System.Drawing.Point(6, 78);
            this.CHKtransfer.Name = "CHKtransfer";
            this.CHKtransfer.Size = new System.Drawing.Size(96, 17);
            this.CHKtransfer.TabIndex = 5;
            this.CHKtransfer.TabStop = true;
            this.CHKtransfer.Text = "Transfer Funds";
            this.CHKtransfer.UseVisualStyleBackColor = true;
            // 
            // CHKwithdraw
            // 
            this.CHKwithdraw.AutoSize = true;
            this.CHKwithdraw.Location = new System.Drawing.Point(6, 54);
            this.CHKwithdraw.Name = "CHKwithdraw";
            this.CHKwithdraw.Size = new System.Drawing.Size(70, 17);
            this.CHKwithdraw.TabIndex = 4;
            this.CHKwithdraw.TabStop = true;
            this.CHKwithdraw.Text = "Withdraw";
            this.CHKwithdraw.UseVisualStyleBackColor = true;
            // 
            // CHKdeposit
            // 
            this.CHKdeposit.AutoSize = true;
            this.CHKdeposit.Location = new System.Drawing.Point(6, 31);
            this.CHKdeposit.Name = "CHKdeposit";
            this.CHKdeposit.Size = new System.Drawing.Size(61, 17);
            this.CHKdeposit.TabIndex = 3;
            this.CHKdeposit.TabStop = true;
            this.CHKdeposit.Text = "Deposit";
            this.CHKdeposit.UseVisualStyleBackColor = true;
            // 
            // SelAccount
            // 
            this.SelAccount.Controls.Add(this.CHKchequing);
            this.SelAccount.Controls.Add(this.CHKsavings);
            this.SelAccount.Location = new System.Drawing.Point(272, 63);
            this.SelAccount.Name = "SelAccount";
            this.SelAccount.Size = new System.Drawing.Size(107, 76);
            this.SelAccount.TabIndex = 7;
            this.SelAccount.TabStop = false;
            this.SelAccount.Text = "Select Account";
            // 
            // CHKchequing
            // 
            this.CHKchequing.AutoSize = true;
            this.CHKchequing.Location = new System.Drawing.Point(6, 45);
            this.CHKchequing.Name = "CHKchequing";
            this.CHKchequing.Size = new System.Drawing.Size(70, 17);
            this.CHKchequing.TabIndex = 5;
            this.CHKchequing.TabStop = true;
            this.CHKchequing.Text = "Chequing";
            this.CHKchequing.UseVisualStyleBackColor = true;
            // 
            // CHKsavings
            // 
            this.CHKsavings.AutoSize = true;
            this.CHKsavings.Location = new System.Drawing.Point(4, 19);
            this.CHKsavings.Name = "CHKsavings";
            this.CHKsavings.Size = new System.Drawing.Size(63, 17);
            this.CHKsavings.TabIndex = 4;
            this.CHKsavings.TabStop = true;
            this.CHKsavings.Text = "Savings";
            this.CHKsavings.UseVisualStyleBackColor = true;
            // 
            // SelKeypad
            // 
            this.SelKeypad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SelKeypad.Controls.Add(this.BTNDotacc);
            this.SelKeypad.Controls.Add(this.BTNCorrectacc);
            this.SelKeypad.Controls.Add(this.BTNEnteracc);
            this.SelKeypad.Controls.Add(this.BTNClearacc);
            this.SelKeypad.Controls.Add(this.TXTaccEnterDisplay);
            this.SelKeypad.Controls.Add(this.BTN0acc);
            this.SelKeypad.Controls.Add(this.BTN9acc);
            this.SelKeypad.Controls.Add(this.BTN8acc);
            this.SelKeypad.Controls.Add(this.BTN7acc);
            this.SelKeypad.Controls.Add(this.BTN6acc);
            this.SelKeypad.Controls.Add(this.BTN5acc);
            this.SelKeypad.Controls.Add(this.BTN4acc);
            this.SelKeypad.Controls.Add(this.BTN3acc);
            this.SelKeypad.Controls.Add(this.BTN2acc);
            this.SelKeypad.Controls.Add(this.BTN1acc);
            this.SelKeypad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SelKeypad.Location = new System.Drawing.Point(12, 63);
            this.SelKeypad.Name = "SelKeypad";
            this.SelKeypad.Size = new System.Drawing.Size(241, 236);
            this.SelKeypad.TabIndex = 8;
            this.SelKeypad.TabStop = false;
            this.SelKeypad.Text = "KeyPad";
            // 
            // BTNDotacc
            // 
            this.BTNDotacc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTNDotacc.Location = new System.Drawing.Point(116, 165);
            this.BTNDotacc.Name = "BTNDotacc";
            this.BTNDotacc.Size = new System.Drawing.Size(49, 40);
            this.BTNDotacc.TabIndex = 14;
            this.BTNDotacc.Text = ".";
            this.BTNDotacc.UseVisualStyleBackColor = false;
            this.BTNDotacc.Click += new System.EventHandler(this.BTN1acc_Click);
            // 
            // BTNCorrectacc
            // 
            this.BTNCorrectacc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BTNCorrectacc.Location = new System.Drawing.Point(180, 119);
            this.BTNCorrectacc.Name = "BTNCorrectacc";
            this.BTNCorrectacc.Size = new System.Drawing.Size(49, 40);
            this.BTNCorrectacc.TabIndex = 13;
            this.BTNCorrectacc.Text = "Correct";
            this.BTNCorrectacc.UseVisualStyleBackColor = false;
            this.BTNCorrectacc.Click += new System.EventHandler(this.BTNCorrectacc_Click);
            // 
            // BTNEnteracc
            // 
            this.BTNEnteracc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BTNEnteracc.Location = new System.Drawing.Point(180, 22);
            this.BTNEnteracc.Name = "BTNEnteracc";
            this.BTNEnteracc.Size = new System.Drawing.Size(49, 40);
            this.BTNEnteracc.TabIndex = 12;
            this.BTNEnteracc.Text = "Enter";
            this.BTNEnteracc.UseVisualStyleBackColor = false;
            this.BTNEnteracc.Click += new System.EventHandler(this.BTNEnteracc_Click);
            // 
            // BTNClearacc
            // 
            this.BTNClearacc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNClearacc.Location = new System.Drawing.Point(180, 68);
            this.BTNClearacc.Name = "BTNClearacc";
            this.BTNClearacc.Size = new System.Drawing.Size(49, 40);
            this.BTNClearacc.TabIndex = 11;
            this.BTNClearacc.Text = "Clear";
            this.BTNClearacc.UseVisualStyleBackColor = false;
            this.BTNClearacc.Click += new System.EventHandler(this.BTNClearacc_Click);
            // 
            // TXTaccEnterDisplay
            // 
            this.TXTaccEnterDisplay.Location = new System.Drawing.Point(7, 210);
            this.TXTaccEnterDisplay.Name = "TXTaccEnterDisplay";
            this.TXTaccEnterDisplay.Size = new System.Drawing.Size(228, 20);
            this.TXTaccEnterDisplay.TabIndex = 10;
            this.TXTaccEnterDisplay.Text = "0.00";
            this.TXTaccEnterDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN0acc
            // 
            this.BTN0acc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTN0acc.Location = new System.Drawing.Point(61, 165);
            this.BTN0acc.Name = "BTN0acc";
            this.BTN0acc.Size = new System.Drawing.Size(49, 40);
            this.BTN0acc.TabIndex = 9;
            this.BTN0acc.Text = "0";
            this.BTN0acc.UseVisualStyleBackColor = false;
            this.BTN0acc.Click += new System.EventHandler(this.BTN1acc_Click);
            // 
            // BTN9acc
            // 
            this.BTN9acc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTN9acc.Location = new System.Drawing.Point(116, 119);
            this.BTN9acc.Name = "BTN9acc";
            this.BTN9acc.Size = new System.Drawing.Size(49, 40);
            this.BTN9acc.TabIndex = 8;
            this.BTN9acc.Text = "9";
            this.BTN9acc.UseVisualStyleBackColor = false;
            this.BTN9acc.Click += new System.EventHandler(this.BTN1acc_Click);
            // 
            // BTN8acc
            // 
            this.BTN8acc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTN8acc.Location = new System.Drawing.Point(61, 119);
            this.BTN8acc.Name = "BTN8acc";
            this.BTN8acc.Size = new System.Drawing.Size(49, 40);
            this.BTN8acc.TabIndex = 7;
            this.BTN8acc.Text = "8";
            this.BTN8acc.UseVisualStyleBackColor = false;
            this.BTN8acc.Click += new System.EventHandler(this.BTN1acc_Click);
            // 
            // BTN7acc
            // 
            this.BTN7acc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTN7acc.Location = new System.Drawing.Point(6, 119);
            this.BTN7acc.Name = "BTN7acc";
            this.BTN7acc.Size = new System.Drawing.Size(49, 40);
            this.BTN7acc.TabIndex = 6;
            this.BTN7acc.Text = "7";
            this.BTN7acc.UseVisualStyleBackColor = false;
            this.BTN7acc.Click += new System.EventHandler(this.BTN1acc_Click);
            // 
            // BTN6acc
            // 
            this.BTN6acc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTN6acc.Location = new System.Drawing.Point(116, 68);
            this.BTN6acc.Name = "BTN6acc";
            this.BTN6acc.Size = new System.Drawing.Size(49, 40);
            this.BTN6acc.TabIndex = 5;
            this.BTN6acc.Text = "6";
            this.BTN6acc.UseVisualStyleBackColor = false;
            this.BTN6acc.Click += new System.EventHandler(this.BTN1acc_Click);
            // 
            // BTN5acc
            // 
            this.BTN5acc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTN5acc.Location = new System.Drawing.Point(61, 68);
            this.BTN5acc.Name = "BTN5acc";
            this.BTN5acc.Size = new System.Drawing.Size(49, 40);
            this.BTN5acc.TabIndex = 4;
            this.BTN5acc.Text = "5";
            this.BTN5acc.UseVisualStyleBackColor = false;
            this.BTN5acc.Click += new System.EventHandler(this.BTN1acc_Click);
            // 
            // BTN4acc
            // 
            this.BTN4acc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTN4acc.Location = new System.Drawing.Point(6, 68);
            this.BTN4acc.Name = "BTN4acc";
            this.BTN4acc.Size = new System.Drawing.Size(49, 40);
            this.BTN4acc.TabIndex = 3;
            this.BTN4acc.Text = "4";
            this.BTN4acc.UseVisualStyleBackColor = false;
            this.BTN4acc.Click += new System.EventHandler(this.BTN1acc_Click);
            // 
            // BTN3acc
            // 
            this.BTN3acc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTN3acc.Location = new System.Drawing.Point(116, 22);
            this.BTN3acc.Name = "BTN3acc";
            this.BTN3acc.Size = new System.Drawing.Size(49, 40);
            this.BTN3acc.TabIndex = 2;
            this.BTN3acc.Text = "3";
            this.BTN3acc.UseVisualStyleBackColor = false;
            this.BTN3acc.Click += new System.EventHandler(this.BTN1acc_Click);
            // 
            // BTN2acc
            // 
            this.BTN2acc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTN2acc.Location = new System.Drawing.Point(61, 22);
            this.BTN2acc.Name = "BTN2acc";
            this.BTN2acc.Size = new System.Drawing.Size(49, 40);
            this.BTN2acc.TabIndex = 1;
            this.BTN2acc.Text = "2";
            this.BTN2acc.UseVisualStyleBackColor = false;
            this.BTN2acc.Click += new System.EventHandler(this.BTN1acc_Click);
            // 
            // BTN1acc
            // 
            this.BTN1acc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTN1acc.Location = new System.Drawing.Point(6, 22);
            this.BTN1acc.Name = "BTN1acc";
            this.BTN1acc.Size = new System.Drawing.Size(49, 40);
            this.BTN1acc.TabIndex = 0;
            this.BTN1acc.Text = "1";
            this.BTN1acc.UseVisualStyleBackColor = false;
            this.BTN1acc.Click += new System.EventHandler(this.BTN1acc_Click);
            // 
            // BTNcloseacc
            // 
            this.BTNcloseacc.Location = new System.Drawing.Point(488, 295);
            this.BTNcloseacc.Name = "BTNcloseacc";
            this.BTNcloseacc.Size = new System.Drawing.Size(75, 23);
            this.BTNcloseacc.TabIndex = 9;
            this.BTNcloseacc.Text = "Close";
            this.BTNcloseacc.UseVisualStyleBackColor = true;
            this.BTNcloseacc.Click += new System.EventHandler(this.BTNcloseacc_Click);
            // 
            // TXTaccinfo
            // 
            this.TXTaccinfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TXTaccinfo.ForeColor = System.Drawing.Color.Black;
            this.TXTaccinfo.Location = new System.Drawing.Point(385, 26);
            this.TXTaccinfo.Multiline = true;
            this.TXTaccinfo.Name = "TXTaccinfo";
            this.TXTaccinfo.ReadOnly = true;
            this.TXTaccinfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXTaccinfo.Size = new System.Drawing.Size(178, 259);
            this.TXTaccinfo.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(575, 320);
            this.ControlBox = false;
            this.Controls.Add(this.TXTaccinfo);
            this.Controls.Add(this.BTNcloseacc);
            this.Controls.Add(this.SelKeypad);
            this.Controls.Add(this.SelAccount);
            this.Controls.Add(this.SelTrans);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SelTrans.ResumeLayout(false);
            this.SelTrans.PerformLayout();
            this.SelAccount.ResumeLayout(false);
            this.SelAccount.PerformLayout();
            this.SelKeypad.ResumeLayout(false);
            this.SelKeypad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.GroupBox SelTrans;
        private System.Windows.Forms.GroupBox SelAccount;
        private System.Windows.Forms.GroupBox SelKeypad;
        private System.Windows.Forms.Button BTN0acc;
        private System.Windows.Forms.Button BTN9acc;
        private System.Windows.Forms.Button BTN8acc;
        private System.Windows.Forms.Button BTN7acc;
        private System.Windows.Forms.Button BTN6acc;
        private System.Windows.Forms.Button BTN5acc;
        private System.Windows.Forms.Button BTN4acc;
        private System.Windows.Forms.Button BTN3acc;
        private System.Windows.Forms.Button BTN2acc;
        private System.Windows.Forms.Button BTN1acc;
        private System.Windows.Forms.Button BTNcloseacc;
        private System.Windows.Forms.Button BTNDotacc;
        private System.Windows.Forms.Button BTNCorrectacc;
        private System.Windows.Forms.Button BTNEnteracc;
        private System.Windows.Forms.Button BTNClearacc;
        private System.Windows.Forms.TextBox TXTaccEnterDisplay;
        private System.Windows.Forms.TextBox TXTaccinfo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton CHKchequing;
        private System.Windows.Forms.RadioButton CHKsavings;
        private System.Windows.Forms.RadioButton CHKwithdraw;
        private System.Windows.Forms.RadioButton CHKdeposit;
        private System.Windows.Forms.RadioButton CHKPayBill;
        private System.Windows.Forms.RadioButton CHKtransfer;
    }
}