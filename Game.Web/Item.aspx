<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Item.aspx.cs" Inherits="Game.Web.Item" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    <asp:GridView ID="GridView1" runat="server" Width="632px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Delete"  HeaderText="功能欄位" ShowHeader="True" Text="刪除" />
        </Columns>
    </asp:GridView>
</asp:Content>

