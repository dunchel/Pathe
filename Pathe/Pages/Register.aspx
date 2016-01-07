<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Pages/Framepage.Master" CodeBehind="Register.aspx.cs" Inherits="Pathe.Pages.Register" %>


<asp:Content ContentPlaceHolderID="Header" runat="server">
    <title>Pathe - Register</title>
</asp:Content>
<asp:Content ContentPlaceHolderID="Body" runat="server">
    <form id="FormRegister" runat="server">

        <div>
            <h1>Register</h1>
            
            <ul>
                <li style="list-style-type: none">
                    <asp:TextBox ID="TB_Voornaam" runat="server" placeholder="Voornaam" required="required" CssClass="sortregister"></asp:TextBox>
                </li>
                <li style="list-style-type: none">
                    <asp:TextBox ID="TB_Achternaam" runat="server" placeholder="Achternaam" required="required" CssClass="sortregister"></asp:TextBox>
                </li>
                <li style="list-style-type: none">
                    <asp:TextBox ID="TB_Wachtwoord" runat="server" placeholder="Wachtwoord" required="required" CssClass="sortregister"></asp:TextBox>
                </li>
                <li style="list-style-type: none">
                   <asp:TextBox ID="TB_Geslacht" runat="server" placeholder="Geslacht" required="required" CssClass="sortregister"></asp:TextBox>
                </li>
                <li style="list-style-type: none">
                    <asp:TextBox ID="TB_Straat" runat="server" placeholder="Straat" required="required" CssClass="sortregister"></asp:TextBox>
                </li>
                <li style="list-style-type: none">
                  <asp:TextBox ID="TB_Huisnummer" runat="server" placeholder="Huisnummer" required="required" CssClass="sortregister"></asp:TextBox>
                </li>
                <li style="list-style-type: none">
                    <asp:TextBox ID="TB_Postcode" runat="server" placeholder="Postcode" required="required" CssClass="sortregister"></asp:TextBox>
                </li>
                <li style="list-style-type: none">
                    <asp:TextBox ID="TB_Plaats" runat="server" placeholder="Plaats" required="required" CssClass="sortregister"></asp:TextBox>
                </li>
                <li style="list-style-type: none">
                    <asp:TextBox ID="TB_Telefoonnummer" runat="server" placeholder="Telefoonnummer" required="required" CssClass="sortregister"></asp:TextBox>
                </li>
                <li style="list-style-type: none">
                    <asp:TextBox ID="TB_Email" runat="server" placeholder="Email" required="required" CssClass="sortregister"></asp:TextBox>
                </li>
                <li style="list-style-type: none">
                    <asp:TextBox ID="TB_Abbonement" runat="server" placeholder="Abbonement" required="required" CssClass="sortregister"></asp:TextBox>
                </li>
                <asp:Button ID="BTN_Register"  OnClick="BTN_Register_Click" runat="server" Text="Register Now!" CssClass="buttonexpanded" />





            </ul>
        </div>
    </form>
</asp:Content>

