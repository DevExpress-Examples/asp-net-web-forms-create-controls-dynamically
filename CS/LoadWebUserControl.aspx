<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoadWebUserControl.aspx.cs"
    Inherits="LoadWebUserControl" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Load Web User Control</title>
</head>
<body>
    <form id="frmMain" runat="server">
        <dx:ASPxComboBox ID="ASPxComboBox1" runat="server" ValueType="System.String" AutoPostBack="True"
            OnSelectedIndexChanged="ASPxComboBox1_SelectedIndexChanged">
            <Items>
                <dx:ListEditItem Text="WebUserControl.ascx" Value="WebUserControl.ascx"></dx:ListEditItem>
                <dx:ListEditItem Text="WebUserControl2.ascx" Value="WebUserControl2.ascx"></dx:ListEditItem>
            </Items>
        </dx:ASPxComboBox>
        <br />
        <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="200px">
        </dx:ASPxRoundPanel>
        <br />
        <a href="Default.aspx"><< Home</a>
    </form>
</body>
</html>