<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CustomerSurvey.aspx.cs" Inherits="CustomerSurvey" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <br/>Enter your customer ID:<asp:TextBox ID="custID" runat="server" ValidationGroup="e"></asp:TextBox>
        <asp:Button ID="getIncident" runat="server" Text="Get Incidents" OnClick="getIncident_Click" ValidationGroup="e" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="custID" Enabled="true" 
            ErrorMessage="Please enter the ID" ValidationGroup="e"></asp:RequiredFieldValidator>
         <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="custID" 
             ErrorMessage="Please enter the numbers" Type="Integer" Enabled="true" ValidationGroup="e" Operator="DataTypeCheck"></asp:CompareValidator>    
        <br />
        <asp:ListBox ID="selectIncidents" runat="server" Height="84px" Width="539px" OnSelectedIndexChanged="selectIncidents_SelectedIndexChanged1" ViewStateMode="Enabled">
        </asp:ListBox>    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TechSupportConnectionString %>" SelectCommand="SELECT [IncidentID], [CustomerID], [ProductCode], [TechID], [DateOpened], [DateClosed], [Title] FROM [Incidents] ORDER BY [DateClosed]"></asp:SqlDataSource>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="selectIncidents" Display="Dynamic" ErrorMessage="Please select an incident" ValidationGroup="s"></asp:RequiredFieldValidator>     
        <asp:Label ID="invalidID" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Panel ID="SurveyPanel" runat="server" Enabled="False">
             Response time:<asp:RadioButtonList ID="responseTime" runat="server"  repeatdirection="horizontal" CellPadding="-1" CellSpacing="0"  >
                <asp:ListItem value ="1" >Not satisfied</asp:ListItem>
                <asp:ListItem value="2">Somewhat satisfied</asp:ListItem>
                <asp:ListItem value="3">Satisfied</asp:ListItem>
                <asp:ListItem value="4">Completly satisfied</asp:ListItem>
            </asp:RadioButtonList>
            <br />         
            Technician efficiency:
            <asp:RadioButtonList ID="techefficiency" runat="server"  repeatdirection="horizontal" >
                <asp:ListItem value ="1">Not satisfied</asp:ListItem>
                <asp:ListItem value ="2">Somewhat satisfied</asp:ListItem>
                <asp:ListItem value ="3">Satisfied</asp:ListItem>
                <asp:ListItem value ="4">Completly satisfied</asp:ListItem>
            </asp:RadioButtonList>
            <br />           
            Problem resolution:
           <asp:RadioButtonList ID="problemresolution" runat="server"  repeatdirection="horizontal" >
                <asp:ListItem value ="1">Not satisfied</asp:ListItem>
                <asp:ListItem value ="2">Somewhat satisfied</asp:ListItem>
                <asp:ListItem value ="3">Satisfied</asp:ListItem>
                <asp:ListItem value ="4">Completly satisfied</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
            Additional comments:<asp:TextBox ID="commentstext" runat="server"  Height="100px" Width="200px" ></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="contactme" runat="server" OnCheckedChanged="checkchange" AutoPostBack="True"/>
            Please contact me to discuss this incident<br />
             <br />
             <asp:RadioButtonList ID="contactby" runat="server">
                 <asp:ListItem  Value="email" >Contact by email</asp:ListItem>
                 <asp:ListItem  Value="phone">Contact by phone</asp:ListItem>
             </asp:RadioButtonList>
             <br />
            <br />
            <br />
            <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" Enabled ="false" ValidationGroup="s"/>
            </asp:Panel>        
        <br />
    </asp:Content>
 <asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server"></asp:Content>
