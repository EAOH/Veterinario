Public Class Frm_Reporte
    Private Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        Dim Formulario As New Frm_Menu_Administrador
        Formulario.Show()
        Me.Close()
    End Sub

    Private Sub Frm_Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Databases.S_REPORTE' Puede moverla o quitarla según sea necesario.
        Me.S_REPORTETableAdapter.Fill(Me.Databases.S_REPORTE)
    End Sub
End Class