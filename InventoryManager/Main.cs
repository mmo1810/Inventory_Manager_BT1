using System;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class Main : Form
    {
        public Main()
        {
            // configuration for Main form
            InitializeComponent();
            pdli.FullRowSelect = true;
            pdli.View = View.Details;
        }
        // allows to enter only decimal number to price textbox
        private void pricebox_KeyPress_1(object sender, KeyPressEventArgs e)
        {            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == ',')
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }
        // allows only numbers for quantity textbox
        private void quantitybox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Hint for typing in the textbox
        private void btnhint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name : enter text \n" +
                "Price : enter Number and a comma ',' \n" +
                "Quantity : enter number only ");
        }
        public void btnadd_Click_1(object sender, EventArgs e)
        {
            //check if user didn't enter anything
            if (namebox.Text == "" || pricebox.Text == "" || quantitybox.Text == "")
            {
                MessageBox.Show("Please enter the infomation !");
            }

            else
            {
                //get product infomation from textbox and then save to memory
                Product prod = new Product();

                prod.Id = Inventory.GetNewId();
                prod.Name = namebox.Text;
                prod.Price = decimal.Parse(pricebox.Text);
                prod.Quantity = int.Parse(quantitybox.Text);
                Inventory.Add(prod); //linked with the method in inventory.cs

                //add product to product list (listview)
                string a = Convert.ToString(prod.Id); //convert product id to add to listview as item
                ListViewItem lvi = new ListViewItem(a); //create new listview item and its subitems
                lvi.SubItems.Add(prod.Name);
                lvi.SubItems.Add(Convert.ToString(prod.Price));
                lvi.SubItems.Add(Convert.ToString(prod.Quantity));
                //add to listview
                pdli.Items.Add(lvi);

                //clear the textboxs
                namebox.Text = "";
                pricebox.Text = "";
                quantitybox.Text = "";
            }
        }
        //remove button configuration
        private void btnremove_Click(object sender, EventArgs e)
        {
            //remove product
            foreach (System.Windows.Forms.ListViewItem eachItem in this.pdli.SelectedItems)
            {
                //get product to remove id from selected item from listview
                int itemToRemove = int.Parse(pdli.SelectedItems[0].Text); 

                //remove from memory (linked with method in inventory.cs)
                Inventory.RemoveProduct(itemToRemove); 
                this.pdli.Items.Remove(eachItem); //remove from listview
            }
        }
        private void btninfo_Click(object sender, EventArgs e)
        {
            //Inventory calculation (linked with 3 method in inventory.cs)
            int productCount = Inventory.GetProductCount();
            int unitCount = Inventory.GetUnitCount();
            decimal inventoryValue = Inventory.GetInventoryValue();

            //Display info in the message box
            MessageBox.Show("\n" +
                $"Product count: {productCount}\n" +
                $"Total Unit count: {unitCount}\n" +
                $"Total Inventory value: {inventoryValue}");
        } 
        //About us button configuration
        private void btnabout_Click(object sender, EventArgs e)
        {
            //show message box
            MessageBox.Show("Designed and configured by Bui Duc Minh - BSAF190024 \n" +
                "Contact: minhbdbsaf190024 @ gmail \n" +
                "Or: minhbui0213 @ gmail \n" +
                "Thank you, \n" +
                "Best regards.");
        }
        //exit button configuration
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //exit program
        }

    }   
}
