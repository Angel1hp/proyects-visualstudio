Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim consumo As Double
        Dim descuento As Double
        Dim impuesto As Double
        Dim total As Double

        If Not Double.TryParse(TextBox1.Text, consumo) Then
            MessageBox.Show("Ingrese un consumo válido.")
            Exit Sub
        End If

        If consumo <= 30 Then
            descuento = consumo * 0.1
        Else
            descuento = consumo * 0.2
        End If

        Dim subtotal = consumo - descuento
        impuesto = subtotal * 0.02
        total = subtotal + impuesto

        Me.Label1.Text = "Importe a pagar: S/ " & total.ToString("F2")

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
