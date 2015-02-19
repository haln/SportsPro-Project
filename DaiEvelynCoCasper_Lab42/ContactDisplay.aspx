<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ContactDisplay.aspx.cs" Inherits="ContactDisplay" MasterPageFile="~/MasterPage.master" %>
<asp:Content runat="server" ID="head" ContentPlaceHolderID="head">
    <title>Display Contactr</title>
</asp:Content>


<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <div>
        <asp:Label ID="contactsListLabel" runat="server" Text="Contact List:"></asp:Label><br />
        <asp:ListBox ID="contactsList" runat="server" OnSelectedIndexChanged="contactsList_SelectedIndexChanged" Height="110px" Width="402px"></asp:ListBox>
    
        <asp:Button ID="removeContact" runat="server" Text="Remove Contact" OnClick="removeContact_Click" />
        <br />
        <asp:Button ID="emptyList" runat="server" Text="Empty List" OnClick="emptyList_Click" />
    
    </div>
        <asp:Button ID="selectCustomers" runat="server" Text="Select Additional Customers" OnClick="selectCustomers_Click" />
    </asp:Content>
 <asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server"></asp:Content>

