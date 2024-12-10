Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SalaryCalculation
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles hra.TextChanged

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim bp, hr, cc, ta, gp, pf, lic, td, np As Double
        bp = Val(amt.Text)
        hr = Val(hra.Text)
        cc = Val(ccas.Text)
        pf = Val(pfs.Text)
        lic = Val(lics.Text)
        ta = hr + cc
        gp = bp + ta
        td = pf + lic
        np = gp - td
        tota.Text = Str(ta)
        gps.Text = Str(gp)
        totd.Text = Str(td)

        nps.Text = Str(np)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pfs.Text = ""
        tota.Text = ""
        totd.Text = ""
        lics.Text = ""
        amt.Text = ""
        ccas.Text = ""
        hra.Text = ""
        gps.Text = ""
        nps.Text = ""
        amt.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class