namespace AI_Bank
{
    partial class Form1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_support = new System.Windows.Forms.Button();
            this.btn_logOut = new System.Windows.Forms.Button();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.lbl_savingsBalance = new System.Windows.Forms.Label();
            this.lbl_checkingBalance = new System.Windows.Forms.Label();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnl_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.btn_support);
            this.flowLayoutPanel1.Controls.Add(this.btn_logOut);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 501);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 100);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 100);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 200);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 100);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_support
            // 
            this.btn_support.Location = new System.Drawing.Point(3, 300);
            this.btn_support.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn_support.Name = "btn_support";
            this.btn_support.Size = new System.Drawing.Size(197, 100);
            this.btn_support.TabIndex = 3;
            this.btn_support.Text = "Support";
            this.btn_support.UseVisualStyleBackColor = true;
            // 
            // btn_logOut
            // 
            this.btn_logOut.Location = new System.Drawing.Point(3, 400);
            this.btn_logOut.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(197, 100);
            this.btn_logOut.TabIndex = 4;
            this.btn_logOut.Text = "Log Out";
            this.btn_logOut.UseVisualStyleBackColor = true;
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.lbl_savingsBalance);
            this.pnl_main.Controls.Add(this.lbl_checkingBalance);
            this.pnl_main.Controls.Add(this.lbl_welcome);
            this.pnl_main.Location = new System.Drawing.Point(206, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(580, 500);
            this.pnl_main.TabIndex = 1;
            this.pnl_main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_savingsBalance
            // 
            this.lbl_savingsBalance.AutoSize = true;
            this.lbl_savingsBalance.Location = new System.Drawing.Point(91, 200);
            this.lbl_savingsBalance.Name = "lbl_savingsBalance";
            this.lbl_savingsBalance.Size = new System.Drawing.Size(93, 13);
            this.lbl_savingsBalance.TabIndex = 2;
            this.lbl_savingsBalance.Text = "Savings Balance: ";
            // 
            // lbl_checkingBalance
            // 
            this.lbl_checkingBalance.AutoSize = true;
            this.lbl_checkingBalance.Location = new System.Drawing.Point(88, 130);
            this.lbl_checkingBalance.Name = "lbl_checkingBalance";
            this.lbl_checkingBalance.Size = new System.Drawing.Size(100, 13);
            this.lbl_checkingBalance.TabIndex = 1;
            this.lbl_checkingBalance.Text = "Checking Balance: ";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(42, 26);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(159, 37);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_support;
        private System.Windows.Forms.Button btn_logOut;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_savingsBalance;
        private System.Windows.Forms.Label lbl_checkingBalance;
    }
}

