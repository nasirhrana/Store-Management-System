namespace WindowsFormsApplicationListViewApp
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.stockInButton = new System.Windows.Forms.Button();
            this.stockOutButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.soldViewButton = new System.Windows.Forms.Button();
            this.setupCategoryButton = new System.Windows.Forms.Button();
            this.setupCompanyButton = new System.Windows.Forms.Button();
            this.setupItemButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stockInButton
            // 
            this.stockInButton.Location = new System.Drawing.Point(480, 185);
            this.stockInButton.Name = "stockInButton";
            this.stockInButton.Size = new System.Drawing.Size(114, 39);
            this.stockInButton.TabIndex = 3;
            this.stockInButton.Text = "Stock In";
            this.stockInButton.UseVisualStyleBackColor = true;
            this.stockInButton.Click += new System.EventHandler(this.stockInButton_Click);
            // 
            // stockOutButton
            // 
            this.stockOutButton.Location = new System.Drawing.Point(619, 185);
            this.stockOutButton.Name = "stockOutButton";
            this.stockOutButton.Size = new System.Drawing.Size(98, 39);
            this.stockOutButton.TabIndex = 4;
            this.stockOutButton.Text = "Stock Out";
            this.stockOutButton.UseVisualStyleBackColor = true;
            this.stockOutButton.Click += new System.EventHandler(this.stockOutButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(75, 270);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(98, 39);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(394, 270);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(119, 38);
            this.logOutButton.TabIndex = 7;
            this.logOutButton.Text = "Logout";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // soldViewButton
            // 
            this.soldViewButton.Location = new System.Drawing.Point(221, 270);
            this.soldViewButton.Name = "soldViewButton";
            this.soldViewButton.Size = new System.Drawing.Size(117, 39);
            this.soldViewButton.TabIndex = 6;
            this.soldViewButton.Text = "Sales Record";
            this.soldViewButton.UseVisualStyleBackColor = true;
            this.soldViewButton.Click += new System.EventHandler(this.soldViewButton_Click);
            // 
            // setupCategoryButton
            // 
            this.setupCategoryButton.Location = new System.Drawing.Point(34, 186);
            this.setupCategoryButton.Name = "setupCategoryButton";
            this.setupCategoryButton.Size = new System.Drawing.Size(122, 38);
            this.setupCategoryButton.TabIndex = 0;
            this.setupCategoryButton.Text = "Setup Category";
            this.setupCategoryButton.UseVisualStyleBackColor = true;
            this.setupCategoryButton.Click += new System.EventHandler(this.setupCategoryButton_Click);
            // 
            // setupCompanyButton
            // 
            this.setupCompanyButton.Location = new System.Drawing.Point(177, 186);
            this.setupCompanyButton.Name = "setupCompanyButton";
            this.setupCompanyButton.Size = new System.Drawing.Size(122, 38);
            this.setupCompanyButton.TabIndex = 1;
            this.setupCompanyButton.Text = "Setup Company";
            this.setupCompanyButton.UseVisualStyleBackColor = true;
            this.setupCompanyButton.Click += new System.EventHandler(this.setupCompanyButton_Click);
            // 
            // setupItemButton
            // 
            this.setupItemButton.Location = new System.Drawing.Point(328, 186);
            this.setupItemButton.Name = "setupItemButton";
            this.setupItemButton.Size = new System.Drawing.Size(122, 38);
            this.setupItemButton.TabIndex = 2;
            this.setupItemButton.Text = "setupItem\r\n";
            this.setupItemButton.UseVisualStyleBackColor = true;
            this.setupItemButton.Click += new System.EventHandler(this.setupItemButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(203, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 89);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 586);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.setupItemButton);
            this.Controls.Add(this.setupCompanyButton);
            this.Controls.Add(this.setupCategoryButton);
            this.Controls.Add(this.soldViewButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.stockOutButton);
            this.Controls.Add(this.stockInButton);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button stockInButton;
        private System.Windows.Forms.Button stockOutButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button soldViewButton;
        private System.Windows.Forms.Button setupCategoryButton;
        private System.Windows.Forms.Button setupCompanyButton;
        private System.Windows.Forms.Button setupItemButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}