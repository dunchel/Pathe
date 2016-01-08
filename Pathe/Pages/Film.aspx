<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Framepage.Master" AutoEventWireup="true" CodeBehind="Film.aspx.cs" Inherits="Pathe.Pages.Film" %>


<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="server">
    <title>Film</title>
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <h1><asp:Literal runat="server" ID="filmnaam"></asp:Literal></h1>
</asp:Content>
