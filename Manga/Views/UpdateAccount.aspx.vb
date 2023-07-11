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
                tbUpdateFirstName.Text = RTrim(userData.firstName)
                tbUpdateLastName.Text = RTrim(userData.lastName)
                tbUpdateEmail.Text = RTrim(userData.email)
                tbUpdatePassword.Text = RTrim(userData.password)

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
        userEmail = lbMail.Text.ToString
        viewModel.getUserData(userData, userEmail)
        fName = RTrim(tbUpdateFirstName.Text.ToString)
        lName = RTrim(tbUpdateLastName.Text.ToString)
        email = RTrim(tbUpdateEmail.Text.ToString)
        newPass = RTrim(tbNewPassword.Text.ToString)
        viewModel.UpdateUser(userData, userData.userId, fName, lName, email, newPass)
        lbMail.Text = userData.email

    End Sub
End Class