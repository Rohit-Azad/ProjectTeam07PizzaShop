using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjectTeam07PizzaShop.PizzaShopDataSet;
using ProjectTeam07PizzaShop.PizzaShopDataSetTableAdapters;
using System.Text.RegularExpressions;

namespace ProjectTeam07PizzaShop
{
    public partial class UserForm : Form
    {
        //dataset
        PizzaShopDataSet pizzaShopDataSet;
        //tables
        ToppingsDataTable toppingsTable;
        SizesDataTable sizeTable;
        OrdersDataTable orderTable;
        //table adapters
        ToppingsTableAdapter toppingsTableAdapter;
        SizesTableAdapter sizeTableAdapter;
        OrdersTableAdapter orderTableAdapter;

        //declaring variables
        string cost;
        string orderTopping;
        public static int countOrders;
        double size;
        double subTotal = 0;
        double totalPrice = 0;
        double finalTotal = 0;
        string selectedSize;
        private int i;
        int receiptCounter;
        private string paymentMethod="";
        string customerName;
        string cardNumber;

        //Lists declarations
        List<double> toppingPrice = new List<double>();
        List<string> toppingName = new List<string>();
        List<double> sizePrice = new List<double>();
        List<string> sizes = new List<string>();
        BindingList<OrderReview> orders= new BindingList<OrderReview>();

        public UserForm()
        {
            InitializeComponent();

            toppingsTable = new ToppingsDataTable();
            sizeTable = new SizesDataTable();
            orderTable = new OrdersDataTable();

            // create the dataset and adapters
            pizzaShopDataSet = new PizzaShopDataSet();

            toppingsTableAdapter = new ToppingsTableAdapter();
            sizeTableAdapter = new SizesTableAdapter();
            orderTableAdapter = new OrdersTableAdapter();

            //filling tables
            toppingsTableAdapter.Fill(toppingsTable);
            sizeTableAdapter.Fill(sizeTable);
            orderTableAdapter.Fill(orderTable);

            //queries to populate ists
            var eachPrice = from t in toppingsTable
                            select t.ToppingPrice;
            toppingPrice.AddRange(eachPrice);

            var eachName = from t in toppingsTable
                           select t.ToppingName;
            toppingName.AddRange(eachName);

            var eachSize = from s in sizeTable
                           select s.PizzaPrice;
            var pizzaSize= from s in sizeTable
                           select s.Size;
            sizePrice.AddRange(eachSize);
            sizes.AddRange(pizzaSize);

            //adding Default values
            size = sizePrice[0];
            subTotal = toppingPrice[0];
            totalPrice = (sizePrice[0] + toppingPrice[0]);
            labelCurrentCost.Text = (toppingPrice[0] + sizePrice[0]).ToString("C2");            
            paymentMethod = "Visa";
            selectedSize = sizes[0];
            orderTopping = toppingName[0];

            //initializinggrid view
            InitializeDataGridView(dataGridViewOrderReview);

            //dyanamically filling radio button text and checkbox text
            GetToppingsNameAndSizes();

            // register event handlers
            checkBox1.CheckedChanged += CheckBox_CheckedChanged;
            checkBox2.CheckedChanged += CheckBox_CheckedChanged;
            checkBox3.CheckedChanged += CheckBox_CheckedChanged;
            checkBox4.CheckedChanged += CheckBox_CheckedChanged;
            checkBox5.CheckedChanged += CheckBox_CheckedChanged;
            checkBox6.CheckedChanged += CheckBox_CheckedChanged;
            checkBox7.CheckedChanged += CheckBox_CheckedChanged;
            checkBox8.CheckedChanged += CheckBox_CheckedChanged;
            checkBox9.CheckedChanged += CheckBox_CheckedChanged;
            checkBox10.CheckedChanged += CheckBox_CheckedChanged;
            checkBox11.CheckedChanged += CheckBox_CheckedChanged;
            checkBox12.CheckedChanged += CheckBox_CheckedChanged;
            checkBox13.CheckedChanged += CheckBox_CheckedChanged;
            checkBox14.CheckedChanged += CheckBox_CheckedChanged;
            checkBox15.CheckedChanged += CheckBox_CheckedChanged;

            radioButtonSize1.CheckedChanged += RadioButtonSize_CheckedChanged;
            radioButtonSize2.CheckedChanged += RadioButtonSize_CheckedChanged;
            radioButtonSize3.CheckedChanged += RadioButtonSize_CheckedChanged;

            radioButtonAmEx.CheckedChanged += RadioButtonPayment_CheckedChanged;
            radioButtonVisa.CheckedChanged += RadioButtonPayment_CheckedChanged;
            radioButtonMC.CheckedChanged += RadioButtonPayment_CheckedChanged;
            radioButtonDebit.CheckedChanged += RadioButtonPayment_CheckedChanged;
            radioButtonCash.CheckedChanged += RadioButtonPayment_CheckedChanged;

            //Button click events
            buttonAddPizza.Click += ButtonAddPizza_Click;
            buttonConfirm.Click += buttonConfirm_Click;
            buttonRemoveOrder.Click += ButtonRemoveOrder_Click;
            buttonNext.Click += ButtonNext_Click;
            buttonReceipt.Click += ButtonReceipt_Click;
            buttonClearReceipt.Click += ButtonClearReceipt_Click;
            buttonSave.Click += ButtonSave_Click;
            buttonClearInfo.Click += ButtonClearInfo_Click;
        }

