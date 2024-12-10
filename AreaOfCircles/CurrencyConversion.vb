Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class CurrencyConversion
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim newf As New AreaOfTriangle()
        newf.Show()
        Me.Hide()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim areaOfCircle As New AreaOfCircle()
        areaOfCircle.Show()
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

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Dim areaOfTringle As New AreaOfTriangle()
        areaOfTringle.Show()
        Me.Hide()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim v, res, val1, val2 As Double
        If ComboBox1.SelectedItem = "Rupee" Then
            val1 = 1.0
        ElseIf ComboBox1.SelectedItem = "Dollar" Then
            val1 = 67.5
        ElseIf ComboBox1.SelectedItem = "Euro" Then
            val1 = 73
        End If
        If ComboBox2.SelectedItem = "Rupee" Then
            val2 = 1.0
        ElseIf ComboBox2.SelectedItem = "Dollar" Then
            val2 = 67.5
        ElseIf ComboBox2.SelectedItem = "Euro" Then
            val2 = 73
        End If
        v = Val(TextBox1.Text)
        res = v * val1 / val2
        rtxt.Text = Str(res)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        rtxt.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dim salary As New SalaryCalculation()
        salary.Show()
        Me.Hide()
    End Sub
End Class