Imports System.IO
Public Class MENU_FLEECE
    Private Sub AgregarLoteToolStripMenuItem_Click(sender As Object, e As EventArgs)

        AgregarLote.ShowDialog()
    End Sub

    Private Sub btnAgregarLote_Click(sender As Object, e As EventArgs) Handles btnAgregarLote.Click
        Me.Hide()
        AgregarLote.ShowDialog()
    End Sub

    Private Sub btnCuadrarLote_Click(sender As Object, e As EventArgs) Handles btnCuadrarLote.Click
        Me.Hide()
        CuadrarLote.ShowDialog()
    End Sub

    Private Sub btnReporteGeneral_Click(sender As Object, e As EventArgs) Handles btnReporteGeneral.Click
        Me.Hide()
        DataReporte.ShowDialog()
    End Sub

    Private Sub MENU_FLEECE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MENU_FLEECE_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim respuesta As DialogResult

        respuesta = MessageBox.Show("¿Desea salir del Programa?", "Salir",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)


        If respuesta = DialogResult.No Then
            e.Cancel = True ' Cancela el evento de cierre

        End If
    End Sub

    Private Sub btnsettings_Click(sender As Object, e As EventArgs) Handles btnsettings.Click
        ' 1. Obtener la ruta de la carpeta donde se está ejecutando el programa
        Dim rutaEjecutable As String = AppDomain.CurrentDomain.BaseDirectory

        ' 2. Combinar la ruta con la ubicación de tu archivo PDF
        Dim rutaPDF As String = Path.Combine(rutaEjecutable, "Manual", "Manual_Usuario_Fleece.pdf")

        Try
            ' 3. Verificar si el archivo realmente existe antes de abrirlo
            If File.Exists(rutaPDF) Then
                ' Abre el PDF con el programa predeterminado de la computadora
                Process.Start(New ProcessStartInfo(rutaPDF) With {.UseShellExecute = True})
            Else
                MessageBox.Show("El archivo del manual no se encuentra en la ruta: " & rutaPDF,
                                "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo abrir el manual: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class