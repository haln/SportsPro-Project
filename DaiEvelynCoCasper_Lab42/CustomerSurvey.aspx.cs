using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerSurvey : System.Web.UI.Page
{
    DataView incidentsTable ;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        if (!IsPostBack)
        {
            //selectIncidents.DataSource = SqlDataSource1;
            //selectIncidents.DataBind();
        }
        // select * from incident table where cutomer id = (user input)       
       // DataRowView row = incidentsTable[0];
    
    }

    protected void getIncident_Click(object sender, EventArgs e)
    {
        selectIncidents.Enabled = true;
        SurveyPanel.Enabled = true;
        submit.Enabled = true;
        //contactby.Enabled = false;
        
        incidentsTable = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
        incidentsTable.RowFilter = "CustomerID =" + custID.Text + " AND DateClosed IS NOT NULL";
        if (incidentsTable.Count == 0)
        {
            invalidID.Text = "Please enter a valid customer ID with closed incidents.";
        }
        else
        {
            invalidID.Text = "";
            this.DisplayIncidents(incidentsTable);
        }
    }

    protected void DisplayIncidents(DataView incidents)
    {
        selectIncidents.Items.Clear();
        Incident incident;
        selectIncidents.Items.Add("--Select an incidents--");
        selectIncidents.Items[0].Value = "None";
        for (int i = 0; i < incidents.Count; i++)
        {
            incident = new Incident((DataRowView)incidents[i]);
            selectIncidents.Items.Add(incident.CustomerIncidentDisplay());
            selectIncidents.Items[i+1].Value = incident.IncidentID + "";
        }
    }
    protected void selectIncidents_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void submit_Click(object sender, EventArgs e)
    {
        
        Survey survey = new Survey();
        survey.CustomerID = int.Parse(custID.Text);
        survey.IncidentID = int.Parse(selectIncidents.SelectedItem.Value);
        survey.ResponseTime = Int32.Parse(responseTime.SelectedValue);
        survey.TechEfficiency = Int32.Parse(techefficiency.SelectedValue);
        survey.Resolution = Int32.Parse(problemresolution.SelectedValue);
        survey.Comments = commentstext.Text;
        survey.Contact = contactme.Checked;
        survey.ContactBy = contactby.SelectedValue;
        Session["survey"] = survey;
        Response.Redirect("SurveyCompleted.aspx");
    }


    protected void checkchange(object sender, EventArgs e)
    {
        contactby.Enabled = contactme.Checked;
    }

    protected void selectIncidents_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
}