Public Class Frm_Medicina
    Private Sub Frm_Medicina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Databases.MEDICINAXENFERMEDAD' Puede moverla o quitarla según sea necesario.
        Me.MEDICINAXENFERMEDADTableAdapter.Fill(Me.Databases.MEDICINAXENFERMEDAD)
        'TODO: esta línea de código carga datos en la tabla 'Databases.MEDICINAS' Puede moverla o quitarla según sea necesario.
        Me.MEDICINASTableAdapter.Fill(Me.Databases.MEDICINAS)

    End Sub
    Private Sub Limpiar()
        Dim Formulario As New Frm_Medicina
        Formulario.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Nuevo_Click(sender As Object, e As EventArgs) Handles Btn_Nuevo.Click
        Btn_Guardar.Visible = True
        Btn_Nuevo.Visible = False
        BtnEliminar.Visible = False
        Tab2.Enabled = False
        Habilitar()
    End Sub

    Private Sub Habilitar()
        Btn_Cancelar.Visible = True
        gbPersonal.Visible = True
        Me.Width = 669
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) \ 2
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        If (Txt_Nombre.Text <> "" And Txt_Dosis.Text <> "" And Txt_Intervalo.Text <> "") Then
            Me.MEDICINASTableAdapter.Insertar_MEDICINA(Txt_Nombre.Text, Txt_Dosis.Text, Txt_Intervalo.Text)
            MsgBox("Se realizo el proceso exitosamente", MsgBoxStyle.Information, "Proceso realizado")
            Limpiar()
        Else
            MessageBox.Show("Falta informacion para almacenar en la BD", "Guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Btn_Actualizar_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click
        If (Txt_Nombre.Text <> "" And Txt_Dosis.Text <> "" And Txt_Intervalo.Text <> "") Then
            Me.MEDICINASTableAdapter.Actualizar_MEDICINA(Txt_Codigo.Text, Txt_Nombre.Text, Txt_Dosis.Text, Txt_Intervalo.Text)
            MsgBox("Se realizo el proceso exitosamente", MsgBoxStyle.Information, "Proceso realizado")
            Limpiar()
        Else
            MessageBox.Show("Falta informacion para almacenar en la BD", "Actualizar registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub DataListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datalistado.CellClick
        TrasladoInformacion()
        Btn_Actualizar.Visible = True
        Btn_Nuevo.Visible = False
        Btn_Guardar.Visible = False
        Habilitar()
    End Sub

    Private Sub TrasladoInformacion()
        Txt_Codigo.Text = Datalistado.SelectedCells.Item(1).Value
        txt_CM.Text = Datalistado.SelectedCells.Item(1).Value
        Txt_Nombre.Text = Datalistado.SelectedCells.Item(2).Value
        Txt_NM.Text = Datalistado.SelectedCells.Item(2).Value
        Txt_Dosis.Text = Datalistado.SelectedCells.Item(3).Value
        Txt_DM.Text = Datalistado.SelectedCells.Item(3).Value
        Txt_Intervalo.Text = Datalistado.SelectedCells.Item(4).Value
        Txt_IM.Text = Datalistado.SelectedCells.Item(4).Value

    End Sub

    Private Sub DataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datalistado.CellContentClick
        If (e.ColumnIndex = Me.Datalistado.Columns.Item("Eliminar").Index) Then
            Dim checkcell As DataGridViewCheckBoxCell = Me.Datalistado.Rows(e.RowIndex).Cells("Eliminar")
            checkcell.Value = Not checkcell.Value
        End If
        Btn_Nuevo.Visible = False
        Btn_Guardar.Visible = False
        Btn_Actualizar.Visible = True
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        For Each row As DataGridViewRow In Datalistado.Rows
            Dim marcada As Boolean = Convert.ToBoolean(row.Cells(0).Value)
            If (marcada) Then
                Dim llavePrimaria As String = row.Cells(1).Value
                Me.MEDICINASTableAdapter.Eliminar_MEDICINA(llavePrimaria)
            End If
        Next
        Limpiar()
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Limpiar()
    End Sub

    Private Sub BtnCerrarSecion_Click(sender As Object, e As EventArgs) Handles Regresar.Click

        Dim Formulario As New Frm_Menu_Administrador
        Formulario.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Enfermedad_Click(sender As Object, e As EventArgs) Handles Btn_Generar.Click
        Dim Formulario As New Frm_Enfermedades
        Formulario.bandera = True
        Formulario.ShowDialog()
        txt_CodigoE.Text = Formulario.Txt_Codigo.Text
        Txt_E.Text = Formulario.Txt_Enfermedad.Text
    End Sub

    Private Sub Btn_Finalizar_Click(sender As Object, e As EventArgs) Handles Btn_Finalizar.Click
        Limpiar()
    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        If (txt_CM.Text <> "" And txt_CodigoE.Text <> "") Then
            Me.MEDICINAXENFERMEDADTableAdapter.Insertar_MEDICINAXENFERMEDAD(txt_CM.Text, txt_CodigoE.Text)
            MsgBox("Se realizo el proceso exitosamente", MsgBoxStyle.Information, "Proceso realizado")
            Me.MEDICINAXENFERMEDADTableAdapter.Fill(Me.Databases.MEDICINAXENFERMEDAD)
            txt_CodigoE.Text = ""
            Txt_E.Text = ""
        Else
            MessageBox.Show("Falta informacion para almacenar en la BD Procure seleccionar antes una enfermedad de la pestaña anterior", "Guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Btn_Quitar_Click(sender As Object, e As EventArgs) Handles Btn_Quitar.Click
        For Each row As DataGridViewRow In Data_Intermedia.Rows
            Dim marcada As Boolean = Convert.ToBoolean(row.Cells(0).Value)
            If (marcada) Then
                Dim llavePrimaria1 As String = row.Cells(1).Value
                Dim llavePrimaria2 As String = row.Cells(2).Value
                Me.MEDICINAXENFERMEDADTableAdapter.Eliminar_MEDICINAXENFERMEDAD(Val(llavePrimaria1), Val(llavePrimaria2))
            End If
        Next
        Me.MEDICINAXENFERMEDADTableAdapter.Fill(Me.Databases.MEDICINAXENFERMEDAD)
    End Sub

    Private Sub Data_Intermedia_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Data_Intermedia.CellClick
        TrasladoInformacion2()
        Btn_Actualizar.Visible = True
        Btn_Nuevo.Visible = False
        Btn_Guardar.Visible = False
        Habilitar()
    End Sub
    Private Sub TrasladoInformacion2()
        Txt_Codigo.Text = Data_Intermedia.SelectedCells.Item(1).Value
        txt_CM.Text = Data_Intermedia.SelectedCells.Item(1).Value
        Txt_Nombre.Text = Data_Intermedia.SelectedCells.Item(3).Value
        Txt_NM.Text = Data_Intermedia.SelectedCells.Item(3).Value
        Txt_Dosis.Text = Data_Intermedia.SelectedCells.Item(4).Value
        Txt_DM.Text = Data_Intermedia.SelectedCells.Item(4).Value
        Txt_Intervalo.Text = Data_Intermedia.SelectedCells.Item(5).Value
        Txt_IM.Text = Data_Intermedia.SelectedCells.Item(5).Value
    End Sub
    Private Sub Data_Intermedia_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Data_Intermedia.CellContentClick
        If (e.ColumnIndex = Me.Data_Intermedia.Columns.Item(0).Index) Then
            Dim checkcell As DataGridViewCheckBoxCell = Me.Data_Intermedia.Rows(e.RowIndex).Cells(0)
            checkcell.Value = Not checkcell.Value
        End If
        Btn_Nuevo.Visible = False
        Btn_Guardar.Visible = False
        Btn_Actualizar.Visible = True
    End Sub
End Class