<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Lblhorafecha = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.txtcontrasena = New System.Windows.Forms.TextBox()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lblhorafecha
        '
        Me.Lblhorafecha.AutoSize = True
        Me.Lblhorafecha.Location = New System.Drawing.Point(249, 9)
        Me.Lblhorafecha.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Lblhorafecha.Name = "Lblhorafecha"
        Me.Lblhorafecha.Size = New System.Drawing.Size(40, 15)
        Me.Lblhorafecha.TabIndex = 15
        Me.Lblhorafecha.Text = "label3"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnCerrar.Location = New System.Drawing.Point(227, 220)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(95, 29)
        Me.BtnCerrar.TabIndex = 14
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(155, 29)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(95, 99)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox1.TabIndex = 13
        Me.pictureBox1.TabStop = False
        '
        'BtnIngresar
        '
        Me.BtnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.BtnIngresar.Location = New System.Drawing.Point(80, 220)
        Me.BtnIngresar.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(95, 29)
        Me.BtnIngresar.TabIndex = 12
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseVisualStyleBackColor = True
        '
        'txtcontrasena
        '
        Me.txtcontrasena.Location = New System.Drawing.Point(144, 174)
        Me.txtcontrasena.Margin = New System.Windows.Forms.Padding(5)
        Me.txtcontrasena.Name = "txtcontrasena"
        Me.txtcontrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontrasena.Size = New System.Drawing.Size(190, 22)
        Me.txtcontrasena.TabIndex = 11
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(144, 142)
        Me.txtusuario.Margin = New System.Windows.Forms.Padding(5)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(190, 22)
        Me.txtusuario.TabIndex = 10
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(48, 177)
        Me.label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(70, 15)
        Me.label2.TabIndex = 9
        Me.label2.Text = "Contraseña"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(48, 146)
        Me.label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(50, 15)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Usuario"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(399, 263)
        Me.Controls.Add(Me.Lblhorafecha)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.BtnIngresar)
        Me.Controls.Add(Me.txtcontrasena)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Lblhorafecha As Label
    Private WithEvents BtnCerrar As Button
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents BtnIngresar As Button
    Private WithEvents txtcontrasena As TextBox
    Private WithEvents txtusuario As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
