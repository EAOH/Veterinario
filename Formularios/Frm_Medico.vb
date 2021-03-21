Public Class Frm_Medico
    Public bandera As New Boolean
    Public Viejo1, Viejo2 As String
    Private Sub Frm_Medico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Date_Ingreso.CustomFormat = "dd/mm/yy"
        'TODO: esta línea de código carga datos en la tabla 'Databases.S_MÉDICO' Puede moverla o quitarla según sea necesario.
        Me.S_MÉDICOTableAdapter.Fill(Me.Databases.S_MÉDICO)

        If (bandera = True) Then
            Btn_Nuevo.Visible = False
            BtnEliminar.Visible = False
            Regresar.Text = "Cargar"
        End If
    End Sub

    Private Sub Limpiar()
        Dim Formulario As New Frm_Medico
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
        Me.Width = 856
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) \ 2
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        If ((Txt_Tel1.Text <> "" Or Txt_Tel2.Text <> "") And Txt_Nombre1.Text <> "" And Txt_Nombre2.Text <> "" And txt_Apellido1.Text <> "" And Txt_Apellido2.Text <> "" And Txt_Direccion.Text <> "" And Combo_Emergencia.Text <> "") Then
            Me.S_MÉDICOTableAdapter.Insertar_MÉDICO(Txt_Nombre1.Text, Txt_Nombre2.Text, txt_Apellido1.Text, Txt_Apellido2.Text, Txt_Direccion.Text, Combo_Emergencia.Text, Date_Ingreso.Value)
            If (Txt_Tel1.Text <> "") Then
                S_MÉDICOTableAdapter.Insertar_TEL_MÉDICO(Txt_Tel1.Text)
            End If
            If (Txt_Tel2.Text <> "") Then
                S_MÉDICOTableAdapter.Insertar_TEL_MÉDICO(Txt_Tel2.Text)
            End If
            MsgBox("Se realizo el proceso exitosamente", MsgBoxStyle.Information, "Proceso realizado")
                Limpiar()
            Else
                MessageBox.Show("Falta informacion para almacenar en la BD", "Guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Btn_Actualizar_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click
        If ((Txt_Tel1.Text <> "" Or Txt_Tel2.Text <> "") And Txt_Nombre1.Text <> "" And Txt_Nombre2.Text <> "" And txt_Apellido1.Text <> "" And Txt_Apellido2.Text <> "" And Txt_Direccion.Text <> "" And Combo_Emergencia.Text <> "") Then
            Me.S_MÉDICOTableAdapter.Actualizar_MÉDICO(Txt_Codigo.Text, Txt_Nombre1.Text, Txt_Nombre2.Text, txt_Apellido1.Text, Txt_Apellido2.Text, Txt_Direccion.Text, Combo_Emergencia.Text, Date_Ingreso.Value)
            If (Txt_Tel1.Text <> "") Then
                S_MÉDICOTableAdapter.Actualizar_TEL_MÉDICO(Txt_Codigo.Text, Viejo1, Txt_Tel1.Text)
            End If
            If (Txt_Tel2.Text <> "") Then
                S_MÉDICOTableAdapter.Actualizar_TEL_MÉDICO(Txt_Codigo.Text, Viejo2, Txt_Tel2.Text)
            End If
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
        Txt_Nombre1.Text = Datalistado.SelectedCells.Item(2).Value
        Txt_Nombre1.Text = Datalistado.SelectedCells.Item(3).Value
        txt_Apellido1.Text = Datalistado.SelectedCells.Item(4).Value
        Txt_Apellido2.Text = Datalistado.SelectedCells.Item(5).Value
        Txt_Direccion.Text = Datalistado.SelectedCells.Item(6).Value
        Combo_Emergencia.Text = Datalistado.SelectedCells.Item(7).Value
        Date_Ingreso.Value = Datalistado.SelectedCells.Item(8).Value
        Txt_Tel1.Text = Datalistado.SelectedCells.Item(9).Value
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
                Me.S_MÉDICOTableAdapter.Eliminar_MÉDICO(llavePrimaria)
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

    Private Sub Txt_Tel1_KeyPress(sender As Object, Caracter As KeyPressEventArgs) Handles Txt_Tel1.KeyPress
        Caracter.Handled = M_Procesos.ValidarInteger(Caracter.KeyChar)
    End Sub

    Private Sub Txt_Tel2_KeyPress(sender As Object, Caracter As KeyPressEventArgs) Handles Txt_Tel2.KeyPress
        Caracter.Handled = M_Procesos.ValidarInteger(Caracter.KeyChar)
    End Sub
End Class