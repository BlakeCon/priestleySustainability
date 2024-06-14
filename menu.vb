Public Class menu
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_Used.Text = "£" & mod_stats.currentUsed.ToString()
        lbl_current.Text = "£" & mod_stats.currentbuget.ToString()

        pbar_budget.Value = pbarProgress()

    End Sub


    Private Sub btn_lighting_Click(sender As Object, e As EventArgs) Handles btn_lighting.Click

    End Sub

    Private Sub btn_computers_Click(sender As Object, e As EventArgs) Handles btn_computers.Click

    End Sub

    Private Sub btn_Other_Click(sender As Object, e As EventArgs) Handles btn_Other.Click

    End Sub

    Private Sub pbar_budget_Click(sender As Object, e As EventArgs) Handles pbar_budget.Click

    End Sub
End Class
