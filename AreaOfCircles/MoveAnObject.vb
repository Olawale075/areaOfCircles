Public Class MoveAnObject
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dim salary As New SalaryCalculation()
        salary.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

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
            PictureBox1.Image = Image.FromFile("C:\Users\Olawa\Pictures\Screenshots\Screenshot 2024-08-15 164544.png")
        End If

    End Sub






    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick



        PictureBox1.Location = New Point(PictureBox1.Location.X + 5,
PictureBox1.Location.Y)

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub






    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        PictureBox1.Location = New Point(PictureBox1.Location.X,
PictureBox1.Location.Y - 5)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Timer3.Enabled = True
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer4.Enabled = False
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        PictureBox1.Location = New Point(PictureBox1.Location.X,
PictureBox1.Location.Y + 5)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer3.Enabled = True
    End Sub
End Class