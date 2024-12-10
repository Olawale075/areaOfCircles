Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AreaOfCircle
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r, area As Double
        Const Pi = 3.142
        'r = InputBox("Enter Your radius")
        r = radiuTxt.Text



        area = Pi * r * r

        TextBox1.Text = Str(area)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim newf As New AreaOfTriangle()
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

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Dim salary As New SalaryCalculation
        salary.Show()
        Me.Hide()




    End Sub
End Class
