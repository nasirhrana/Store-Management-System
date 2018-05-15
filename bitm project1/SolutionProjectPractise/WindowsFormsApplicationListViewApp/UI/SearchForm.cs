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
using WindowsFormsApplicationListViewApp.ViewModel;

namespace WindowsFormsApplicationListViewApp
{
    public partial class SearchForm : Form
    {
        Thread th;
        public SearchForm()
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (companyComboBox.Text!="")
            {
                if (categoryComboBox.Text!="")
                {
                    Search aSearch=new Search();
                    aSearch.CompanyName = companyComboBox.Text;
                    aSearch.CatagoryName = categoryComboBox.Text;
                    List<Search> aCompanies = aViewManager.GetAll(aSearch);
                    foreach (Search company in aCompanies)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = company.ItemName;
                        item.SubItems.Add(company.CompanyName);
                        item.SubItems.Add(company.CatagoryName);
                        item.SubItems.Add(company.ReorderLevel.ToString());
                        item.SubItems.Add(company.Quantity.ToString());

                       allListView.Items.Add(item);
                       
                    }
                }
            }
        }
        private SearchAndViewManager aViewManager=new SearchAndViewManager();
        private void SearchForm_Load(object sender, EventArgs e)
        {
            List<Company> aCompanies = aViewManager.GetAllCompany();
            
            Company defaultCompany=new Company();
            defaultCompany.Id = -1;
            defaultCompany.CompanyName = "--select--";
            aCompanies.Insert(0,defaultCompany);

            companyComboBox.DataSource = aCompanies;
            companyComboBox.DisplayMember = "CompanyName";


            List<Catagory> aCatagories = aViewManager.GetAllCatagory();

            Catagory defaultCompany1 = new Catagory();
            defaultCompany1.Id = -1;
            defaultCompany1.CatagoryName = "--select--";
            aCatagories.Insert(0, defaultCompany1);

            categoryComboBox.DataSource = aCatagories;
            categoryComboBox.DisplayMember = "CatagoryName";
        }
    }
}
