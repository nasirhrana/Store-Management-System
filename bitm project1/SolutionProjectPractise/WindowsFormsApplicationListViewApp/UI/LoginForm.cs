using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using WindowsFormsApplicationListViewApp.BLL;

namespace WindowsFormsApplicationListViewApp
{
    
    public partial class LoginForm : Form
    {
        Thread th;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
           
        }
        LoginManager aManager=new LoginManager();
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text != "")
            {
                if (passwordTextBox.Text!="")
                {
                    Login aLogin=new Login();
                    aLogin.Username = userNameTextBox.Text;
                    aLogin.Password = passwordTextBox.Text;
                    string message = aManager.Login(aLogin);
                    if (message == "1")
                    {
                        this.Close();
                        th = new Thread(OpenNewForm);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }
                    else
                    {
                        MessageBox.Show(message);
                    }
                }
            }
            else
            {
                MessageBox.Show("username and password is required");
            }
            
        }

        private void OpenNewForm(object obj)
        {
            Application.Run(new AdminForm());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
     
        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void opennewform(object obj)
        {
            Application.Run(new UserInterfaceForm());
        }
    }
}
