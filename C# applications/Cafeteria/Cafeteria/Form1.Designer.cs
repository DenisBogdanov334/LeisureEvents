namespace Cafeteria
{
    partial class Cafeteria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cafeteria));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMainCourse = new System.Windows.Forms.Button();
            this.btnDessets = new System.Windows.Forms.Button();
            this.btnBeverages = new System.Windows.Forms.Button();
            this.groupBoxCategory = new System.Windows.Forms.GroupBox();
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.ColumnProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveSelectedProduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProceedOrder = new System.Windows.Forms.Button();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.dataGridViewBill = new System.Windows.Forms.DataGridView();
            this.CulumnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDownQty = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxStoreId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(508, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(950, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(140, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categories";
            // 
            // btnMainCourse
            // 
            this.btnMainCourse.AutoSize = true;
            this.btnMainCourse.BackColor = System.Drawing.Color.PowderBlue;
            this.btnMainCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMainCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMainCourse.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnMainCourse.Location = new System.Drawing.Point(145, 225);
            this.btnMainCourse.Name = "btnMainCourse";
            this.btnMainCourse.Size = new System.Drawing.Size(215, 42);
            this.btnMainCourse.TabIndex = 2;
            this.btnMainCourse.Text = "Main Course";
            this.btnMainCourse.UseVisualStyleBackColor = false;
            this.btnMainCourse.Click += new System.EventHandler(this.btnMainCourse_Click);
            // 
            // btnDessets
            // 
            this.btnDessets.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDessets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDessets.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnDessets.Location = new System.Drawing.Point(384, 225);
            this.btnDessets.Name = "btnDessets";
            this.btnDessets.Size = new System.Drawing.Size(215, 42);
            this.btnDessets.TabIndex = 3;
            this.btnDessets.Text = "Desserts";
            this.btnDessets.UseVisualStyleBackColor = false;
            this.btnDessets.Click += new System.EventHandler(this.btnDessets_Click);
            // 
            // btnBeverages
            // 
            this.btnBeverages.BackColor = System.Drawing.Color.PowderBlue;
            this.btnBeverages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBeverages.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnBeverages.Location = new System.Drawing.Point(629, 225);
            this.btnBeverages.Name = "btnBeverages";
            this.btnBeverages.Size = new System.Drawing.Size(215, 42);
            this.btnBeverages.TabIndex = 4;
            this.btnBeverages.Text = "Beverages";
            this.btnBeverages.UseVisualStyleBackColor = false;
            this.btnBeverages.Click += new System.EventHandler(this.btnBeverages_Click);
            // 
            // groupBoxCategory
            // 
            this.groupBoxCategory.BackColor = System.Drawing.Color.MistyRose;
            this.groupBoxCategory.Controls.Add(this.dataGridViewMenu);
            this.groupBoxCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCategory.Location = new System.Drawing.Point(145, 308);
            this.groupBoxCategory.Name = "groupBoxCategory";
            this.groupBoxCategory.Size = new System.Drawing.Size(699, 539);
            this.groupBoxCategory.TabIndex = 5;
            this.groupBoxCategory.TabStop = false;
            this.groupBoxCategory.Text = "Main Course";
            // 
            // dataGridViewMenu
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewMenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMenu.ColumnHeadersHeight = 35;
            this.dataGridViewMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProductId,
            this.ColumnProductName,
            this.ColumnProductPrice});
            this.dataGridViewMenu.Location = new System.Drawing.Point(40, 54);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMenu.RowHeadersWidth = 60;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridViewMenu.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewMenu.RowTemplate.Height = 24;
            this.dataGridViewMenu.Size = new System.Drawing.Size(623, 450);
            this.dataGridViewMenu.TabIndex = 14;
            this.dataGridViewMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenu_CellClick);
            // 
            // ColumnProductId
            // 
            this.ColumnProductId.HeaderText = "ProductID";
            this.ColumnProductId.Name = "ColumnProductId";
            this.ColumnProductId.ReadOnly = true;
            this.ColumnProductId.Width = 123;
            // 
            // ColumnProductName
            // 
            this.ColumnProductName.HeaderText = "ProductName";
            this.ColumnProductName.Name = "ColumnProductName";
            this.ColumnProductName.ReadOnly = true;
            this.ColumnProductName.Width = 150;
            // 
            // ColumnProductPrice
            // 
            this.ColumnProductPrice.HeaderText = "ProductPrice";
            this.ColumnProductPrice.Name = "ColumnProductPrice";
            this.ColumnProductPrice.ReadOnly = true;
            this.ColumnProductPrice.Width = 145;
            // 
            // btnRemoveSelectedProduct
            // 
            this.btnRemoveSelectedProduct.AutoSize = true;
            this.btnRemoveSelectedProduct.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRemoveSelectedProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveSelectedProduct.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveSelectedProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveSelectedProduct.Image")));
            this.btnRemoveSelectedProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveSelectedProduct.Location = new System.Drawing.Point(1097, 666);
            this.btnRemoveSelectedProduct.Name = "btnRemoveSelectedProduct";
            this.btnRemoveSelectedProduct.Size = new System.Drawing.Size(237, 64);
            this.btnRemoveSelectedProduct.TabIndex = 7;
            this.btnRemoveSelectedProduct.Text = "Remove product";
            this.btnRemoveSelectedProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveSelectedProduct.UseVisualStyleBackColor = false;
            this.btnRemoveSelectedProduct.Click += new System.EventHandler(this.btnRemoveSelectedProduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1092, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bill";
            // 
            // btnProceedOrder
            // 
            this.btnProceedOrder.AutoSize = true;
            this.btnProceedOrder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnProceedOrder.Enabled = false;
            this.btnProceedOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProceedOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnProceedOrder.Image")));
            this.btnProceedOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProceedOrder.Location = new System.Drawing.Point(1097, 773);
            this.btnProceedOrder.Name = "btnProceedOrder";
            this.btnProceedOrder.Size = new System.Drawing.Size(226, 70);
            this.btnProceedOrder.TabIndex = 9;
            this.btnProceedOrder.Text = "Proceed with order";
            this.btnProceedOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProceedOrder.UseVisualStyleBackColor = false;
            this.btnProceedOrder.Click += new System.EventHandler(this.btnProceedOrder_Click);
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.BackColor = System.Drawing.Color.LightCoral;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTotalPrice.Location = new System.Drawing.Point(1092, 603);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(173, 29);
            this.lbTotalPrice.TabIndex = 10;
            this.lbTotalPrice.Text = "Total price ---";
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.AutoSize = true;
            this.btnCancelOrder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancelOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelOrder.Image")));
            this.btnCancelOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelOrder.Location = new System.Drawing.Point(1402, 666);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(182, 64);
            this.btnCancelOrder.TabIndex = 11;
            this.btnCancelOrder.Text = "Cancel order";
            this.btnCancelOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // dataGridViewBill
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewBill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CulumnProductName,
            this.ColumnPrice,
            this.ColumnQty,
            this.ColumnTotal});
            this.dataGridViewBill.Location = new System.Drawing.Point(1092, 225);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewBill.RowHeadersWidth = 60;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridViewBill.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewBill.RowTemplate.Height = 24;
            this.dataGridViewBill.Size = new System.Drawing.Size(563, 339);
            this.dataGridViewBill.TabIndex = 1;
            // 
            // CulumnProductName
            // 
            this.CulumnProductName.HeaderText = "ProductName";
            this.CulumnProductName.Name = "CulumnProductName";
            this.CulumnProductName.ReadOnly = true;
            this.CulumnProductName.Width = 165;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "Price";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            this.ColumnPrice.Width = 92;
            // 
            // ColumnQty
            // 
            this.ColumnQty.HeaderText = "Qty";
            this.ColumnQty.Name = "ColumnQty";
            this.ColumnQty.ReadOnly = true;
            this.ColumnQty.Width = 77;
            // 
            // ColumnTotal
            // 
            this.ColumnTotal.HeaderText = "Total";
            this.ColumnTotal.Name = "ColumnTotal";
            this.ColumnTotal.ReadOnly = true;
            this.ColumnTotal.Width = 90;
            // 
            // numericUpDownQty
            // 
            this.numericUpDownQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownQty.Location = new System.Drawing.Point(885, 752);
            this.numericUpDownQty.Name = "numericUpDownQty";
            this.numericUpDownQty.Size = new System.Drawing.Size(86, 41);
            this.numericUpDownQty.TabIndex = 15;
            this.numericUpDownQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQty.ValueChanged += new System.EventHandler(this.numericUpDownQty_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(881, 706);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Quantity:";
            // 
            // comboBoxStoreId
            // 
            this.comboBoxStoreId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStoreId.Location = new System.Drawing.Point(262, 65);
            this.comboBoxStoreId.Name = "comboBoxStoreId";
            this.comboBoxStoreId.Size = new System.Drawing.Size(112, 28);
            this.comboBoxStoreId.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MistyRose;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(141, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Store ID:";
            // 
            // Cafeteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1829, 874);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxStoreId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownQty);
            this.Controls.Add(this.dataGridViewBill);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.btnProceedOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemoveSelectedProduct);
            this.Controls.Add(this.groupBoxCategory);
            this.Controls.Add(this.btnBeverages);
            this.Controls.Add(this.btnDessets);
            this.Controls.Add(this.btnMainCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Cafeteria";
            this.Text = "Cafeteria";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMainCourse;
        private System.Windows.Forms.Button btnDessets;
        private System.Windows.Forms.Button btnBeverages;
        private System.Windows.Forms.GroupBox groupBoxCategory;
        private System.Windows.Forms.Button btnRemoveSelectedProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProceedOrder;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.DataGridView dataGridViewBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn CulumnProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxStoreId;
        private System.Windows.Forms.Label label4;
    }
}

