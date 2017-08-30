Public Class frmConfig
    Public MainForm As FrmMath

    'Public Max_Number As Integer = 99
    'Public Min_Number As Integer = 10
    'Public Max_Plus_Value As Integer = 100
    'Public Min_Minus_Value As Integer = 0


    Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMax.Text = MainForm.Max_Number
        txtMin.Text = MainForm.Min_Number
        txtPlus.Text = MainForm.Max_Plus_Value
        txtMinus.Text = MainForm.Min_Minus_Value
        txtSeconds.Text = MainForm.Max_Seconds

    End Sub

    Private Sub txtValidate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMax.KeyPress, txtMin.KeyPress, txtPlus.KeyPress, txtMinus.KeyPress, txtSeconds.KeyPress
        Dim i As Integer
        i = Asc(e.KeyChar)

        If (i < Asc("0") Or i > Asc("9")) And e.KeyChar <> vbBack Then

            Debug.Print(e.KeyChar)
            e.KeyChar = Nothing
        End If

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If Val(txtMax.Text) > Val(txtMin.Text) And Val(txtPlus.Text) > Val(txtMinus.Text) And Val(txtPlus.Text) > Val(txtMax.Text) Then

            MainForm.Max_Number = txtMax.Text
            MainForm.Min_Number = txtMin.Text
            MainForm.Max_Plus_Value = txtPlus.Text
            MainForm.Min_Minus_Value = txtMinus.Text
            MainForm.Max_Seconds = txtSeconds.Text
            Me.Close()

        End If
    End Sub
End Class