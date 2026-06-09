<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarLote
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarLote))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.txtdispo = New System.Windows.Forms.TextBox()
        Me.txtlote = New System.Windows.Forms.TextBox()
        Me.txtpo = New System.Windows.Forms.TextBox()
        Me.txtestilo = New System.Windows.Forms.TextBox()
        Me.txttalla = New System.Windows.Forms.TextBox()
        Me.txttotaldzrecibidas = New System.Windows.Forms.TextBox()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.cmbcolor = New System.Windows.Forms.ComboBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnbusquedalote = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(34, 70)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&N# "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(32, 137)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&DISPO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(34, 171)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&LOTE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(34, 205)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "&PO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(32, 103)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "&ESTILO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(34, 240)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "&COLOR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(34, 273)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "&TALLA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(29, 305)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "&TOTAL DZ RECIBIDAS"
        '
        'txtnum
        '
        Me.txtnum.ForeColor = System.Drawing.Color.Black
        Me.txtnum.Location = New System.Drawing.Point(91, 70)
        Me.txtnum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(182, 20)
        Me.txtnum.TabIndex = 8
        '
        'txtdispo
        '
        Me.txtdispo.ForeColor = System.Drawing.Color.Black
        Me.txtdispo.Location = New System.Drawing.Point(91, 137)
        Me.txtdispo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtdispo.Name = "txtdispo"
        Me.txtdispo.Size = New System.Drawing.Size(182, 20)
        Me.txtdispo.TabIndex = 9
        '
        'txtlote
        '
        Me.txtlote.ForeColor = System.Drawing.Color.Black
        Me.txtlote.Location = New System.Drawing.Point(91, 171)
        Me.txtlote.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtlote.Name = "txtlote"
        Me.txtlote.Size = New System.Drawing.Size(182, 20)
        Me.txtlote.TabIndex = 10
        '
        'txtpo
        '
        Me.txtpo.ForeColor = System.Drawing.Color.Black
        Me.txtpo.Location = New System.Drawing.Point(91, 202)
        Me.txtpo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtpo.Name = "txtpo"
        Me.txtpo.Size = New System.Drawing.Size(182, 20)
        Me.txtpo.TabIndex = 11
        '
        'txtestilo
        '
        Me.txtestilo.ForeColor = System.Drawing.Color.Black
        Me.txtestilo.Location = New System.Drawing.Point(93, 103)
        Me.txtestilo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtestilo.Name = "txtestilo"
        Me.txtestilo.Size = New System.Drawing.Size(180, 20)
        Me.txtestilo.TabIndex = 12
        '
        'txttalla
        '
        Me.txttalla.ForeColor = System.Drawing.Color.Black
        Me.txttalla.Location = New System.Drawing.Point(91, 270)
        Me.txttalla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txttalla.Name = "txttalla"
        Me.txttalla.Size = New System.Drawing.Size(182, 20)
        Me.txttalla.TabIndex = 14
        '
        'txttotaldzrecibidas
        '
        Me.txttotaldzrecibidas.ForeColor = System.Drawing.Color.Black
        Me.txttotaldzrecibidas.Location = New System.Drawing.Point(174, 302)
        Me.txttotaldzrecibidas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txttotaldzrecibidas.Name = "txttotaldzrecibidas"
        Me.txttotaldzrecibidas.Size = New System.Drawing.Size(99, 20)
        Me.txttotaldzrecibidas.TabIndex = 15
        '
        'btnactualizar
        '
        Me.btnactualizar.FlatAppearance.BorderSize = 0
        Me.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnactualizar.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactualizar.ForeColor = System.Drawing.Color.Black
        Me.btnactualizar.Image = CType(resources.GetObject("btnactualizar.Image"), System.Drawing.Image)
        Me.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnactualizar.Location = New System.Drawing.Point(322, 146)
        Me.btnactualizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(63, 47)
        Me.btnactualizar.TabIndex = 17
        Me.btnactualizar.Text = "&Actualizar"
        Me.btnactualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'cmbcolor
        '
        Me.cmbcolor.ForeColor = System.Drawing.Color.Black
        Me.cmbcolor.FormattingEnabled = True
        Me.cmbcolor.Location = New System.Drawing.Point(91, 237)
        Me.cmbcolor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbcolor.Name = "cmbcolor"
        Me.cmbcolor.Size = New System.Drawing.Size(182, 21)
        Me.cmbcolor.TabIndex = 34
        '
        'btneliminar
        '
        Me.btneliminar.FlatAppearance.BorderSize = 0
        Me.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminar.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.ForeColor = System.Drawing.Color.Black
        Me.btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), System.Drawing.Image)
        Me.btneliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btneliminar.Location = New System.Drawing.Point(322, 208)
        Me.btneliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(61, 47)
        Me.btneliminar.TabIndex = 21
        Me.btneliminar.Text = "&Eliminar"
        Me.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.FlatAppearance.BorderSize = 0
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.Black
        Me.btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), System.Drawing.Image)
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnguardar.Location = New System.Drawing.Point(322, 87)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(61, 47)
        Me.btnguardar.TabIndex = 20
        Me.btnguardar.Text = "&Guardar"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(102, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(206, 25)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "INSERTAR LOTES"
        '
        'btnbusquedalote
        '
        Me.btnbusquedalote.FlatAppearance.BorderSize = 0
        Me.btnbusquedalote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbusquedalote.Image = CType(resources.GetObject("btnbusquedalote.Image"), System.Drawing.Image)
        Me.btnbusquedalote.Location = New System.Drawing.Point(279, 62)
        Me.btnbusquedalote.Name = "btnbusquedalote"
        Me.btnbusquedalote.Size = New System.Drawing.Size(43, 34)
        Me.btnbusquedalote.TabIndex = 35
        Me.btnbusquedalote.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(308, 270)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 52)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "&Regresar Menu"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AgregarLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(407, 352)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnbusquedalote)
        Me.Controls.Add(Me.cmbcolor)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtestilo)
        Me.Controls.Add(Me.txttotaldzrecibidas)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.txttalla)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtdispo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtlote)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtpo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Navy
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "AgregarLote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarLote"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnum As TextBox
    Friend WithEvents txtdispo As TextBox
    Friend WithEvents txtlote As TextBox
    Friend WithEvents txtpo As TextBox
    Friend WithEvents txtestilo As TextBox
    Friend WithEvents txttalla As TextBox
    Friend WithEvents txttotaldzrecibidas As TextBox
    Friend WithEvents btnactualizar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbcolor As ComboBox
    Friend WithEvents btnbusquedalote As Button
    Friend WithEvents Button1 As Button
End Class
