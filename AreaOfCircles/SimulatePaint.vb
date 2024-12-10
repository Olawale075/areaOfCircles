Public Class SimulatePaint
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dim salary As New SalaryCalculation()
        salary.Show()
        Me.Hide()
    End Sub
End Class