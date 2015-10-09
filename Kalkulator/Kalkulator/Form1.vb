Public Class Form1

    Dim operand1 As Double
    Dim [operator] As String
    Dim baru As String
    Dim temp As String
    Dim operand2 As Double

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click, Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click
        TextBox1.Text = TextBox1.Text & sender.text
    End Sub

    Private Sub Buttonplus_Click(sender As Object, e As EventArgs) Handles Buttonplus.Click
        If baru = "" Then
            operand1 = Val(TextBox1.Text)
            TextBox1.Text = ""
            TextBox1.Focus()
            [operator] = "+"
        ElseIf baru = False Then
            If [operator] = "+" Then
                temp = operand1 + Val(TextBox1.Text)
                operand1 = temp
                TextBox1.Text = ""
                [operator] = "+"
            ElseIf [operator] = "-" Then
                temp = operand1 - Val(TextBox1.Text)
                operand1 = temp
                TextBox1.Text = ""
                [operator] = "+"
            End If

        End If

        baru = False
    End Sub

    Private Sub Buttonmin_Click(sender As Object, e As EventArgs) Handles Buttonmin.Click
        If baru = "" Then
            operand1 = Val(TextBox1.Text)
            TextBox1.Text = ""
            TextBox1.Focus()
            [operator] = "-"
        ElseIf baru = False Then
            If [operator] = "+" Then
                temp = operand1 + Val(TextBox1.Text)
                operand1 = temp
                TextBox1.Text = ""
                [operator] = "-"
            ElseIf [operator] = "-" Then
                temp = operand1 - Val(TextBox1.Text)
                operand1 = temp
                TextBox1.Text = ""
                [operator] = "-"
            End If

        End If

        baru = False
    End Sub

    Private Sub Buttonsama_Click(sender As Object, e As EventArgs) Handles Buttonsama.Click
        Dim hasil As Double
        operand2 = Val(TextBox1.Text)

        Select Case [operator]

            Case "+"
                hasil = operand1 + operand2
                TextBox1.Text = hasil.ToString
                baru = True
            Case "-"
                hasil = operand1 - operand2
                TextBox1.Text = hasil.ToString
        End Select
        TextBox1.Text = hasil.ToString
    End Sub

    
    Private Sub Buttontitik_Click(sender As Object, e As EventArgs) Handles Buttontitik.Click
        If InStr(TextBox1.Text, ".") > 0 Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & "."
        End If
    End Sub

    Private Sub Buttonclear_Click(sender As Object, e As EventArgs) Handles Buttonclear.Click
        TextBox1.Text = ""
        operand1 = 0
        temp = 0
        baru = True
    End Sub


   
End Class
