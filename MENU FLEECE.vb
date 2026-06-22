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

    End Sub
End Class