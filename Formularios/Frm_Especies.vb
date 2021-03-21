Public Class Frm_Especies
    Public bandera As New Boolean
    Private Sub Frm_Especies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Databases.ESPECIES' Puede moverla o quitarla según sea necesario.
        Me.ESPECIESTableAdapter.Fill(Me.Databases.ESPECIES)
        If (bandera = True) Then
            Btn_Nuevo.Visible = False
            BtnEliminar.Visible = False
            Regresar.Text = "Cargar"
        End If
    End Sub

    Private Sub Limpiar()
        Dim Formulario As New Frm_Especies
        Formulario.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Nuevo_Click(sender As Object, e As EventArgs) Handles Btn_Nuevo.Click
        Btn_Guardar.Visible = True
        Btn_Nuevo.Visible = False
        BtnEliminar.Visible = False
        Habilitar()
    End Sub

    Private Sub Habilitar()
        If (bandera = True) Then
            Btn_Cancelar.Visible = False
        Else
            Btn_Cancelar.Visible = True
        End If
        gbPersonal.Visible = True
        Me.Width = 652
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) \ 2
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        If (Txt_Especie.Text <> "" And Combo_Familia.Text <> "") Then
            Me.ESPECIESTableAdapter.Insertar_Especie(Txt_Especie.Text, Combo_Familia.Text)
            MsgBox("Se realizo el proceso exitosamente", MsgBoxStyle.Information, "Proceso realizado")
            Limpiar()
        Else
            MessageBox.Show("Falta informacion para almacenar en la BD", "Guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Btn_Actualizar_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click
        If (Txt_Especie.Text <> "" And Combo_Familia.Text <> "") Then
            Me.ESPECIESTableAdapter.Actualizar_ESPECIE(Txt_Codigo.Text, Txt_Especie.Text, Combo_Familia.Text)
            MsgBox("Se realizo el proceso exitosamente", MsgBoxStyle.Information, "Proceso realizado")
            Limpiar()
        Else
            MessageBox.Show("Falta informacion para almacenar en la BD", "Actualizar registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub DataListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datalistado.CellClick
        TrasladoInformacion()
        If bandera = True Then
            gbPersonal.Enabled = False
            Btn_Actualizar.Visible = False
        Else
            Btn_Actualizar.Visible = True
            Btn_Nuevo.Visible = False
            Btn_Guardar.Visible = False
        End If
        Habilitar()
    End Sub

    Private Sub TrasladoInformacion()
        Txt_Codigo.Text = Datalistado.SelectedCells.Item(1).Value
        Txt_Especie.Text = Datalistado.SelectedCells.Item(2).Value
        Combo_Familia.Text = Datalistado.SelectedCells.Item(3).Value
    End Sub

    Private Sub DataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datalistado.CellContentClick
        If (e.ColumnIndex = Me.Datalistado.Columns.Item("Eliminar").Index) Then
            Dim checkcell As DataGridViewCheckBoxCell = Me.Datalistado.Rows(e.RowIndex).Cells("Eliminar")
            checkcell.Value = Not checkcell.Value
        End If
        Btn_Nuevo.Visible = False
        Btn_Guardar.Visible = False
        If (bandera = True) Then
            Btn_Actualizar.Visible = False
        Else
            Btn_Actualizar.Visible = True
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        For Each row As DataGridViewRow In Datalistado.Rows
            Dim marcada As Boolean = Convert.ToBoolean(row.Cells(0).Value)
            If (marcada) Then
                Dim llavePrimaria As String = row.Cells(1).Value
                Me.ESPECIESTableAdapter.Eliminar_ESPECIE(llavePrimaria)
            End If
        Next
        Limpiar()
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Limpiar()
    End Sub

    Private Sub BtnCerrarSecion_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        If bandera = True Then
            Me.Close()
        Else
            Dim Formulario As New Frm_Menu_Administrador
            Formulario.Show()
            Me.Close()
        End If
    End Sub
End Class