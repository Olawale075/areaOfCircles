Public Class ManageEmployee
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim newf As New AreaOfCircle()
        newf.Show()
        Me.Hide()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim currencyConversion As New CurrencyConversion()
        currencyConversion.Show()
        Me.Hide()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim retrieveImages As New RetrieveImages()
        retrieveImages.Show()
        Me.Hide()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim simulatePaint As New SimulatePaint()

        simulatePaint.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim moveAnObject As New MoveAnObject()

        moveAnObject.Show()
        Me.Hide()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Dim areaOfcircle As New AreaOfCircle()

        areaOfcircle.Show()
        Me.Hide()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Dim areaOfcircle As New AreaOfCircle()

        areaOfcircle.Show()
        Me.Hide()



    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dim salary As New SalaryCalculation()
        salary.Show()
        Me.Hide()
    End Sub
End Class