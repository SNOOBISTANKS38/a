Imports System.Security.Cryptography

Public Class Form1
    Dim n1, n2, res

    Private Sub Mult_Click(sender As Object, e As EventArgs) Handles Mult.Click
        Dim mult, res As Single
        n1 = Val(TextN1.Text)
        n2 = Val(TextN2.Text)
        mult = n1 * n2
        Textresultado.Text = mult
        Label1.Text = "*"

        res = Val(Me.Textresultado.Text)
        Me.EJEMPLO.Items.Clear()

        For i = 1 To n2
            mult = n1
            res = i * n1

            Me.EJEMPLO.Items.Add(mult & " x " & i & " = " & res)
        Next
        MsgBox("La multiplicación es una forma muy rápida de sumar el mismo número una y otra vez.", MsgBoxStyle.Information, "¿Qué son la multiplicación?")
        MsgBox("Sabes Multiplicar ", MsgBoxStyle.Question, "PREGUNTA")


    End Sub

    Private Sub btndiv_Click(sender As Object, e As EventArgs) Handles btndiv.Click
        Dim div, res As Single
        n1 = Val(TextN1.Text)
        n2 = Val(TextN2.Text)
        div = n1 * n2
        Textresultado.Text = div
        Label1.Text = "/"

        res = Val(Me.Textresultado.Text)
        Me.EJEMPLO.Items.Clear()

        For i = 1 To n2
            div = n1
            res = i / n1

            Me.EJEMPLO.Items.Add(div & " / " & i & " = " & res)

        Next

        MsgBox("Dividir es una distribución equitativa, es decir, repartir entre partes o grupos iguales", MsgBoxStyle.Information, "¿Qué es la división?")
        MsgBox("Sabes Dividir ", MsgBoxStyle.Question, "PREGUNTA")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Textresultado_TextChanged(sender As Object, e As EventArgs) Handles Textresultado.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Division.Show()
        Me.Hide()
    End Sub

    Private Sub Bntresta_Click(sender As Object, e As EventArgs) Handles Bntresta.Click
        Dim resta As Single
        n1 = Val(TextN1.Text)
        n2 = Val(TextN2.Text)
        resta = n1 - n2
        Textresultado.Text = resta
        Label1.Text = "-"
        MsgBox("La resta o sustracción es una operación matemática que consiste en sacar, quitar, reducir o separar algo de un todo", MsgBoxStyle.Information, "¿Qué son las restas?")
        MsgBox("Sabes Restar ", MsgBoxStyle.Question, "PREGUNTA")
    End Sub

    Private Sub btnSUMA_Click(sender As Object, e As EventArgs) Handles btnSUMA.Click
        Dim suma As Single
        n1 = Val(TextN1.Text)
        n2 = Val(TextN2.Text)
        suma = n1 + n2
        Textresultado.Text = suma
        Label1.Text = "+"
        MsgBox("Operación artimetica que consiste en reunir varias cantidades ", MsgBoxStyle.Information, "QUE ES LA SUMA")
        MsgBox("Sabes Sumar ", MsgBoxStyle.Question, "PREGUNTA")


    End Sub
End Class
