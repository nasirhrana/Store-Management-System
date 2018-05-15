namespace WindowsFormsApplicationListViewApp
{
    partial class SetupCompanyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showAllCompanyButton = new System.Windows.Forms.Button();
            this.backToAdminButton = new System.Windows.Forms.Button();
            this.companySaveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.companyListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.companyListView);
            this.groupBox1.Controls.Add(this.showAllCompanyButton);
            this.groupBox1.Controls.Add(this.backToAdminButton);
            this.groupBox1.Controls.Add(this.companySaveButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.companyNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(1, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 536);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // showAllCompanyButton
            // 
            this.showAllCompanyButton.Location = new System.Drawing.Point(122, 118);
            this.showAllCompanyButton.Name = "showAllCompanyButton";
            this.showAllCompanyButton.Size = new System.Drawing.Size(75, 23);
            this.showAllCompanyButton.TabIndex = 4;
            this.showAllCompanyButton.Text = "Show All";
            this.showAllCompanyButton.UseVisualStyleBackColor = true;
            this.showAllCompanyButton.Click += new System.EventHandler(this.showAllCompanyButton_Click);
            // 
            // backToAdminButton
            // 
            this.backToAdminButton.Location = new System.Drawing.Point(373, 118);
            this.backToAdminButton.Name = "backToAdminButton";
            this.backToAdminButton.Size = new System.Drawing.Size(113, 23);
            this.backToAdminButton.TabIndex = 2;
            this.backToAdminButton.Text = "Back to Admin";
            this.backToAdminButton.UseVisualStyleBackColor = true;
            this.backToAdminButton.Click += new System.EventHandler(this.backToAdminButton_Click);
            // 
            // companySaveButton
            // 
            this.companySaveButton.Location = new System.Drawing.Point(237, 118);
            this.companySaveButton.Name = "companySaveButton";
            this.companySaveButton.Size = new System.Drawing.Size(75, 23);
            this.companySaveButton.TabIndex = 1;
            this.companySaveButton.Text = "Save";
            this.companySaveButton.UseVisualStyleBackColor = true;
            this.companySaveButton.Click += new System.EventHandler(this.companySaveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Location = new System.Drawing.Point(137, 52);
            this.companyNameTextBox.Multiline = true;
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(374, 31);
            this.companyNameTextBox.TabIndex = 0;
            // 
            // companyListView
            // 
            this.companyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.companyListView.Location = new System.Drawing.Point(11, 200);
            this.companyListView.Name = "companyListView";
            this.companyListView.Size = new System.Drawing.Size(639, 315);
            this.companyListView.TabIndex = 5;
            this.companyListView.UseCompatibleStateImageBehavior = false;
            this.companyListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 200;
            // 
            // SetupCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 549);
            this.Controls.Add(this.groupBox1);
            this.Name = "SetupCompanyForm";
            this.Text = "Setup Company Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button companySaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.Button backToAdminButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showAllCompanyButton;
        private System.Windows.Forms.ListView companyListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}