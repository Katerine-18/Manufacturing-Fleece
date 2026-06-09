<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bitacora_Auditorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bitacora_Auditorias))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.txtnumerolote = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtdocenas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtestilo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvHistorial = New System.Windows.Forms.DataGridView()
        Me.btnconfirmar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lote"
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(562, 50)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(231, 21)
        Me.cmbStatus.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(473, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(473, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Observación"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(562, 92)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacion.Size = New System.Drawing.Size(331, 98)
        Me.txtObservacion.TabIndex = 4
        '
        'txtnumerolote
        '
        Me.txtnumerolote.Location = New System.Drawing.Point(121, 16)
        Me.txtnumerolote.Name = "txtnumerolote"
        Me.txtnumerolote.Size = New System.Drawing.Size(100, 20)
        Me.txtnumerolote.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtdocenas)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtestilo)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtnumerolote)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(44, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(369, 152)
        Me.Panel1.TabIndex = 6
        '
        'txtdocenas
        '
        Me.txtdocenas.Location = New System.Drawing.Point(121, 91)
        Me.txtdocenas.Name = "txtdocenas"
        Me.txtdocenas.Size = New System.Drawing.Size(100, 20)
        Me.txtdocenas.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Total Docenas"
        '
        'txtestilo
        '
        Me.txtestilo.Location = New System.Drawing.Point(121, 54)
        Me.txtestilo.Name = "txtestilo"
        Me.txtestilo.Size = New System.Drawing.Size(100, 20)
        Me.txtestilo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Estilo"
        '
        'dgvHistorial
        '
        Me.dgvHistorial.BackgroundColor = System.Drawing.Color.White
        Me.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistorial.Location = New System.Drawing.Point(35, 284)
        Me.dgvHistorial.Name = "dgvHistorial"
        Me.dgvHistorial.RowHeadersVisible = False
        Me.dgvHistorial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvHistorial.Size = New System.Drawing.Size(896, 172)
        Me.dgvHistorial.TabIndex = 7
        '
        'btnconfirmar
        '
        Me.btnconfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconfirmar.Location = New System.Drawing.Point(740, 196)
        Me.btnconfirmar.Name = "btnconfirmar"
        Me.btnconfirmar.Size = New System.Drawing.Size(153, 30)
        Me.btnconfirmar.TabIndex = 8
        Me.btnconfirmar.Text = "Confirmar Auditoria"
        Me.btnconfirmar.UseVisualStyleBackColor = True
        '
        'Bitacora_Auditorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(954, 562)
        Me.Controls.Add(Me.btnconfirmar)
        Me.Controls.Add(Me.dgvHistorial)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbStatus)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Bitacora_Auditorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bitacora_Auditorias"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents txtnumerolote As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtdocenas As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtestilo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvHistorial As DataGridView
    Friend WithEvents btnconfirmar As Button
End Class
