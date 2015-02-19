using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Incident
/// </summary>
public class Incident
{
    public int IncidentID;
    public int CustomerID;
    public string ProductCode;
    public string DateOpened;
    public string DateClosed;
    public string title;
    public int techID;

	public Incident(DataRowView incident)
	{
        IncidentID = int.Parse(incident[0].ToString());
        CustomerID = int.Parse(incident[1].ToString());
        ProductCode = incident[2].ToString();
        techID = int.Parse(incident[3].ToString());
        DateOpened = incident[4].ToString();
        DateClosed = incident[5].ToString();
        title = incident[6].ToString();

		//
		// TODO: Add constructor logic here
		//
	}
    public String CustomerIncidentDisplay()
    {
        return "Incident for product " + ProductCode + " closed " + DateClosed + "(" + title + ")";

    }
}