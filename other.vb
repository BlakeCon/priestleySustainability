Imports System.Data.SqlClient

Public Class other
    Private Sub Usage_Click(sender As Object, e As EventArgs) Handles Usage.Click

    End Sub

    Private Sub other_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As SqlConnection = New SqlConnection("Data Source=localhost;Initial Catalog=prs;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM Other", con)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        DataGridView1.DataSource = dt

        Dim con2 As SqlConnection = New SqlConnection("Data Source=localhost;Initial Catalog=prs;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
        Dim cmd2 As SqlCommand = New SqlCommand("SELECT * FROM Other WHERE AC = 'YES' AND Heating = 'YES'", con2)
        Dim a2 As New SqlDataAdapter(cmd2)
        Dim dt2 As New DataTable
        a2.Fill(dt2)
        DataGridView2.DataSource = dt2

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class