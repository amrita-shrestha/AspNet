<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LearningCRUD.WebForm1" %>
<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="PC" TagName="Card" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <%-- <div>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    </div--%>>
    <%-- for user control --%>
    <PC:Card runat="server"
        Title="Samsung"
        Description="Something"
        Image="https://images.unsplash.com/photo-1511385348-a52b4a160dc2?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1814&q=80"
        ></PC:Card>
    <PC:Card runat="server"
        Title="Samsung"
        Description="Something"
        Image="https://images.unsplash.com/photo-1511385348-a52b4a160dc2?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1814&q=80"
        ></PC:Card>
    <PC:Card runat="server"
        Title="Samsung"
        Description="Something"
        Image="https://cdn.thewirecutter.com/wp-content/media/2023/04/budgetandroidphones-2048px-2x1-1.jpg?auto=webp&quality=75&crop=2:1&width=980&dpr=2"
        ></PC:Card>
</asp:Content>
