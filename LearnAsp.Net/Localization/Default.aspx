<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Localization._Default" Culture="Auto" UICulture="Auto" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div>
        <% Response.Write("Your current culture: " + System.Globalization.CultureInfo.CurrentCulture.DisplayName);    %>
        <br />
        <% Response.Write("Current date, in a culture specific format: " + DateTime.Now.ToString()); %>
        <br />
        <% Response.Write("Current date, in a culture specific format: " + DateTime.Now.ToString(System.Globalization.CultureInfo.GetCultureInfo("de-DE").DateTimeFormat)); %>
        <br />
        <asp:Label runat="server" ID="lblHelloWorld" Text="Hello, world!" Font-Names="Verdana" ForeColor="Blue" meta:resourcekey="lblHelloWorld" />
        <br />
        <asp:Label runat="server" ID="lblHelloWorld2" Text="<%$ Resources:lblHelloWorld.Text %>" Font-Names="<%$ Resources:lblHelloWorld.Font-Names %>" ForeColor="<%$ Resources:lblHelloWorld.ForeColor %>"  />
    </div>

</asp:Content>
