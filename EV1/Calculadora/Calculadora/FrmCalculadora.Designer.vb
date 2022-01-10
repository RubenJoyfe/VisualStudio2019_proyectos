<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalculadora
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtNumeros = New System.Windows.Forms.TextBox()
        Me.btnsiete = New System.Windows.Forms.Button()
        Me.btnocho = New System.Windows.Forms.Button()
        Me.btnnueve = New System.Windows.Forms.Button()
        Me.btnmultiplicar = New System.Windows.Forms.Button()
        Me.btncuatro = New System.Windows.Forms.Button()
        Me.btncinco = New System.Windows.Forms.Button()
        Me.btnseis = New System.Windows.Forms.Button()
        Me.btnrestar = New System.Windows.Forms.Button()
        Me.btnuno = New System.Windows.Forms.Button()
        Me.btndos = New System.Windows.Forms.Button()
        Me.btntres = New System.Windows.Forms.Button()
        Me.btnsumar = New System.Windows.Forms.Button()
        Me.btnNegPos = New System.Windows.Forms.Button()
        Me.btncero = New System.Windows.Forms.Button()
        Me.btncoma = New System.Windows.Forms.Button()
        Me.btnIgual = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAlcuadrado = New System.Windows.Forms.Button()
        Me.btnRemoveLast = New System.Windows.Forms.Button()
        Me.btndividir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtNumeros
        '
        Me.TxtNumeros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNumeros.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumeros.Location = New System.Drawing.Point(30, 30)
        Me.TxtNumeros.Name = "TxtNumeros"
        Me.TxtNumeros.Size = New System.Drawing.Size(278, 44)
        Me.TxtNumeros.TabIndex = 0
        Me.TxtNumeros.Text = "0"
        Me.TxtNumeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnsiete
        '
        Me.btnsiete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsiete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsiete.Location = New System.Drawing.Point(30, 165)
        Me.btnsiete.Name = "btnsiete"
        Me.btnsiete.Size = New System.Drawing.Size(65, 65)
        Me.btnsiete.TabIndex = 1
        Me.btnsiete.Text = "7"
        Me.btnsiete.UseVisualStyleBackColor = False
        '
        'btnocho
        '
        Me.btnocho.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnocho.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnocho.Location = New System.Drawing.Point(101, 165)
        Me.btnocho.Name = "btnocho"
        Me.btnocho.Size = New System.Drawing.Size(65, 65)
        Me.btnocho.TabIndex = 1
        Me.btnocho.Text = "8"
        Me.btnocho.UseVisualStyleBackColor = False
        '
        'btnnueve
        '
        Me.btnnueve.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnnueve.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnueve.Location = New System.Drawing.Point(172, 165)
        Me.btnnueve.Name = "btnnueve"
        Me.btnnueve.Size = New System.Drawing.Size(65, 65)
        Me.btnnueve.TabIndex = 1
        Me.btnnueve.Text = "9"
        Me.btnnueve.UseVisualStyleBackColor = False
        '
        'btnmultiplicar
        '
        Me.btnmultiplicar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnmultiplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmultiplicar.Location = New System.Drawing.Point(243, 165)
        Me.btnmultiplicar.Name = "btnmultiplicar"
        Me.btnmultiplicar.Size = New System.Drawing.Size(65, 65)
        Me.btnmultiplicar.TabIndex = 1
        Me.btnmultiplicar.Text = "x"
        Me.btnmultiplicar.UseVisualStyleBackColor = False
        '
        'btncuatro
        '
        Me.btncuatro.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btncuatro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncuatro.Location = New System.Drawing.Point(30, 236)
        Me.btncuatro.Name = "btncuatro"
        Me.btncuatro.Size = New System.Drawing.Size(65, 65)
        Me.btncuatro.TabIndex = 1
        Me.btncuatro.Text = "4"
        Me.btncuatro.UseVisualStyleBackColor = False
        '
        'btncinco
        '
        Me.btncinco.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btncinco.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncinco.Location = New System.Drawing.Point(101, 236)
        Me.btncinco.Name = "btncinco"
        Me.btncinco.Size = New System.Drawing.Size(65, 65)
        Me.btncinco.TabIndex = 1
        Me.btncinco.Text = "5"
        Me.btncinco.UseVisualStyleBackColor = False
        '
        'btnseis
        '
        Me.btnseis.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnseis.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnseis.Location = New System.Drawing.Point(172, 236)
        Me.btnseis.Name = "btnseis"
        Me.btnseis.Size = New System.Drawing.Size(65, 65)
        Me.btnseis.TabIndex = 1
        Me.btnseis.Text = "6"
        Me.btnseis.UseVisualStyleBackColor = False
        '
        'btnrestar
        '
        Me.btnrestar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnrestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrestar.Location = New System.Drawing.Point(243, 236)
        Me.btnrestar.Name = "btnrestar"
        Me.btnrestar.Size = New System.Drawing.Size(65, 65)
        Me.btnrestar.TabIndex = 1
        Me.btnrestar.Text = "-"
        Me.btnrestar.UseVisualStyleBackColor = False
        '
        'btnuno
        '
        Me.btnuno.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnuno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnuno.Location = New System.Drawing.Point(30, 307)
        Me.btnuno.Name = "btnuno"
        Me.btnuno.Size = New System.Drawing.Size(65, 65)
        Me.btnuno.TabIndex = 1
        Me.btnuno.Text = "1"
        Me.btnuno.UseVisualStyleBackColor = False
        '
        'btndos
        '
        Me.btndos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btndos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndos.Location = New System.Drawing.Point(101, 307)
        Me.btndos.Name = "btndos"
        Me.btndos.Size = New System.Drawing.Size(65, 65)
        Me.btndos.TabIndex = 1
        Me.btndos.Text = "2"
        Me.btndos.UseVisualStyleBackColor = False
        '
        'btntres
        '
        Me.btntres.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btntres.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntres.Location = New System.Drawing.Point(172, 307)
        Me.btntres.Name = "btntres"
        Me.btntres.Size = New System.Drawing.Size(65, 65)
        Me.btntres.TabIndex = 1
        Me.btntres.Text = "3"
        Me.btntres.UseVisualStyleBackColor = False
        '
        'btnsumar
        '
        Me.btnsumar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnsumar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsumar.Location = New System.Drawing.Point(243, 307)
        Me.btnsumar.Name = "btnsumar"
        Me.btnsumar.Size = New System.Drawing.Size(65, 65)
        Me.btnsumar.TabIndex = 1
        Me.btnsumar.Text = "+"
        Me.btnsumar.UseVisualStyleBackColor = False
        '
        'btnNegPos
        '
        Me.btnNegPos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNegPos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNegPos.Location = New System.Drawing.Point(30, 378)
        Me.btnNegPos.Name = "btnNegPos"
        Me.btnNegPos.Size = New System.Drawing.Size(65, 65)
        Me.btnNegPos.TabIndex = 1
        Me.btnNegPos.Text = "+/-"
        Me.btnNegPos.UseVisualStyleBackColor = False
        '
        'btncero
        '
        Me.btncero.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btncero.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncero.Location = New System.Drawing.Point(101, 378)
        Me.btncero.Name = "btncero"
        Me.btncero.Size = New System.Drawing.Size(65, 65)
        Me.btncero.TabIndex = 1
        Me.btncero.Text = "0"
        Me.btncero.UseVisualStyleBackColor = False
        '
        'btncoma
        '
        Me.btncoma.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btncoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncoma.Location = New System.Drawing.Point(172, 378)
        Me.btncoma.Name = "btncoma"
        Me.btncoma.Size = New System.Drawing.Size(65, 65)
        Me.btncoma.TabIndex = 1
        Me.btncoma.Text = ","
        Me.btncoma.UseVisualStyleBackColor = False
        '
        'btnIgual
        '
        Me.btnIgual.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIgual.Location = New System.Drawing.Point(243, 378)
        Me.btnIgual.Name = "btnIgual"
        Me.btnIgual.Size = New System.Drawing.Size(65, 65)
        Me.btnIgual.TabIndex = 1
        Me.btnIgual.Text = "="
        Me.btnIgual.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(30, 94)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(65, 65)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAlcuadrado
        '
        Me.btnAlcuadrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlcuadrado.Location = New System.Drawing.Point(101, 94)
        Me.btnAlcuadrado.Name = "btnAlcuadrado"
        Me.btnAlcuadrado.Size = New System.Drawing.Size(65, 65)
        Me.btnAlcuadrado.TabIndex = 1
        Me.btnAlcuadrado.Text = "x²"
        Me.btnAlcuadrado.UseVisualStyleBackColor = True
        '
        'btnRemoveLast
        '
        Me.btnRemoveLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveLast.Location = New System.Drawing.Point(172, 94)
        Me.btnRemoveLast.Name = "btnRemoveLast"
        Me.btnRemoveLast.Size = New System.Drawing.Size(65, 65)
        Me.btnRemoveLast.TabIndex = 1
        Me.btnRemoveLast.Text = "⌫"
        Me.btnRemoveLast.UseVisualStyleBackColor = True
        '
        'btndividir
        '
        Me.btndividir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btndividir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndividir.Location = New System.Drawing.Point(243, 94)
        Me.btndividir.Name = "btndividir"
        Me.btndividir.Size = New System.Drawing.Size(65, 65)
        Me.btndividir.TabIndex = 1
        Me.btndividir.Text = "/"
        Me.btndividir.UseVisualStyleBackColor = False
        '
        'FrmCalculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 469)
        Me.Controls.Add(Me.btnIgual)
        Me.Controls.Add(Me.btnsumar)
        Me.Controls.Add(Me.btnrestar)
        Me.Controls.Add(Me.btndividir)
        Me.Controls.Add(Me.btnmultiplicar)
        Me.Controls.Add(Me.btncoma)
        Me.Controls.Add(Me.btntres)
        Me.Controls.Add(Me.btnseis)
        Me.Controls.Add(Me.btnRemoveLast)
        Me.Controls.Add(Me.btnnueve)
        Me.Controls.Add(Me.btncero)
        Me.Controls.Add(Me.btndos)
        Me.Controls.Add(Me.btncinco)
        Me.Controls.Add(Me.btnAlcuadrado)
        Me.Controls.Add(Me.btnocho)
        Me.Controls.Add(Me.btnNegPos)
        Me.Controls.Add(Me.btnuno)
        Me.Controls.Add(Me.btncuatro)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnsiete)
        Me.Controls.Add(Me.TxtNumeros)
        Me.Name = "FrmCalculadora"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNumeros As TextBox
    Friend WithEvents btnsiete As Button
    Friend WithEvents btnocho As Button
    Friend WithEvents btnnueve As Button
    Friend WithEvents btnmultiplicar As Button
    Friend WithEvents btncuatro As Button
    Friend WithEvents btncinco As Button
    Friend WithEvents btnseis As Button
    Friend WithEvents btnrestar As Button
    Friend WithEvents btnuno As Button
    Friend WithEvents btndos As Button
    Friend WithEvents btntres As Button
    Friend WithEvents btnsumar As Button
    Friend WithEvents btnNegPos As Button
    Friend WithEvents btncero As Button
    Friend WithEvents btncoma As Button
    Friend WithEvents btnIgual As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAlcuadrado As Button
    Friend WithEvents btnRemoveLast As Button
    Friend WithEvents btndividir As Button
End Class
