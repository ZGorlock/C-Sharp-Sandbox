<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Validation._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        Small number:<br />
        <asp:TextBox runat="server" id="txtSmallNumber" /><br /><br />
        Big number:<br />
        <asp:TextBox runat="server" id="txtBigNumber" /><br />
        <asp:CompareValidator runat="server" id="cmpNumbers" controltovalidate="txtSmallNumber" controltocompare="txtBigNumber" operator="LessThan" type="Integer" errormessage="The first number should be smaller than the second number!" /><br />
        
        <br /><br />
        Date:<br />
        <asp:TextBox runat="server" id="txtDate" />
        <asp:RangeValidator runat="server" id="rngDate" controltovalidate="txtDate" type="Date" minimumvalue="01-01-2006" maximumvalue="12-31-2006" errormessage="Please enter a valid date within 2006!" />

        <br /><br />
        4 digit number:<br />
        <asp:TextBox runat="server" id="txtNumber" />
        <asp:RegularExpressionValidator runat="server" id="rexNumber" controltovalidate="txtNumber" validationexpression="^[0-9]{4}$" errormessage="Please enter a 4 digit number!" />

        <br /><br />
        Custom text:<br />
        <asp:TextBox runat="server" id="txtCustom" />
        <asp:CustomValidator runat="server" id="cusCustom" controltovalidate="txtCustom" onservervalidate="cusCustom_ServerValidate" errormessage="The text must be exactly 8 characters long!" />
        
        <br /><br />
    </div>

</asp:Content>
