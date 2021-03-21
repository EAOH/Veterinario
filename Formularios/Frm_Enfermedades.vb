Public Class Frm_Enfermedades
    Public bandera As New Boolean
    Private Sub Frm_Enfermedades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Databases.ENFERMEDADXRAZA' Puede moverla o quitarla según sea necesario.
        Me.ENFERMEDADXRAZATableAdapter.Fill(Me.Databases.ENFERMEDADXRAZA)
        'TODO: esta línea de código carga datos en la tabla 'Databases.ENFERMEDADXRAZA' Puede moverla o quitarla según sea necesario.
        Me.ENFERMEDADXRAZATableAdapter.Fill(Me.Databases.ENFERMEDADXRAZA)
        'TODO: esta línea de código carga datos en la tabla 'Databases.ENFERMEDADES' Puede moverla o quitarla según sea necesario.
        Me.ENFERMEDADESTableAdapter.Fill(Me.Databases.ENFERMEDADES)
        If (bandera = True) Then
            Btn_Nuevo.Visible = False
            BtnEliminar.Visible = False
            Regresar.Text = "Cargar"
            Tab2.Visible = False
        End If
    End Sub
    Private Sub Limpiar()
        Dim Formulario As New Frm_Enfermedades
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
        If (bandera = True) Then
            Btn_Cancelar.Visible = False
        Else
            Btn_Cancelar.Visible = True
        End If
        gbPersonal.Visible = True
        Me.Width = 674
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) \ 2
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        If (Txt_Enfermedad.Text <> "") Then
            Me.ENFERMEDADESTableAdapter.Insertar_ENFERMEDAD(Txt_Enfermedad.Text)
            MsgBox("Se realizo el proceso exitosamente", MsgBoxStyle.Information, "Proceso realizado")
            Limpiar()
        Else
            MessageBox.Show("Falta informacion para almacenar en la BD", "Guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Btn_Actualizar_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click
        If (Txt_Enfermedad.Text <> "") Then
            Me.ENFERMEDADESTableAdapter.Actualizar_ENFERMEDAD(Txt_Codigo.Text, Txt_Enfermedad.Text)
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
        txt_CodigoE.Text = Datalistado.SelectedCells.Item(1).Value
        Txt_Enfermedad.Text = Datalistado.SelectedCells.Item(2).Value
        Txt_E.Text = Datalistado.SelectedCells.Item(2).Value
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
                Me.ENFERMEDADESTableAdapter.Eliminar_ENFERMEDAD(llavePrimaria)
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

    Private Sub Btn_Raza_Click(sender As Object, e As EventArgs) Handles Btn_Generar.Click
        Dim Formulario As New Frm_Razas
        Formulario.bandera = True
        Formulario.ShowDialog()
        Txt_CodigoR.Text = Formulario.Txt_Codigo.Text
        txt_R.Text = Formulario.Txt_Raza.Text
    End Sub

    Private Sub Btn_Finalizar_Click(sender As Object, e As EventArgs) Handles Btn_Finalizar.Click
        Limpiar()
    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        If (txt_CodigoE.Text <> "" And Txt_CodigoR.Text <> "") Then
            Me.ENFERMEDADXRAZATableAdapter.Insertar_ENFERMEDADXRAZA(txt_CodigoE.Text, Txt_CodigoR.Text)
            MsgBox("Se realizo el proceso exitosamente", MsgBoxStyle.Information, "Proceso realizado")
            Me.ENFERMEDADXRAZATableAdapter.Fill(Me.Databases.ENFERMEDADXRAZA)
            Txt_CodigoR.Text = ""
            txt_R.Text = ""
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
                Me.ENFERMEDADXRAZATableAdapter.Eliminar_ENFERMEDADXRAZA(Val(llavePrimaria1), Val(llavePrimaria2))
            End If
        Next
        Me.ENFERMEDADXRAZATableAdapter.Fill(Me.Databases.ENFERMEDADXRAZA)
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
        txt_CodigoE.Text = Data_Intermedia.SelectedCells.Item(1).Value
        Txt_Enfermedad.Text = Data_Intermedia.SelectedCells.Item(3).Value
        Txt_E.Text = Data_Intermedia.SelectedCells.Item(3).Value
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