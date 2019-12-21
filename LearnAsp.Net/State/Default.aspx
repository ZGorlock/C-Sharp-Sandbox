<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="State._Default" %>


<asp:Content ID="MainBody" ContentPlaceHolderID="MainContent" runat="server">
    <div runat="server" id="BodyTag">
    <asp:DropDownList runat="server" id="ColorSelector" autopostback="true" onselectedindexchanged="ColorSelector_IndexChanged">
        <asp:ListItem value="White" selected="True">Select color...</asp:ListItem>
        <asp:ListItem value="Red">Red</asp:ListItem>
        <asp:ListItem value="Green">Green</asp:ListItem>
        <asp:ListItem value="Blue">Blue</asp:ListItem>
    </asp:DropDownList>
    </div>

        <asp:TextBox runat="server" id="NameField" />
        <asp:Button runat="server" id="SubmitForm" onclick="SubmitForm_Click" text="Submit & set name" />
        <asp:Button runat="server" id="RefreshPage" text="Just submit" />
        <br /><br />
        Name retrieved from ViewState: <asp:Label runat="server" id="NameLabel" />

</asp:Content>