Imports System.ComponentModel

Public Class FrmCalculadora
    ' Sender y e
    '  - Sender: mi ventana, de tipo Object
    '  - e: la lista de argumentos para ese evento.
    Private Sub FrmCalculadora_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Size = New Size(352, 508)
    End Sub

    Private Sub FrmCalculadora_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim res As Byte
        res = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = vbNo Then e.Cancel = True
    End Sub

    Dim nums(2) As Double
    Dim num_pos As Integer = 0
    Dim result As Double
    Dim simbolo_operacion As String

    Private Sub addNum(number)
        If TxtNumeros.Text = 0 Then
            TxtNumeros.Text += number
        Else
            TxtNumeros.Text &= number
        End If
        'nums(num_pos) = 10 * nums(num_pos) + number (& concatena en vez de sumar)
        'nums(num_pos) &= number
        'TxtNumeros.Text = nums(num_pos)

    End Sub
    Private Sub clearScr()
        TxtNumeros.Text = 0
        num_pos = 0
        nums(0) = 0
        nums(1) = 0
    End Sub
    Private Sub clearLastNum()
        Try
            Dim newstr As String
            Dim numtostr As String = nums(num_pos).ToString
            For i = 0 To numtostr.Length - 2
                newstr += numtostr(i)
            Next
            nums(num_pos) = Integer.Parse(newstr)
            TxtNumeros.Text = nums(num_pos)
        Catch ex As Exception
            nums(num_pos) = 0
            TxtNumeros.Text = 0
        End Try

    End Sub

    Private Sub btnuno_Click(sender As Object, e As EventArgs) Handles btnuno.Click
        addNum(Integer.Parse(sender.Text))
    End Sub

    Private Sub btndos_Click(sender As Object, e As EventArgs) Handles btndos.Click
        addNum(Integer.Parse(sender.Text))
    End Sub

    Private Sub btntres_Click(sender As Object, e As EventArgs) Handles btntres.Click
        addNum(Integer.Parse(sender.Text))
    End Sub

    Private Sub btncuatro_Click(sender As Object, e As EventArgs) Handles btncuatro.Click
        addNum(Integer.Parse(sender.Text))
    End Sub

    Private Sub btncinco_Click(sender As Object, e As EventArgs) Handles btncinco.Click
        addNum(Integer.Parse(sender.Text))
    End Sub

    Private Sub btnseis_Click(sender As Object, e As EventArgs) Handles btnseis.Click
        addNum(Integer.Parse(sender.Text))
    End Sub

    Private Sub btnsiete_Click(sender As Object, e As EventArgs) Handles btnsiete.Click
        addNum(Integer.Parse(sender.Text))
    End Sub

    Private Sub btnocho_Click(sender As Object, e As EventArgs) Handles btnocho.Click
        addNum(Integer.Parse(sender.Text))
    End Sub

    Private Sub btnnueve_Click(sender As Object, e As EventArgs) Handles btnnueve.Click
        addNum(Integer.Parse(sender.Text))
    End Sub

    Private Sub btncero_Click(sender As Object, e As EventArgs) Handles btncero.Click
        addNum(Integer.Parse(sender.Text))
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearScr()
    End Sub

    Private Sub btnRemoveLast_Click(sender As Object, e As EventArgs) Handles btnRemoveLast.Click
        clearLastNum()
    End Sub

    Private Sub TxtNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumeros.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        Else

        End If
    End Sub

    'val() parsea automaticamente a donde lo vayas a guardar

    Private Sub TxtNumeros_TextChanged(sender As Object, e As EventArgs) Handles TxtNumeros.TextChanged
        nums(num_pos) = TxtNumeros.Text
    End Sub

    Private Sub Operador(operador As String)
        Dim esOperador As Boolean = False
        Select Case operador
            Case "+"
                esOperador = True
            Case "-"
                esOperador = True
            Case "x"
                esOperador = True
            Case "/"
                esOperador = True
            Case "="
                'MessageBox.Show("Operacion " + nums(0).ToString + simbolo_operacion + nums(1).ToString)
                Calcular()
            Case Else
                MessageBox.Show("unknown")
        End Select

        If esOperador Then
            simbolo_operacion = operador
            num_pos = 1
            TxtNumeros.Text = 0
        End If

    End Sub

    Private Sub Calcular()
        Select Case simbolo_operacion
            Case "+"
                TxtNumeros.Text = nums(0) + nums(1)
            Case "-"
                TxtNumeros.Text = nums(0) - nums(1)
            Case "x"
                TxtNumeros.Text = nums(0) * nums(1)
            Case "/"
                TxtNumeros.Text = nums(0) / nums(1)
        End Select
        nums(0) = TxtNumeros.Text
        num_pos = 0
    End Sub

    Private Sub btnsumar_Click(sender As Object, e As EventArgs) Handles btnsumar.Click
        Operador(sender.Text)
    End Sub

    Private Sub btnrestar_Click(sender As Object, e As EventArgs) Handles btnrestar.Click
        Operador(sender.Text)
    End Sub

    Private Sub btnmultiplicar_Click(sender As Object, e As EventArgs) Handles btnmultiplicar.Click
        Operador(sender.Text)
    End Sub

    Private Sub btndividir_Click(sender As Object, e As EventArgs) Handles btndividir.Click
        Operador(sender.Text)
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        Operador(sender.Text)

    End Sub
End Class
