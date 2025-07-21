Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ventas As Double
        Dim comision As Double

        If Not Double.TryParse(TextBox1.Text, ventas) Then
            MessageBox.Show("Ingrese un valor numérico válido para ventas.")
            Exit Sub
        End If

        If ventas < 50 Then
            comision = 0
        ElseIf ventas <= 500 Then
            comision = ventas * 0.1
        Else
            comision = 50 + (ventas * 0.08)
        End If

        Label1.Text = "Comisión: S/ " & comision.ToString("F2")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
