Imports System.Data.SqlClient

Public Class Bitacora_Auditorias
    Public LoteRecibido As String
    Public EstiloRecibido As String
    Public DocenasRecibidas As String

    Private Sub Bitacora_Auditorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' --- 1. ---
        txtnumerolote.Text = LoteRecibido
        txtestilo.Text = EstiloRecibido
        txtdocenas.Text = DocenasRecibidas

        ' --- 2. ---
        cmbStatus.Items.Clear()
        cmbStatus.Items.Add("Seleccione un resultado...")
        cmbStatus.Items.Add("Aprobado Elcatex")
        cmbStatus.Items.Add("Rechazado - Requiere Corrección")
        cmbStatus.Items.Add("Aprobado Sanmar")
        cmbStatus.Items.Add("Exportar")
        cmbStatus.SelectedIndex = 0

        ' --- 3. CARGAR HISTORIAL ---
        CargarHistorial(txtnumerolote.Text)
    End Sub

    Private Sub btnconfirmar_Click(sender As Object, e As EventArgs) Handles btnconfirmar.Click
        ' Validaciones
        If cmbStatus.SelectedIndex <= 0 Then
            MessageBox.Show("Por favor, seleccione un estatus válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtObservacion.Text) Then
            MessageBox.Show("Debe ingresar una observación.", "Evidencia Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- 4.  ---
        Dim nuevoEstatus As Integer
        Select Case cmbStatus.Text
            Case "Aprobado Elcatex" : nuevoEstatus = 1
            Case "Rechazado - Requiere Corrección" : nuevoEstatus = 2
            Case "Aprobado Sanmar" : nuevoEstatus = 3
            Case "Exportar" : nuevoEstatus = 4
        End Select

        Try

            Using conn As New SqlConnection(My.Settings.FLEECE)
                conn.Open()
                Dim trans As SqlTransaction = conn.BeginTransaction()

                Try
                    ' A. ACTUALIZAR TABLA PRINCIPAL
                    Dim sqlUpdate As String = "UPDATE AGREGARLOTES SET Estatus = @estatus WHERE Lote = @lote"
                    Dim cmdUpdate As New SqlCommand(sqlUpdate, conn, trans)
                    cmdUpdate.Parameters.AddWithValue("@estatus", nuevoEstatus)
                    cmdUpdate.Parameters.AddWithValue("@lote", txtnumerolote.Text)
                    cmdUpdate.ExecuteNonQuery()

                    ' B. INSERTAR EN BITÁCORA
                    Dim sqlInsert As String = "INSERT INTO BITACORA_AUDITORIA (NumLote, EstatusNuevo, Observaciones, Usuario) " &
                                            "VALUES (@lote, @estatus, @obs, @usuario)"
                    Dim cmdInsert As New SqlCommand(sqlInsert, conn, trans)
                    cmdInsert.Parameters.AddWithValue("@lote", txtnumerolote.Text)
                    cmdInsert.Parameters.AddWithValue("@estatus", nuevoEstatus)
                    cmdInsert.Parameters.AddWithValue("@obs", txtObservacion.Text)
                    cmdInsert.Parameters.AddWithValue("@usuario", Environment.UserName)
                    cmdInsert.ExecuteNonQuery()

                    trans.Commit()
                    MessageBox.Show("Auditoría registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()

                Catch ex As Exception
                    trans.Rollback()
                    MessageBox.Show("Error al procesar: " & ex.Message)
                End Try
            End Using
        Catch ex As Exception
            MessageBox.Show("Error de conexión: " & ex.Message)
        End Try
    End Sub

    Public Sub CargarHistorial(ByVal numLote As String)
        Try
            ' Consulta para obtener el historial de auditorías del lote
            Using conn As New SqlConnection(My.Settings.FLEECE)
                Dim sql As String = "SELECT FechaRevision AS [Fecha], " &
                                    "CASE EstatusNuevo " &
                                    " WHEN 1 THEN 'Aprobado Elcatex' " &
                                    " WHEN 3 THEN 'Aprobado Sanmar' " &
                                    " WHEN 4 THEN 'Exportación' " &
                                    " WHEN 2 THEN 'Rechazado' " &
                                    " ELSE 'Otro' END AS [Estatus], " &
                                    "Observaciones, Usuario " &
                                    "FROM BITACORA_AUDITORIA " &
                                    "WHERE NumLote = @lote " &
                                    "ORDER BY FechaRevision DESC"

                Dim da As New SqlDataAdapter(sql, conn)
                da.SelectCommand.Parameters.AddWithValue("@lote", numLote)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvHistorial.DataSource = dt
                dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End Using
        Catch ex As Exception
            ' 
        End Try
        dgvHistorial.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvHistorial.AutoResizeRows()
    End Sub
End Class
