using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    
    public partial class SetupItemForm : Form
    {
        private Thread th;
        public SetupItemForm()
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

        private void savebutton_Click(object sender, EventArgs e)
        {
            SetupItem aSetupItem=new SetupItem();
            aSetupItem.Name = setupItemTextBox.Text;
            aSetupItem.ReorderLevel = Convert.ToInt32(setupReorderLevelTextBox.Text);
            aSetupItem.CatagoryNameId = (int) categoryComboBox.SelectedValue;
            aSetupItem.CompanyNameId = (int) companyComboBox.SelectedValue;
            

            string message = aItemManager.SaveItem(aSetupItem);
            MessageBox.Show(message);
        }
        private ItemManager aItemManager=new ItemManager();
        private void SetupItemForm_Load(object sender, EventArgs e)
        {
            List<SetupCatagory> aCatagories = aItemManager.GetAllCatagory();

            SetupCatagory defaultCatagory = new SetupCatagory();
            defaultCatagory.Id = -1;
            defaultCatagory.Name = "--select--";
            aCatagories.Insert(0, defaultCatagory);

            categoryComboBox.DataSource = aCatagories;
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "Id";
            

            List<SetupCompany> aCompanies = aItemManager.GetAllCompany();

            SetupCompany defaultCompany = new SetupCompany();
            defaultCompany.Id = -2;
            defaultCompany.Name = "--select--";
            aCompanies.Insert(0, defaultCompany);

            companyComboBox.DataSource = aCompanies;
            companyComboBox.DisplayMember = "Name";
            companyComboBox.ValueMember = "Id";

            setupReorderLevelTextBox.Text = 0.ToString();

        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
