using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApplicationListViewApp.BLL;
using WindowsFormsApplicationListViewApp.Models;

namespace WindowsFormsApplicationListViewApp.UI
{
    public partial class SetupCatagoryForm : Form
    {
        Thread th;
        public SetupCatagoryForm()
        {
            
            InitializeComponent();
        }

        private void backToAdminButton_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void OpenNewForm(object obj)
        {
            Application.Run(new AdminForm());
        }
        CatagoryManager aCatagoryManager=new CatagoryManager();
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (categoryNameTextBox.Text != "")
            {
                SetupCatagory aCatagory = new SetupCatagory();
                aCatagory.Name = categoryNameTextBox.Text;

                if (saveButton.Text=="Save")
                {
                    string message = aCatagoryManager.SaveCatagory(aCatagory);
                    MessageBox.Show(message);
                }
                else
                {
                    aCatagory.Id = Convert.ToInt32(hiddenIdLabel.Text);
                    string message = aCatagoryManager.UpdateCatagory(aCatagory);
                    MessageBox.Show(message);
                    deleteButton.Enabled = false;
                }

  
            }
            else
            {
                MessageBox.Show("enter  catagory name first");
            }
            ResetForm();
        }
        
        private void categoryNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            catagoryListView.Items.Clear();
            List<SetupCatagory> aCatagories = aCatagoryManager.GetAllCatagory();
            foreach (SetupCatagory catagory in aCatagories)
            {
                ListViewItem item = new ListViewItem();
                item.Text = catagory.Id.ToString();
                
                item.SubItems.Add(catagory.Name);
                item.Tag = catagory;

                catagoryListView.Items.Add(item);
                showAllButton.Text = "Refresh";
            }
            ResetForm();


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (categoryNameTextBox.Text != "")
            {
                SetupCatagory aCatagory = new SetupCatagory();
                aCatagory.Name = categoryNameTextBox.Text;
                aCatagory.Id = Convert.ToInt32(hiddenIdLabel.Text);
                string message = aCatagoryManager.DeleteCatagory(aCatagory);
                MessageBox.Show(message);

            }
            else
            {
                MessageBox.Show("enter name firest");
            }
            ResetForm();
            deleteButton.Enabled = false;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
           ResetForm();
            deleteButton.Enabled = false;
        }

        private void ResetForm()
        {
            categoryNameTextBox.Clear();
            saveButton.Text = "Save";
        }

        private void catagoryListView_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectedItem = catagoryListView.SelectedItems[0];
            SetupCatagory aCatagory = (SetupCatagory) selectedItem.Tag;
            hiddenIdLabel.Text = aCatagory.Id.ToString();
            categoryNameTextBox.Text = aCatagory.Name;

            saveButton.Text = "Update";
            deleteButton.Enabled = true;
            resetButton.Enabled = true;
        }
        
    }
}
