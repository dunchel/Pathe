<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Framepage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Pathe.Pages.Login" %>

<asp:Content ContentPlaceHolderID="Header" runat="server">
    <title>Pathe - Home</title>
</asp:Content>
<asp:Content ContentPlaceHolderID="Body" runat="server">
    <form id="FormLogin" runat="server">

        <h1>Login</h1>
       

        <ul>
             <asp:Label ID="Welkom" runat="server" Text="Welkom" CssClass=""></asp:Label>
            <li style="list-style-type: none">
                <asp:TextBox ID="TB_Username" runat="server" placeholder="Username" Height="22px" CssClass="logintextbox"></asp:TextBox>
            </li>
            <li style="list-style-type: none">
                <asp:TextBox ID="TB_Password" runat="server" placeholder="Password" Height="22px" CssClass="logintextbox"></asp:TextBox>
            </li>
        </ul>

        <ul>
            <li style="list-style-type: none">
                <asp:Button ID="Btn_Login" runat="server"  OnClick="Btn_Login_Click" Text="Login" Width="100px" />
            </li>
            <li style="list-style-type: none">
                <asp:Button ID="Btn_Register" runat="server" Text="Register" Width="100px" OnClick="Btn_Register_Click1" />
            </li>
        </ul>
    </form>
</asp:Content>
