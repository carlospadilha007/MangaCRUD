Public Class UpdateAccount
    Inherits System.Web.UI.Page

    Public userEmail As String = String.Empty
    Public userData As User = New User

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim viewModel As ViewModel = New ViewModel
        Try
            If Not Page.PreviousPage Is Nothing Then
                Dim email = PreviousPage.getEmail.ToString()
                viewModel.getUserData(userData, email)
                tbUpdateFirstName.Text = userData.firstName
                tbUpdateLastName.Text = userData.lastName
                tbUpdateEmail.Text = userData.email
                tbUpdatePassword.Text = userData.password

                userEmail = userData.email
                lbMail.Text = userData.email

            End If
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Protected Sub btnDeleteAccount_Click(sender As Object, e As EventArgs) Handles btnDeleteAccount.Click
        Dim viewModel As ViewModel = New ViewModel
        userEmail = lbMail.Text.ToString
        viewModel.getUserData(userData, userEmail)
        viewModel.deleteUser(userData.userId)
    End Sub

    Protected Sub btnUpdateAccount_Click(sender As Object, e As EventArgs) Handles btnUpdateAccount.Click
        Dim viewModel As ViewModel = New ViewModel
        Dim fName As String, lName As String, email As String, newPass As String
        viewModel.getUserData(userData, userEmail)
        fName = tbUpdateFirstName.ToString
        lName = tbUpdateLastName.ToString
        email = tbUpdateEmail.ToString
        newPass = tbNewPassword.ToString
        viewModel.UpdateUser(userData, userData.userId, fName, lName, email, newPass)
    End Sub
End Class