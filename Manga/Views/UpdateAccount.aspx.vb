Public Class UpdateAccount
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not Page.PreviousPage Is Nothing Then

                lbEmail.Text = PreviousPage.getEmail.ToString()
                lbFirstName.Text = PreviousPage.getUserId.ToString()

            End If
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

End Class