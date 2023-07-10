Public Class UserCreate
    Inherits System.Web.UI.Page

    Private userData As User = New User
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click

        userData.firstName = tbFirstName.Text.ToString
        userData.lastName = tbLastName.Text.ToString
        userData.email = tbEmail.Text.ToString
        userData.password = tbPassword.Text.ToString

        'Inserção do Usuário
        Dim viewModel = New ViewModel
        viewModel.CreateUser(userData)
        '~/Views/UpdateAccount.aspx
    End Sub

    Public ReadOnly Property getEmail() As String
        Get
            Return tbEmail.Text
        End Get
    End Property

    Public ReadOnly Property getUserId() As String
        Get
            Return userData.userId
        End Get
    End Property

    Public ReadOnly Property getPassword() As String
        Get
            Return tbPassword.Text
        End Get
    End Property

End Class