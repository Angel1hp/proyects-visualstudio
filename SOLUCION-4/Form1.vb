Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim N As Integer

        If Not Integer.TryParse(TextBox1.Text, N) OrElse N <= 0 Then
            MessageBox.Show("Ingrese un número entero positivo.")
            Exit Sub
        End If

        Dim suma As Integer = 0

        For i As Integer = 1 To N
            suma += i
        Next

        Dim promedio As Double = suma / N

        Label1.Text = "Promedio: " & promedio.ToString("F2")

    End Sub
End Class
