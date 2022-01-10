<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInicial
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn1
        '
        Me.Btn1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Btn1.ForeColor = System.Drawing.Color.White
        Me.Btn1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn1.Location = New System.Drawing.Point(12, 12)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(143, 134)
        Me.Btn1.TabIndex = 0
        Me.Btn1.Text = "Pulsa para una sorpresa"
        Me.Btn1.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(713, 415)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'FrmInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Btn1)
        Me.Name = "FrmInicial"
        Me.Text = "FrmInicial"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn1 As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Button1 As Button
End Class
