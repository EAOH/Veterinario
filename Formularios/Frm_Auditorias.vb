Public Class Frm_Auditorias
    Private Sub Frm_Auditorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Databases.AUDITORIAS' Puede moverla o quitarla según sea necesario.
        Me.AUDITORIASTableAdapter.Fill(Me.Databases.AUDITORIAS)

    End Sub

    Private Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        Dim Formulario As New Frm_Menu_Administrador
        Formulario.Show()
        Me.Close()
    End Sub
End Class