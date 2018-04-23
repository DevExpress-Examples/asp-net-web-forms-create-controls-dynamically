<%@ Page Language="vb" AutoEventWireup="true" CodeFile="LoadSingleWebControl.aspx.vb" Inherits="LoadSingleWebControl" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v8.3, Version=8.3.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Load Web Control</title>
	<style type="text/css">
	.PanelControlsContainer { padding: 5px; }
	</style>
</head>
<body>
	<form id="frmMain" runat="server">
		<dx:ASPxButton ID="btnCreateControl" runat="server" Text="Create a New Control" OnClick="btnCreateControl_Click"></dx:ASPxButton>
		<asp:Panel ID="pnlContainer" runat="server" BorderColor="black" BorderStyle="Dotted" BorderWidth="1" CssClass="PanelControlsContainer">
		</asp:Panel>
		<a href="Default.aspx"><< Home</a>
	</form>
</body>
</html>
