<%@ Page Language="C#" MasterPageFile="~/MasterPage.master"AutoEventWireup="true" CodeFile="SurveyCompleted.aspx.cs" Inherits="SurveyCompleted" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="return" runat="server" Text="Return to Survey" OnClick="return_Click" />

    
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>
