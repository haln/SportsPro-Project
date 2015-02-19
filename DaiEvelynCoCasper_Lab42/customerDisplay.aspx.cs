using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class customerDisplay : System.Web.UI.Page
{
    //CustomerList customerList = CustomerList.GetCustomers();
    protected void Page_Load(object sender, EventArgs e)
    {
        //the page is first time loaded
        if (!IsPostBack)
        {
            DropDownList1.DataBind();
        }        
            
            DataView customerTable = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
            
            customerTable.RowFilter = "CustomerID = " + DropDownList1.SelectedValue;
            DataRowView row = customerTable[0];
            Customer customer = new Customer(row);

            labelAddress.Text = customer.address + "</br>" + customer.city + ", " + customer.state + "  " + customer.zipcode;

            LabelEmail.Text = customer.email;
            labelPhone.Text = customer.phone;
        
    }
    protected void addToList_Click(object sender, EventArgs e)
    {
        CustomerList customerList = CustomerList.GetCustomers();
        Customer cust = customerList[DropDownList1.SelectedItem.Text];
        if (cust!=null)
        {
            errorMsg.Text = "Customer is already in contacts list.";
        }
        else
        {
            cust = new Customer((DataRowView)(((DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty))[DropDownList1.SelectedIndex]));
            customerList.AddItem(cust);
            errorMsg.Text = cust.name+" has been added to contacts list.";
        }
        //Server.Transfer("ContactDisplay.aspx");
    }
    protected void displayContacts_Click(object sender, EventArgs e)
    {
        Server.Transfer("ContactDisplay.aspx");
    }
}