using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Customer
/// </summary>
public class Customer
{
    public int customerID;
    public string name;
    public string address;
    public string city;
    public string state;
    public string zipcode;
    public string phone;
    public string email;
	public Customer(DataRowView customer)
	{
        customerID = int.Parse(customer[0].ToString());
        name = customer[1].ToString();
        address = customer[2].ToString();
        city = customer[3].ToString();
        state = customer[4].ToString();
        zipcode = customer[5].ToString();
        phone = customer[6].ToString();
        email = customer[7].ToString();
	}

    public override String ToString()
    {
        return name + ": " + phone + "; " + email;
    }
}