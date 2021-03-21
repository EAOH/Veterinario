Public Class Frm_Usuario

    Private Sub Frm_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Databases1.USUARIOS' Puede moverla o quitarla según sea necesario.
        Me.USUARIOSTableAdapter.Fill(Me.Databases1.USUARIOS)

    End Sub

    Private Sub Limpiar()
        Dim Formulario As New Frm_Usuario
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
        Btn_Cancelar.Visible = True
        gbPersonal.Visible = True
        Me.Width = 851
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) \ 2
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        If (Txt_Usuario.Text <> "" And Txt_Contraseña.Text <> "" And Txt_Tel.Text <> "" And Txt_Nombre1.Text <> "" And Txt_Nombre2.Text <> "" And txt_Apellido1.Text <> "" And Txt_Apellido2.Text <> "" And Combo_Usuario.Text <> "") Then
            Me.USUARIOSTableAdapter.Insertar_Usuario(Txt_Usuario.Text, Txt_Nombre1.Text, Txt_Nombre2.Text, txt_Apellido1.Text, Txt_Apellido2.Text, Txt_Tel.Text, Txt_Direccion.Text, Txt_Contraseña.Text, Combo_Usuario.Text)
            MsgBox("Se realizo el proceso exitosamente", MsgBoxStyle.Information, "Proceso realizado")
            Limpiar()
        Else
            MessageBox.Show("Falta informacion para almacenar en la BD", "Guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Btn_Actualizar_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click
        If (Txt_Usuario.Text <> "" And Txt_Contraseña.Text <> "" And Txt_Tel.Text <> "" And Txt_Nombre1.Text <> "" And Txt_Nombre2.Text <> "" And txt_Apellido1.Text <> "" And Txt_Apellido2.Text <> "" And Combo_Usuario.Text <> "") Then
            Me.USUARIOSTableAdapter.Actualizar_Usuario(Txt_Usuario.Text, Txt_Nombre1.Text, Txt_Nombre2.Text, txt_Apellido1.Text, Txt_Apellido2.Text, Txt_Tel.Text, Txt_Direccion.Text, Txt_Contraseña.Text, Combo_Usuario.Text)
            MsgBox("Se realizo el proceso exitosamente", MsgBoxStyle.Information, "Proceso realizado")
            Limpiar()
        Else
            MessageBox.Show("Falta informacion para almacenar en la BD", "Actualizar registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub DataListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datalistado.CellClick
        Txt_Usuario.Enabled = False
        TrasladoInformacion()
        Btn_Actualizar.Visible = True
            Btn_Nuevo.Visible = False
        Btn_Guardar.Visible = False
        Habilitar()
    End Sub

    Private Sub TrasladoInformacion()
        Txt_Usuario.Text = Datalistado.SelectedCells.Item(1).Value
        Txt_Nombre1.Text = Datalistado.SelectedCells.Item(2).Value
        Txt_Nombre2.Text = Datalistado.SelectedCells.Item(3).Value
        txt_Apellido1.Text = Datalistado.SelectedCells.Item(4).Value
        Txt_Apellido2.Text = Datalistado.SelectedCells.Item(5).Value
        Txt_Tel.Text = Datalistado.SelectedCells.Item(6).Value
        Txt_Direccion.Text = Datalistado.SelectedCells.Item(7).Value
        Txt_Contraseña.Text = Datalistado.SelectedCells.Item(8).Value
        Combo_Usuario.Text = Datalistado.SelectedCells.Item(9).Value
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
                Me.USUARIOSTableAdapter.Eliminar_Usuario(llavePrimaria)
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

    Private Sub Txt_Tel_KeyPress(sender As Object, Caracter As KeyPressEventArgs) Handles Txt_Tel.KeyPress
        Caracter.Handled = M_Procesos.ValidarInteger(Caracter.KeyChar)
    End Sub
End Class