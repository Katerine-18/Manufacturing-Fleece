<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MENU_FLEECE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MENU_FLEECE))
        Me.btnAgregarLote = New System.Windows.Forms.Button()
        Me.btnExportacion = New System.Windows.Forms.Button()
        Me.btnCuadrarLote = New System.Windows.Forms.Button()
        Me.btnElcatex = New System.Windows.Forms.Button()
        Me.btnReporteGeneral = New System.Windows.Forms.Button()
        Me.btnSanmar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAgregarLote
        '
        Me.btnAgregarLote.FlatAppearance.BorderSize = 0
        Me.btnAgregarLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarLote.Image = CType(resources.GetObject("btnAgregarLote.Image"), System.Drawing.Image)
        Me.btnAgregarLote.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregarLote.Location = New System.Drawing.Point(68, 153)
        Me.btnAgregarLote.Name = "btnAgregarLote"
        Me.btnAgregarLote.Size = New System.Drawing.Size(145, 73)
        Me.btnAgregarLote.TabIndex = 1
        Me.btnAgregarLote.Text = "&Agregar Lote"
        Me.btnAgregarLote.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregarLote.UseVisualStyleBackColor = True
        '
        'btnExportacion
        '
        Me.btnExportacion.FlatAppearance.BorderSize = 0
        Me.btnExportacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportacion.Image = CType(resources.GetObject("btnExportacion.Image"), System.Drawing.Image)
        Me.btnExportacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExportacion.Location = New System.Drawing.Point(539, 281)
        Me.btnExportacion.Name = "btnExportacion"
        Me.btnExportacion.Size = New System.Drawing.Size(145, 73)
        Me.btnExportacion.TabIndex = 2
        Me.btnExportacion.Text = "&Exportacion"
        Me.btnExportacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExportacion.UseVisualStyleBackColor = True
        '
        'btnCuadrarLote
        '
        Me.btnCuadrarLote.FlatAppearance.BorderSize = 0
        Me.btnCuadrarLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCuadrarLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuadrarLote.Image = CType(resources.GetObject("btnCuadrarLote.Image"), System.Drawing.Image)
        Me.btnCuadrarLote.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCuadrarLote.Location = New System.Drawing.Point(309, 153)
        Me.btnCuadrarLote.Name = "btnCuadrarLote"
        Me.btnCuadrarLote.Size = New System.Drawing.Size(145, 73)
        Me.btnCuadrarLote.TabIndex = 3
        Me.btnCuadrarLote.Text = "&Cuadrar Lote"
        Me.btnCuadrarLote.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCuadrarLote.UseVisualStyleBackColor = True
        '
        'btnElcatex
        '
        Me.btnElcatex.FlatAppearance.BorderSize = 0
        Me.btnElcatex.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnElcatex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnElcatex.Image = CType(resources.GetObject("btnElcatex.Image"), System.Drawing.Image)
        Me.btnElcatex.Location = New System.Drawing.Point(56, 281)
        Me.btnElcatex.Name = "btnElcatex"
        Me.btnElcatex.Size = New System.Drawing.Size(145, 73)
        Me.btnElcatex.TabIndex = 4
        Me.btnElcatex.Text = "&Auditorias Elcatex"
        Me.btnElcatex.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnElcatex.UseVisualStyleBackColor = True
        '
        'btnReporteGeneral
        '
        Me.btnReporteGeneral.FlatAppearance.BorderSize = 0
        Me.btnReporteGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporteGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteGeneral.Image = CType(resources.GetObject("btnReporteGeneral.Image"), System.Drawing.Image)
        Me.btnReporteGeneral.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReporteGeneral.Location = New System.Drawing.Point(539, 153)
        Me.btnReporteGeneral.Name = "btnReporteGeneral"
        Me.btnReporteGeneral.Size = New System.Drawing.Size(145, 73)
        Me.btnReporteGeneral.TabIndex = 5
        Me.btnReporteGeneral.Text = "&Reporte General"
        Me.btnReporteGeneral.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReporteGeneral.UseVisualStyleBackColor = True
        '
        'btnSanmar
        '
        Me.btnSanmar.FlatAppearance.BorderSize = 0
        Me.btnSanmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSanmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSanmar.Image = CType(resources.GetObject("btnSanmar.Image"), System.Drawing.Image)
        Me.btnSanmar.Location = New System.Drawing.Point(293, 281)
        Me.btnSanmar.Name = "btnSanmar"
        Me.btnSanmar.Size = New System.Drawing.Size(156, 73)
        Me.btnSanmar.TabIndex = 6
        Me.btnSanmar.Text = "&Auditorias Sanmar"
        Me.btnSanmar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSanmar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(286, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 38)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Menu Fleece"
        '
        'MENU_FLEECE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(764, 426)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSanmar)
        Me.Controls.Add(Me.btnReporteGeneral)
        Me.Controls.Add(Me.btnElcatex)
        Me.Controls.Add(Me.btnCuadrarLote)
        Me.Controls.Add(Me.btnExportacion)
        Me.Controls.Add(Me.btnAgregarLote)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MENU_FLEECE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENU FLEECE"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregarLote As Button
    Friend WithEvents btnExportacion As Button
    Friend WithEvents btnCuadrarLote As Button
    Friend WithEvents btnElcatex As Button
    Friend WithEvents btnReporteGeneral As Button
    Friend WithEvents btnSanmar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
