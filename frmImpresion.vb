Imports Microsoft.Reporting.WebForms
Imports Microsoft.Reporting.WinForms
Public Class frmImpresion

    ' Esta variable recibirá los datos del lote
    Public Property DatosLote As DataTable

    Private Sub frmImpresion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' --- VALIDAR LOS DATOS ---
            ' Si DatosLote es nada, lanzamos un aviso y salimos para evitar el error de "Referencia a objeto"
            If DatosLote Is Nothing Then
                MessageBox.Show("No se recibieron datos para generar el reporte.", "Error de Datos")
                Me.Close()
                Return
            End If

            ' --- VINCULAR EL ARCHIVO .RDLC ---
            ' IMPORTANTE: "FLEECE" es tu proyecto. Asegúrate que "Informe1.rdlc" sea el nombre REAL de tu archivo.
            ' Si tu archivo se llama dsLotes.rdlc, cambia "Informe1.rdlc" por "dsLotes.rdlc"
            Me.ReporteImpresion.LocalReport.ReportEmbeddedResource = "FLEECE.PackingList.rdlc"

            ' --- LIMPIAR Y CARGAR ---
            Me.ReporteImpresion.LocalReport.DataSources.Clear()

            ' El nombre "dsLotes" (Dataset)
            Dim rds As New Microsoft.Reporting.WinForms.ReportDataSource("dsLotes", DatosLote)
            Me.ReporteImpresion.LocalReport.DataSources.Add(rds)

            ' --- REFRESCAR ---
            Me.ReporteImpresion.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.ReporteImpresion.RefreshReport()

        Catch ex As Exception
            MessageBox.Show("Error crítico: " & ex.Message)
        End Try

    End Sub

    Private Sub ReporteImpresion_Load(sender As Object, e As EventArgs) Handles ReporteImpresion.Load

    End Sub
End Class

