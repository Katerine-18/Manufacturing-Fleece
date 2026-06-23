<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataReporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataReporte))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbuscador = New System.Windows.Forms.TextBox()
        Me.dgvReporteGeneral = New System.Windows.Forms.DataGridView()
        Me.btnpackinglist = New System.Windows.Forms.Button()
        Me.btnAbrirAuditoria = New System.Windows.Forms.Button()
        Me.btnregresar = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        CType(Me.dgvReporteGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(408, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(501, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reporte General de Lotes a Entregar Auditoría"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(268, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Buscar Lote"
        '
        'txtbuscador
        '
        Me.txtbuscador.Location = New System.Drawing.Point(371, 93)
        Me.txtbuscador.Name = "txtbuscador"
        Me.txtbuscador.Size = New System.Drawing.Size(148, 20)
        Me.txtbuscador.TabIndex = 2
        '
        'dgvReporteGeneral
        '
        Me.dgvReporteGeneral.AllowUserToAddRows = False
        Me.dgvReporteGeneral.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvReporteGeneral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvReporteGeneral.BackgroundColor = System.Drawing.Color.White
        Me.dgvReporteGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReporteGeneral.Location = New System.Drawing.Point(31, 134)
        Me.dgvReporteGeneral.Name = "dgvReporteGeneral"
        Me.dgvReporteGeneral.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvReporteGeneral.Size = New System.Drawing.Size(1141, 434)
        Me.dgvReporteGeneral.TabIndex = 4
        '
        'btnpackinglist
        '
        Me.btnpackinglist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpackinglist.Location = New System.Drawing.Point(533, 90)
        Me.btnpackinglist.Name = "btnpackinglist"
        Me.btnpackinglist.Size = New System.Drawing.Size(174, 23)
        Me.btnpackinglist.TabIndex = 5
        Me.btnpackinglist.Text = "Generar Packing List"
        Me.btnpackinglist.UseVisualStyleBackColor = True
        '
        'btnAbrirAuditoria
        '
        Me.btnAbrirAuditoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrirAuditoria.Location = New System.Drawing.Point(713, 90)
        Me.btnAbrirAuditoria.Name = "btnAbrirAuditoria"
        Me.btnAbrirAuditoria.Size = New System.Drawing.Size(158, 23)
        Me.btnAbrirAuditoria.TabIndex = 6
        Me.btnAbrirAuditoria.Text = "Ver Historial"
        Me.btnAbrirAuditoria.UseVisualStyleBackColor = True
        '
        'btnregresar
        '
        Me.btnregresar.FlatAppearance.BorderSize = 0
        Me.btnregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregresar.Image = CType(resources.GetObject("btnregresar.Image"), System.Drawing.Image)
        Me.btnregresar.Location = New System.Drawing.Point(1025, 84)
        Me.btnregresar.Name = "btnregresar"
        Me.btnregresar.Size = New System.Drawing.Size(39, 37)
        Me.btnregresar.TabIndex = 7
        Me.btnregresar.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.FlatAppearance.BorderSize = 0
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.Location = New System.Drawing.Point(1070, 85)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(40, 35)
        Me.btnExportar.TabIndex = 8
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.FlatAppearance.BorderSize = 0
        Me.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlimpiar.Image = CType(resources.GetObject("btnlimpiar.Image"), System.Drawing.Image)
        Me.btnlimpiar.Location = New System.Drawing.Point(1116, 84)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(40, 35)
        Me.btnlimpiar.TabIndex = 9
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'DataReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1199, 613)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnregresar)
        Me.Controls.Add(Me.btnAbrirAuditoria)
        Me.Controls.Add(Me.btnpackinglist)
        Me.Controls.Add(Me.dgvReporteGeneral)
        Me.Controls.Add(Me.txtbuscador)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DataReporte"
        Me.Text = "DataReporte"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvReporteGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbuscador As TextBox
    Friend WithEvents dgvReporteGeneral As DataGridView
    Friend WithEvents btnpackinglist As Button
    Friend WithEvents btnAbrirAuditoria As Button
    Friend WithEvents btnregresar As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnlimpiar As Button
End Class
