Imports System.Diagnostics.CodeAnalysis

Public Class AddLiv

    Private Sub AddLiv_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTN1_Click(sender As Object, e As EventArgs) Handles BTN1.Click
        If Not (IsNumeric(TB1.Text) And Len(TB1.Text) = 13) Or (ListLiv.LB1.Items.Contains(TB1.Text)) Or (String.IsNullOrWhiteSpace(TB2.Text)) Or (String.IsNullOrWhiteSpace(TB3.Text)) Then
            MessageBox.Show("erreur")
        Else
            Dim Fromx As ListLiv()
            ListLiv.LB1.Items.Add(TB1.Text)
            ListLiv.LB2.Items.Add(TB2.Text)
            ListLiv.LB3.Items.Add(TB3.Text)
            List2.DGV_Livre.Rows.Add(TB1.Text, TB2.Text, TB3.Text)

        End If


    End Sub

    Private Sub TB1_TextChanged(sender As Object, e As EventArgs) Handles TB1.TextChanged

    End Sub

    Private Sub TB2_TextChanged(sender As Object, e As EventArgs) Handles TB2.TextChanged

    End Sub

    Private Sub BTN2_Click(sender As Object, e As EventArgs) Handles BTN2.Click
        Form2.ShowForm(New ListLiv)
    End Sub
End Class
