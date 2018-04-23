Imports System
Imports System.Web.UI
Imports DevExpress.Web.ASPxEditors

Partial Public Class LoadSingleWebControl
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
        If Session("WasButtonCreated") IsNot Nothing Then
            CreateControlProcedure(pnlContainer)
        End If
    End Sub

    Protected Sub btnCreateControl_Click(ByVal sender As Object, ByVal e As EventArgs)
        If Session("WasButtonCreated") Is Nothing Then
            CreateControlProcedure(pnlContainer)
            Session("WasButtonCreated") = True
        End If
    End Sub
    Private Sub CreateControlProcedure(ByVal container As Control)
        Dim btn As New ASPxButton()
        btn.ID = "btnRunTime"
        container.Controls.Add(btn)

        btn.Text = String.Format("This ASPxButton is created at RunTime once. ID = {0}", btn.ID)
    End Sub
End Class