Imports System.IO
Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents TreeView As System.Windows.Forms.TreeView
    Friend WithEvents ListView As System.Windows.Forms.ListView
    Friend WithEvents OptAjustar As System.Windows.Forms.RadioButton
    Friend WithEvents OptMantener As System.Windows.Forms.RadioButton
    Friend WithEvents PicImagen As System.Windows.Forms.PictureBox
    Friend WithEvents CboUnidades As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CboUnidades = New System.Windows.Forms.ComboBox()
        Me.TreeView = New System.Windows.Forms.TreeView()
        Me.ListView = New System.Windows.Forms.ListView()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.OptAjustar = New System.Windows.Forms.RadioButton()
        Me.OptMantener = New System.Windows.Forms.RadioButton()
        Me.PicImagen = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PicImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CboUnidades
        '
        Me.CboUnidades.Location = New System.Drawing.Point(8, 8)
        Me.CboUnidades.Name = "CboUnidades"
        Me.CboUnidades.Size = New System.Drawing.Size(88, 21)
        Me.CboUnidades.TabIndex = 0
        Me.CboUnidades.Text = "Unidades"
        '
        'TreeView
        '
        Me.TreeView.Location = New System.Drawing.Point(8, 40)
        Me.TreeView.Name = "TreeView"
        Me.TreeView.Size = New System.Drawing.Size(152, 128)
        Me.TreeView.TabIndex = 1
        '
        'ListView
        '
        Me.ListView.HideSelection = False
        Me.ListView.LargeImageList = Me.ImageList
        Me.ListView.Location = New System.Drawing.Point(8, 176)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(248, 136)
        Me.ListView.SmallImageList = Me.ImageList
        Me.ListView.StateImageList = Me.ImageList
        Me.ListView.TabIndex = 2
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "")
        Me.ImageList.Images.SetKeyName(1, "")
        Me.ImageList.Images.SetKeyName(2, "")
        Me.ImageList.Images.SetKeyName(3, "")
        '
        'OptAjustar
        '
        Me.OptAjustar.Location = New System.Drawing.Point(16, 328)
        Me.OptAjustar.Name = "OptAjustar"
        Me.OptAjustar.Size = New System.Drawing.Size(64, 16)
        Me.OptAjustar.TabIndex = 3
        Me.OptAjustar.Text = "Ajustar"
        '
        'OptMantener
        '
        Me.OptMantener.Checked = True
        Me.OptMantener.Location = New System.Drawing.Point(88, 328)
        Me.OptMantener.Name = "OptMantener"
        Me.OptMantener.Size = New System.Drawing.Size(72, 16)
        Me.OptMantener.TabIndex = 4
        Me.OptMantener.TabStop = True
        Me.OptMantener.Text = "Mantener"
        '
        'PicImagen
        '
        Me.PicImagen.Location = New System.Drawing.Point(272, 80)
        Me.PicImagen.Name = "PicImagen"
        Me.PicImagen.Size = New System.Drawing.Size(176, 208)
        Me.PicImagen.TabIndex = 5
        Me.PicImagen.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(328, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(464, 374)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PicImagen)
        Me.Controls.Add(Me.OptMantener)
        Me.Controls.Add(Me.OptAjustar)
        Me.Controls.Add(Me.ListView)
        Me.Controls.Add(Me.TreeView)
        Me.Controls.Add(Me.CboUnidades)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PicImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Unidades() As String
        OptMantener.Checked = True
        Unidades = System.Environment.GetLogicalDrives
        CboUnidades.Items.AddRange(Unidades)
        TreeView.ImageList = ImageList


        ListView.View = View.Details
        ListView.Columns.Add(New ColumnHeader)
        ListView.Columns(0).Text = "Nombre Archivo"
        ListView.Columns(0).TextAlign = HorizontalAlignment.Center
        ListView.Columns(0).Width = 150
        ListView.Columns.Add(New ColumnHeader)
        ListView.Columns(1).Text = "Tamaño"
        ListView.Columns(1).TextAlign = HorizontalAlignment.Center
        ListView.Columns(1).Width = -2
        ListView.Sorting = SortOrder.Ascending


        ListView.LargeImageList = ImageList
        ListView.SmallImageList = ImageList
        ListView.StateImageList = ImageList
    End Sub

    Private Sub CboUnidades_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboUnidades.SelectedIndexChanged
        Dim oDirUnidades As New DirectoryInfo(CboUnidades.Text)
        Dim oDirectorios() As DirectoryInfo
        oDirectorios = oDirUnidades.GetDirectories
        TreeView.Nodes.Clear()

        Dim oDirInfor As DirectoryInfo
        Dim oNodo As TreeNode
        For Each oDirInfor In oDirectorios
            oNodo = New TreeNode(oDirInfor.FullName, 0, 0)
            TreeView.Nodes.Add(oNodo)

        Next
    End Sub

    Private Sub TreeView_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView.AfterSelect
        If Not e.Node.IsExpanded Then
            Dim oSubDirInfo As DirectoryInfo
            oSubDirInfo = New DirectoryInfo(e.Node.FullPath)

            Dim oSubDirectorios() As DirectoryInfo
            oSubDirectorios = oSubDirInfo.GetDirectories

            Dim oSubDir As DirectoryInfo
            Dim oNodo As TreeNode
            For Each oSubDir In oSubDirectorios
                oNodo = New TreeNode(oSubDir.Name, 0, 0)
                e.Node.Nodes.Add(oNodo.Text)
            Next
            Dim oArchivos() As FileInfo
            oArchivos = oSubDirInfo.GetFiles
            ListView.Items.Clear()

            Dim oarchivoinfo As FileInfo
            For Each oarchivoinfo In oArchivos

                Select Case oarchivoinfo.Extension.ToUpper
                    Case ".BMP", ".PNG", ".WMF)"
                        Dim Item1 As New ListViewItem(oarchivoinfo.Name, 1)
                        Item1.SubItems.Add(oarchivoinfo.Length)
                        'ListView.Items.AddRange(New ListViewItem() {Item1})
                        ListView.Items.Add(Item1)

                    Case ".JPG", ".JPEG"
                        Dim Item2 As New ListViewItem(oarchivoinfo.Name, 3)
                        Item2.SubItems.Add(oarchivoinfo.Length)
                        ListView.Items.Add(Item2)

                    Case ".GIF"
                        Dim Item3 As New ListViewItem(oarchivoinfo.Name, 2)
                        Item3.SubItems.Add(oarchivoinfo.Length)
                        ListView.Items.Add(Item3)

                End Select

            Next
        End If
    End Sub

    Private Sub ListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView.SelectedIndexChanged
        If ListView.SelectedItems.Count > 0 Then
            PicImagen.Invalidate()
            PicImagen.Image = New Bitmap(TreeView.SelectedNode.FullPath & "\" & ListView.SelectedItems(0).Text)
        End If
    End Sub

    Private Sub PicImagen_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PicImagen.Paint
        If Not (IsNothing(TreeView.SelectedNode)) Then
            Dim oBitmap As New Bitmap(TreeView.SelectedNode.FullPath & "\" & ListView.SelectedItems(0).Text)
            Dim oGraf As Graphics = e.Graphics
            If OptAjustar.Checked Then
                oGraf.DrawImage(oBitmap, 0, 0, PicImagen.Size.Width, PicImagen.Size.Height)
            Else

                oGraf.DrawImage(oBitmap, 0, 0, oBitmap.Size.Width, oBitmap.Size.Height)

            End If
        End If

    End Sub

    Private Sub OptAjustar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptAjustar.Click
        PicImagen.Invalidate()
    End Sub

    Private Sub OptMantener_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptMantener.Click
        PicImagen.Invalidate()
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    '    Dim tipo As Integer
    '    Dim carleido As Integer
    '    Dim leer As StreamReader
    '    ' carleido = leer.read()
    '    While Not (Chr(carleido) = "*")
    '        carleido = leer.Read()
    '        Dim cadena As String = ""
    '        While Not (Chr(carleido) = ";") And Not (Chr(carleido) = "*")
    '            cadena = Chr(carleido)
    '            carleido = leer.Read
    '        End While
    '        'leido el ;
    '        Dim tipo As Integer = 0
    '        If IsNumeric(cadena) Then
    '            tipo = 1
    '        ElseIf isdate(cadena) Then
    '            tipo = 2
    '        Else
    '            tipo = 3
    '        End If
    '        Select Case tipo
    '            Case 1
    '             ' tipo columna numerica
    '            Case 2

    '               ' tipo columna fecha
    '            Case 3

    '                'tipo columna string
    '        End Select
    '        'carleido = leer.Read
    '    End While

    'End Sub
End Class



