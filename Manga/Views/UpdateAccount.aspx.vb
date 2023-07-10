Public Class UpdateAccount
    Inherits System.Web.UI.Page

    Private userId As Int32 = New Int32
    Private userEmail As String = String.Empty

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim viewModel As ViewModel = New ViewModel
        Dim user As User = New User
        Try
            If Not Page.PreviousPage Is Nothing Then
                Dim email = PreviousPage.getEmail.ToString()
                viewModel.getUserData(user, email)
                tbUpdateFirstName.Text = user.firstName
                tbUpdateLastName.Text = user.lastName
                tbUpdateEmail.Text = user.email
                tbUpdatePassword.Text = user.password

                userId = CType(PreviousPage.getUserId.ToString, Int32)
                userEmail = PreviousPage.getEmail

            End If
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Protected Sub btnDeleteAccount_Click(sender As Object, e As EventArgs) Handles btnDeleteAccount.Click
        Dim viewModel As ViewModel = New ViewModel
        viewModel.deleteUser(userId)
    End Sub
End Class