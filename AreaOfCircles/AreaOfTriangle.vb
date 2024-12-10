Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AreaOfTriangle
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
        Dim FormControls As New FormControls()

        FormControls.Show()
        Me.Hide()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Dim employeeMagement As New ManageEmployee()
        employeeMagement.Show()
        Me.Hide()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        btxt.Text = ""
        hTxt.Text = ""
        rtxt.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim b, h, area As Double
        b = Val(btxt.Text)
        h = Val(hTxt.Text)
        area = 0.5 * b * h
        rtxt.Text = Str(area)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Dim salary As New SalaryCalculation()
        salary.Show()
        Me.Hide()
    End Sub
End Class