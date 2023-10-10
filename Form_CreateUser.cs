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
   
    
    public partial class Form_CreateUser : Form
    {
        bool createChecking, createSavings;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //bindingSource.DataSource = lbl_newUserTitle;

        }
        public Form_CreateUser()
        {
            InitializeComponent();
        }

        private void btn_createAccount_Click(object sender, EventArgs e) //Button to click to create a new user for them system.
        {
          
            
            if(clb_accountsCreate.GetItemChecked(0)) //enabled checking
            {
                createChecking = true;

            }
            if (clb_accountsCreate.GetItemChecked(1)) //enabled savings
            {
                createSavings = true;

            }
            if(txb_createPassword.Text != txb_createPasswordConfirm.Text) //Check if passwords match
            {
                MessageBox.Show("Passwords do not match. Please re-enter your passwords.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try//create new user from data entry and save as JSON file
            {
               User newUser = new User(txb_createUser.Text, txb_createPassword.Text, createChecking, createSavings); 
               if(DataManager.DoesUserExist(newUser))
                {
                    MessageBox.Show("User already exists!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("User Successfully Created!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Close();


        }
    }
}
