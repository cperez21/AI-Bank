using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_Bank
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //Check user JSON folder with 
            
            
            
            
            
            
            
            
            
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void btn_newUser_Click(object sender, EventArgs e)
        {
            Form_CreateUser f_createUser = new Form_CreateUser();
            f_createUser.ShowDialog();
        }
    }
}
