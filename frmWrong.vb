Public Class frmWrong

    Public wrongquestions As List(Of WrongAnswer)

    Private Sub frmWrong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Public Sub LoadData(Optional m_wrongqlist As List(Of WrongAnswer) = Nothing)
        If Not m_wrongqlist Is Nothing Then
            wrongquestions = m_wrongqlist
        End If
        Dim dt As New DataTable("WrongAnswers")
        Dim d1 As DataColumn = dt.Columns.Add("Question to Answer")
        Dim d2 As DataColumn = dt.Columns.Add("Your Answer to The Question")
        Dim d3 As DataColumn = dt.Columns.Add("Correct Answer Should Be")
        Dim d4 As DataColumn = dt.Columns.Add("Round")
        For Each obj As WrongAnswer In wrongquestions
            Dim dr = dt.NewRow()
            dr(0) = obj.Question
            dr(1) = obj.YourAnswer
            dr(2) = "***" 'obj.CorrectAnswer
            dr(3) = obj.Round
            dt.Rows.Add(dr)

        Next

        'dsWrongAnswers.Tables.Add(dt)
        dgvTable.DataSource = dt
        dgvTable.Columns.Item(0).Width = dgvTable.Width * 0.22
        dgvTable.Columns.Item(1).Width = dgvTable.Width * 0.28
        dgvTable.Columns.Item(2).Width = dgvTable.Width * 0.28
        dgvTable.Columns.Item(3).Width = dgvTable.Width * 0.1
        dgvTable.Refresh()
    End Sub

End Class