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
using WindowsFormsApplicationListViewApp.Models;


namespace WindowsFormsApplicationListViewApp
{
    public partial class SetupCompanyForm : Form
    {
        Thread th;
        public SetupCompanyForm()
        {
            InitializeComponent();
        }

        

        private void backToAdminButton_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewFormAdmin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenNewFormAdmin(object obj)
        {
            Application.Run(new AdminForm());
        }
        public void ClearData()
        {
            companyNameTextBox.Text = "";
        }
        CompanyManager aCompanyManager=new CompanyManager();
        SetupCompany aCompany=new SetupCompany();
        private void companySaveButton_Click(object sender, EventArgs e)
        {
            if (companyNameTextBox.Text != "")
            {
                aCompany.Name = companyNameTextBox.Text;
                string message = aCompanyManager.SaveCompany(aCompany);

                MessageBox.Show(message);



            }
            else
            {
                MessageBox.Show("select row");
            }

            ClearData();
        }

        private void showAllCompanyButton_Click(object sender, EventArgs e)
        {

            companyListView.Items.Clear();
            List<SetupCompany> aCompanies = aCompanyManager.GetAllCompany();
            foreach (SetupCompany company in aCompanies)
            {
                ListViewItem item = new ListViewItem();
                item.Text = company.Id.ToString();
                item.SubItems.Add(company.Name);

                companyListView.Items.Add(item);
                showAllCompanyButton.Text = "Refresh";
            }
            ResetForm();
        }
        private void ResetForm()
        {
            companyNameTextBox.Clear();
        }
    }
}
