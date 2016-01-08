<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Framepage.Master" AutoEventWireup="true" CodeBehind="FilmOverzicht.aspx.cs" Inherits="Pathe.Pages.FilmOverzicht" %>

<asp:Content ContentPlaceHolderID="Header" runat="server">
    <title>Pathe - Film overzicht</title>
</asp:Content>

<asp:Content ContentPlaceHolderID="Body" runat="server">
    <h1>Film overzicht</h1>
    <asp:ListView ID="lv_FilmList" runat="server" OnItemDataBound="lv_FilmList_ItemDataBound" OnSelectedIndexChanged="lv_FilmList_SelectedIndexChanged">
        <ItemTemplate>
            <div class="filmbox">
              
                <a href="Film.aspx?id=<%# Eval("FilmID") %>"> <%# Eval("Filmnaam") %></a>
                <br />

                <asp:Label ID="filmrating" Text="text" runat="server"  />
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
            </div>

        </ItemTemplate>
    </asp:ListView>
</asp:Content>
