namespace PP1E
{
    partial class Supervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supervisor));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.commandsuper = new System.Windows.Forms.GroupBox();
            this.BTNSupSubmit = new System.Windows.Forms.Button();
            this.TXTSupInfo = new System.Windows.Forms.TextBox();
            this.chkSupClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chkSupPayIntrest = new System.Windows.Forms.RadioButton();
            this.chkSupRefill = new System.Windows.Forms.RadioButton();
            this.chkSupOutServ = new System.Windows.Forms.RadioButton();
            this.chkSupPrintRep = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.commandsuper.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // commandsuper
            // 
            this.commandsuper.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.commandsuper.Controls.Add(this.chkSupPrintRep);
            this.commandsuper.Controls.Add(this.chkSupOutServ);
            this.commandsuper.Controls.Add(this.chkSupRefill);
            this.commandsuper.Controls.Add(this.chkSupPayIntrest);
            this.commandsuper.Controls.Add(this.BTNSupSubmit);
            this.commandsuper.Location = new System.Drawing.Point(29, 90);
            this.commandsuper.Name = "commandsuper";
            this.commandsuper.Size = new System.Drawing.Size(175, 168);
            this.commandsuper.TabIndex = 1;
            this.commandsuper.TabStop = false;
            this.commandsuper.Text = "Commands";
            // 
            // BTNSupSubmit
            // 
            this.BTNSupSubmit.Location = new System.Drawing.Point(46, 137);
            this.BTNSupSubmit.Name = "BTNSupSubmit";
            this.BTNSupSubmit.Size = new System.Drawing.Size(75, 23);
            this.BTNSupSubmit.TabIndex = 4;
            this.BTNSupSubmit.Text = "Submit";
            this.BTNSupSubmit.UseVisualStyleBackColor = true;
            this.BTNSupSubmit.Click += new System.EventHandler(this.BTNSupSubmit_Click);
            // 
            // TXTSupInfo
            // 
            this.TXTSupInfo.Location = new System.Drawing.Point(262, 90);
            this.TXTSupInfo.Multiline = true;
            this.TXTSupInfo.Name = "TXTSupInfo";
            this.TXTSupInfo.Size = new System.Drawing.Size(283, 168);
            this.TXTSupInfo.TabIndex = 2;
            // 
            // chkSupClose
            // 
            this.chkSupClose.Location = new System.Drawing.Point(488, 285);
            this.chkSupClose.Name = "chkSupClose";
            this.chkSupClose.Size = new System.Drawing.Size(75, 23);
            this.chkSupClose.TabIndex = 3;
            this.chkSupClose.Text = "Close";
            this.chkSupClose.UseVisualStyleBackColor = true;
            this.chkSupClose.Click += new System.EventHandler(this.chkSupClose_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chkSupPayIntrest
            // 
            this.chkSupPayIntrest.AutoSize = true;
            this.chkSupPayIntrest.Location = new System.Drawing.Point(25, 30);
            this.chkSupPayIntrest.Name = "chkSupPayIntrest";
            this.chkSupPayIntrest.Size = new System.Drawing.Size(75, 17);
            this.chkSupPayIntrest.TabIndex = 4;
            this.chkSupPayIntrest.TabStop = true;
            this.chkSupPayIntrest.Text = "Pay Intrest";
            this.chkSupPayIntrest.UseVisualStyleBackColor = true;
            // 
            // chkSupRefill
            // 
            this.chkSupRefill.AutoSize = true;
            this.chkSupRefill.Location = new System.Drawing.Point(25, 53);
            this.chkSupRefill.Name = "chkSupRefill";
            this.chkSupRefill.Size = new System.Drawing.Size(74, 17);
            this.chkSupRefill.TabIndex = 4;
            this.chkSupRefill.TabStop = true;
            this.chkSupRefill.Text = "Refill ATM";
            this.chkSupRefill.UseVisualStyleBackColor = true;
            // 
            // chkSupOutServ
            // 
            this.chkSupOutServ.AutoSize = true;
            this.chkSupOutServ.Location = new System.Drawing.Point(25, 76);
            this.chkSupOutServ.Name = "chkSupOutServ";
            this.chkSupOutServ.Size = new System.Drawing.Size(85, 17);
            this.chkSupOutServ.TabIndex = 4;
            this.chkSupOutServ.TabStop = true;
            this.chkSupOutServ.Text = "Out Of Order";
            this.chkSupOutServ.UseVisualStyleBackColor = true;
            // 
            // chkSupPrintRep
            // 
            this.chkSupPrintRep.AutoSize = true;
            this.chkSupPrintRep.Location = new System.Drawing.Point(25, 99);
            this.chkSupPrintRep.Name = "chkSupPrintRep";
            this.chkSupPrintRep.Size = new System.Drawing.Size(86, 17);
            this.chkSupPrintRep.TabIndex = 4;
            this.chkSupPrintRep.TabStop = true;
            this.chkSupPrintRep.Text = "Print Reports";
            this.chkSupPrintRep.UseVisualStyleBackColor = true;
            // 
            // Supervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(575, 320);
            this.ControlBox = false;
            this.Controls.Add(this.chkSupClose);
            this.Controls.Add(this.TXTSupInfo);
            this.Controls.Add(this.commandsuper);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Supervisor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supervisor";
            this.Load += new System.EventHandler(this.Supervisor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.commandsuper.ResumeLayout(false);
            this.commandsuper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox commandsuper;
        private System.Windows.Forms.Button BTNSupSubmit;
        private System.Windows.Forms.TextBox TXTSupInfo;
        private System.Windows.Forms.Button chkSupClose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton chkSupPayIntrest;
        private System.Windows.Forms.RadioButton chkSupRefill;
        private System.Windows.Forms.RadioButton chkSupOutServ;
        private System.Windows.Forms.RadioButton chkSupPrintRep;
    }
}