        //clearing customer information
        private void ButtonClearInfo_Click(object sender, EventArgs e)
        {
            textBoxCcNumber.Text = "";
            textBoxName.Text = "";

        }

        //save receipt as text file
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            
            string sPath = "../../receipts/Receipt_"+ receiptCounter +".txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in listBoxReceipt.Items)
            {
                SaveFile.WriteLine(item.ToString());
            }
            SaveFile.ToString();
            SaveFile.Close();

            MessageBox.Show("Receipt Saved!");
            receiptCounter++;
        }

        //clear receipt listbox
        private void ButtonClearReceipt_Click(object sender, EventArgs e)
        {
            listBoxReceipt.Items.Clear();
        }

        //payment method selection
        private void RadioButtonPayment_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAmEx.Checked)    
            {
                paymentMethod = "AmEx";
                textBoxCcNumber.Enabled = true;
                textBoxCcNumber.Text = "";
            }
            else if (radioButtonCash.Checked)
            {
                paymentMethod = "Cash";
                textBoxCcNumber.Enabled = false;
                textBoxCcNumber.Text = "";
            }
            else if (radioButtonVisa.Checked)
            {
                paymentMethod = "Visa";
                textBoxCcNumber.Enabled = true;
                textBoxCcNumber.Text = "";
            }
            else if (radioButtonMC.Checked)
            {
                paymentMethod = "MasterCard";
                textBoxCcNumber.Enabled = true;
                textBoxCcNumber.Text = "";
            }
            else if (radioButtonDebit.Checked)
            {
                paymentMethod = "Debit/Interac";
                textBoxCcNumber.Enabled = true;
                textBoxCcNumber.Text = "";
            }
        }

        //moving to next tab
        private void ButtonNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex + 1 < tabControl1.TabCount) ?
                             tabControl1.SelectedIndex + 1 : tabControl1.SelectedIndex;
        }

        //remove an order
        private void ButtonRemoveOrder_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridViewOrderReview.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    dataGridViewOrderReview.Rows.RemoveAt(dataGridViewOrderReview.SelectedRows[0].Index);
                }
            }
        }

        //getting pizza size
        private void RadioButtonSize_CheckedChanged(object sender, EventArgs e)
        {
            var radio = (RadioButton)sender;
            int radioID;
            int.TryParse(radio.Name.Remove(0, 15), out radioID);

            if (radio.Checked)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i == radioID - 1)
                    {
                        size = sizePrice[i];
                        selectedSize = sizes[i];
                    }
                }
            }
            totalPrice = subTotal + size;
            labelCurrentCost.Text = totalPrice.ToString("C2");
        }

        //receipt generation(generates receipt and takes you to receipt tab)
        private void ButtonReceipt_Click(object sender, EventArgs e)
        {
            listBoxReceipt.Items.Clear();
            ReceiptGeneration();
        }

        //order confirmation. Adds data to orders table
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            foreach (OrderReview or in orders)
            {
                orderTableAdapter.Insert(GetName(), or.Toppings, or.Size, paymentMethod, or.Price);
            }
            orderTableAdapter.Update(orderTable);
            orderTableAdapter.Fill(orderTable);
            ReceiptGeneration();

            MessageBox.Show("Order Confirmed and Payment Recieved");

            //resetting orders review tab
            dataGridViewOrderReview.Rows.Clear();
            labelTCost.Text = "";
            textBoxCcNumber.Text = "";
            textBoxName.Text = "";
        }

        //toppings price determination
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = (CheckBox)sender;
            int ID;

            int.TryParse(checkBox.Name.Remove(0, 8), out ID);

            if (checkBox.Checked)
            {
                for (int i = 0; i < 15; i++)
                {
                    if (i == ID - 1)
                    {
                        subTotal += toppingPrice[i];
                        orderTopping += toppingName[i] + " ";
                    }
                    else
                    {
                        subTotal += 0;
                        orderTopping += "";
                    }
                }
            }
            else
            {
                for (int i = 0; i < 15; i++)
                {
                    if (i == ID - 1)
                    {
                        subTotal -= toppingPrice[i];
                        orderTopping = orderTopping.Replace(toppingName[i], "");
                    }
                    else
                    {
                        subTotal -= 0;
                    }
                }
            }
            if (subTotal < 0)
                subTotal = sizePrice[0];
            totalPrice = subTotal + size;
            labelCurrentCost.Text = totalPrice.ToString("C2");
        }

        //Adding pizza to order
        private void ButtonAddPizza_Click(object sender, EventArgs e)
        {
            cost = totalPrice.ToString("f2");

            UpdateOrderReview();
            MessageBox.Show("Pizza Added for Review");
            ClearForm();
            dataGridViewOrderReview.Columns["PaymentMethod"].Visible = false;
            dataGridViewOrderReview.Columns["CustomerName"].Visible = false;
        }

        //function to set radio and checkbox text
        private void GetToppingsNameAndSizes()
        {
            checkBox1.Text = toppingName[0] +" -("+toppingPrice[0].ToString("C2")+")";
            checkBox2.Text = toppingName[1] + " -(" + toppingPrice[1].ToString("C2") + ")";
            checkBox3.Text = toppingName[2] + " -(" + toppingPrice[2].ToString("C2") + ")";
            checkBox4.Text = toppingName[3] + " -(" + toppingPrice[3].ToString("C2") + ")";
            checkBox5.Text = toppingName[4] + " -(" + toppingPrice[4].ToString("C2") + ")";
            checkBox6.Text = toppingName[5] + " -(" + toppingPrice[5].ToString("C2") + ")";
            checkBox7.Text = toppingName[6] + " -(" + toppingPrice[6].ToString("C2") + ")";
            checkBox8.Text = toppingName[7] + " -(" + toppingPrice[7].ToString("C2") + ")";
            checkBox9.Text = toppingName[8] + " -(" + toppingPrice[8].ToString("C2") + ")";
            checkBox10.Text = toppingName[9] + " -(" + toppingPrice[9].ToString("C2") + ")";
            checkBox11.Text = toppingName[10] + " -(" + toppingPrice[10].ToString("C2") + ")";
            checkBox12.Text = toppingName[11] + " -(" + toppingPrice[11].ToString("C2") + ")";
            checkBox13.Text = toppingName[12] + " -(" + toppingPrice[12].ToString("C2") + ")";
            checkBox14.Text = toppingName[13] + " -(" + toppingPrice[13].ToString("C2") + ")";
            checkBox15.Text = toppingName[14] + " -(" + toppingPrice[14].ToString("C2") + ")";
            radioButtonSize1.Text += sizes[0] +" -"+sizePrice[0].ToString("C2");
            radioButtonSize2.Text += sizes[1] + " -" + sizePrice[1].ToString("C2");
            radioButtonSize3.Text += sizes[2] + " -" + sizePrice[2].ToString("C2");
        }
        //FUNCTIONS
        //clearing form after clicking add pizza
        private void ClearForm()
        {
            checkBox1.Checked = true;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            radioButtonSize1.Checked = true;
            radioButtonSize2.Checked = false;
            radioButtonSize3.Checked = false;
            labelCurrentCost.Text = (toppingPrice[0]+ sizePrice[0]).ToString("C2");
        }

        //adding orders to order review datagridview
        private void UpdateOrderReview()
        {
            i++;
            orders.Add(new OrderReview(i,orderTopping,selectedSize,cost));

            dataGridViewOrderReview.DataSource = orders;
            //determining total cost of all pizzas in our order
            var total = from c in orders
                        select Double.Parse(c.Price);
            finalTotal = total.Sum();
            labelTCost.Text = finalTotal.ToString("C2");
        }
    
        //getting customer name
        private string GetName()
        {
            customerName = textBoxName.Text;
            if (customerName == "")
                customerName = "John Doe";
            else
                customerName = textBoxName.Text;
            return customerName;
        }

        //function to generate receipt
        private void ReceiptGeneration()
        {
            if (radioButtonCash.Checked)
                cardNumber = "Cash";
            else if (textBoxCcNumber.Text == "")
                cardNumber = "**** **** **** 1234";
            else if (textBoxCcNumber.Text.Length < 4)
            {
                cardNumber = textBoxCcNumber.Text;
                while (cardNumber.Length < 4)
                    cardNumber += "0";
            }
            else
                cardNumber = "**** **** **** " + textBoxCcNumber.Text.Substring(textBoxCcNumber.Text.Length - 4);
            listBoxReceipt.Items.Clear();
            listBoxReceipt.Items.Add("=============Team 07 Pizza Shop Management System===================");
            listBoxReceipt.Items.Add("");
            listBoxReceipt.Items.Add("=====================By Dasan and Rohit=============================");
            listBoxReceipt.Items.Add("");
            listBoxReceipt.Items.Add("===========================Receipt==================================");
            listBoxReceipt.Items.Add("");
            listBoxReceipt.Items.Add("      Customer's Name: " + GetName());

            foreach (OrderReview or in orders)
            {
                listBoxReceipt.Items.Add("           Pizza Number:   " + or.OrderID);
                listBoxReceipt.Items.Add("        Toppings Added:   " + or.Toppings);
                listBoxReceipt.Items.Add("   Pizza Size Selected:   " + or.Size);
                listBoxReceipt.Items.Add("        Payment Method:   " + paymentMethod);
                listBoxReceipt.Items.Add("Price of current Pizza:   " + "$" + or.Price);
                listBoxReceipt.Items.Add(" ");
                listBoxReceipt.Items.Add("===================================================================");
                listBoxReceipt.Items.Add(" ");
            }
            listBoxReceipt.Items.Add(" ");
            listBoxReceipt.Items.Add(" ");

            listBoxReceipt.Items.Add("               Order Total: " + finalTotal.ToString("C2"));
            listBoxReceipt.Items.Add("                Paid Using: " + cardNumber);
            listBoxReceipt.Items.Add("=============================THE END=============================");

            tabControl1.SelectedIndex = (tabControl1.SelectedIndex + 1 < tabControl1.TabCount) ?
                             tabControl1.SelectedIndex + 1 : tabControl1.SelectedIndex;
        }

        //Initializing datagridview
        private void InitializeDataGridView(DataGridView gridView)
        {
            gridView.AutoGenerateColumns = true;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridView.AllowUserToAddRows = false;
        }

        //OrderReviewClass
        private class OrderReview
        {
            public int OrderID { get; set; }
            public string CustomerName { get; set; }
            public string Toppings { get; set; }
            public string Size { get; set; }
            public string PaymentMethod { get; set; }
            public string Price { get; set; }  

            public OrderReview(int orderId, string toppings, string size, string price)
            {
                OrderID = orderId;
                Toppings = toppings;
                Size = size;
                Price = price; ;
            }
        }
    }
}
