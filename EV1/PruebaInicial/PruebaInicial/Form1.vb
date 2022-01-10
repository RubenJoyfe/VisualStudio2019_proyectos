Public Class FrmInicial
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        MessageBox.Show("Hola hola")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub FrmInicial_FormClosed(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim Valor As Byte = 0        'Declaración de variable
        Valor = MessageBox.Show("¿Seguro que desea salir?", "Cerrar programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Valor = vbNo Then            'vbYes vbNo... es como igualar a un valor ya existente
            e.Cancel = True
        End If
    End Sub

End Class
