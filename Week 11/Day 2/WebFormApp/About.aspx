<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebFormApp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    </h3>
    <p>Use this area to provide additional information.<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
</asp:Content>
