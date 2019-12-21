<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Caching._Default" %>
<%@ OutputCache duration="5" varybyparam="None" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <b>Caching</b>
        <%= DateTime.Now.ToString() %>
        
        <br /><br />
        <a href="?p=1">1</a><br />
        <a href="?p=2">2</a><br />
        <a href="?p=3">3</a><br />

        <br /><br />
<%--        Fresh datestamp:<br />
        <asp:Substitution runat="server" ID="UnCachedArea" MethodName="GetFreshDateTime" />--%>

    </div>
</asp:Content>
