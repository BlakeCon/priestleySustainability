Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_Used.Text = "£" & mod_stats.currentUsed.ToString()
        lbl_current.Text = "£" & mod_stats.currentbuget.ToString()

        pbar_budget.Value = pbarProgress()


    End Sub


    Private Sub btn_lighting_Click(sender As Object, e As EventArgs) Handles btn_lighting.Click
        Me.Hide()
        lighting.Show()
    End Sub

    Private Sub btn_computers_Click(sender As Object, e As EventArgs) Handles btn_computers.Click
        Me.Hide()
        computers.Show()
    End Sub

    Private Sub btn_Other_Click(sender As Object, e As EventArgs) Handles btn_Other.Click
        Me.Hide()
        other.Show()
    End Sub

    Private Sub pbar_budget_Click(sender As Object, e As EventArgs) Handles pbar_budget.Click

    End Sub

    Private Sub btn_change_Click(sender As Object, e As EventArgs) Handles btn_change.Click
        Dim newbudget As Integer
        newbudget = InputBox("Enter a new budget")
        currentbuget = newbudget
        lbl_current.Text = "£" & mod_stats.currentbuget.ToString()

        pbar_budget.Value = pbarProgress()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lbl_Used.Text = "£" & mod_stats.currentUsed.ToString()
        lbl_current.Text = "£" & mod_stats.currentbuget.ToString()

        pbar_budget.Value = pbarProgress()
    End Sub
End Class
