using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using WindowsFormsApplicationListViewApp.BLL;
using WindowsFormsApplicationListViewApp.Models;
using WindowsFormsApplicationListViewApp.ViewModel;

namespace WindowsFormsApplicationListViewApp
{
    public partial class StockInForm : Form
    {
        Thread th;
        public StockInForm()
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

        private ItemManager aManager = new ItemManager();

        private StockInManager aStockInManager=new StockInManager();
        private void StockInForm_Load(object sender, EventArgs e)
        {
            List<ItemWithCompany> aCatagories = aStockInManager.GetAllItemCompany();


            itemComboBox.DataSource = aCatagories;
            itemComboBox.DisplayMember = "ItemName";
            itemComboBox.ValueMember = "Id";
            
            companyComboBox.DataSource = aCatagories;
                    
             companyComboBox.DisplayMember = "CompanyName";
             companyComboBox.ValueMember = "Id";
            showReorderLevelTextBox.Enabled = false;          
        }       
        private SetupItem aItem=new SetupItem();
        private StockIn aStockIn=new StockIn();
        private int availableQuntity = 0;
        private int id = 0;
        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            id = Convert.ToInt32(itemComboBox.SelectedValue.ToString());
            aItem.Id = id;
            var ReorderLevel = aStockInManager.GetReorderLevel(aItem);
            showReorderLevelTextBox.Text = ReorderLevel.ToString();

            id = Convert.ToInt32(itemComboBox.SelectedValue.ToString());
            aStockIn.ItemId = id;
            availableQuntity = aStockInManager.GetAvailableQuantity(aStockIn);
            showAvailableQuantityTextBox.Text = availableQuntity.ToString();
            
        }
       
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (stockInQuantityTextBox.Text!="")
            {
                int finalQuantity = Convert.ToInt32(stockInQuantityTextBox.Text);
                aStockIn.Quantity = finalQuantity + availableQuntity;
                aStockIn.ItemId = id;

                var message = aStockInManager.UpdateQuantity(aStockIn);
                MessageBox.Show(message);
                stockInQuantityTextBox.Clear();
                Clear();
            }
            else
            {
                MessageBox.Show("please give quantity");
            }
            
            

        }
        public void Clear()
        {
            companyComboBox.Text = "";
            itemComboBox.Text = "";
            showReorderLevelTextBox.Text = "";
            showAvailableQuantityTextBox.Text = "";


        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }     
        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void stockInQuantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
