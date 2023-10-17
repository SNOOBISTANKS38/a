Public Class Form4
    Dim correctas As Integer
    Dim incorrectas As Integer
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Rbcorrecto4.Checked = True Then
            correctas = correctas + 1
            lblcorrecta.Text = correctas
        Else
            incorrectas = incorrectas + 1
            lblincorreta.Text = incorrectas


        End If
        Gb4.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Division.Show()
        Me.Hide()

    End Sub

    Private Sub Btnverificar2_Click(sender As Object, e As EventArgs) Handles Btnverificar2.Click
        If Rbcorrecto2.Checked = True Then
            correctas = correctas + 1
            lblcorrecta.Text = correctas
        Else
            incorrectas = incorrectas + 1
            lblincorreta.Text = incorrectas


        End If
        Gb2.Enabled = False
    End Sub

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        If Rbcorrecto.Checked = True Then
            correctas = correctas + 1
            lblcorrecta.Text = correctas
        Else
            incorrectas = incorrectas + 1
            lblincorreta.Text = incorrectas


        End If
        Gb1.Enabled = False
    End Sub

    Private Sub Btnverificar3_Click(sender As Object, e As EventArgs) Handles Btnverificar3.Click
        If Rbcorrecto3.Checked = True Then
            correctas = correctas + 1
            lblcorrecta.Text = correctas
        Else
            incorrectas = incorrectas + 1
            lblincorreta.Text = incorrectas


        End If
        Gb3.Enabled = False
    End Sub
End Class