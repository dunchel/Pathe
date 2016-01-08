<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Framepage.Master" AutoEventWireup="true" CodeBehind="FilmOverzicht.aspx.cs" Inherits="Pathe.Pages.FilmOverzicht" %>

<asp:Content ContentPlaceHolderID="Header" runat="server">
    <title>Pathe - Film overzicht</title>
</asp:Content>

<asp:Content ContentPlaceHolderID="Body" runat="server">
    <h1 id="filmoverzichtlabel" runat="server">Film overzicht</h1>
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
      <ul id="AddMovieDialog" runat="server" visible="false">
                <li style="list-style-type: none">
                    <asp:TextBox ID="TB_Filmnaam" runat="server" placeholder="Filmnaam"  CssClass="sortregister"></asp:TextBox>
                </li>
                <li style="list-style-type: none">
                    <asp:TextBox ID="TB_Rating" runat="server" placeholder="Rating"  CssClass="sortregister"></asp:TextBox>
                </li>
                <li style="list-style-type: none">
                    <asp:TextBox ID="TB_Kijkwijzer" runat="server" placeholder="Kijkwijzer"  CssClass="sortregister"></asp:TextBox>
                </li>
                <li style="list-style-type: none">
                   <asp:TextBox ID="TB_Genre" runat="server" placeholder="Genre"  CssClass="sortregister"></asp:TextBox>
                </li>
                <li style="list-style-type: none">
                    <asp:TextBox ID="TB_Kwaliteit" runat="server" placeholder="Kwaliteit"  CssClass="sortregister"></asp:TextBox>
                </li>
                <li style="list-style-type: none">
                    <asp:DropDownList ID="dp_Dimensionaal" runat="server"  CssClass="sortregister">
                        <asp:ListItem Text="2D" Value="2D" />
                        <asp:ListItem Text="3D" Value="3D" />
                    </asp:DropDownList>
                </li>
                <li style="list-style-type: none">
                    <asp:TextBox ID="Lengte" runat="server" placeholder="Lengte"  CssClass="sortregister"></asp:TextBox>
                </li>
               
               <asp:Button Text="Add Film" ID="btn_AddFilm" runat="server" Visible="false" CssClass="buttonexpanded" OnClick="btn_AddFilm_Click" />
            </ul>

    

</asp:Content>
