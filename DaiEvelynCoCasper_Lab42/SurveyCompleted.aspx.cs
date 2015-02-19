using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SurveyCompleted : System.Web.UI.Page
{
    private Survey survey;
    protected void Page_Load(object sender, EventArgs e)
    {
        string msg = " ";
        survey = (Survey)Session["survey"];
        if(survey.Contact == true){
            if (survey.ContactBy == "email")
                msg = "Thank you for your feedback! A customer service represntative will contact you via Email within 24 hours.";
            else if(survey.ContactBy == "phone"){
                msg = "Thank you for your feedback! A customer service represntative will contact you via phone within 24 hours.";}
            Label1.Text = msg;
        }
        else
            Label1.Text = "Thank you for your feedback!";
    }
    protected void return_Click(object sender, EventArgs e)
    {
        Server.Transfer("CustomerSurvey.aspx");
    }
}