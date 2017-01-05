'Reed Kemp'
'10/14/2015'
'CRN: 1588'
Option Explicit On
Option Strict On

Public Class FrmQuestion
    Dim index As Integer = 0
    Dim score As Double = 0

    Dim UserAnswer(MaxNoOfQuestions - 1) As String
    Public Sub ShowQuestion(index As Integer)
        lblQnum.Text = CStr(index + 1) & "."
        lblQuestion.Text = test(index).question

        rdoT.Checked = False
        rdoF.Checked = False

    End Sub

    Private Sub FrmQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblQuestion.Text = test(0).question
    End Sub

    Private Sub btnNextQuestion_Click(sender As Object, e As EventArgs) Handles btnNextQuestion.Click
        If rdoT.Checked = True Then
            UserAnswer(index) = "T"
        ElseIf rdoF.Checked = True Then
            UserAnswer(index) = "F"
        Else
            UserAnswer(index) = "*"
        End If

        If (UserAnswer(index) = test(index).correctAnswer) Then
            score = score + (100 / NumberOfQuestions)
        ElseIf (UserAnswer(index) = "*") Then
            score = score
        Else
            score = score + (-50 / NumberOfQuestions)
        End If

        If (index <= (NumberOfQuestions - 1)) Then

            grades = grades & "           " & test(index).correctAnswer & vbTab & vbTab & vbTab & UserAnswer(index) & vbNewLine

        End If

        If (index = NumberOfQuestions - 2) Then
            btnNextQuestion.Text = "Finish"

        End If
        If (index = NumberOfQuestions - 1) Then
            Me.Hide()
            MsgBox("Correct Answer" & vbTab & "        Your answer" & vbNewLine & grades & vbNewLine _
                   & "  *indicates tha you did not answer the question" & vbNewLine & vbNewLine & vbNewLine _
                    & "Your score is:  " & CStr(Math.Round(score)), , "Test Result")
            Application.Exit()

        Else
            index = index + 1
            ShowQuestion(index)
        End If
    End Sub
End Class