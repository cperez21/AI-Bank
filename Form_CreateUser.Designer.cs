namespace AI_Bank
{
    partial class Form_CreateUser
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
            this.lbl_userEnter = new System.Windows.Forms.Label();
            this.lbl_passwordEnter = new System.Windows.Forms.Label();
            this.lbl_passwordConfirm = new System.Windows.Forms.Label();
            this.clb_accountsCreate = new System.Windows.Forms.CheckedListBox();
            this.lbl_newUserTitle = new System.Windows.Forms.Label();
            this.txb_createUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_createAccount = new System.Windows.Forms.Button();
            this.txb_createPassword = new System.Windows.Forms.TextBox();
            this.txb_createPasswordConfirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_userEnter
            // 
            this.lbl_userEnter.AutoSize = true;
            this.lbl_userEnter.Location = new System.Drawing.Point(43, 94);
            this.lbl_userEnter.Name = "lbl_userEnter";
            this.lbl_userEnter.Size = new System.Drawing.Size(60, 13);
            this.lbl_userEnter.TabIndex = 0;
            this.lbl_userEnter.Text = "User Name";
            // 
            // lbl_passwordEnter
            // 
            this.lbl_passwordEnter.AutoSize = true;
            this.lbl_passwordEnter.Location = new System.Drawing.Point(43, 127);
            this.lbl_passwordEnter.Name = "lbl_passwordEnter";
            this.lbl_passwordEnter.Size = new System.Drawing.Size(53, 13);
            this.lbl_passwordEnter.TabIndex = 1;
            this.lbl_passwordEnter.Text = "Password";
            // 
            // lbl_passwordConfirm
            // 
            this.lbl_passwordConfirm.AutoSize = true;
            this.lbl_passwordConfirm.Location = new System.Drawing.Point(43, 159);
            this.lbl_passwordConfirm.Name = "lbl_passwordConfirm";
            this.lbl_passwordConfirm.Size = new System.Drawing.Size(91, 13);
            this.lbl_passwordConfirm.TabIndex = 2;
            this.lbl_passwordConfirm.Text = "Confirm Password";
            // 
            // clb_accountsCreate
            // 
            this.clb_accountsCreate.BackColor = System.Drawing.SystemColors.Control;
            this.clb_accountsCreate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_accountsCreate.FormattingEnabled = true;
            this.clb_accountsCreate.Items.AddRange(new object[] {
            "Checking Account",
            "Savings Account"});
            this.clb_accountsCreate.Location = new System.Drawing.Point(43, 220);
            this.clb_accountsCreate.Name = "clb_accountsCreate";
            this.clb_accountsCreate.Size = new System.Drawing.Size(120, 90);
            this.clb_accountsCreate.TabIndex = 3;
            // 
            // lbl_newUserTitle
            // 
            this.lbl_newUserTitle.AutoSize = true;
            this.lbl_newUserTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newUserTitle.Location = new System.Drawing.Point(39, 23);
            this.lbl_newUserTitle.Name = "lbl_newUserTitle";
            this.lbl_newUserTitle.Size = new System.Drawing.Size(161, 31);
            this.lbl_newUserTitle.TabIndex = 4;
            this.lbl_newUserTitle.Text = "Create User";
            // 
            // txb_createUser
            // 
            this.txb_createUser.Location = new System.Drawing.Point(109, 91);
            this.txb_createUser.Name = "txb_createUser";
            this.txb_createUser.Size = new System.Drawing.Size(100, 20);
            this.txb_createUser.TabIndex = 1;
            this.txb_createUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Account(s) to open:";
            // 
            // btn_createAccount
            // 
            this.btn_createAccount.Location = new System.Drawing.Point(81, 355);
            this.btn_createAccount.Name = "btn_createAccount";
            this.btn_createAccount.Size = new System.Drawing.Size(75, 23);
            this.btn_createAccount.TabIndex = 6;
            this.btn_createAccount.Text = "OK";
            this.btn_createAccount.UseVisualStyleBackColor = true;
            this.btn_createAccount.Click += new System.EventHandler(this.btn_createAccount_Click);
            // 
            // txb_createPassword
            // 
            this.txb_createPassword.Location = new System.Drawing.Point(109, 120);
            this.txb_createPassword.Name = "txb_createPassword";
            this.txb_createPassword.PasswordChar = '*';
            this.txb_createPassword.Size = new System.Drawing.Size(100, 20);
            this.txb_createPassword.TabIndex = 2;
            // 
            // txb_createPasswordConfirm
            // 
            this.txb_createPasswordConfirm.Location = new System.Drawing.Point(140, 156);
            this.txb_createPasswordConfirm.Name = "txb_createPasswordConfirm";
            this.txb_createPasswordConfirm.PasswordChar = '*';
            this.txb_createPasswordConfirm.Size = new System.Drawing.Size(100, 20);
            this.txb_createPasswordConfirm.TabIndex = 3;
            // 
            // Form_CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 422);
            this.Controls.Add(this.txb_createPasswordConfirm);
            this.Controls.Add(this.txb_createPassword);
            this.Controls.Add(this.btn_createAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_createUser);
            this.Controls.Add(this.lbl_newUserTitle);
            this.Controls.Add(this.clb_accountsCreate);
            this.Controls.Add(this.lbl_passwordConfirm);
            this.Controls.Add(this.lbl_passwordEnter);
            this.Controls.Add(this.lbl_userEnter);
            this.Name = "Form_CreateUser";
            this.Text = "Add a New User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_userEnter;
        private System.Windows.Forms.Label lbl_passwordEnter;
        private System.Windows.Forms.Label lbl_passwordConfirm;
        private System.Windows.Forms.CheckedListBox clb_accountsCreate;
        private System.Windows.Forms.Label lbl_newUserTitle;
        private System.Windows.Forms.TextBox txb_createUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_createAccount;
        private System.Windows.Forms.TextBox txb_createPassword;
        private System.Windows.Forms.TextBox txb_createPasswordConfirm;
    }
}