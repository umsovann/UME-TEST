Imports System.Net.Security
Imports System.Security.Cryptography.Pkcs

Public Class frmLoop
    Private Sub btnwhileloop_Click(sender As Object, e As EventArgs) Handles btnwhileloop.Click
        Dim i As Integer = 1
        Dim str As String = ""
        While i <= 12
            str = str & "i = " & i & vbCrLf
            i += 1

        End While
        txtwhileloop.Text = str
    End Sub

    Private Sub btndowhileloop_Click(sender As Object, e As EventArgs) Handles btndowhileloop.Click
        Dim i As Integer = 1
        Dim str As String = ""
        Do While i <= 12

            If i = 6 Then
                Exit Do

            End If
            str = str & "i = " & i & vbCrLf
            i += 1
        Loop
        txtdowhileloop.Text = str

    End Sub

    Private Sub btndoloop_Click(sender As Object, e As EventArgs) Handles btndoloop.Click
        Dim i As Integer = 1
        Dim str As String = ""
        Do
            str = str & "i = " & i & vbCrLf
            i += 1

        Loop While i <= 12
        txtdoloop.Text = str
    End Sub

    Private Sub btndountilloop_Click(sender As Object, e As EventArgs) Handles btndountilloop.Click
        'Dim i As Integer = 1
        'Dim str As String = ""
        'Do Until i >= 13
        '    str = str & "i = " & i & vbCrLf
        '    i += 1

        'Loop
        'txtdountilloop.Text = str

        Dim i As Integer = 1
        Dim str As String = ""
        Do
            str = str & "i = " & i & vbCrLf
            i += 1

        Loop Until i >= 13
        txtdountilloop.Text = str

    End Sub

    Private Sub btnfornextloop_Click(sender As Object, e As EventArgs) Handles btnfornextloop.Click
        Dim i As Integer
        Dim str As String = ""
        For i = 1 To 12
            If i = 6 Then
                Exit For
            End If
            str = str & "i = " & i & vbCrLf
        Next i
        txtfornextloop.Text = str

    End Sub
End Class