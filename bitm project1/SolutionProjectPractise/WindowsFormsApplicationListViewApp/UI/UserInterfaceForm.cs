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

namespace WindowsFormsApplicationListViewApp
{
    public partial class UserInterfaceForm : Form
    {
        Thread th;
        public UserInterfaceForm()
        {
            InitializeComponent();
        }
        
        private void loginButton_Click(object sender, EventArgs e)
        {
           
            
            this.Close();
            th = new Thread(OpenNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenNewForm(object obj)
        {
            Application.Run(new LoginForm());
        }

        private void UserInterfaceForm_Load(object sender, EventArgs e)
        {








        }
    }
}
