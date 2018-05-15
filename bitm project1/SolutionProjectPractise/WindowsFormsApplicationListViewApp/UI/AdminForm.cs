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
using WindowsFormsApplicationListViewApp.UI;

namespace WindowsFormsApplicationListViewApp
{
    public partial class AdminForm : Form
    {
        Thread th;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void soldViewButton_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewFormSalesRecord);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenNewFormSalesRecord(object obj)
        {
            Application.Run(new SalesRecordForm());
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenNewForm(object obj)
        {
            Application.Run(new UserInterfaceForm());
        }

        private void setupCategoryButton_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewFormAdmin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenNewFormAdmin(object obj)
        {
            Application.Run(new SetupCatagoryForm());
        }

        private void setupCompanyButton_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewFormCompany);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenNewFormCompany(object obj)
        {
            Application.Run(new SetupCompanyForm());
        }

        private void setupItemButton_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewFormItem);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenNewFormItem(object obj)
        {
            Application.Run(new SetupItemForm());
        }

        private void stockInButton_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewFormStockIn);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenNewFormStockIn(object obj)
        {
            Application.Run(new StockInForm());
        }

        private void stockOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewFormStockOut);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenNewFormStockOut(object obj)
        {
            Application.Run(new StockOutForm());
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewFormSearch);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenNewFormSearch(object obj)
        {
            Application.Run(new SearchForm());
        }

 

    }
}
