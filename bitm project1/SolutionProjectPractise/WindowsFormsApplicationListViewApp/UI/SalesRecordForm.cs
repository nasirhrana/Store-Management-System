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
    public partial class SalesRecordForm : Form
    {
        private Thread th;

        public SalesRecordForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toDateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

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

        private int counter = 0;

        private void SearchButton_Click(object sender, EventArgs e)
        {
            
                ReportManager aReportManager = new ReportManager();
                Report aProjectModels = new Report();
                aProjectModels.FromDateTime = Convert.ToDateTime(fromDateTimePicker.Text);
                aProjectModels.ToDateTime = Convert.ToDateTime(toDateTimePicker.Text);
                List<Report> viewReport = aReportManager.ViewSwals(aProjectModels);

                recordListView.Items.Clear();
                foreach (Report report in viewReport)
                {
                    ListViewItem item = new ListViewItem();
                    
                    item.SubItems.Add(report.ItemName);
                    item.SubItems.Add(report.Quantity.ToString());
                    recordListView.Items.Add(item);
                }
        }

        private void fromDateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SalesRecordForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
