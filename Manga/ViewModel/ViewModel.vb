Imports System.Data.SqlClient

Imports System.IO
Imports System.Xml
Imports Newtonsoft.Json
Public Class ViewModel

    Private conectString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UserLogin;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    Private queryInsert As String = String.Empty
    Private queryDelete As String = String.Empty
    Private queryUpdate As String = String.Empty

    Public Sub CreateUser(ByRef user As User)

        Dim firstName = user.firstName
        Dim lastName = user.lastName
        Dim email = user.email
        Dim password = user.password
        Dim id = -1

        'Queries
        queryInsert &= "INSERT INTO UsersData (id, firstName, lastName, email, password)"
        queryInsert &= "VALUES (@id, @firstName, @lastName, @email, @password)"

        'query que verifica emails repitidos
        Dim queryEmailIsNew = "SELECT * FROM UsersData Where email="
        queryEmailIsNew &= "'" & email & "'"

        'query que busca os dados no banco
        Dim queryAllData = "SELECT * FROM UsersData"


        If verificationNewAccount(email) Then
            Using con As SqlConnection = New SqlConnection(conectString)
                Using cmd As SqlCommand = New SqlCommand(queryInsert, con)

                    cmd.Parameters.AddWithValue("@firstName", firstName)
                    cmd.Parameters.AddWithValue("@lastName", lastName)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@password", password)

                    'proximo valor do id
                    id = getLastUserId() + 1
                    user.userId = id
                    cmd.Parameters.AddWithValue("@id", id)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                End Using
            End Using
        End If

    End Sub

    Private Function countUsers(ByVal selectString As String) As Int32
        '"SELECT * FROM UsersData Where email='teste3@email.com'"
        Using con As SqlConnection = New SqlConnection(conectString)
            Dim adapter As New SqlDataAdapter(selectString, con)
            Dim n_users As New DataTable
            adapter.Fill(n_users)
            Return n_users.Rows.Count
        End Using
    End Function

    Private Function verificationNewAccount(ByVal email As String) As Boolean
        Dim query = "SELECT * FROM UsersData Where email="
        query &= "'" & email & "'"
        Dim c = countUsers(query)
        If (countUsers(query) = 0) Then
            Return True
        Else Return False
        End If
    End Function


    Private Function getLastUserId() As Int32


        Using con As SqlConnection = New SqlConnection(conectString)
            Dim stringQuery = "SELECT TOP (3) * FROM UsersData ORDER BY Id DESC"
            Dim adapter As New SqlDataAdapter(stringQuery, con)
            Dim n_users As New DataTable
            adapter.Fill(n_users)
            Dim u As Integer = n_users.Rows.Count
            Dim lastUser = n_users.Rows.Cast(Of DataRow)().FirstOrDefault()

            Console.WriteLine(lastUser.GetType)
            Console.WriteLine(lastUser("Id"))
            Return lastUser("Id")
        End Using

    End Function

End Class
