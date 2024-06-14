Imports Microsoft.VisualBasic.ApplicationServices

Module mod_stats
    Public currentbuget As Integer = 100000
    Public currentUsed As Integer = 180200

    Private Function InitializeRandomNumber() As Integer
        Dim rand As New Random()
        Return rand.Next(1000, 10000)
    End Function
    Public Function pbarProgress() As Decimal
        Dim percentageUsed As Decimal = (currentUsed / currentbuget) * 100
        If percentageUsed <= 100 Then
            Return percentageUsed
        Else
            Return 100
        End If
    End Function
End Module
