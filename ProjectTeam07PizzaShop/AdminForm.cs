using ProjectTeam07PizzaShop.PizzaShopDataSetTableAdapters;
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

namespace ProjectTeam07PizzaShop
{
    public partial class AdminForm : Form
    {
        //dataset
        PizzaShopDataSet pizzaShopDataSet = new PizzaShopDataSet();
        
        //tables
        ToppingsDataTable toppingsTable;
        SizesDataTable sizeTable;
        OrdersDataTable orderTable;
       
        //table adapters
        ToppingsTableAdapter toppingsTableAdapter;
        SizesTableAdapter sizeTableAdapter;
        OrdersTableAdapter orderTableAdapter;


        public AdminForm()
        {
            //initializing adapters
            toppingsTableAdapter = new ToppingsTableAdapter();
            sizeTableAdapter = new SizesTableAdapter();
            orderTableAdapter = new OrdersTableAdapter();

            //short names for tables
            toppingsTable = pizzaShopDataSet.Toppings;
            sizeTable = pizzaShopDataSet.Sizes;
            orderTable = pizzaShopDataSet.Orders;

            InitializeComponent();

            //filling tables
            toppingsTableAdapter.Fill(toppingsTable);
            sizeTableAdapter.Fill(sizeTable);
            orderTableAdapter.Fill(orderTable);

            //initializing data grid views
            InitializeDataGridView(dataGridViewOrdersSummary, orderTable);
            InitializeDataGridView(dataGridViewSize, sizeTable);
            InitializeDataGridView(dataGridViewToppings, toppingsTable);

            //query to set statistics
            var total = from c in orderTable
                        select double.Parse(c.Price);

            labelEarnings.Text = total.Sum().ToString("C2");
            labelNumberOfOrders.Text = total.Count().ToString();
            
            //event handlers
            buttonUpdatePrice.Click += ButtonUpdatePrice_Click;
            buttonBackup.Click += ButtonBackup_Click;
            buttonRemoveOrders.Click += ButtonRemoveOrders_Click;
            buttonSaveChanges.Click += ButtonSaveChanges_Click;
            pizzaShopDataSet.AcceptChanges();

            //hiding ID columns
            dataGridViewOrdersSummary.Columns[0].Visible = false;
            dataGridViewSize.Columns[0].Visible = false;
            dataGridViewToppings.Columns[0].Visible = false;
        }

        //save changes made to order table by admin
        private void ButtonSaveChanges_Click(object sender, EventArgs e)
        {
            orderTableAdapter.Update(orderTable);
            orderTableAdapter.Fill(orderTable);
            var total = from c in orderTable
                        select double.Parse(c.Price);
            //updating statistics
            labelEarnings.Text = total.Sum().ToString("C2");
            labelNumberOfOrders.Text = total.Count().ToString();
            MessageBox.Show("Orders Updated Successfully");
        }

        //backup dataset to XML
        private void ButtonBackup_Click(object sender, EventArgs e)
        {
            WriteXmlToFile(pizzaShopDataSet);
            MessageBox.Show("Data Backed Up Successfully");

        }

        //Price update button
        private void ButtonUpdatePrice_Click(object sender, EventArgs e)
        {
            toppingsTableAdapter.Update(toppingsTable);
            sizeTableAdapter.Update(sizeTable);

            sizeTableAdapter.Fill(sizeTable);
            toppingsTableAdapter.Fill(toppingsTable);
        }

        //Remove orders fro, order table
        private void ButtonRemoveOrders_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridViewOrdersSummary.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    dataGridViewOrdersSummary.Rows.RemoveAt(dataGridViewOrdersSummary.SelectedRows[0].Index);
                }
            }
        }

        //Initializing grid views
        private void InitializeDataGridView(DataGridView gridView, DataTable table)
        {
            gridView.Rows.Clear();
            gridView.AutoGenerateColumns = true;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridView.DataSource = table;
            gridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridView.AllowUserToAddRows = false;
        }
        
        //Function save to XML
        private void WriteXmlToFile(DataSet sourceDataSet)
        {
            // Save this DataSet as XML.
            sourceDataSet.WriteXml(@"..\..\XMLBackup\" + sourceDataSet.DataSetName + ".xml");
            sourceDataSet.WriteXmlSchema(@"..\..\XMLBackup\" + sourceDataSet.DataSetName + ".xsd");
           
        }
    }
}
