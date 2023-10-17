Public Class Division
    Dim correctas As Integer
    Dim incorrectas As Integer
    Private Sub Division_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnayuda_Click(sender As Object, e As EventArgs) Handles btnayuda.Click
        MsgBox("Dividir es una distribución equitativa, es decir, repartir entre partes o grupos iguales", MsgBoxStyle.Information, "AYUDA")
        MsgBox("EJMPLO en imagen hay 20 naranjas y hay 4 entonces se divide  20/4 es = 5 cada persona va obtener 5 naranjas ", MsgBoxStyle.Question, "EJEMPLO")
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
End Class