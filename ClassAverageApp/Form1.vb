Option Strict On
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles newGradeBTN.Click
        Dim num As Integer = CInt(newGradeTBX.Text)
        gradesLBX.Items.Add(num)
    End Sub

    Private Sub calculateBTN_Click(sender As Object, e As EventArgs) Handles calculateBTN.Click
        Dim sum As Integer = 0
        Dim average As Double
        For i = 0 To gradesLBX.Items.Count - 1
            sum += CInt(gradesLBX.Items(i))
        Next
        average = sum / gradesLBX.Items.Count

        outputLBL.Text = String.Format("{0:F1}", average)
    End Sub
End Class
