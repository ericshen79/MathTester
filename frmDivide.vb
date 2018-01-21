Imports System.ComponentModel

Public Class frmDivide
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        For Each i As Control In Me.Controls
            If i.Name.Substring(0, 7) = "TextBox" Then
                i.Text = ""
            End If
        Next
    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress, TextBox3.KeyPress, TextBox4.KeyPress, TextBox5.KeyPress, TextBox6.KeyPress, TextBox7.KeyPress, TextBox8.KeyPress, TextBox9.KeyPress, TextBox10.KeyPress, TextBox11.KeyPress, TextBox12.KeyPress, TextBox14.KeyPress, TextBox15.KeyPress, TextBox18.KeyPress, TextBox19.KeyPress, TextBox23.KeyPress
        Dim i As Integer
        i = Asc(e.KeyChar)

        If (i < Asc("0") Or i > Asc("9")) And e.KeyChar <> vbBack Then

            Debug.Print(e.KeyChar)
            e.KeyChar = Nothing
        Else
            sender.Text = ""
        End If
    End Sub

    Private Sub frmHelper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = TextBox5
    End Sub

    Private Sub frmHelper_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        btnReset_Click(Nothing, Nothing)
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged, TextBox4.TextChanged, TextBox5.TextChanged, TextBox6.TextChanged, TextBox7.TextChanged, TextBox8.TextChanged, TextBox9.TextChanged, TextBox10.TextChanged, TextBox11.TextChanged, TextBox12.TextChanged, TextBox14.TextChanged, TextBox15.TextChanged, TextBox18.TextChanged, TextBox19.TextChanged, TextBox23.TextChanged
        If sender.Text <> "" Then
            Me.SelectNextControl(sender, True, True, True, True)
        End If
    End Sub


End Class