<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Framepage.Master" AutoEventWireup="true" CodeBehind="Film.aspx.cs" Inherits="Pathe.Pages.Film" %>


<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="server">
    <title>Film</title>
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <h1>
        <asp:Literal runat="server" ID="filmnaam"></asp:Literal></h1>

    
    
    <asp:Label ID="filmrating" Text="text" runat="server" />
    <br />
    <asp:Label ID="kijkwijzer" Text="text" runat="server" />
    <br />
    <asp:Label ID="genre" Text="text" runat="server" />
    <br />
    <asp:Label ID="kwaliteit" Text="text" runat="server" />
    <br />
    <asp:Label ID="dimensionaal" Text="text" runat="server" />
    <br />
    <asp:Label ID="lengte" Text="text" runat="server" />
    <p>
        <h2>Reacties</h2>
    <asp:ListView ID="lv_Reacties" runat="server" OnItemDataBound="lv_Reacties_ItemDataBound">
        <ItemTemplate>
            <div class="filmbox">

                <asp:Label ID="reactietekst" Text="text" runat="server"  />
                <br />
               
            </div>
        </ItemTemplate>
    </asp:ListView>
        <br />
        <asp:TextBox runat="server" ID="TB_reactie" CssClass="logintextbox"></asp:TextBox> 
        <asp:Button runat="server" ID="btn_postReactie" Text="Post Reactie" CssClass="buttonexpanded" OnClick="btn_postReactie_Click" />
        
        </p>

</asp:Content>
