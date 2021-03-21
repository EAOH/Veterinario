Public Class Frm_Login
    Private Sub USUARIOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.USUARIOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Databases)

    End Sub

    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Databases.USUARIOS' Puede moverla o quitarla según sea necesario.
        Me.USUARIOSTableAdapter.Fill(Me.Databases.USUARIOS)
    End Sub

    Private Sub Btn_Ingresar_Click(sender As Object, e As EventArgs) Handles Btn_Ingresar.Click
        Dim C As Integer = 0
        If (Txt_Usuario.Text <> "" And Txt_Contraseña.Text <> "") Then
            For index = 0 To USUARIOSBindingSource.Count - 1
                If (Txt_Usuario.Text = USU_USUARIOLabel1.Text And Txt_Contraseña.Text = USU_CONTRASEÑALabel1.Text) Then
                    index = USUARIOSBindingSource.Count
                ElseIf ((Txt_Usuario.Text <> USU_USUARIOLabel1.Text Or Txt_Contraseña.Text <> USU_CONTRASEÑALabel1.Text) And index = USUARIOSBindingSource.Count - 1) Then
                    USU_TIPOLabel1.Text = ""
                Else
                    USUARIOSBindingSource.MoveNext()
                    C = C + 1
                End If
            Next
            Select Case USU_TIPOLabel1.Text
                Case ""
                    MsgBox("Usuario o Contraseña Invalido.", MsgBoxStyle.Exclamation, "No encontrado")
                Case "Atencion al cliente"
                    Me.Hide()
                    Dim Formulario As New Frm_Menu_Atencion
                    Formulario.Show()
                Case "Administrador"
                    Me.Hide()
                    Dim Formulario As New Frm_Menu_Administrador
                    Formulario.Show()
            End Select
        End If
        Txt_Contraseña.Text = ""
        Txt_Usuario.Text = ""
        Txt_Usuario.Select()
        For index = 0 To C
            USUARIOSBindingSource.MovePrevious()
        Next
    End Sub
End Class
