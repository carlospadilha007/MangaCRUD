Public Class UserLogin
    Inherits System.Web.UI.Page

    Private userId As String = String.Empty
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not Page.PreviousPage Is Nothing Then

                tbEmailLogin.Text = PreviousPage.getEmail.ToString()
                userId = PreviousPage.getUserId.ToString()
                tbPasswordLogin.Text = PreviousPage.getPassword.ToString()
            End If
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public ReadOnly Property getEmail() As String
        Get
            Return tbEmailLogin.Text
        End Get
    End Property

    Public ReadOnly Property getUserId() As String
        Get
            Return userId
        End Get
    End Property

End Class