Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sumaCuadrados As Integer = 0
        Dim sumaCubos As Integer = 0

        For i As Integer = 1 To 20
            sumaCuadrados += i * i
            sumaCubos += i * i * i
        Next

        Label1.Text = "Suma de cuadrados: " & sumaCuadrados & vbCrLf &
              "Suma de cubos: " & sumaCubos

    End Sub
End Class
