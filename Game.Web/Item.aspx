<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Item.aspx.cs" Inherits="Game.Web.Item" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    <asp:GridView ID="GridView1" runat="server" Width="632px" OnRowCommand="GridView1_RowCommand1"  >
        <Columns>
            <asp:ButtonField CommandName="edit" HeaderText="Edit" Text="按鈕" />
            <asp:ButtonField CommandName="del" HeaderText="Del" Text="按鈕" />
        </Columns>
    </asp:GridView>
</asp:Content>

