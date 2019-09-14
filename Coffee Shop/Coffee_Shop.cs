using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string Customer_Name = "";
            string Contact_No = "";
            string Address = "";
            string Order = "";
            string Quantity = "";
            int quantity=0;
            int price = 0;


            if (customer_nameTextBox.Text == "" || contact_noTextBox.Text == "" || addressTextBox.Text == "" ||
                orderComboBox.Text == "" || quantityTextBox.Text == "")
            {
                if (customer_nameTextBox.Text == "" && contact_noTextBox.Text == "" && addressTextBox.Text == "" &&
                    orderComboBox.Text == "" && quantityTextBox.Text == "")
                {
                    MessageBox.Show("Please enter all customer information");
                }
                else if (customer_nameTextBox.Text == "")
                {
                    MessageBox.Show("Please enter a customer name");
                }
                else if (contact_noTextBox.Text == "")
                {
                    MessageBox.Show("Please enter a customer no");
                }
                else if (addressTextBox.Text == "")
                {
                    MessageBox.Show("Please enter a address");
                }
                else if (orderComboBox.Text == "")
                {
                    MessageBox.Show("Please enter a order");
                }
                else if (quantityTextBox.Text == "")
                {
                    MessageBox.Show("Please enter a quantity");
                }
                else
                {
                    MessageBox.Show("Please enter all customer information");
                }

                
            }
            else
            {
                Customer_Name = customer_nameTextBox.Text;
                Contact_No = contact_noTextBox.Text;
                Address = addressTextBox.Text;
                Order = orderComboBox.Text;
                Quantity = quantityTextBox.Text;

                quantity = Convert.ToInt32(Quantity);

                if (orderComboBox.Text == "Black")
                {
                    price = quantity * 120;
                    MessageBox.Show("The bill is " + price + "Tk.");
                }
                else if (orderComboBox.Text == "Cold")
                {
                    price = quantity * 100;
                    MessageBox.Show("The bill is " + price + "Tk.");
                }
                else if (orderComboBox.Text == "Hot")
                {
                    price = quantity * 90;
                    MessageBox.Show("The bill is " + price + "Tk.");
                }
                else if (orderComboBox.Text == "Regular")
                {
                    price = quantity * 80;
                    MessageBox.Show("The bill is " + price + "Tk.");
                }
                else
                {
                    MessageBox.Show("Please enter a order");
                }
                

                purchase_informationRichTextBox.SelectedText = Environment.NewLine + "Customer Name :" + Customer_Name;
                purchase_informationRichTextBox.SelectedText = Environment.NewLine + "Contact Number:" + Contact_No;
                purchase_informationRichTextBox.SelectedText = Environment.NewLine + "Address             :" + Address;
                purchase_informationRichTextBox.SelectedText = Environment.NewLine + "Order                 :" + Order;
                purchase_informationRichTextBox.SelectedText = Environment.NewLine + "Quantity            :" + quantity;
                purchase_informationRichTextBox.SelectedText = Environment.NewLine + "Price                 :" + price + "Tk.";
                purchase_informationRichTextBox.SelectedText = Environment.NewLine + "";

                MessageBox.Show("Successfully Saved");

                customer_nameTextBox.Text = "";
                contact_noTextBox.Text = "";
                addressTextBox.Text = "";
                orderComboBox.Text = "";
                quantityTextBox.Text = "";
            }

        }
    }
}
