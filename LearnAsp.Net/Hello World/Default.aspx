<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Hello_World._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <asp:Label runat="server" id="HelloWorldLabel"></asp:Label>
    
        <br /><br />
        <asp:TextBox runat="server" id="TextInput" /> 
        <asp:Button runat="server" id="GreetButton" text="Say Hello!" OnClick="GreetButton_Click" />
        
        <br /><br />
        <asp:DropDownList runat="server" id="GreetList" autopostback="true" onselectedindexchanged="GreetList_SelectedIndexChanged">
            <asp:ListItem value="no one">No one</asp:ListItem>
            <asp:ListItem value="world">World</asp:ListItem>
            <asp:ListItem value="universe">Universe</asp:ListItem>
        </asp:DropDownList>
        
        <br /><br />
        Your name:<br />
        <asp:TextBox runat="server" id="txtName" />
        <asp:RequiredFieldValidator runat="server" id="reqName" controltovalidate="txtName" errormessage="Please enter your name!" />
        <br /><br />
        <asp:Button runat="server" id="btnSubmitForm" text="Ok" OnClick="btnSubmitForm_Click" />

    </div>

</asp:Content>
