Imports System.Data.SqlClient

Public Class computers

    Dim locator As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btn_LRC_Click(sender As Object, e As EventArgs) Handles btn_LRC.Click
        locator = "LRC"
        Me.lbl_locator.Text = locator
    End Sub

    Private Sub btn_LC_Click(sender As Object, e As EventArgs) Handles btn_LC.Click
        locator = "LC"
        Me.lbl_locator.Text = locator
    End Sub

    Private Sub btn_mob_Click(sender As Object, e As EventArgs) Handles btn_mob.Click
        locator = "MOB"
        Me.lbl_locator.Text = locator
    End Sub

    Private Sub btn_oth_Click(sender As Object, e As EventArgs) Handles btn_oth.Click
        locator = InputBox("Enter a room number or locator")
        Me.lbl_locator.Text = locator
    End Sub




    Private Sub computers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=localhost;Initial Catalog=prs;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM Comp WHERE locator = @locator", con)
        cmd.Parameters.AddWithValue("@locator", locator)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btn_power_Click(sender As Object, e As EventArgs) Handles btn_power.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=localhost;Initial Catalog=prs;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
        Dim cmd As SqlCommand = New SqlCommand("UPDATE Comp SET IsON = 'NO' WHERE locator = @locator AND LoggedIn = 'NO' AND IsOn = 'YES'", con)
        cmd.Parameters.AddWithValue("@locator", locator)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        DataGridView1.DataSource = dt
        currentUsed = currentUsed - 2000
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btn_all_Click(sender As Object, e As EventArgs) Handles btn_all.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=localhost;Initial Catalog=prs;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM Comp", con)

        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=localhost;Initial Catalog=prs;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
        Dim cmd As SqlCommand = New SqlCommand("UPDATE Comp SET IsON = 'NO' WHERE LoggedIn = 'NO' AND IsOn = 'YES'", con)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        DataGridView1.DataSource = dt
        currentUsed = currentUsed - 2000
    End Sub


End Class