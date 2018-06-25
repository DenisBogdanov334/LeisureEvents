namespace Overview
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVisitorHistory = new System.Windows.Forms.Button();
            this.btnVisitorStatus = new System.Windows.Forms.Button();
            this.txtbVisitorId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVisitorsTotal = new System.Windows.Forms.Button();
            this.btnVisitorsPresent = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTotalMoneySpent = new System.Windows.Forms.Button();
            this.btnTotalBalanceVisitors = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnFreeSpots = new System.Windows.Forms.Button();
            this.btnBookedSpots = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnTotalAmountProduct = new System.Windows.Forms.Button();
            this.btnTotalPerShop = new System.Windows.Forms.Button();
            this.txtbShopProductId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnLoanProfit = new System.Windows.Forms.Button();
            this.txtbLoanStandId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShowLoanedProducts = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVisitorHistory);
            this.groupBox1.Controls.Add(this.btnVisitorStatus);
            this.groupBox1.Controls.Add(this.txtbVisitorId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(37, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 238);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visitor status";
            // 
            // btnVisitorHistory
            // 
            this.btnVisitorHistory.BackColor = System.Drawing.Color.MistyRose;
            this.btnVisitorHistory.Location = new System.Drawing.Point(45, 167);
            this.btnVisitorHistory.Name = "btnVisitorHistory";
            this.btnVisitorHistory.Size = new System.Drawing.Size(147, 51);
            this.btnVisitorHistory.TabIndex = 3;
            this.btnVisitorHistory.Text = "Visitor history";
            this.btnVisitorHistory.UseVisualStyleBackColor = false;
            this.btnVisitorHistory.Click += new System.EventHandler(this.btnVisitorHistory_Click);
            // 
            // btnVisitorStatus
            // 
            this.btnVisitorStatus.BackColor = System.Drawing.Color.MistyRose;
            this.btnVisitorStatus.Location = new System.Drawing.Point(45, 91);
            this.btnVisitorStatus.Name = "btnVisitorStatus";
            this.btnVisitorStatus.Size = new System.Drawing.Size(147, 51);
            this.btnVisitorStatus.TabIndex = 2;
            this.btnVisitorStatus.Text = "Visitor status";
            this.btnVisitorStatus.UseVisualStyleBackColor = false;
            this.btnVisitorStatus.Click += new System.EventHandler(this.btnVisitorStatus_Click);
            // 
            // txtbVisitorId
            // 
            this.txtbVisitorId.Location = new System.Drawing.Point(114, 42);
            this.txtbVisitorId.Name = "txtbVisitorId";
            this.txtbVisitorId.Size = new System.Drawing.Size(103, 27);
            this.txtbVisitorId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Visitor Id:";
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.ItemHeight = 20;
            this.listBoxInfo.Location = new System.Drawing.Point(43, 379);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(581, 224);
            this.listBoxInfo.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVisitorsTotal);
            this.groupBox2.Controls.Add(this.btnVisitorsPresent);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(356, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 238);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visitors";
            // 
            // btnVisitorsTotal
            // 
            this.btnVisitorsTotal.BackColor = System.Drawing.Color.MistyRose;
            this.btnVisitorsTotal.Location = new System.Drawing.Point(25, 138);
            this.btnVisitorsTotal.Name = "btnVisitorsTotal";
            this.btnVisitorsTotal.Size = new System.Drawing.Size(171, 74);
            this.btnVisitorsTotal.TabIndex = 1;
            this.btnVisitorsTotal.Text = "Total visitors (registered)";
            this.btnVisitorsTotal.UseVisualStyleBackColor = false;
            this.btnVisitorsTotal.Click += new System.EventHandler(this.btnVisitorsTotal_Click);
            // 
            // btnVisitorsPresent
            // 
            this.btnVisitorsPresent.BackColor = System.Drawing.Color.MistyRose;
            this.btnVisitorsPresent.Location = new System.Drawing.Point(25, 42);
            this.btnVisitorsPresent.Name = "btnVisitorsPresent";
            this.btnVisitorsPresent.Size = new System.Drawing.Size(171, 74);
            this.btnVisitorsPresent.TabIndex = 0;
            this.btnVisitorsPresent.Text = "Visitors present";
            this.btnVisitorsPresent.UseVisualStyleBackColor = false;
            this.btnVisitorsPresent.Click += new System.EventHandler(this.btnVisitorsPresent_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTotalMoneySpent);
            this.groupBox3.Controls.Add(this.btnTotalBalanceVisitors);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(662, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 238);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Visitors\' balance";
            // 
            // btnTotalMoneySpent
            // 
            this.btnTotalMoneySpent.BackColor = System.Drawing.Color.MistyRose;
            this.btnTotalMoneySpent.Location = new System.Drawing.Point(43, 138);
            this.btnTotalMoneySpent.Name = "btnTotalMoneySpent";
            this.btnTotalMoneySpent.Size = new System.Drawing.Size(155, 73);
            this.btnTotalMoneySpent.TabIndex = 1;
            this.btnTotalMoneySpent.Text = "Revenue";
            this.btnTotalMoneySpent.UseVisualStyleBackColor = false;
            this.btnTotalMoneySpent.Click += new System.EventHandler(this.btnTotalMoneySpent_Click);
            // 
            // btnTotalBalanceVisitors
            // 
            this.btnTotalBalanceVisitors.BackColor = System.Drawing.Color.MistyRose;
            this.btnTotalBalanceVisitors.Location = new System.Drawing.Point(43, 42);
            this.btnTotalBalanceVisitors.Name = "btnTotalBalanceVisitors";
            this.btnTotalBalanceVisitors.Size = new System.Drawing.Size(155, 73);
            this.btnTotalBalanceVisitors.TabIndex = 0;
            this.btnTotalBalanceVisitors.Text = "Total balance of all visitors";
            this.btnTotalBalanceVisitors.UseVisualStyleBackColor = false;
            this.btnTotalBalanceVisitors.Click += new System.EventHandler(this.btnTotalBalanceVisitors_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnFreeSpots);
            this.groupBox4.Controls.Add(this.btnBookedSpots);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(966, 383);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 220);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Camping statistics ";
            // 
            // btnFreeSpots
            // 
            this.btnFreeSpots.BackColor = System.Drawing.Color.MistyRose;
            this.btnFreeSpots.Location = new System.Drawing.Point(54, 121);
            this.btnFreeSpots.Name = "btnFreeSpots";
            this.btnFreeSpots.Size = new System.Drawing.Size(146, 56);
            this.btnFreeSpots.TabIndex = 1;
            this.btnFreeSpots.Text = "Free spots";
            this.btnFreeSpots.UseVisualStyleBackColor = false;
            this.btnFreeSpots.Click += new System.EventHandler(this.btnFreeSpots_Click);
            // 
            // btnBookedSpots
            // 
            this.btnBookedSpots.BackColor = System.Drawing.Color.MistyRose;
            this.btnBookedSpots.Location = new System.Drawing.Point(54, 38);
            this.btnBookedSpots.Name = "btnBookedSpots";
            this.btnBookedSpots.Size = new System.Drawing.Size(146, 56);
            this.btnBookedSpots.TabIndex = 0;
            this.btnBookedSpots.Text = "Booked spots";
            this.btnBookedSpots.UseVisualStyleBackColor = false;
            this.btnBookedSpots.Click += new System.EventHandler(this.btnBookedSpots_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnTotalAmountProduct);
            this.groupBox5.Controls.Add(this.btnTotalPerShop);
            this.groupBox5.Controls.Add(this.txtbShopProductId);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(966, 98);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(243, 238);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Shops";
            // 
            // btnTotalAmountProduct
            // 
            this.btnTotalAmountProduct.BackColor = System.Drawing.Color.MistyRose;
            this.btnTotalAmountProduct.Location = new System.Drawing.Point(18, 167);
            this.btnTotalAmountProduct.Name = "btnTotalAmountProduct";
            this.btnTotalAmountProduct.Size = new System.Drawing.Size(165, 53);
            this.btnTotalAmountProduct.TabIndex = 3;
            this.btnTotalAmountProduct.Text = "Total amount of certain product";
            this.btnTotalAmountProduct.UseVisualStyleBackColor = false;
            this.btnTotalAmountProduct.Click += new System.EventHandler(this.btnTotalAmountProduct_Click);
            // 
            // btnTotalPerShop
            // 
            this.btnTotalPerShop.BackColor = System.Drawing.Color.MistyRose;
            this.btnTotalPerShop.Location = new System.Drawing.Point(18, 108);
            this.btnTotalPerShop.Name = "btnTotalPerShop";
            this.btnTotalPerShop.Size = new System.Drawing.Size(165, 53);
            this.btnTotalPerShop.TabIndex = 2;
            this.btnTotalPerShop.Text = "Total profit per shop\r\n";
            this.btnTotalPerShop.UseVisualStyleBackColor = false;
            this.btnTotalPerShop.Click += new System.EventHandler(this.btnTotalPerShop_Click);
            // 
            // txtbShopProductId
            // 
            this.txtbShopProductId.Location = new System.Drawing.Point(18, 66);
            this.txtbShopProductId.Name = "txtbShopProductId";
            this.txtbShopProductId.Size = new System.Drawing.Size(132, 27);
            this.txtbShopProductId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Shop/Product Id:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnLoanProfit);
            this.groupBox6.Controls.Add(this.txtbLoanStandId);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.btnShowLoanedProducts);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.Location = new System.Drawing.Point(662, 379);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(235, 224);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Loaned Products";
            // 
            // btnLoanProfit
            // 
            this.btnLoanProfit.BackColor = System.Drawing.Color.MistyRose;
            this.btnLoanProfit.Location = new System.Drawing.Point(34, 99);
            this.btnLoanProfit.Name = "btnLoanProfit";
            this.btnLoanProfit.Size = new System.Drawing.Size(154, 52);
            this.btnLoanProfit.TabIndex = 4;
            this.btnLoanProfit.Text = "Profit per loan stand";
            this.btnLoanProfit.UseVisualStyleBackColor = false;
            this.btnLoanProfit.Click += new System.EventHandler(this.btnLoanProfit_Click);
            // 
            // txtbLoanStandId
            // 
            this.txtbLoanStandId.Location = new System.Drawing.Point(34, 57);
            this.txtbLoanStandId.Name = "txtbLoanStandId";
            this.txtbLoanStandId.Size = new System.Drawing.Size(111, 27);
            this.txtbLoanStandId.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loan stand Id:";
            // 
            // btnShowLoanedProducts
            // 
            this.btnShowLoanedProducts.BackColor = System.Drawing.Color.MistyRose;
            this.btnShowLoanedProducts.Location = new System.Drawing.Point(34, 157);
            this.btnShowLoanedProducts.Name = "btnShowLoanedProducts";
            this.btnShowLoanedProducts.Size = new System.Drawing.Size(154, 52);
            this.btnShowLoanedProducts.TabIndex = 0;
            this.btnShowLoanedProducts.Text = "Show loaned products";
            this.btnShowLoanedProducts.UseVisualStyleBackColor = false;
            this.btnShowLoanedProducts.Click += new System.EventHandler(this.btnShowLoanedProducts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1266, 630);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBoxInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVisitorHistory;
        private System.Windows.Forms.Button btnVisitorStatus;
        private System.Windows.Forms.TextBox txtbVisitorId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVisitorsTotal;
        private System.Windows.Forms.Button btnVisitorsPresent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTotalMoneySpent;
        private System.Windows.Forms.Button btnTotalBalanceVisitors;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnFreeSpots;
        private System.Windows.Forms.Button btnBookedSpots;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnTotalAmountProduct;
        private System.Windows.Forms.Button btnTotalPerShop;
        private System.Windows.Forms.TextBox txtbShopProductId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnShowLoanedProducts;
        private System.Windows.Forms.Button btnLoanProfit;
        private System.Windows.Forms.TextBox txtbLoanStandId;
        private System.Windows.Forms.Label label4;
    }
}

