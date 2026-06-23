Imports System.Data.SqlClient

Public Class FrmLogin
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Lblhorafecha.Text = System.DateTime.Now
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If String.IsNullOrWhiteSpace(txtusuario.Text) Or String.IsNullOrWhiteSpace(txtcontrasena.Text) Then
            MessageBox.Show("Por favor ingrese usuario y contraseña.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using con As New SqlConnection(My.Settings.FLEECE)
                con.Open()

                ' Consulta segura con parámetros
                Dim cmd As New SqlCommand("SELECT * FROM USUARIOS WHERE idusuario = @usuario AND contrasena = @contrasena", con)
                cmd.Parameters.AddWithValue("@usuario", txtusuario.Text.Trim())
                cmd.Parameters.AddWithValue("@contrasena", txtcontrasena.Text.Trim())

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    If reader.Item("estado") = True Then
                        Me.Hide()
                        MENU_FLEECE.ShowDialog()
                    Else
                        MessageBox.Show("Usuario Inactivo.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("Usuario o Contraseña Incorrectos.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtcontrasena.Clear()
                    txtusuario.Focus()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al conectar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class