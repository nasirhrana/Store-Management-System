namespace WindowsFormsApplicationListViewApp.UI
{
    partial class SetupCatagoryForm
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
            this.hiddenIdLabel = new System.Windows.Forms.Label();
            this.catagoryListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resetButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backToAdminButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hiddenIdLabel);
            this.groupBox1.Controls.Add(this.catagoryListView);
            this.groupBox1.Controls.Add(this.resetButton);
            this.groupBox1.Controls.Add(this.showAllButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.backToAdminButton);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.categoryNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-2, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // hiddenIdLabel
            // 
            this.hiddenIdLabel.AutoSize = true;
            this.hiddenIdLabel.Location = new System.Drawing.Point(15, 20);
            this.hiddenIdLabel.Name = "hiddenIdLabel";
            this.hiddenIdLabel.Size = new System.Drawing.Size(35, 13);
            this.hiddenIdLabel.TabIndex = 8;
            this.hiddenIdLabel.Text = "label3";
            // 
            // catagoryListView
            // 
            this.catagoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.catagoryListView.FullRowSelect = true;
            this.catagoryListView.Location = new System.Drawing.Point(54, 167);
            this.catagoryListView.Name = "catagoryListView";
            this.catagoryListView.Size = new System.Drawing.Size(570, 266);
            this.catagoryListView.TabIndex = 7;
            this.catagoryListView.UseCompatibleStateImageBehavior = false;
            this.catagoryListView.View = System.Windows.Forms.View.Details;
            this.catagoryListView.DoubleClick += new System.EventHandler(this.catagoryListView_DoubleClick);
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
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(129, 94);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(233, 94);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(75, 23);
            this.showAllButton.TabIndex = 5;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(446, 94);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // backToAdminButton
            // 
            this.backToAdminButton.Location = new System.Drawing.Point(537, 94);
            this.backToAdminButton.Name = "backToAdminButton";
            this.backToAdminButton.Size = new System.Drawing.Size(105, 23);
            this.backToAdminButton.TabIndex = 2;
            this.backToAdminButton.Text = "Back to Admin";
            this.backToAdminButton.UseVisualStyleBackColor = true;
            this.backToAdminButton.Click += new System.EventHandler(this.backToAdminButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(340, 94);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(264, 38);
            this.categoryNameTextBox.Multiline = true;
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(340, 28);
            this.categoryNameTextBox.TabIndex = 0;
            this.categoryNameTextBox.TextChanged += new System.EventHandler(this.categoryNameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category LIst";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // colId
            // 
            this.colId.Name = "colId";
            // 
            // colName
            // 
            this.colName.Name = "colName";
            // 
            // SetupCatagoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 453);
            this.Controls.Add(this.groupBox1);
            this.Name = "SetupCatagoryForm";
            this.Text = "SetupCatagoryForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backToAdminButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ListView catagoryListView;
        internal System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label hiddenIdLabel;
    }
}