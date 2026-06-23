Imports System.Data.SqlClient

Public Class CuadrarLote
    Private Sub CuadrarLote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarcombonivel()
    End Sub

    Sub llenarcombonivel()
        Try
            Dim con As New SqlConnection(My.Settings.FLEECE)
            con.Open()

            Dim cmd As New SqlCommand("sp_ConsultarEstatus", con)
            cmd.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            cmbstatus.DataSource = dt
            cmbstatus.DisplayMember = "NombreEstatus"
            cmbstatus.ValueMember = "Codigo"
            cmbstatus.SelectedIndex = -1

            con.Close()
        Catch ex As Exception
            MsgBox("Error al llenar el combo: " & ex.Message)
        End Try
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        ' Validar que se haya seleccionado un estatus
        If cmbstatus.SelectedIndex = -1 Then
            MessageBox.Show("Por favor seleccione un estatus.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validar que el total coincida con las docenas recibidas
        If Val(txttotalcuadraje.Text) <> Val(txttotaldzrecibidas.Text) Then
            MessageBox.Show("El total de cuadraje no coincide con las docenas recibidas. Verifique sus datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Using con As New SqlConnection(My.Settings.FLEECE)
                con.Open()
                Dim cmd As New SqlCommand("sp_CuadrarLote", con)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@Num", txtnum.Text)
                cmd.Parameters.AddWithValue("@Primeras", txtprimeras.Text)
                cmd.Parameters.AddWithValue("@Parciales", txtparciales.Text)
                cmd.Parameters.AddWithValue("@Segundas", txtsegundas.Text)
                cmd.Parameters.AddWithValue("@Terceras", txtterceras.Text)
                cmd.Parameters.AddWithValue("@Scrapt", txtscrapt.Text)
                cmd.Parameters.AddWithValue("@TotalCuadraje", txttotalcuadraje.Text)
                cmd.Parameters.AddWithValue("@Estatus", cmbstatus.SelectedValue) ' ← Corregido

                cmd.ExecuteNonQuery()
                MessageBox.Show("Cuadraje guardado y estatus actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DataReporte.llenarDatagrid()  ' ← Refresca el grid en DataReporte
                LimpiarTextos()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub calcularTotal()
        Try
            Dim p As Decimal = 0, par As Decimal = 0, s As Decimal = 0, t As Decimal = 0, sc As Decimal = 0
            Dim totalRecibido As Decimal = 0

            Decimal.TryParse(txtprimeras.Text, p)
            Decimal.TryParse(txtparciales.Text, par)
            Decimal.TryParse(txtsegundas.Text, s)
            Decimal.TryParse(txtterceras.Text, t)
            Decimal.TryParse(txtscrapt.Text, sc)
            Decimal.TryParse(txttotaldzrecibidas.Text, totalRecibido)

            Dim sumaTotal As Decimal = p + par + s + t + sc
            txttotalcuadraje.Text = sumaTotal.ToString()

            If Math.Round(sumaTotal, 2) = Math.Round(totalRecibido, 2) Then
                txttotalcuadraje.BackColor = Color.LightGreen
                txttotalcuadraje.ForeColor = Color.Black
            Else
                txttotalcuadraje.BackColor = Color.Salmon
                txttotalcuadraje.ForeColor = Color.White
            End If

        Catch ex As Exception
            Console.WriteLine("Error en cálculo: " & ex.Message)
        End Try
    End Sub

    Private Sub txtnum_Leave(sender As Object, e As EventArgs) Handles txtnum.Leave
        If txtnum.Text <> "" Then
            Try
                Using con As New SqlConnection(My.Settings.FLEECE)
                    con.Open()
                    Dim cmd As New SqlCommand("sp_BuscarLoteParaCuadrar", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@DatoBusqueda", txtnum.Text)

                    Dim dr As SqlDataReader = cmd.ExecuteReader()

                    If dr.Read() Then
                        txtnum.Text = dr("Num").ToString()
                        txttotaldzrecibidas.Text = dr("TotalDZRecibidas").ToString()
                        txtnum.ReadOnly = True
                        txttotaldzrecibidas.ReadOnly = True
                        txtprimeras.Focus()
                    Else
                        MessageBox.Show("El lote no existe en el sistema.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtnum.Clear()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al buscar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Sub LimpiarTextos()
        txtnum.Text = ""
        txttotaldzrecibidas.Text = ""
        txtprimeras.Text = ""
        txtparciales.Text = ""
        txtsegundas.Text = ""
        txtterceras.Text = ""
        txtscrapt.Text = ""
        txttotalcuadraje.Text = ""
        cmbstatus.SelectedIndex = -1  ' ← Corregido
        txtnum.ReadOnly = False        ' ← Corregido
        txttotaldzrecibidas.ReadOnly = False  ' ← Corregido
        txtnum.Focus()
    End Sub

    Private Sub txtprimeras_TextChanged(sender As Object, e As EventArgs) Handles txtprimeras.TextChanged
        calcularTotal()
    End Sub

    Private Sub txtparciales_TextChanged(sender As Object, e As EventArgs) Handles txtparciales.TextChanged
        calcularTotal()
    End Sub

    Private Sub txtsegundas_TextChanged(sender As Object, e As EventArgs) Handles txtsegundas.TextChanged
        calcularTotal()
    End Sub

    Private Sub txtterceras_TextChanged(sender As Object, e As EventArgs) Handles txtterceras.TextChanged
        calcularTotal()
    End Sub

    Private Sub txtscrapt_TextChanged(sender As Object, e As EventArgs) Handles txtscrapt.TextChanged
        calcularTotal()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        LimpiarTextos()
        MENU_FLEECE.Show()
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        ' Validar que haya un N# para actualizar
        If String.IsNullOrWhiteSpace(txtnum.Text) Then
            MessageBox.Show("Por favor, ingrese un N# para actualizar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validar que se haya seleccionado un estatus
        If cmbstatus.SelectedIndex = -1 Then
            MessageBox.Show("Por favor seleccione un estatus.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validar que el total coincida con las docenas recibidas
        If Val(txttotalcuadraje.Text) <> Val(txttotaldzrecibidas.Text) Then
            MessageBox.Show("El total de cuadraje no coincide con las docenas recibidas. Verifique sus datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Using con As New SqlConnection(My.Settings.FLEECE)
                con.Open()
                Dim cmd As New SqlCommand("sp_CuadrarLote", con)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@Num", txtnum.Text)
                cmd.Parameters.AddWithValue("@Primeras", txtprimeras.Text)
                cmd.Parameters.AddWithValue("@Parciales", txtparciales.Text)
                cmd.Parameters.AddWithValue("@Segundas", txtsegundas.Text)
                cmd.Parameters.AddWithValue("@Terceras", txtterceras.Text)
                cmd.Parameters.AddWithValue("@Scrapt", txtscrapt.Text)
                cmd.Parameters.AddWithValue("@TotalCuadraje", txttotalcuadraje.Text)
                cmd.Parameters.AddWithValue("@Estatus", cmbstatus.SelectedValue)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Cuadraje actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DataReporte.llenarDatagrid()
                LimpiarTextos()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        ' Validar que haya un N# para eliminar
        If String.IsNullOrWhiteSpace(txtnum.Text) Then
            MessageBox.Show("Por favor, ingrese un N# para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim respuesta As DialogResult = MessageBox.Show(
        "¿Está seguro de eliminar el cuadraje del Lote N# " & txtnum.Text & "? Esta acción no se puede deshacer.",
        "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If respuesta = DialogResult.Yes Then
            Try
                Using con As New SqlConnection(My.Settings.FLEECE)
                    con.Open()
                    ' Limpiamos solo los campos de cuadraje, no el lote completo
                    Dim sql As String = "UPDATE AGREGARLOTES SET Primeras = 0, Parciales = 0, Segundas = 0, " &
                                    "Terceras = 0, Scrapt = 0, TotalCuadraje = 0, Estatus = 0 WHERE Num = @Num"
                    Dim cmd As New SqlCommand(sql, con)
                    cmd.Parameters.Add("@Num", SqlDbType.Int).Value = Convert.ToInt32(txtnum.Text)

                    Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()

                    If filasAfectadas > 0 Then
                        MessageBox.Show("Cuadraje eliminado satisfactoriamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        DataReporte.llenarDatagrid()
                        LimpiarTextos()
                    Else
                        MessageBox.Show("No se encontró el lote con ese N#.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al eliminar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class