using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CustomerList
/// </summary>
public class CustomerList
{
    private static List<Customer> customerList;
	public CustomerList()
	{
        customerList = new List<Customer>();
	}

    public int Count(){
        return customerList.Count;
    }
    public Customer this[int index]
    {
        get { return customerList[index]; }
        set { customerList[index] = value; }
    }

    public Customer this[string name]
    {
        get { 
            foreach(Customer cust in customerList){
                if (cust.name.Equals(name))
                {
                    return cust;
                }
            };
            return null;
        }
    }

    public static CustomerList GetCustomers()
    {
        CustomerList customerList = (CustomerList)HttpContext.Current.Session["contactsList"];
        if (customerList == null)
            HttpContext.Current.Session["contactsList"] = new CustomerList();
        return (CustomerList)HttpContext.Current.Session["contactsList"];
    }

    public void AddItem(Customer customer)
    {
        customerList.Add(customer);
    }

    public void RemoveAt(int index)
    {
        try
        {
            customerList.RemoveAt(index);
        }
        catch
        {
            return;
        }
    }

    public void Clear()
    {
        customerList = null;
        HttpContext.Current.Session["contactsList"] = null;
    }
}