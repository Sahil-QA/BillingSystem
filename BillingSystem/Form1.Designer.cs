namespace BillingSystem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.itemName = new System.Windows.Forms.TextBox();
            this.itemQantity = new System.Windows.Forms.TextBox();
            this.itemPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.add_item = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hsnCode = new System.Windows.Forms.TextBox();
            this.new_Order = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.labourValue = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteItem = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.productInfoDataSet = new BillingSystem.productInfoDataSet();
            this.grandTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BSprintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.BSprintDocument = new System.Drawing.Printing.PrintDocument();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.stateCode = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.invoiceDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.invoiceNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.transpostMode = new System.Windows.Forms.TextBox();
            this.dateOfSupply = new System.Windows.Forms.TextBox();
            this.vehicalNo = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.state2Code = new System.Windows.Forms.TextBox();
            this.state2 = new System.Windows.Forms.TextBox();
            this.gstinNo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.nameAndAddress = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.placeOfSupply = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.sgstAmount = new System.Windows.Forms.Label();
            this.cgstAmount = new System.Windows.Forms.Label();
            this.allProductTotalAmount = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.corName = new System.Windows.Forms.Label();
            this.addressOfCorp = new System.Windows.Forms.Label();
            this.GstIN = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.SearchInvoice = new System.Windows.Forms.TextBox();
            this.ShowDataBtn = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.sweetDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sweetDataTableAdapter = new BillingSystem.productInfoDataSetTableAdapters.SweetDataTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoDataSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sweetDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name :";
            // 
            // itemName
            // 
            this.itemName.Location = new System.Drawing.Point(93, 37);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(145, 20);
            this.itemName.TabIndex = 1;
            this.itemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onEnter);
            // 
            // itemQantity
            // 
            this.itemQantity.Location = new System.Drawing.Point(93, 82);
            this.itemQantity.Name = "itemQantity";
            this.itemQantity.Size = new System.Drawing.Size(91, 20);
            this.itemQantity.TabIndex = 2;
            this.itemQantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QtyToRate);
            // 
            // itemPrice
            // 
            this.itemPrice.Location = new System.Drawing.Point(93, 125);
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Size = new System.Drawing.Size(91, 20);
            this.itemPrice.TabIndex = 3;
            this.itemPrice.TextChanged += new System.EventHandler(this.itemPrice_TextChanged);
            this.itemPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itemPrice_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = " CGST  is 2.5%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Qty(kg) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rate : ";
            // 
            // add_item
            // 
            this.add_item.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.add_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_item.Location = new System.Drawing.Point(267, 143);
            this.add_item.Name = "add_item";
            this.add_item.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.add_item.Size = new System.Drawing.Size(181, 95);
            this.add_item.TabIndex = 8;
            this.add_item.Text = "ADD  Item   Total";
            this.add_item.UseVisualStyleBackColor = false;
            this.add_item.Click += new System.EventHandler(this.add_Item);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hsnCode);
            this.groupBox1.Controls.Add(this.new_Order);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.add_item);
            this.groupBox1.Controls.Add(this.labourValue);
            this.groupBox1.Controls.Add(this.itemName);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.itemQantity);
            this.groupBox1.Controls.Add(this.itemPrice);
            this.groupBox1.Location = new System.Drawing.Point(12, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 324);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Entry";
            // 
            // hsnCode
            // 
            this.hsnCode.Location = new System.Drawing.Point(93, 284);
            this.hsnCode.Name = "hsnCode";
            this.hsnCode.Size = new System.Drawing.Size(91, 20);
            this.hsnCode.TabIndex = 17;
            // 
            // new_Order
            // 
            this.new_Order.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.new_Order.Enabled = false;
            this.new_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_Order.Location = new System.Drawing.Point(267, 19);
            this.new_Order.Name = "new_Order";
            this.new_Order.Size = new System.Drawing.Size(181, 95);
            this.new_Order.TabIndex = 11;
            this.new_Order.Text = "New Order";
            this.new_Order.UseVisualStyleBackColor = false;
            this.new_Order.Click += new System.EventHandler(this.resetValues_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(23, 287);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "HSN Code :";
            // 
            // labourValue
            // 
            this.labourValue.Location = new System.Drawing.Point(93, 248);
            this.labourValue.Name = "labourValue";
            this.labourValue.Size = new System.Drawing.Size(91, 20);
            this.labourValue.TabIndex = 22;
            this.labourValue.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 251);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 13);
            this.label21.TabIndex = 19;
            this.label21.Text = "Labour/Cartage :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(152, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = " SGST  is 2.5%";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteItem);
            this.groupBox2.Controls.Add(this.dataGridView);
            this.groupBox2.Location = new System.Drawing.Point(478, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(854, 324);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // deleteItem
            // 
            this.deleteItem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.deleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItem.Location = new System.Drawing.Point(666, 284);
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.deleteItem.Size = new System.Drawing.Size(182, 34);
            this.deleteItem.TabIndex = 24;
            this.deleteItem.Text = "Delete Selected Item";
            this.deleteItem.UseVisualStyleBackColor = false;
            this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView.Location = new System.Drawing.Point(3, 16);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(848, 305);
            this.dataGridView.TabIndex = 14;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            this.dataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseDown);
            // 
            // productInfoDataSet
            // 
            this.productInfoDataSet.DataSetName = "productInfoDataSet";
            this.productInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grandTotal
            // 
            this.grandTotal.AutoSize = true;
            this.grandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandTotal.Location = new System.Drawing.Point(138, 131);
            this.grandTotal.Name = "grandTotal";
            this.grandTotal.Size = new System.Drawing.Size(14, 13);
            this.grandTotal.TabIndex = 17;
            this.grandTotal.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Grand Total :";
            // 
            // BSprintPreviewDialog
            // 
            this.BSprintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.BSprintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.BSprintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.BSprintPreviewDialog.Enabled = true;
            this.BSprintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("BSprintPreviewDialog.Icon")));
            this.BSprintPreviewDialog.Name = "BSprintPreviewDialog";
            this.BSprintPreviewDialog.Visible = false;
            // 
            // BSprintDocument
            // 
            this.BSprintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.BSprintDocument_PrintPage);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.stateCode);
            this.groupBox4.Controls.Add(this.state);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.invoiceDate);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.invoiceNo);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(12, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(401, 100);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reverse Charge";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "State Code : ";
            // 
            // stateCode
            // 
            this.stateCode.Location = new System.Drawing.Point(291, 65);
            this.stateCode.Name = "stateCode";
            this.stateCode.Size = new System.Drawing.Size(100, 20);
            this.stateCode.TabIndex = 6;
            this.stateCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StateCodeToTransportMode);
            // 
            // state
            // 
            this.state.Location = new System.Drawing.Point(80, 65);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(100, 20);
            this.state.TabIndex = 5;
            this.state.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StateToCode);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "State : ";
            // 
            // invoiceDate
            // 
            this.invoiceDate.Location = new System.Drawing.Point(291, 17);
            this.invoiceDate.Name = "invoiceDate";
            this.invoiceDate.Size = new System.Drawing.Size(100, 20);
            this.invoiceDate.TabIndex = 3;
            this.invoiceDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DateToState);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Invoice Date :";
            // 
            // invoiceNo
            // 
            this.invoiceNo.Location = new System.Drawing.Point(80, 17);
            this.invoiceNo.Name = "invoiceNo";
            this.invoiceNo.Size = new System.Drawing.Size(100, 20);
            this.invoiceNo.TabIndex = 1;
            this.invoiceNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.invoiceNoToDate);
            this.invoiceNo.Leave += new System.EventHandler(this.invoiceCheck);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Invoice No. :";
            // 
            // transpostMode
            // 
            this.transpostMode.Location = new System.Drawing.Point(59, 19);
            this.transpostMode.Name = "transpostMode";
            this.transpostMode.Size = new System.Drawing.Size(100, 20);
            this.transpostMode.TabIndex = 8;
            this.transpostMode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.transpostMode_KeyDown);
            // 
            // dateOfSupply
            // 
            this.dateOfSupply.Location = new System.Drawing.Point(59, 65);
            this.dateOfSupply.Name = "dateOfSupply";
            this.dateOfSupply.Size = new System.Drawing.Size(100, 20);
            this.dateOfSupply.TabIndex = 10;
            this.dateOfSupply.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateOfSupply_KeyDown);
            // 
            // vehicalNo
            // 
            this.vehicalNo.Location = new System.Drawing.Point(259, 19);
            this.vehicalNo.Name = "vehicalNo";
            this.vehicalNo.Size = new System.Drawing.Size(100, 20);
            this.vehicalNo.TabIndex = 9;
            this.vehicalNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vehicalNo_KeyDown);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.state2Code);
            this.groupBox5.Controls.Add(this.state2);
            this.groupBox5.Controls.Add(this.gstinNo);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.nameAndAddress);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Location = new System.Drawing.Point(790, 83);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(542, 100);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Details of Receiver Billed to/Consinnee Shipped to";
            // 
            // state2Code
            // 
            this.state2Code.Location = new System.Drawing.Point(436, 65);
            this.state2Code.Name = "state2Code";
            this.state2Code.Size = new System.Drawing.Size(100, 20);
            this.state2Code.TabIndex = 17;
            this.state2Code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.state2CodeToNewOrder);
            // 
            // state2
            // 
            this.state2.Location = new System.Drawing.Point(261, 65);
            this.state2.Name = "state2";
            this.state2.Size = new System.Drawing.Size(100, 20);
            this.state2.TabIndex = 16;
            this.state2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.state2_KeyDown);
            // 
            // gstinNo
            // 
            this.gstinNo.Location = new System.Drawing.Point(100, 65);
            this.gstinNo.Name = "gstinNo";
            this.gstinNo.Size = new System.Drawing.Size(100, 20);
            this.gstinNo.TabIndex = 15;
            this.gstinNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gstinNo_KeyDown);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(367, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "State Code:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(220, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "State:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(31, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "GSTIN No.:";
            // 
            // nameAndAddress
            // 
            this.nameAndAddress.Location = new System.Drawing.Point(100, 16);
            this.nameAndAddress.Name = "nameAndAddress";
            this.nameAndAddress.Size = new System.Drawing.Size(436, 20);
            this.nameAndAddress.TabIndex = 12;
            this.nameAndAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameAndAddress_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Name And Add. :";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.transpostMode);
            this.groupBox6.Controls.Add(this.vehicalNo);
            this.groupBox6.Controls.Add(this.dateOfSupply);
            this.groupBox6.Controls.Add(this.placeOfSupply);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(419, 83);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(365, 100);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            // 
            // placeOfSupply
            // 
            this.placeOfSupply.Location = new System.Drawing.Point(259, 65);
            this.placeOfSupply.Name = "placeOfSupply";
            this.placeOfSupply.Size = new System.Drawing.Size(100, 20);
            this.placeOfSupply.TabIndex = 11;
            this.placeOfSupply.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlaceOfSupplyToName);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(8, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 31);
            this.label10.TabIndex = 8;
            this.label10.Text = "Transport   Mode :";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 27);
            this.label11.TabIndex = 9;
            this.label11.Text = "Date of Supply :";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(194, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 26);
            this.label12.TabIndex = 10;
            this.label12.Text = "Place of Supply :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(187, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Vehical No. :";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.sgstAmount);
            this.groupBox7.Controls.Add(this.cgstAmount);
            this.groupBox7.Controls.Add(this.allProductTotalAmount);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.grandTotal);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Location = new System.Drawing.Point(478, 519);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(529, 184);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Price(RS)";
            // 
            // sgstAmount
            // 
            this.sgstAmount.AutoSize = true;
            this.sgstAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sgstAmount.Location = new System.Drawing.Point(138, 105);
            this.sgstAmount.Name = "sgstAmount";
            this.sgstAmount.Size = new System.Drawing.Size(14, 13);
            this.sgstAmount.TabIndex = 25;
            this.sgstAmount.Text = "0";
            // 
            // cgstAmount
            // 
            this.cgstAmount.AutoSize = true;
            this.cgstAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cgstAmount.Location = new System.Drawing.Point(138, 76);
            this.cgstAmount.Name = "cgstAmount";
            this.cgstAmount.Size = new System.Drawing.Size(14, 13);
            this.cgstAmount.TabIndex = 24;
            this.cgstAmount.Text = "0";
            // 
            // allProductTotalAmount
            // 
            this.allProductTotalAmount.AutoSize = true;
            this.allProductTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allProductTotalAmount.Location = new System.Drawing.Point(138, 44);
            this.allProductTotalAmount.Name = "allProductTotalAmount";
            this.allProductTotalAmount.Size = new System.Drawing.Size(14, 13);
            this.allProductTotalAmount.TabIndex = 23;
            this.allProductTotalAmount.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(23, 105);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(81, 13);
            this.label23.TabIndex = 21;
            this.label23.Text = "SGST Amount :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 76);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 13);
            this.label22.TabIndex = 20;
            this.label22.Text = "CGST  Amount :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(52, 44);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 13);
            this.label20.TabIndex = 18;
            this.label20.Text = "Amount  :";
            // 
            // corName
            // 
            this.corName.AutoSize = true;
            this.corName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.corName.Location = new System.Drawing.Point(477, 9);
            this.corName.Name = "corName";
            this.corName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.corName.Size = new System.Drawing.Size(237, 39);
            this.corName.TabIndex = 10;
            this.corName.Text = "Billing System";
            this.corName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addressOfCorp
            // 
            this.addressOfCorp.AutoSize = true;
            this.addressOfCorp.Location = new System.Drawing.Point(504, 48);
            this.addressOfCorp.Name = "addressOfCorp";
            this.addressOfCorp.Size = new System.Drawing.Size(89, 13);
            this.addressOfCorp.TabIndex = 21;
            this.addressOfCorp.Text = "A Simple Solution";
            // 
            // GstIN
            // 
            this.GstIN.AutoSize = true;
            this.GstIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GstIN.Location = new System.Drawing.Point(1141, 48);
            this.GstIN.Name = "GstIN";
            this.GstIN.Size = new System.Drawing.Size(191, 13);
            this.GstIN.TabIndex = 22;
            this.GstIN.Text = "GSTIN NO.  02ADZPN7340J2Z2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Location = new System.Drawing.Point(12, 660);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 43);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(310, 16);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(138, 13);
            this.label26.TabIndex = 13;
            this.label26.Text = "Default HSN Code is 20001";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(21, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(292, 64);
            this.button4.TabIndex = 12;
            this.button4.Text = "PrintPreview\r\n";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.printPreView);
            // 
            // PrintButton
            // 
            this.PrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.Image = ((System.Drawing.Image)(resources.GetObject("PrintButton.Image")));
            this.PrintButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintButton.Location = new System.Drawing.Point(21, 104);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(292, 64);
            this.PrintButton.TabIndex = 11;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.PrintButton);
            this.groupBox8.Controls.Add(this.button4);
            this.groupBox8.Location = new System.Drawing.Point(1013, 519);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(319, 184);
            this.groupBox8.TabIndex = 24;
            this.groupBox8.TabStop = false;
            // 
            // SearchInvoice
            // 
            this.SearchInvoice.Location = new System.Drawing.Point(139, 48);
            this.SearchInvoice.Name = "SearchInvoice";
            this.SearchInvoice.Size = new System.Drawing.Size(91, 20);
            this.SearchInvoice.TabIndex = 23;
            // 
            // ShowDataBtn
            // 
            this.ShowDataBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ShowDataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDataBtn.Location = new System.Drawing.Point(51, 89);
            this.ShowDataBtn.Name = "ShowDataBtn";
            this.ShowDataBtn.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.ShowDataBtn.Size = new System.Drawing.Size(179, 39);
            this.ShowDataBtn.TabIndex = 23;
            this.ShowDataBtn.Text = "Show Data";
            this.ShowDataBtn.UseVisualStyleBackColor = false;
            this.ShowDataBtn.Click += new System.EventHandler(this.ShowDataBtn_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(34, 51);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(94, 13);
            this.label24.TabIndex = 20;
            this.label24.Text = "Invoice Number :  ";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label24);
            this.groupBox9.Controls.Add(this.ShowDataBtn);
            this.groupBox9.Controls.Add(this.SearchInvoice);
            this.groupBox9.Location = new System.Drawing.Point(12, 519);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(454, 135);
            this.groupBox9.TabIndex = 24;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Previous Invoice Data  ";
            // 
            // sweetDataBindingSource
            // 
            this.sweetDataBindingSource.DataMember = "SweetData";
            this.sweetDataBindingSource.DataSource = this.productInfoDataSet;
            // 
            // sweetDataTableAdapter
            // 
            this.sweetDataTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1354, 736);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GstIN);
            this.Controls.Add(this.addressOfCorp);
            this.Controls.Add(this.corName);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sweetDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.TextBox itemQantity;
        private System.Windows.Forms.TextBox itemPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add_item;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button new_Order;
        private System.Windows.Forms.PrintPreviewDialog BSprintPreviewDialog;
        private System.Drawing.Printing.PrintDocument BSprintDocument;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox stateCode;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox invoiceDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox invoiceNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox dateOfSupply;
        private System.Windows.Forms.TextBox vehicalNo;
        private System.Windows.Forms.TextBox transpostMode;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox placeOfSupply;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox nameAndAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox state2;
        private System.Windows.Forms.TextBox gstinNo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label grandTotal;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox state2Code;
        private System.Windows.Forms.TextBox hsnCode;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label corName;
        private System.Windows.Forms.Label addressOfCorp;
        private System.Windows.Forms.Label GstIN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label sgstAmount;
        private System.Windows.Forms.Label cgstAmount;
        private System.Windows.Forms.Label allProductTotalAmount;
        private System.Windows.Forms.TextBox labourValue;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox SearchInvoice;
        private System.Windows.Forms.Button ShowDataBtn;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button deleteItem;
        private productInfoDataSet productInfoDataSet;
        private System.Windows.Forms.BindingSource sweetDataBindingSource;
        private productInfoDataSetTableAdapters.SweetDataTableAdapter sweetDataTableAdapter;
    }
}

