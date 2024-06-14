Imports System.Data.SqlClient

Public Class lighting
    Dim locator As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        locator = TextBox1.Text
        Dim con As SqlConnection = New SqlConnection("Data Source=localhost;Initial Catalog=prs;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM Lights WHERE locator = @locator", con)
        cmd.Parameters.AddWithValue("@locator", locator)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_all.Click
        locator = "None"
        Dim con As SqlConnection = New SqlConnection("Data Source=localhost;Initial Catalog=prs;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM Lights", con)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles btn_power.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=localhost;Initial Catalog=prs;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
        Dim cmd As SqlCommand = New SqlCommand("UPDATE Lights SET LightsOn = 'NO' WHERE locator = @locator AND RoomInUse = 'NO' AND LightsOn = 'YES'", con)
        cmd.Parameters.AddWithValue("@locator", locator)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        DataGridView1.DataSource = dt
        currentUsed = currentUsed - 2000
    End Sub

    Private Sub Button4_Click_2(sender As Object, e As EventArgs) Handles Button4.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=localhost;Initial Catalog=prs;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
        Dim cmd As SqlCommand = New SqlCommand("UPDATE Lights SET LightsOn = 'NO' WHERE  RoomInUse = 'NO' AND LightsOn = 'YES'", con)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        DataGridView1.DataSource = dt
        currentUsed = currentUsed - 2000
    End Sub
End Class