<%@ Page Language="C#" AutoEventWireup="true" CodeFile="customerDisplay.aspx.cs" Inherits="customerDisplay" MasterPageFile="~/MasterPage.master" %>

<asp:Content runat="server" ID="head" ContentPlaceHolderID="head">
    <title>Display Customer</title>
</asp:Content>


<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <div>
        <label id="selectCustomer">Select a customer</label>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="CustomerID">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TechSupportConnectionString %>" SelectCommand="SELECT * FROM [Customers] ORDER BY [NAME]"></asp:SqlDataSource>
        <br />
            <table>
                <tr>
                    <td class="tableItem"><label id="address">Address: </label></td>
                    <td><asp:Label ID="labelAddress" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td class="tableItem"><label id="phone">Phone: </label></td>
                    <td><asp:Label ID="labelPhone" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td class="tableItem"><label id="email">Email: </label></td>
                    <td><asp:Label ID="LabelEmail" runat="server" ></asp:Label></td>
                </tr>
            </table>
        
        <asp:Button ID="addToList" runat="server" OnClick="addToList_Click" Text="Add to Contact List" />
        <asp:Button ID="displayContacts" runat="server" OnClick="displayContacts_Click" Text="Display Contact List" />
        <br />
        <br />
        <asp:Label ID="errorMsg" runat="server"></asp:Label>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server"></asp:Content>
    
    
