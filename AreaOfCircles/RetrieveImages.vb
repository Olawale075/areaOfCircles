Public Class RetrieveImages
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim areaOfcircle As New AreaOfCircle()

        areaOfcircle.Show()
        Me.Hide()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim currencyConversion As New CurrencyConversion()
        currencyConversion.Show()
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
        Dim formControls As New FormControls()


        formControls.Show()
        Me.Hide()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Dim employeeMagement As New ManageEmployee()
        employeeMagement.Show()
        Me.Hide()



    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Dim Mathcalculator As New MathCalculator
        Mathcalculator.Show()
        Me.Hide()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dim salary As New SalaryCalculation()
        salary.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ComboBox1.SelectedIndex = 0) Then
            PictureBox1.Image = Image.FromFile("C:\Users\Olawa\Pictures\Screenshots\Screenshot 2024-11-29 214959.png")
        ElseIf (ComboBox1.SelectedIndex = 1) Then
            PictureBox1.Image = Image.FromFile("C:\Users\Olawa\Pictures\Screenshots\Screenshot 2024-11-26 220934.png")
        ElseIf (ComboBox1.SelectedIndex = 2) Then
            PictureBox1.Image = Image.FromFile("C:\Users\Olawa\Pictures\Screenshots\Screenshot 2024-11-26 213309.png")
        ElseIf (ComboBox1.SelectedIndex = 3) Then
            PictureBox1.Image = Image.FromFile("C:\Users\Olawa\Pictures\Screenshots\pack.png")
        ElseIf (ComboBox1.SelectedIndex = 4) Then
            PictureBox1.Image = Image.FromFile("C:\Users\Olawa\Pictures\MEmu Photo\_MG_6725.CR2")
        End If

    End Sub
End Class