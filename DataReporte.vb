Imports System.Data.SqlClient

Public Class DataReporte
    Private Sub DataReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarDatagrid()


    End Sub

    Sub llenarDatagrid()
        Try
            Using con As New SqlConnection(My.Settings.FLEECE)
                ' Cambiamos la consulta directa por la llamada al Stored Procedure
                Dim cmd As New SqlCommand("sp_ConsultarReporteCuadraje", con)
                cmd.CommandType = CommandType.StoredProcedure

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                da.Fill(dt)
                dgvReporteGeneral.DataSource = dt
                ' Justo después de: dgvReporteGeneral.DataSource = dt
                dgvReporteGeneral.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgvReporteGeneral.Columns(dgvReporteGeneral.Columns.Count - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        End Try

    End Sub


    Private Sub txtbuscador_TextChanged(sender As Object, e As EventArgs) Handles txtbuscador.TextChanged
        Try
            Using con As New SqlConnection(My.Settings.FLEECE)
                con.Open()

                ' CAMBIO CLAVE: Hacemos el JOIN con la tabla ESTATUS para traer el nombre
                Dim sql As String = "SELECT A.Num, A.Estilo, A.Dispo, A.Lote, A.PO, A.Color, A.Talla, " &
                                "A.TotalDZRecibidas, A.Primeras, A.Parciales, A.Segundas, A.Terceras, " &
                                "A.Scrapt, A.TotalCuadraje, E.NombreEstatus AS Estatus " &
                                "FROM AGREGARLOTES A " &
                                "INNER JOIN ESTATUS E ON A.Estatus = E.Codigo " &
                                "WHERE A.Estilo LIKE @busqueda OR " &
                                "A.Color LIKE @busqueda OR " &
                                "A.Talla LIKE @busqueda OR " &
                                "CAST(A.Lote AS VARCHAR) LIKE @busqueda OR " &
                                "CAST(A.Num AS VARCHAR) LIKE @busqueda"

                Dim cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@busqueda", "%" & txtbuscador.Text & "%")

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                dgvReporteGeneral.DataSource = dt
            End Using
        Catch ex As Exception
            Console.WriteLine("Error al filtrar: " & ex.Message)
        End Try
    End Sub


    Private Sub btnpackinglist_Click(sender As Object, e As EventArgs) Handles btnpackinglist.Click
        Try
            ' 1. Consultamos los datos del lote seleccionado
            Dim dt As New DataTable
            Using con As New SqlConnection(My.Settings.FLEECE)
                Dim sql As String = "SELECT * FROM AGREGARLOTES WHERE Num = @Num"
                Dim cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@Num", txtbuscador.Text)
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using

            ' 2. Si el lote existe, abrimos la ventana de impresión
            If dt.Rows.Count > 0 Then
                Dim visor As New frmImpresion()
                visor.DatosLote = dt ' Pasamos el DataTable al nuevo formulario
                visor.ShowDialog()   ' ShowDialog hace que el usuario deba cerrar el reporte para volver
            Else
                MessageBox.Show("Primero busca un lote válido para generar el Packing List.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub btnAbrirAuditoria_Click(sender As Object, e As EventArgs) Handles btnAbrirAuditoria.Click
        ' Verificamos que haya una fila seleccionada
        If dgvReporteGeneral.SelectedRows.Count > 0 Then
            Dim frm As New Bitacora_Auditorias() ' Creamos una instancia de tu formulario

            ' Pasamos los datos de la fila seleccionada a las variables públicas del otro formulario
            ' Cambia "NumLote", "Estilo", etc., por los nombres exactos de tus columnas
            frm.LoteRecibido = dgvReporteGeneral.CurrentRow.Cells("Lote").Value.ToString()
            frm.EstiloRecibido = dgvReporteGeneral.CurrentRow.Cells("Estilo").Value.ToString()
            frm.DocenasRecibidas = dgvReporteGeneral.CurrentRow.Cells("TotalDZRecibidas").Value.ToString()

            ' Abrimos el formulario como un Pop-up (ShowDialog no deja usar la de atrás hasta cerrar esta)
            frm.ShowDialog()

            ' Opcional: Cuando se cierre el pop-up, refrescamos la tabla principal
            llenarDatagrid()
        Else
            MessageBox.Show("Por favor, seleccione un lote de la lista para auditar.")
        End If
    End Sub
End Class