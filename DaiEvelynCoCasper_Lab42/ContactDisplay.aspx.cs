using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ContactDisplay : System.Web.UI.Page
{
    private CustomerList customer;

    protected void Page_Load(object sender, EventArgs e)
    {
        customer = CustomerList.GetCustomers();
        if (!IsPostBack)
        {
            this.DisplayCustomers();
        }
    }


    protected void DisplayCustomers()
    {
        contactsList.Items.Clear();
        Customer cust;
        // int count = customerList.Count;
        for (int i = 0; i < customer.Count(); i++)
        {
            cust = customer[i];
            contactsList.Items.Add(cust.ToString());
        }
    }
    protected void contactsList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void selectCustomers_Click(object sender, EventArgs e)
    {
        Server.Transfer("CustomerDisplay.aspx");
    }
    protected void emptyList_Click(object sender, EventArgs e)
    {
        customer.Clear();
        Server.Transfer("ContactDisplay.aspx");
    }
    protected void removeContact_Click(object sender, EventArgs e)
    {
        customer.RemoveAt(contactsList.SelectedIndex);
        Server.Transfer("ContactDisplay.aspx");
    }
}