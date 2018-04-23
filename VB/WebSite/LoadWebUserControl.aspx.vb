Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class LoadWebUserControl
	Inherits System.Web.UI.Page
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		If Session("Name") IsNot Nothing Then
			LoadUserControl(Session("Name").ToString())
		End If
	End Sub

	Protected Sub ASPxComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim ucName As String = ASPxComboBox1.SelectedItem.Text
		LoadUserControl(ucName)
		Session("Name") = ucName
	End Sub

	Private Sub LoadUserControl(ByVal ucName As String)
		Dim control As Control = LoadControl(ucName)
		control.ID = ucName.Split(New Char() { "."c }, StringSplitOptions.RemoveEmptyEntries)(0)
		ASPxRoundPanel1.Controls.Clear()
		ASPxRoundPanel1.Controls.Add(control)
	End Sub
End Class
