Imports System.Data.SqlClient

Public Class FrmLogin
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Lblhorafecha.Text = System.DateTime.Now
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        'Conectando a la base de datos
        Dim con As New SqlConnection(My.Settings.FLEECE)
        con.Open()
        Dim reader As SqlDataReader
        Dim cmd As New SqlCommand("select * from USUARIOS where idusuario='" & txtusuario.Text & "' and contrasena= '" & txtcontrasena.Text & " ' ", con)
        reader = cmd.ExecuteReader

        'Validando si el usuario existe en la base de datos
        If reader.Read Then

            If reader.Item("estado") = True Then
                'VariablesPublicas.idusuario = reader.Item("idusuario")
                'VariablesPublicas.nivel = reader.Item("nivel")

                Me.Hide()
                MENU_FLEECE.ShowDialog()

            Else
                MessageBox.Show("Usuario Inactivo")

            End If
        Else
            MessageBox.Show("Usuario o Contraseña Incorrectos")
        End If
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
