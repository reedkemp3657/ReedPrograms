'Reed Kemp'
'10/14/2015'
'CRN: 1588'
Option Explicit On
Option Strict On
Imports System.IO

Module Module1
    Public grades As String
    Public NumberOfQuestions As Integer
    Public UserAnswer As String
    Structure testQuestion
        <VBFixedString(150)> Public question As String
        <VBFixedString(1)> Public correctAnswer As String
    End Structure

    Public Const MaxNoOfQuestions = 25
    Public test(MaxNoOfQuestions - 1) As testQuestion


End Module
