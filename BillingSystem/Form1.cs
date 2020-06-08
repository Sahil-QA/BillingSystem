using BillingSystem.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace BillingSystem
{
    public partial class Form1 : Form
    {
        //private OleDbConnection connection = new OleDbConnection();



        public Form1()
        {
            InitializeComponent();

            
        }
       


        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'productInfoDataSet.SweetData' table. You can move, or remove it, as needed.
        //    this.sweetDataTableAdapter.Fill(this.productInfoDataSet.SweetData);


           
        //    //connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\sahilkhan\Documents\Access\productInfo.accdb; Persist Security Info = False; ";
            
        //}
           
        
        
        
        

        //Variables
        int countValue = 0;
        int num = 1; 
        private List<Allitems> GridItems = new List<Allitems>();
        double itemProduct;
        double totalPrice;
        double itemFinalPrice;
        double cgstCalValue;
        double valuecgst;
        double valuesgst;
        double sgstCalValue;
        double calculatedCgst;
        double calculatedSgst;
        double totalGST;
        double labourPrice;
        bool QtyTypeCheck;
        bool PriceTypeCheck;
        int index;
        DataGridViewRow selectedRow;


        /// First Focus



        private void add_Item(object sender, EventArgs e)
        {

            if (invoiceNo.Text == string.Empty)
            {
                MessageBox.Show("Enter Invoice Number", "Error", MessageBoxButtons.OK);
            }
            else
            {
                new_Order.Enabled = true;

                if (itemName.Text != string.Empty && QtyTypeCheck == true && PriceTypeCheck == true && itemQantity.Text != string.Empty && itemQantity.Text != string.Empty)
                {
                    num++;
                }

                if (showMessage())
                {
                    // hsn default Value
                    if (hsnCode.Text == string.Empty && gstinNo.Text == string.Empty)
                    {
                        hsnCode.Text = "20001";
                        gstinNo.Text  = "02ADZPN7340J2Z2";
                    }


                    dataGridConnect();

                    //try
                    //{
                    //    OleDbCommand command = connection.CreateCommand();
                    //    connection.Open();
                    //    double Invoiceval = Convert.ToDouble(invoiceNo.Text);
                    //    command.CommandText = "Insert into SweetData (SrNo, InvoiceNo, ProductName, Rate, Qantity, Amount) values('"+num+"', '"+ Invoiceval+"', '"+ itemName.Text + "', '"+ itemPrice.Text + "','"+itemQantity.Text + "','" +itemProduct+ "')";
                    //    command.Connection = connection;
                    //    command.ExecuteNonQuery();

                    //    connection.Close();

                    //}catch(Exception ex)
                    //{
                    //    MessageBox.Show("" + ex);
                    //}

                    //try
                    //{
                    //    connection.Open();

                    //    OleDbCommand com = new OleDbCommand();

                    //    string query = "Select * from SweetData ";
                    //    com.CommandText = query;
                    //    com.Connection = connection;
                    //    com.ExecuteNonQuery();

                    //    OleDbDataAdapter da = new OleDbDataAdapter(com);
                    //    DataTable dt = new DataTable();
                    //    da.Fill(dt);
                    //    dataGridView.DataSource = dt;

                    //    connection.Close();
                    //}
                    //catch(Exception ex)
                    //{
                    //    MessageBox.Show("" + ex);
                    //}
                }


                gstData();



                itemName.Clear();
                itemQantity.Clear();
                itemPrice.Clear();

                itemName.Focus();

                add_item.Enabled = false;

            }


        }

        private void resetValues_Click(object sender, EventArgs e)
        {
            countValue++;
            num = 0;


            itemName.Clear();
            itemQantity.Clear();
            itemPrice.Clear();
            invoiceNo.Clear();

            totalPrice = 0;
            itemFinalPrice = 0;
            itemProduct = 0;




            itemName.Focus();



            /// AMOUNT SHOW ITEMS
            allProductTotalAmount.Text = "0";
            cgstAmount.Text = "0";
            sgstAmount.Text = "0";
            grandTotal.Text = "0";


            dataGridView.DataSource = null;
            GridItems.Clear();


        }





        private void valueEntry()
        {

            if (itemQantity.Text != string.Empty && itemPrice.Text != string.Empty)
            {
                double rate = Convert.ToDouble(itemPrice.Text);
                double qty = Convert.ToDouble(itemQantity.Text);

                itemProduct = qty * rate;

            }

            itemFinalPrice = itemFinalPrice + itemProduct;




        }


        /// 
        /// CalCulations
        ///

        private void gstData()
        {

            valueEntry();


            //CGST

            valuecgst = 0.025;
            cgstCalValue = itemFinalPrice * valuecgst;




            //SGST

            valuesgst = 0.025;
            sgstCalValue = itemFinalPrice * valuesgst;


            //CGST AMOUNT...........
            calculatedCgst =  cgstCalValue;
            //SGST AMOUNT............
            calculatedSgst =  sgstCalValue;
            //Total GST
            totalGST = cgstCalValue + sgstCalValue;


            ///////////////////////////////////////      Labour Amount ////////////////
            if (labourValue.Text == string.Empty)
            {
                labourPrice = 0;
            }
            else
            {
                labourPrice = Convert.ToDouble(labourValue.Text);
            }

            totalPrice = itemFinalPrice + totalGST + labourPrice;

            //// Show CGST AND SGST AMOUNT
            cgstAmount.Text = calculatedCgst.ToString();
            sgstAmount.Text = calculatedSgst.ToString();

            //// SHOW ALL PRODUCT SUM without GST
            allProductTotalAmount.Text = itemFinalPrice.ToString();

            // Total Price with GST
            grandTotal.Text = totalPrice.ToString();

           
        }
        

        ///Dialog Message on empty textArea

        private bool showMessage()
        {


            if (itemName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Product Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                itemName.Focus();
                return false;
            }


            if (itemQantity.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Qantity of the Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                itemQantity.Focus();
                return false;
            }
            else
            {
                double temp;
                bool isNumber = double.TryParse(itemQantity.Text.Trim(), out temp);

                QtyTypeCheck = isNumber;

                if (!isNumber)
                {

                    MessageBox.Show("Enter a Numeric Qantity Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    itemQantity.Clear();
                    itemQantity.Focus();


                    return false;
                }
            }

            if (itemPrice.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Price of the Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                itemPrice.Focus();
                return false;
            }
            else
            {
                double temp;
                bool isNumber = double.TryParse(itemPrice.Text.Trim(), out temp);

                PriceTypeCheck = isNumber;

                if (!isNumber)
                {

                    MessageBox.Show("Enter a Numeric Price Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    itemPrice.Clear();
                    itemPrice.Focus();


                    return false;
                }
                

            }


            return true;
        }


        // // // // // // // // // //             Data Grid View                // // // // / // / // //
        public void dataGridConnect()
        {


            Allitems items = new Allitems()
            {

                SrNo = num,
                ProductName = itemName.Text,
                Qantity = Convert.ToDouble(itemQantity.Text.Trim()),
                Rate = Convert.ToDouble(itemPrice.Text.Trim()),
                TotalAmount = Convert.ToDouble(itemQantity.Text.Trim()) * Convert.ToDouble(itemPrice.Text.Trim()),
                HsnCode = hsnCode.Text,
                CgstRate = "2.5%",
                SgstRate = "2.5%",
                CgstAmount = (((Convert.ToDouble(itemQantity.Text.Trim()) * Convert.ToDouble(itemPrice.Text.Trim())) * 0.025)),
                SgstAmount = (((Convert.ToDouble(itemQantity.Text.Trim()) * Convert.ToDouble(itemPrice.Text.Trim())) * 0.025))



            };

            GridItems.Add(items);

            dataGridView.DataSource = null;
            dataGridView.DataSource = GridItems;



        }



        private void itemPrice_TextChanged(object sender, EventArgs e)
        {
            add_item.Enabled = true;
        }


        //// //// //// //// ////                   EnterPress Events........... //// //// //// //// //// 
        private void onEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                itemQantity.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                new_Order.Focus();
            }
        }



        private void StateCodeToTransportMode(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                transpostMode.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                state.Focus();
            }
        }

        private void PlaceOfSupplyToName(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nameAndAddress.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                dateOfSupply.Focus();
            }
        }

        private void state2CodeToNewOrder(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                itemName.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                state2.Focus();
            }
        }

        private void invoiceNoToDate(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                invoiceDate.Focus();
            }
        }

        private void DateToState(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                state.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                invoiceNo.Focus();
            }
        }

        private void StateToCode(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                stateCode.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                invoiceDate.Focus();
            }
        }



        private void QtyToRate(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                itemName.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                itemPrice.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                new_Order.Focus();
            }

        }

        private void itemPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                itemQantity.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                add_item.Focus();
            }

            else if (e.KeyCode == Keys.Escape)
            {
                new_Order.Focus();
            }
        }

        private void transpostMode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                vehicalNo.Focus();

            }
            else if (e.KeyCode == Keys.Up)
            {
                stateCode.Focus();
            }
        }

        private void vehicalNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateOfSupply.Focus();

            }
            else if (e.KeyCode == Keys.Up)
            {
                transpostMode.Focus();
            }
        }

        private void dateOfSupply_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                placeOfSupply.Focus();

            }
            else if (e.KeyCode == Keys.Up)
            {
                vehicalNo.Focus();
            }
        }

        private void nameAndAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gstinNo.Focus();

            }
            else if (e.KeyCode == Keys.Up)
            {
                placeOfSupply.Focus();
            }
        }




        private void state2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                state2Code.Focus();

            }
            else if (e.KeyCode == Keys.Up)
            {
                gstinNo.Focus();
            }
        }

        private void gstinNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                state2.Focus();

            }
            else if (e.KeyCode == Keys.Up)
            {
                nameAndAddress.Focus();
            }
        }



        //
        //
        //......................................... PrintPreview And PrintDocument.................................

        private void printPreView(object sender, EventArgs e)
        {
            PrintPreviewDialog BSprintPreviewDialog = new PrintPreviewDialog();
            BSprintPreviewDialog.Document = BSprintDocument;
            
            if(BSprintPreviewDialog.IsDisposed == true)
            {
               BSprintPreviewDialog = new PrintPreviewDialog();
            }
            

            BSprintPreviewDialog.Show();
        }

        private void BSprintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Pen BlackPen = new Pen(Color.Black, 1);
            


            e.Graphics.DrawString("TAX INVOICE", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(410, 2));
            e.Graphics.DrawString("R.D.T. ENTERPRISES", new Font("Arial", 32, FontStyle.Regular), Brushes.Black, new Point(200, 8));


            e.Graphics.DrawString(addressOfCorp.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(255, 54));
            e.Graphics.DrawString(GstIN.Text, new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(700, 40));
            e.Graphics.DrawString("Phone : 0177-2841694", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(700, 20));

            //  e.Graphics.DrawString("Total Amount :" + totalAmount.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10, 10));
            

            // Reverse Charge
            e.Graphics.DrawString("Reverse Charge", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(10, 76));
            e.Graphics.DrawString("Invoce No.: ", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(10, 100));
            e.Graphics.DrawString(invoiceNo.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(80, 100));
            e.Graphics.DrawString("Invoce Date: ", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(210, 100));
            e.Graphics.DrawString(invoiceDate.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(290, 100));
            e.Graphics.DrawString("State : ", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(10, 124));
            e.Graphics.DrawString(state.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(80, 124));
            e.Graphics.DrawString("State Code: ", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(210, 124));
            e.Graphics.DrawString(stateCode.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(290, 124));

            //Transpotation Info
            e.Graphics.DrawString("Transport Mode ", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(430, 76));
            e.Graphics.DrawString(transpostMode.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(540, 76));
            e.Graphics.DrawString("Vehical NO. : ", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(430, 100));
            e.Graphics.DrawString(vehicalNo.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(520, 100));
            e.Graphics.DrawString("Date of Supply :", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(430, 124));
            e.Graphics.DrawString(dateOfSupply.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(530, 124));
            e.Graphics.DrawString("Place Of Supply :", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(600, 124));
            e.Graphics.DrawString(placeOfSupply.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(710, 124));


            //Details Of Receiver
            e.Graphics.DrawString("Details of Receiver Billed to/Consignee Shipped to", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(10, 150));
            e.Graphics.DrawString("Name & Address :", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(10, 174));
            e.Graphics.DrawString(nameAndAddress.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(130, 174));
            e.Graphics.DrawString("GSTINO :", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(180, 220));
            e.Graphics.DrawString(gstinNo.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(250, 220));
            e.Graphics.DrawString("State :", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(380, 220));
            e.Graphics.DrawString(state2.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(430, 220));
            e.Graphics.DrawString("State Code :", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(600, 220));
            e.Graphics.DrawString(state2.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(690, 220));

            //e.Graphics.DrawString(placeOfSupply.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(700, 124));




            // // // // // // // // // // //                       Lines......................... // // // // // 
            Point pointOne = new Point(0, 68);
            Point pointSecond = new Point(850, 68);

            Point p3 = new Point(0, 140);
            Point p4 = new Point(850, 140);

            Point p5 = new Point(425, 62);
            Point p6 = new Point(425, 140);

            Point p7 = new Point(0, 400);
            Point p8 = new Point(855, 400);

            Point p9 = new Point(0, 800);
            Point p10 = new Point(855, 800);

            // // Table Lines

            Point p11 = new Point(218, 240);
            Point p12 = new Point(218, 800);

            Point p13 = new Point(288, 240);
            Point p14 = new Point(288, 800);

            Point p15 = new Point(348, 240);
            Point p16 = new Point(348, 800);

    //Mid Line
            Point p17 = new Point(418, 240);
            Point p18 = new Point(418, 950);

            Point p19 = new Point(518, 240);
            Point p20 = new Point(518, 800);

            Point p21 = new Point(578, 260);
            Point p22 = new Point(578, 800);

            Point p23 = new Point(668, 240);
            Point p24 = new Point(668, 800);

            Point p25 = new Point(758, 260);
            Point p26 = new Point(758, 800);

            //// Below Table lines 

            Point p27 = new Point(418, 830);
            Point p28 = new Point(855, 830);

            Point p29 = new Point(418, 860);
            Point p30 = new Point(855, 860);

            Point p31 = new Point(418, 890);
            Point p32 = new Point(855, 890);

            Point p33 = new Point(418, 920);
            Point p34 = new Point(855, 920);

            Point p35 = new Point(0, 950);
            Point p36 = new Point(855, 950);


            // Gst coloum line
            Point p37 = new Point(518, 260);
            Point p38 = new Point(850, 260);




            Rectangle r1 = new Rectangle(0, 240, 850, 40); 

            e.Graphics.DrawRectangle(BlackPen, r1);

            e.Graphics.DrawLine(BlackPen, pointOne, pointSecond );
            e.Graphics.DrawLine(BlackPen, p3, p4);
            e.Graphics.DrawLine(BlackPen, p5, p6);
            e.Graphics.DrawLine(BlackPen, p9, p10);
            e.Graphics.DrawLine(BlackPen, p11, p12);
            e.Graphics.DrawLine(BlackPen, p13, p14);
            e.Graphics.DrawLine(BlackPen, p15, p16);
            e.Graphics.DrawLine(BlackPen, p17, p18);
            e.Graphics.DrawLine(BlackPen, p19, p20);
            e.Graphics.DrawLine(BlackPen, p21, p22);
            e.Graphics.DrawLine(BlackPen, p23, p24);
            e.Graphics.DrawLine(BlackPen, p25, p26);
            e.Graphics.DrawLine(BlackPen, p27, p28);
            e.Graphics.DrawLine(BlackPen, p29, p30);
            e.Graphics.DrawLine(BlackPen, p31, p32);
            e.Graphics.DrawLine(BlackPen, p33, p34);
            e.Graphics.DrawLine(BlackPen, p35, p36);
            e.Graphics.DrawLine(BlackPen, p37, p38);


            // // // // //  List Headings /// 
            e.Graphics.DrawString("Discription of product", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(10, 242));
            e.Graphics.DrawString("HSN \nCode", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(220, 242));
            e.Graphics.DrawString("Qty.", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(290, 242));
            e.Graphics.DrawString("Rate \n(Rs)", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(350, 242));
            e.Graphics.DrawString("Amount(Rs)", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(420, 242));
            e.Graphics.DrawString("\tCGST\nRate", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(520, 248));
            e.Graphics.DrawString("\nAmount", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(580, 248));
            e.Graphics.DrawString("\tSGST\nRate", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(670, 248));
            e.Graphics.DrawString("\nAmount", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(760, 248));



            // // // // // List Data // // // // // 
            int Ypoint = 290;

            foreach (var i in GridItems)
            {
                e.Graphics.DrawString(i.ProductName, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, Ypoint));
                e.Graphics.DrawString(i.HsnCode, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(220, Ypoint));
                e.Graphics.DrawString(i.Qantity.ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(290, Ypoint));
                e.Graphics.DrawString(i.Rate.ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(350, Ypoint));
                e.Graphics.DrawString(i.TotalAmount.ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(420, Ypoint));
                e.Graphics.DrawString(i.CgstRate, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(520, Ypoint));
                e.Graphics.DrawString(i.CgstAmount.ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(580, Ypoint));
                e.Graphics.DrawString(i.SgstRate, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(670, Ypoint));
                e.Graphics.DrawString(i.SgstAmount.ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(760, Ypoint));


                Ypoint += 25;
            }


            e.Graphics.DrawString("Amount :", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(418, 810));
            e.Graphics.DrawString(allProductTotalAmount.Text, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(600, 810));
            e.Graphics.DrawString("Labour/Cartage :", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(418, 840));
            e.Graphics.DrawString(labourValue.Text, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(600, 840));
            e.Graphics.DrawString("CGST Amount :", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(418, 870));
            e.Graphics.DrawString(cgstAmount.Text, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(600, 870));
            e.Graphics.DrawString("SGST Amount :", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(418, 900));
            e.Graphics.DrawString(sgstAmount.Text, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(600, 900));
            e.Graphics.DrawString("Grand Total :", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(418, 930));
            e.Graphics.DrawString(grandTotal.Text, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(600, 930));


            // /// // / / Footer

            e.Graphics.DrawString("Note :", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(10, 950));
            e.Graphics.DrawString("All Subjects To Shimla Jurisdiction Only\nGoods once sold will not be taken back.\nChanna, Paneer & Khoya Products to be consumed same day.", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(40, 970));

            e.Graphics.DrawString("For R.D.T. Enterprises", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(700, 950));
            e.Graphics.DrawString("Authority Signatory", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(700, 1050));
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            BSprintDocument.Print();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = dataGridView.CurrentCell.RowIndex;
                GridItems.RemoveAt(rowIndex);
            }catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }
        }

        private void dataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (dataGridView.DataSource == null)
                    {
                        MessageBox.Show("List is Empty.", "Error");
                    }
                    else
                    {
                        var hti = dataGridView.HitTest(e.X, e.Y);
                        dataGridView.Rows[hti.RowIndex].Selected = true;
                    }           
                }
            }
            catch(Exception )
            {
                MessageBox.Show("Select an Item.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            selectedRow = dataGridView.Rows[index];
            

            //try
            //{
            //    selectedValue = dataGridView.Rows[e.RowIndex].Cells["SrNo"].FormattedValue.ToString();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("" + ex);
            //}
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            

            if(dataGridView.DataSource != null)
            {
                int selectedvalue = dataGridView.CurrentCell.RowIndex + 1;
                DialogResult result = new DialogResult();
                result = MessageBox.Show("Are You Sure To Delete Product At SrNo " + selectedvalue, "Delete Product", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                   try
                    {
                        int rowIndex = dataGridView.CurrentCell.RowIndex;
                        GridItems.RemoveAt(rowIndex);

                        dataGridView.DataSource = null;
                        dataGridView.DataSource = GridItems;


                        /// calculation
                        double totalAfter = GridItems.Sum(X => X.TotalAmount);
                        itemFinalPrice = totalAfter;


                        double cgstAfter = totalAfter * 0.025;
                        cgstCalValue = cgstAfter;
                        double sgstAfter = totalAfter * 0.025;
                        sgstCalValue = sgstAfter;


                        double totalGstAfter = cgstCalValue + sgstCalValue;
                        totalGST = totalGstAfter;

                        double grandTotalAfter = totalAfter + totalGstAfter;
                        totalPrice = grandTotalAfter;


                        allProductTotalAmount.Text = totalAfter.ToString();
                        cgstAmount.Text = cgstAfter.ToString();
                        sgstAmount.Text = sgstAfter.ToString();
                        grandTotal.Text = grandTotalAfter.ToString();

                        num--;


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No item in the List.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }else
            {
                MessageBox.Show("List is Empty.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

       

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.D)
            {
                deleteItem.Focus();
            }
        }

        
}

}

