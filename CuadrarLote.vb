Imports System.Data.SqlClient

Public Class CuadrarLote
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub CuadrarLote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarcombonivel()
    End Sub

    Sub llenarcombonivel()
        Try
            Dim con As New SqlConnection(My.Settings.FLEECE)
            con.Open()

            ' Creamos el comando apuntando al Stored Procedure
            Dim cmd As New SqlCommand("sp_ConsultarEstatus", con)
            cmd.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            ' Configuramos el ComboBox
            cmbstatus.DataSource = dt
            cmbstatus.DisplayMember = "NombreEstatus"
            cmbstatus.ValueMember = "Codigo"

            ' El toque final: que inicie vacío
            cmbstatus.SelectedIndex = -1

            con.Close()
        Catch ex As Exception
            MsgBox("Error al llenar el combo: " & ex.Message)
        End Try
    End Sub


    Private Sub txtlote_Leave(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        ' Validamos que el total sea igual al recibido
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
                cmd.Parameters.AddWithValue("@Estatus", 0)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Cuadraje guardado y estatus actualizado correctamente.")
                LimpiarTextos()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub



    Sub calcularTotal()
        Try
            ' Usamos Decimal para permitir números con punto/coma
            Dim p As Decimal = 0, par As Decimal = 0, s As Decimal = 0, t As Decimal = 0, sc As Decimal = 0
            Dim totalRecibido As Decimal = 0

            ' Intentamos obtener los valores de los textos, si están vacíos valen 0
            Decimal.TryParse(txtprimeras.Text, p)
            Decimal.TryParse(txtparciales.Text, par)
            Decimal.TryParse(txtsegundas.Text, s)
            Decimal.TryParse(txtterceras.Text, t)
            Decimal.TryParse(txtscrapt.Text, sc)
            Decimal.TryParse(txttotaldzrecibidas.Text, totalRecibido)

            ' Calculamos la suma
            Dim sumaTotal As Decimal = p + par + s + t + sc

            ' Mostramos el resultado (con 2 decimales si lo deseas, o redondeado)
            ' .ToString("N2") muestra 2 decimales. Si quieres enteros usa .ToString("N0")
            txttotalcuadraje.Text = sumaTotal.ToString()

            ' Comparación para el color
            ' Usamos Math.Round para asegurar que la comparación ignore diferencias mínimas de decimales
            If Math.Round(sumaTotal, 2) = Math.Round(totalRecibido, 2) Then
                txttotalcuadraje.BackColor = Color.LightGreen
                txttotalcuadraje.ForeColor = Color.Black
            Else
                txttotalcuadraje.BackColor = Color.Salmon ' Cambié a salmón porque azul suele ocultar el texto negro
                txttotalcuadraje.ForeColor = Color.White
            End If

        Catch ex As Exception
            ' Es mejor saber qué pasa si algo falla
            Console.WriteLine("Error en cálculo: " & ex.Message)
        End Try
    End Sub


    Private Sub txttotalcuadraje_TextChanged(sender As Object, e As EventArgs) Handles txttotalcuadraje.TextChanged
        calcularTotal()
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
                        ' Llenamos los campos con la info de la base de datos
                        txtnum.Text = dr("Num").ToString()
                        txttotaldzrecibidas.Text = dr("TotalDZRecibidas").ToString()

                        ' INHABILITAMOS los campos para que no se modifiquen
                        txtnum.ReadOnly = True
                        txttotaldzrecibidas.ReadOnly = True

                        ' Ponemos el foco en el primer campo de cuadraje
                        txtprimeras.Focus()
                    Else
                        MessageBox.Show("El lote no existe en el sistema.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtnum.Clear()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al buscar: " & ex.Message)
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
        cmbstatus.SelectedText = ""
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
        MENU_FLEECE.Show()
    End Sub
End Class