namespace LoanStand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.borrow = new System.Windows.Forms.Button();
            this.numericUpDownQty = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownDays = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.items = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priceperday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.remove = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.bill = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxReturn = new System.Windows.Forms.GroupBox();
            this.txtbProductIdReturn = new System.Windows.Forms.TextBox();
            this.txtbAmountReturn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill)).BeginInit();
            this.groupBoxReturn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(421, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 113);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(68, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Items";
            // 
            // borrow
            // 
            this.borrow.BackColor = System.Drawing.Color.PaleGreen;
            this.borrow.Enabled = false;
            this.borrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.borrow.Location = new System.Drawing.Point(890, 459);
            this.borrow.Name = "borrow";
            this.borrow.Size = new System.Drawing.Size(197, 77);
            this.borrow.TabIndex = 5;
            this.borrow.Text = "Borrow";
            this.borrow.UseVisualStyleBackColor = false;
            this.borrow.Click += new System.EventHandler(this.borrow_Click);
            // 
            // numericUpDownQty
            // 
            this.numericUpDownQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownQty.Location = new System.Drawing.Point(676, 457);
            this.numericUpDownQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownQty.Name = "numericUpDownQty";
            this.numericUpDownQty.Size = new System.Drawing.Size(45, 34);
            this.numericUpDownQty.TabIndex = 6;
            this.numericUpDownQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQty.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(556, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(734, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Days";
            // 
            // numericUpDownDays
            // 
            this.numericUpDownDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDays.Location = new System.Drawing.Point(810, 458);
            this.numericUpDownDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownDays.Name = "numericUpDownDays";
            this.numericUpDownDays.Size = new System.Drawing.Size(48, 34);
            this.numericUpDownDays.TabIndex = 9;
            this.numericUpDownDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDays.ValueChanged += new System.EventHandler(this.numericUpDownDays_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(556, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            // 
            // items
            // 
            this.items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.Productname,
            this.Priceperday});
            this.items.Location = new System.Drawing.Point(62, 222);
            this.items.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.items.Name = "items";
            this.items.RowTemplate.Height = 28;
            this.items.Size = new System.Drawing.Size(427, 212);
            this.items.TabIndex = 12;
            this.items.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.items.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.items_CellContentClick);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            // 
            // Productname
            // 
            this.Productname.HeaderText = "Product name";
            this.Productname.Name = "Productname";
            // 
            // Priceperday
            // 
            this.Priceperday.HeaderText = "Price";
            this.Priceperday.Name = "Priceperday";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 10);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 33);
            this.comboBox1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Loan Stand ID";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(632, 508);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 30);
            this.textBox1.TabIndex = 16;
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.Color.Coral;
            this.remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.Location = new System.Drawing.Point(172, 474);
            this.remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(161, 74);
            this.remove.TabIndex = 17;
            this.remove.Text = "Remove item";
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Tomato;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(362, 474);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(150, 74);
            this.cancel.TabIndex = 18;
            this.cancel.Text = "Cancel Order";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // bill
            // 
            this.bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.price1,
            this.qty,
            this.days,
            this.total});
            this.bill.Location = new System.Drawing.Point(583, 207);
            this.bill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bill.Name = "bill";
            this.bill.RowTemplate.Height = 28;
            this.bill.Size = new System.Drawing.Size(724, 212);
            this.bill.TabIndex = 19;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product name";
            this.Product.Name = "Product";
            // 
            // price1
            // 
            this.price1.HeaderText = "Price";
            this.price1.Name = "price1";
            // 
            // qty
            // 
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            // 
            // days
            // 
            this.days.HeaderText = "Days";
            this.days.Name = "days";
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(578, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Bill";
            // 
            // groupBoxReturn
            // 
            this.groupBoxReturn.Controls.Add(this.btnReturn);
            this.groupBoxReturn.Controls.Add(this.label8);
            this.groupBoxReturn.Controls.Add(this.label7);
            this.groupBoxReturn.Controls.Add(this.txtbAmountReturn);
            this.groupBoxReturn.Controls.Add(this.txtbProductIdReturn);
            this.groupBoxReturn.Location = new System.Drawing.Point(62, 580);
            this.groupBoxReturn.Name = "groupBoxReturn";
            this.groupBoxReturn.Size = new System.Drawing.Size(563, 125);
            this.groupBoxReturn.TabIndex = 21;
            this.groupBoxReturn.TabStop = false;
            this.groupBoxReturn.Text = "Return Product";
            // 
            // txtbProductIdReturn
            // 
            this.txtbProductIdReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbProductIdReturn.Location = new System.Drawing.Point(184, 35);
            this.txtbProductIdReturn.Name = "txtbProductIdReturn";
            this.txtbProductIdReturn.Size = new System.Drawing.Size(100, 27);
            this.txtbProductIdReturn.TabIndex = 0;
            // 
            // txtbAmountReturn
            // 
            this.txtbAmountReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbAmountReturn.Location = new System.Drawing.Point(184, 84);
            this.txtbAmountReturn.Name = "txtbAmountReturn";
            this.txtbAmountReturn.Size = new System.Drawing.Size(100, 27);
            this.txtbAmountReturn.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(26, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Product Id:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(26, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Amount returned:";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.SandyBrown;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReturn.Location = new System.Drawing.Point(368, 51);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(144, 40);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1410, 745);
            this.Controls.Add(this.groupBoxReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bill);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.items);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownDays);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownQty);
            this.Controls.Add(this.borrow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill)).EndInit();
            this.groupBoxReturn.ResumeLayout(false);
            this.groupBoxReturn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button borrow;
        private System.Windows.Forms.NumericUpDown numericUpDownQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownDays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView items;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priceperday;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DataGridView bill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn price1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn days;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxReturn;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbAmountReturn;
        private System.Windows.Forms.TextBox txtbProductIdReturn;
    }
}

