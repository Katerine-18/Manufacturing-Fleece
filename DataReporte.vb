Imports System.Data.SqlClient
Imports System.IO

Public Class DataReporte
    Private Sub DataReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarDatagrid()
    End Sub

    Sub llenarDatagrid()
        Try
            Using con As New SqlConnection(My.Settings.FLEECE)
                Dim cmd As New SqlCommand("sp_ConsultarReporteCuadraje", con)
                cmd.CommandType = CommandType.StoredProcedure

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                da.Fill(dt)

                ' Suspende el dibujado visual hasta que todo esté listo
                dgvReporteGeneral.SuspendLayout()
                dgvReporteGeneral.DataSource = dt
                dgvReporteGeneral.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgvReporteGeneral.Columns(dgvReporteGeneral.Columns.Count - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dgvReporteGeneral.ResumeLayout()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub

    Private Sub txtbuscador_TextChanged(sender As Object, e As EventArgs) Handles txtbuscador.TextChanged
        ' MEJORA 1: Si el buscador tiene menos de 2 caracteres muestra todo
        If txtbuscador.Text.Length < 2 Then
            llenarDatagrid()
            Exit Sub
        End If

        Try
            Using con As New SqlConnection(My.Settings.FLEECE)
                con.Open()

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

    ' MEJORA 2: Exportar a Excel
    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            If dgvReporteGeneral.Rows.Count = 0 Then
                MessageBox.Show("No hay datos para exportar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "CSV (Excel)|*.csv"
            saveDialog.Title = "Exportar Reporte"
            saveDialog.FileName = "ReporteFLEECE_" & Format(Now, "yyyyMMdd")

            If saveDialog.ShowDialog() = DialogResult.OK Then
                Dim sb As New System.Text.StringBuilder()

                ' Encabezados
                For Each col As DataGridViewColumn In dgvReporteGeneral.Columns
                    sb.Append(col.HeaderText & ",")
                Next
                sb.AppendLine()

                ' Filas
                For Each row As DataGridViewRow In dgvReporteGeneral.Rows
                    For Each cell As DataGridViewCell In row.Cells
                        sb.Append(If(cell.Value IsNot Nothing, cell.Value.ToString(), "") & ",")
                    Next
                    sb.AppendLine()
                Next

                File.WriteAllText(saveDialog.FileName, sb.ToString(), System.Text.Encoding.UTF8)
                MessageBox.Show("Reporte exportado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al exportar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' MEJORA 3: Limpiar buscador
    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtbuscador.Clear()
        llenarDatagrid()
    End Sub

    Private Sub btnpackinglist_Click(sender As Object, e As EventArgs) Handles btnpackinglist.Click
        Try
            Dim dt As New DataTable
            Using con As New SqlConnection(My.Settings.FLEECE)
                Dim sql As String = "SELECT * FROM AGREGARLOTES WHERE Num = @Num"
                Dim cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@Num", txtbuscador.Text)
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using

            If dt.Rows.Count > 0 Then
                Dim visor As New frmImpresion()
                visor.DatosLote = dt
                visor.ShowDialog()
            Else
                MessageBox.Show("Primero busca un lote válido para generar el Packing List.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAbrirAuditoria_Click(sender As Object, e As EventArgs) Handles btnAbrirAuditoria.Click
        If dgvReporteGeneral.SelectedRows.Count > 0 Then
            Dim frm As New Bitacora_Auditorias()

            frm.LoteRecibido = dgvReporteGeneral.CurrentRow.Cells("Lote").Value.ToString()
            frm.EstiloRecibido = dgvReporteGeneral.CurrentRow.Cells("Estilo").Value.ToString()
            frm.DocenasRecibidas = dgvReporteGeneral.CurrentRow.Cells("TotalDZRecibidas").Value.ToString()

            frm.ShowDialog()
            llenarDatagrid()
        Else
            MessageBox.Show("Por favor, seleccione un lote de la lista para auditar.")
        End If
    End Sub

    Private Sub DataReporte_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Hide()
        MENU_FLEECE.Show()
    End Sub

    Private Sub btnregresar_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Me.Hide()
        MENU_FLEECE.Show()
    End Sub
End Class