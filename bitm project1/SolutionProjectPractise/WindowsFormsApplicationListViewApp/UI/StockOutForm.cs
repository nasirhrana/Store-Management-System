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
using WindowsFormsApplicationListViewApp.ViewModel;

namespace WindowsFormsApplicationListViewApp
{
    public partial class StockOutForm : Form
    {
        private Thread th;

        public StockOutForm()
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

        private StockInManager aStockInManager = new StockInManager();
        private SetupItem aItem = new SetupItem();
        private StockIn aStockIn = new StockIn();
        private int availableQuntity = 0;
        private int id = 0;

        private void StockOutForm_Load(object sender, EventArgs e)
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

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = Convert.ToInt32(itemComboBox.SelectedValue.ToString());
            aItem.Id = id;
            var ReorderLevel = aStockInManager.GetReorderLevel(aItem);
            ReorderLevelTextBox.Text = ReorderLevel.ToString();

            id = Convert.ToInt32(itemComboBox.SelectedValue.ToString());
            aStockIn.ItemId = id;
            availableQuntity = aStockInManager.GetAvailableQuantity(aStockIn);
            availableQuantityTextBox.Text = availableQuntity.ToString();
        }

        public void Clear()
        {
            companyComboBox.Text = "";
            itemComboBox.Text = "";
            ReorderLevelTextBox.Text = "";
            availableQuantityTextBox.Text = "";
            quantityTextBox.Text = "";

        }

        private void addButton_Click(object sender, EventArgs e)
        {

            availableQuntity = Convert.ToInt32(availableQuantityTextBox.Text) -
                               Convert.ToInt32(ReorderLevelTextBox.Text) - Convert.ToInt32(quantityTextBox.Text);
            if (availableQuntity>=0)
            {
                if (quantityTextBox.Text != "")
                {
                    StockOut aStockOut = new StockOut();
                    aStockOut.ItemName = itemComboBox.Text;
                    aStockOut.CompanyName = companyComboBox.Text;
                    aStockOut.Quantity = Convert.ToInt32(quantityTextBox.Text);
                    aStockOut.Id = Convert.ToInt32(itemComboBox.SelectedValue);
                    

                    ListViewItem item = new ListViewItem();
                    item.Text = aStockOut.ItemName;
                    item.SubItems.Add(aStockOut.ItemName);
                    item.SubItems.Add(aStockOut.Quantity.ToString());
                    item.SubItems.Add(aStockOut.Id.ToString());

                    stockOutListView.Items.Add(item);
                    Clear();
                }
                else
                {
                    MessageBox.Show("please give quantity");
                }
            }
            else
            {
                MessageBox.Show("amount of this item is insufficient");
            }
            

           
        }
        Sell aSell=new Sell();
        StockOutManager aStockOutManager=new StockOutManager();
        StockOut aStockOut=new StockOut();
        private void sellButton_Click(object sender, EventArgs e)
        {
            
            GetTotalValu();
            GetTotalValue();
        }


        public void GetTotalValu()
        {
            int a = 0;

            foreach (ListViewItem listView in stockOutListView.Items)
            {
                aSell.ItemName = stockOutListView.Items[a].SubItems[0].Text;
                aSell.Quantity = Convert.ToInt32(stockOutListView.Items[a].SubItems[2].Text);
                var mesage=aStockOutManager.Insert(aSell);
                //MessageBox.Show(mesage);


            }

        }

        private void damageButton_Click(object sender, EventArgs e)
        {
            GetTotalValue();
        }

        public void GetTotalValue()
        {
            aStockOut.Quantity = availableQuntity;
            int a = 0;
            foreach (ListViewItem listView in stockOutListView.Items)
            {
                
                aStockOut.Id = Convert.ToInt32(stockOutListView.Items[a].SubItems[3].Text);
                var mesage = aStockOutManager.Update(aStockOut);
                MessageBox.Show(mesage);


            }
        }

        private void lostButton_Click(object sender, EventArgs e)
        {
            GetTotalValue();
        }
    }
}
