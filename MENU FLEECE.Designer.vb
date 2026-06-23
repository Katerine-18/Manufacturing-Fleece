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
        Me.btnCuadrarLote = New System.Windows.Forms.Button()
        Me.btnReporteGeneral = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsettings = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAgregarLote
        '
        Me.btnAgregarLote.FlatAppearance.BorderSize = 0
        Me.btnAgregarLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarLote.Image = CType(resources.GetObject("btnAgregarLote.Image"), System.Drawing.Image)
        Me.btnAgregarLote.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregarLote.Location = New System.Drawing.Point(47, 158)
        Me.btnAgregarLote.Name = "btnAgregarLote"
        Me.btnAgregarLote.Size = New System.Drawing.Size(145, 73)
        Me.btnAgregarLote.TabIndex = 1
        Me.btnAgregarLote.Text = "&Agregar Lote"
        Me.btnAgregarLote.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregarLote.UseVisualStyleBackColor = True
        '
        'btnCuadrarLote
        '
        Me.btnCuadrarLote.FlatAppearance.BorderSize = 0
        Me.btnCuadrarLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCuadrarLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuadrarLote.Image = CType(resources.GetObject("btnCuadrarLote.Image"), System.Drawing.Image)
        Me.btnCuadrarLote.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCuadrarLote.Location = New System.Drawing.Point(286, 158)
        Me.btnCuadrarLote.Name = "btnCuadrarLote"
        Me.btnCuadrarLote.Size = New System.Drawing.Size(145, 73)
        Me.btnCuadrarLote.TabIndex = 3
        Me.btnCuadrarLote.Text = "&Cuadrar Lote"
        Me.btnCuadrarLote.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCuadrarLote.UseVisualStyleBackColor = True
        '
        'btnReporteGeneral
        '
        Me.btnReporteGeneral.FlatAppearance.BorderSize = 0
        Me.btnReporteGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporteGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteGeneral.Image = CType(resources.GetObject("btnReporteGeneral.Image"), System.Drawing.Image)
        Me.btnReporteGeneral.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReporteGeneral.Location = New System.Drawing.Point(516, 158)
        Me.btnReporteGeneral.Name = "btnReporteGeneral"
        Me.btnReporteGeneral.Size = New System.Drawing.Size(145, 73)
        Me.btnReporteGeneral.TabIndex = 5
        Me.btnReporteGeneral.Text = "&Reporte General"
        Me.btnReporteGeneral.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReporteGeneral.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(160, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(82, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(238, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 38)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Menu Fleece"
        '
        'btnsettings
        '
        Me.btnsettings.FlatAppearance.BorderSize = 0
        Me.btnsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsettings.Image = CType(resources.GetObject("btnsettings.Image"), System.Drawing.Image)
        Me.btnsettings.Location = New System.Drawing.Point(585, 278)
        Me.btnsettings.Name = "btnsettings"
        Me.btnsettings.Size = New System.Drawing.Size(76, 64)
        Me.btnsettings.TabIndex = 9
        Me.btnsettings.Text = "Ayuda"
        Me.btnsettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsettings.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(62, 56)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'MENU_FLEECE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(686, 364)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnsettings)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReporteGeneral)
        Me.Controls.Add(Me.btnCuadrarLote)
        Me.Controls.Add(Me.btnAgregarLote)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MENU_FLEECE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENU FLEECE"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregarLote As Button
    Friend WithEvents btnCuadrarLote As Button
    Friend WithEvents btnReporteGeneral As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnsettings As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
