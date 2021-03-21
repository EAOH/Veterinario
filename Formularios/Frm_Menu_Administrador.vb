Public Class Frm_Menu_Administrador
    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        Frm_Login.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Usuario_Click(sender As Object, e As EventArgs) Handles Btn_Usuario.Click
        Me.Close()
        Dim Formulario As New Frm_Usuario
        Formulario.Show()
    End Sub

    Private Sub Btn_Auditoria_Click(sender As Object, e As EventArgs) Handles Btn_Auditoria.Click
        Me.Close()
        Dim Formulario As New Frm_Auditorias
        Formulario.Show()
    End Sub

    Private Sub Btn_Especies_Click(sender As Object, e As EventArgs) Handles Btn_Especies.Click
        Me.Close()
        Dim Formulario As New Frm_Especies
        Formulario.Show()
    End Sub

    Private Sub Btn_Razas_Click(sender As Object, e As EventArgs) Handles Btn_Razas.Click
        Me.Close()
        Dim Formulario As New Frm_Razas
        Formulario.Show()
    End Sub

    Private Sub Btn_Enfermedades_Click(sender As Object, e As EventArgs) Handles Btn_Enfermedades.Click
        Me.Close()
        Dim Formulario As New Frm_Enfermedades
        Formulario.Show()
    End Sub

    Private Sub Btn_Medicinas_Click(sender As Object, e As EventArgs) Handles Btn_Medicinas.Click
        Me.Close()
        Dim Formulario As New Frm_Medicina
        Formulario.Show()
    End Sub

    Private Sub Btn_Reportes_Click(sender As Object, e As EventArgs) Handles btn_Reportes.Click
        Me.Close()
        Dim Formulario As New Frm_Reporte
        Formulario.Show()
    End Sub

    Private Sub Btn_Medicos_Click(sender As Object, e As EventArgs) Handles Btn_Medicos.Click
        Me.Close()
        Dim Formulario As New Frm_Medico
        Formulario.Show()
    End Sub

    Private Sub Frm_Menu_Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class