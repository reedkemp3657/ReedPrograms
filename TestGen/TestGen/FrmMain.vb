'Reed Kemp'
'10/14/2015'
'CRN: 1588'
Option Explicit On


Public Class FrmMain
    Dim i As Integer = 0

    Private Sub FrmQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FileOpen(1, "ExcelTest.dat", OpenMode.Random, , , Len(test(0)))
        Do While Not EOF(1)
            FileGet(1, test(i))
            i = i + 1
        Loop
        FileClose()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CboQuestionNum.Items.Add("5")
        CboQuestionNum.Items.Add("10")
        CboQuestionNum.Items.Add("15")
        CboQuestionNum.Items.Add("25")
        CboQuestionNum.Items.Add("60")

    End Sub


    Private Sub BtnTestStart_Click(sender As Object, e As EventArgs) Handles BtnTestStart.Click
        NumberOfQuestions = CboQuestionNum.Text
        Me.Hide()
        FrmQuestion.Show()
    End Sub
End Class
