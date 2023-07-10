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

    Protected Sub btnLoginAccount_Click(sender As Object, e As EventArgs) Handles btnLoginAccount.Click
        Dim viewModel As ViewModel = New ViewModel
        Dim email = tbEmailLogin.Text.ToString
        Dim pass = tbPasswordLogin.Text.ToString

        'tentativa de parar o metodo postback caso o login não seja aceito
        If viewModel.CheckLogin(email, pass) Then
            btnLoginAccount.Attributes.Add("OnClientClick", "return true;")
        Else
            btnLoginAccount.Attributes.Add("OnClientClick", "return false;")
        End If
    End Sub
End Class