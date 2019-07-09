<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="Game.Web.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblAccountDetails" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:LinkButton ID="lkbtnMember" runat="server" OnClick="lkbtnMember_Click">查看使用者帳號密碼表</asp:LinkButton>
            <br />
            <br />
            <asp:LinkButton ID="lkbtnItem" runat="server" OnClick="lkbtnItem_Click">查看物品基本數值表</asp:LinkButton>
            <br />
            <br />
            <asp:LinkButton ID="lkbtnMonster" runat="server" OnClick="lkbtnMonster_Click">查看怪物基本數據表</asp:LinkButton>
            <br />
            <br />
            <asp:LinkButton ID="lkbtnTreasure" runat="server" OnClick="lkbtnTreasure_Click">查看怪物掉落寶物資料表</asp:LinkButton>
            <br />
            <br />
            <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" style="height: 21px" />
        </div>
    </form>
</body>
</html>
