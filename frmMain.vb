Imports System.ComponentModel
Imports System.IO
Imports System.Text

Public Structure WrongAnswer
    Public Question As String
    Public YourAnswer As String
    Public CorrectAnswer As Integer
    Public Round As Integer
    Public Timestamp As DateTime
End Structure

Public Enum OperatorSelection
    Plus_Minus = 0
    Multiply_Divide = 1
    Multiply_Only = 2
    Plus_Minus_Multiply = 3
    Divide_Only = 4
    All = 5
End Enum

Public Class FrmMath
    Private Structure CalculateFormula
        Public FirstValue As Integer
        Public CalculatorOperator As String
        Public SecondValue As Integer
        Public Result As Integer

    End Structure

    Private Structure CorrectAnswer
        Public Question As String
        Public YourAnswer As String
        Public Round As Integer
        Public Timestamp As DateTime
    End Structure

    Public Max_Number As Integer = 99
    Public Min_Number As Integer = 10
    Public Max_Multiply_Number As Integer = 9 '99
    Public Max_Plus_Value As Integer = 100
    Public Min_Minus_Value As Integer = 0
    Public Max_Seconds As Integer = 135

    Public logfile As String
    Public logfile_correct As String

    Const MAX_QUESTIONS = 20

    Dim t As Integer
    Dim wronganswers As Integer = 0
    Dim correctanswers As Integer = 0

    Dim QuestionLabels(MAX_QUESTIONS) As Label
    Dim AnswerTestBoxes(MAX_QUESTIONS) As TextBox
    Dim ToTestFormulas(MAX_QUESTIONS) As CalculateFormula
    Dim r As Integer
    Public OptSelection As OperatorSelection
    Private wrongquestions As List(Of WrongAnswer)
    Private correctquestions As List(Of CorrectAnswer)


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        tmrFinish.Enabled = True
        Dim questions As List(Of String) = New List(Of String)
        btnRecheck.Enabled = False
        r = r + 1
        Dim i As Integer

        Dim ix As Integer = 0
        Dim iy As Integer = 0

        Select Case OptSelection
            Case OperatorSelection.Plus_Minus
                ix = 2
                iy = 0
            Case OperatorSelection.Multiply_Only
                ix = 1
                iy = 2
            Case OperatorSelection.Multiply_Divide
                ix = 2
                iy = 2
            Case OperatorSelection.Plus_Minus_Multiply
                ix = 3
                iy = 0
            Case OperatorSelection.Divide_Only
                ix = 1
                iy = 3
            Case OperatorSelection.All
                ix = 4
                iy = 0
        End Select


        For i = 1 To MAX_QUESTIONS
            Dim x As Integer
            Dim y As Integer
            Dim o As Integer
            Dim z As Integer
            Dim q As String = ""
            Dim goloop As Boolean = True
            Dim m As Integer
            While goloop

                o = Int(Rnd() * ix) + iy

                x = 0
                y = 0
                m = 0

                If o = 0 Or o = 1 Then
                    x = Int(Rnd() * (Max_Number - Min_Number + 1)) + Min_Number
                    y = Int(Rnd() * (Max_Number - Min_Number + 1)) + Min_Number
                ElseIf o = 2 Then
                    'x = Int(Rnd() * 99) + 1
                    x = Int(Rnd() * Max_Multiply_Number) + 1
                    'y = Int(Rnd() * 99) + 1
                    'y = Int(Rnd() * Max_Multiply_Number) + 1
                    y = Int(Rnd() * 30) + 1
                Else
                    Do Until x > 100 And x < 1000
                        m = Int(Rnd() * (500 - 50)) + 51
                        y = Int(Rnd() * (9 - 2)) + 3
                        x = y * m
                        Debug.Print(CStr(y) + "*" + CStr(m) + "=" + CStr(x))
                    Loop
                End If

                Select Case o
                    Case 0 ' +
                        z = x + y
                        q = x.ToString() + " + " + y.ToString + " = "
                    Case 1 ' -
                        z = x - y
                        q = x.ToString() + " - " + y.ToString + " = "
                    Case 2 ' * ×
                        z = x * y
                        q = x.ToString() + " × " + y.ToString + " = "
                    Case 3 ' / ÷ 
                        z = x / y
                        q = x.ToString() + " ÷ " + y.ToString + " = "
                    Case Else
                        ' Not possible
                End Select

                'If o = 1 Then
                'z = x - y
                'Else
                'z = x + y
                'End If
                'q = x.ToString() + IIf(o = 1, " - ", " + ") + y.ToString + " = "
                If o= 2 or o=3 or (z > Min_Minus_Value And z < Max_Plus_Value And (Not questions.Contains(q))) Then
                    goloop = False
                End If
            End While

            QuestionLabels(i).Text = q
            questions.Add(q)
            AnswerTestBoxes(i).Text = ""
            'AnswerTestBoxes(i).Text = z.ToString()

            ToTestFormulas(i).FirstValue = x
            ToTestFormulas(i).CalculatorOperator = o
            ToTestFormulas(i).SecondValue = y
            ToTestFormulas(i).Result = z

            AnswerTestBoxes(i).BackColor = Color.White
        Next

        btnStart.Enabled = False
        btnFinish.Enabled = True
        t = 0
        tmrFinish.Enabled = True

    End Sub

    Private Sub FrmMath_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()

        tmrFinish.Interval = 1000
        Dim configfile As String = System.IO.Path.GetDirectoryName(New Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath) + "\config.ini"
        Dim fileexists As Boolean = System.IO.File.Exists(configfile)
        If fileexists Then
            Using SR As New StreamReader(configfile)
                Dim line As String
                ' Read the stream to a string and write the string to the console.
                line = SR.ReadToEnd()

                Dim items() As String = line.Split(",")

                Max_Number = Val(items(0))
                Min_Number = Val(items(1))
                Max_Plus_Value = Val(items(2))
                Min_Minus_Value = Val(items(3))
                Max_Seconds = Val(items(4))
                chbLimit.Enabled = IIf(items(5) = 1, True, False)
                OptSelection = CType(Val(items(6)), OperatorSelection)
                Max_Multiply_Number = Val(items(7))

            End Using

        End If
        logfile = System.IO.Path.GetDirectoryName(New Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath) + "\logfile_wrong_" + DateTime.Now.ToString("yyyy-MM-dd") + ".csv"
        logfile_correct = System.IO.Path.GetDirectoryName(New Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath) + "\logfile_correct_" + DateTime.Now.ToString("yyyy-MM-dd") + ".csv"

        'MessageBox.Show(logfile)
        Dim i As Integer
        wrongquestions = New List(Of WrongAnswer)
        correctquestions = New List(Of CorrectAnswer)

        For i = 1 To MAX_QUESTIONS
            QuestionLabels(i) = Me.Controls.Item("lblQuestion" + i.ToString())
            AnswerTestBoxes(i) = Me.Controls.Item("txtAnswer" + i.ToString())
        Next
        'btnStart_Click(Nothing, Nothing)

        chbLimit.Text = "Time Limit - " + Str(Max_Seconds) + " seconds"

    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click

        If btnFinish.Enabled Then
            tmrFinish.Enabled = False

            btnRecheck.Enabled = True

            Dim i As Integer
            For i = 1 To MAX_QUESTIONS
                If AnswerTestBoxes(i).Text.TrimStart("0") = ToTestFormulas(i).Result.ToString() Then
                    AnswerTestBoxes(i).BackColor = Color.LightGreen
                    correctanswers += 1
                    Dim item As CorrectAnswer
                    item.Question = QuestionLabels(i).Text
                    item.YourAnswer = AnswerTestBoxes(i).Text
                    item.Round = r
                    item.Timestamp = DateTime.Now()
                    correctquestions.Add(item)
                Else
                    AnswerTestBoxes(i).BackColor = Color.Red
                    wronganswers += 1
                    Dim item As WrongAnswer
                    item.Question = QuestionLabels(i).Text
                    item.CorrectAnswer = ToTestFormulas(i).Result
                    item.YourAnswer = AnswerTestBoxes(i).Text
                    item.Round = r
                    item.Timestamp = DateTime.Now()
                    wrongquestions.Add(item)
                End If

            Next
            Me.Text = "Math Tester: Correct: " + correctanswers.ToString() + " Wrong: " + wronganswers.ToString()

            btnStart.Enabled = True

            btnFinish.Enabled = False
        End If
    End Sub

    Private Sub txtAnswer1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnswer1.KeyPress, txtAnswer2.KeyPress, txtAnswer3.KeyPress, txtAnswer4.KeyPress, txtAnswer5.KeyPress, txtAnswer6.KeyPress, txtAnswer7.KeyPress, txtAnswer8.KeyPress, txtAnswer9.KeyPress, txtAnswer10.KeyPress, txtAnswer11.KeyPress, txtAnswer12.KeyPress, txtAnswer20.KeyPress, txtAnswer19.KeyPress, txtAnswer18.KeyPress, txtAnswer17.KeyPress, txtAnswer16.KeyPress, txtAnswer15.KeyPress, txtAnswer14.KeyPress, txtAnswer13.KeyPress
        Dim i As Integer
        i = Asc(e.KeyChar)

        If (i < Asc("0") Or i > Asc("9")) And e.KeyChar <> vbBack Then

            Debug.Print(e.KeyChar)
            e.KeyChar = Nothing
        End If

    End Sub

    Private Sub tmrFinish_Tick(sender As Object, e As EventArgs) Handles tmrFinish.Tick
        t += 1
        Dim m As Integer
        Dim s As Integer

        s = t Mod 60
        m = Int(t / 60)

        lblTime.Text = m.ToString("00") + ":" + s.ToString("00")

        If chbLimit.Checked Then
            If t = Max_Seconds Then
                MessageBox.Show("Time is up!")
                If btnFinish.Enabled = True Then btnFinish_Click(Nothing, Nothing)
            End If
        End If

    End Sub

    Private Sub btnWrong_Click(sender As Object, e As EventArgs) Handles btnWrong.Click
        Dim errorform As New frmWrong
        errorform.wrongquestions = Me.wrongquestions
        tmrFinish.Enabled = False
        errorform.ShowDialog()
        tmrFinish.Enabled = True
    End Sub

    Private Sub FrmMath_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If btnFinish.Enabled = True Then
            MessageBox.Show("You need check first before closing the window!")
            'btnFinish_Click(Nothing, Nothing)
            e.Cancel = True
        End If

    End Sub

    Private Sub FrmMath_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        Dim fileexists As Boolean = System.IO.File.Exists(logfile)
        Dim fslog As System.IO.FileStream
        If Not fileexists Then
            fslog = System.IO.File.Open(logfile, FileMode.Create)
            Dim toBytes() As Byte = System.Text.Encoding.ASCII.GetBytes("Question,Your_Answer,Correct_Answer,Round,TimeStamp" + vbCrLf)
            fslog.Write(toBytes, 0, toBytes.Count)
            fslog.Close()
        End If
        fslog = System.IO.File.Open(logfile, FileMode.Append)
        For Each obj As WrongAnswer In wrongquestions
            Dim toBytes() As Byte
            With obj
                toBytes = System.Text.Encoding.ASCII.GetBytes(.Question + "," + .YourAnswer + "," + Str(.CorrectAnswer) + "," + Str(.Round) + "," + .Timestamp.ToString() + vbCrLf)
            End With
            fslog.Write(toBytes, 0, toBytes.Count)
        Next
        fslog.Close()

        Dim fslog_correct As System.IO.FileStream
        fileexists = System.IO.File.Exists(logfile_correct)
        If Not fileexists Then
            fslog_correct = System.IO.File.Open(logfile_correct, FileMode.Create)
            Dim toBytes() As Byte = System.Text.Encoding.ASCII.GetBytes("Question,Your_Answer,Round,TimeStamp" + vbCrLf)
            fslog_correct.Write(toBytes, 0, toBytes.Count)
            fslog_correct.Close()
        End If
        fslog_correct = System.IO.File.Open(logfile_correct, FileMode.Append)
        For Each obj As CorrectAnswer In correctquestions
            Dim toBytes() As Byte
            With obj
                toBytes = System.Text.Encoding.ASCII.GetBytes(.Question + "," + .YourAnswer + "," + Str(.Round) + "," + .Timestamp.ToString() + vbCrLf)
            End With
            fslog_correct.Write(toBytes, 0, toBytes.Count)
        Next
        fslog_correct.Close()
    End Sub

    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click

        Dim config_form As New frmConfig

        frmConfig.MainForm = Me
        tmrFinish.Enabled = False
        frmConfig.ShowDialog()
        tmrFinish.Enabled = True

        chbLimit.Text = "Time Limit - " + Str(Max_Seconds) + " seconds"

    End Sub

    Private Sub btnRecheck_Click(sender As Object, e As EventArgs) Handles btnRecheck.Click
        Dim i As Integer
        For i = 1 To MAX_QUESTIONS
            If AnswerTestBoxes(i).Text.TrimStart("0") = ToTestFormulas(i).Result.ToString() Then
                If AnswerTestBoxes(i).BackColor = Color.Red Or AnswerTestBoxes(i).BackColor = Color.LightCyan Then
                    AnswerTestBoxes(i).BackColor = Color.LightCyan
                End If
            Else
                AnswerTestBoxes(i).BackColor = Color.Red
            End If
        Next
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click

        Dim help_form As New frmHelper
        help_form.Show()
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click

        Dim help_form As New frmDivide
        help_form.Show()
    End Sub
End Class
