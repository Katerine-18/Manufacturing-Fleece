Imports System.Data.SqlClient

Public Class AgregarLote
    Private Sub AgregarLote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCmbColores()
        llenarDatagrid()
    End Sub

    'Llenando datos al combo box de colores
    Sub LlenarCmbColores()
        Dim con As New SqlConnection(My.Settings.FLEECE)
        con.Open()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da = New SqlDataAdapter("select Color from COLORES", con)
        da.Fill(dt)

        cmbcolor.DataSource = dt
        cmbcolor.DisplayMember = "Color"
        con.Close()
    End Sub

    'Llenando datadriedview desde la base de datos
    Sub llenarDatagrid()

        Dim con As New SqlConnection(My.Settings.FLEECE)
        con.Open()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da = New SqlDataAdapter("SElECT * FROM AGREGARLOTES", con)

        da.Fill(dt)


    End Sub


    Private Sub btncuadrar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        Try
            Using con As New SqlConnection(My.Settings.FLEECE)
                con.Open()

                Dim cmd As New SqlCommand("sp_InsertarLote", con)
                cmd.CommandType = CommandType.StoredProcedure

                ' --- CONVERSIÓN DE DATOS ---
                ' Num, Lote, PO y TotalDZRecibidas deben ir como números (Val)
                ' Estilo, Dispo, Color y Talla se quedan como texto (.Text)

                cmd.Parameters.AddWithValue("@Num", Val(txtnum.Text))
                cmd.Parameters.AddWithValue("@Estilo", txtestilo.Text)
                cmd.Parameters.AddWithValue("@Dispo", txtdispo.Text)
                cmd.Parameters.AddWithValue("@Lote", Val(txtlote.Text))
                cmd.Parameters.AddWithValue("@PO", Val(txtpo.Text))
                cmd.Parameters.AddWithValue("@Color", cmbcolor.Text)
                cmd.Parameters.AddWithValue("@Talla", txttalla.Text)
                cmd.Parameters.AddWithValue("@TotalDZRecibidas", Val(txttotaldzrecibidas.Text))

                ' Ejecutamos la instrucción
                cmd.ExecuteNonQuery()

                MessageBox.Show("Lote Agregado Correctamente a la base de datos FLEECE")

                ' Limpia los campos o actualiza el grid
                llenarDatagrid()
                ' Limpiar los campos después de guardar
                LimpiarTextos()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message)
        End Try

    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click

        Try
            Using con As New SqlConnection(My.Settings.FLEECE)
                con.Open()
                ' Importante: Asegúrate de tener un procedimiento llamado sp_ActualizarLote
                ' o cambia la instrucción a un UPDATE directo si no lo tienes.
                Dim cmd As New SqlCommand("sp_ActualizarLote", con)
                cmd.CommandType = CommandType.StoredProcedure

                ' --- MANEJO CORRECTO DE DECIMALES ---
                ' Usamos .Add con el tipo de dato explícito para que SQL no se confunda.

                ' El identificador (N#) suele ser entero
                cmd.Parameters.Add("@Num", SqlDbType.Int).Value = Convert.ToInt32(txtnum.Text)

                ' Campos de Texto
                cmd.Parameters.Add("@Estilo", SqlDbType.NVarChar).Value = txtestilo.Text
                cmd.Parameters.Add("@Dispo", SqlDbType.NVarChar).Value = txtdispo.Text
                cmd.Parameters.Add("@Color", SqlDbType.NVarChar).Value = cmbcolor.Text
                cmd.Parameters.Add("@Talla", SqlDbType.NVarChar).Value = txttalla.Text

                ' Campos Numéricos (Lote y PO suelen ser enteros)
                cmd.Parameters.Add("@Lote", SqlDbType.Int).Value = Convert.ToInt32(txtlote.Text)
                cmd.Parameters.Add("@PO", SqlDbType.Int).Value = Convert.ToInt32(txtpo.Text)

                ' EL CAMPO CRÍTICO: Total DZ Recibidas (Decimal)
                ' Esto evita que 10.5 se convierta en 10
                Dim totalRecibidas As Decimal
                If Decimal.TryParse(txttotaldzrecibidas.Text, totalRecibidas) Then
                    cmd.Parameters.Add("@TotalDZRecibidas", SqlDbType.Decimal, 6, 2).Value = totalRecibidas
                Else
                    cmd.Parameters.Add("@TotalDZRecibidas", SqlDbType.Decimal, 6, 2).Value = 0
                End If

                ' Ejecutamos
                cmd.ExecuteNonQuery()

                MessageBox.Show("¡Lote actualizado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                llenarDatagrid()
                LimpiarTextos()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar: " & ex.Message, "Error de Conversión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        ' Preguntar antes de borrar
        Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro de eliminar este Lote? Esta acción no se puede deshacer.", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If respuesta = DialogResult.Yes Then
            Try
                Using con As New SqlConnection(My.Settings.FLEECE)
                    con.Open()
                    Dim sql As String = "DELETE FROM AGREGARLOTES WHERE Lote=@Lote"
                    Dim cmd As New SqlCommand(sql, con)

                    cmd.Parameters.AddWithValue("@Lote", txtlote.Text)

                    Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()

                    If filasAfectadas > 0 Then
                        MessageBox.Show("Lote eliminado satisfactoriamente.")
                        ' Limpiar campos después de eliminar
                        txtlote.Clear()
                        txtestilo.Clear()
                        llenarDatagrid()
                    Else
                        MessageBox.Show("El Lote no existe o no pudo ser eliminado.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al eliminar: " & ex.Message)
            End Try
        End If
    End Sub

    Sub LimpiarTextos()
        txtnum.Text = ""
        txtestilo.Text = ""
        txtdispo.Text = ""
        txtlote.Text = ""
        txtpo.Text = ""
        cmbcolor.Text = ""
        txttalla.Text = ""
        txttotaldzrecibidas.Text = ""
        txtnum.Focus()

    End Sub

    Private Sub btnbusquedalote_Click(sender As Object, e As EventArgs) Handles btnbusquedalote.Click
        ' Validamos que el campo N# no esté vacío
        If String.IsNullOrWhiteSpace(txtnum.Text) Then
            MessageBox.Show("Por favor, ingrese un número (N#) para buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using con As New SqlConnection(My.Settings.FLEECE)
                con.Open()
                ' Buscamos todos los campos del lote que coincida con el N#
                Dim sql As String = "SELECT Estilo, Dispo, Lote, PO, Color, Talla, TotalDZRecibidas FROM AGREGARLOTES WHERE Num = @Num"

                Dim cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@Num", Val(txtnum.Text))

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    ' Si encuentra el registro, llena los TextBoxes
                    txtestilo.Text = reader("Estilo").ToString()
                    txtdispo.Text = reader("Dispo").ToString()
                    txtlote.Text = reader("Lote").ToString()
                    txtpo.Text = reader("PO").ToString()
                    cmbcolor.Text = reader("Color").ToString()
                    txttalla.Text = reader("Talla").ToString()

                    ' Para el decimal, nos aseguramos que se vea bien en el texto
                    txttotaldzrecibidas.Text = reader("TotalDZRecibidas").ToString()

                    MessageBox.Show("Datos cargados correctamente.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No se encontró ningún lote con ese número.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    LimpiarTextos()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al buscar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MENU_FLEECE.Show()
    End Sub
End Class