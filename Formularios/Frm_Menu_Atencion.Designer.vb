<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Menu_Atencion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Menu_Atencion))
        Me.Tip_Menu_Arención = New System.Windows.Forms.ToolTip(Me.components)
        Me.Btn_Dueño = New System.Windows.Forms.Button()
        Me.btn_Paciente = New System.Windows.Forms.Button()
        Me.Btn_Citas = New System.Windows.Forms.Button()
        Me.Btn_Cerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Tip_Menu_Arención
        '
        Me.Tip_Menu_Arención.BackColor = System.Drawing.Color.White
        Me.Tip_Menu_Arención.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Tip_Menu_Arención.ToolTipTitle = "Informacion"
        '
        'Btn_Dueño
        '
        Me.Btn_Dueño.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Dueño.Location = New System.Drawing.Point(12, 12)
        Me.Btn_Dueño.Name = "Btn_Dueño"
        Me.Btn_Dueño.Size = New System.Drawing.Size(119, 85)
        Me.Btn_Dueño.TabIndex = 10
        Me.Btn_Dueño.Text = "Mantenimiento de Dueño"
        Me.Tip_Menu_Arención.SetToolTip(Me.Btn_Dueño, "Ingresa al formulario para administrar la tabla de Dueño del paciente")
        Me.Btn_Dueño.UseVisualStyleBackColor = True
        '
        'btn_Paciente
        '
        Me.btn_Paciente.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Paciente.Location = New System.Drawing.Point(137, 12)
        Me.btn_Paciente.Name = "btn_Paciente"
        Me.btn_Paciente.Size = New System.Drawing.Size(119, 85)
        Me.btn_Paciente.TabIndex = 11
        Me.btn_Paciente.Text = "Mantenimiento de Paciente"
        Me.Tip_Menu_Arención.SetToolTip(Me.btn_Paciente, "Ingresa al formulario para administrar la tabla de Dueño del paciente")
        Me.btn_Paciente.UseVisualStyleBackColor = True
        '
        'Btn_Citas
        '
        Me.Btn_Citas.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Citas.Location = New System.Drawing.Point(12, 103)
        Me.Btn_Citas.Name = "Btn_Citas"
        Me.Btn_Citas.Size = New System.Drawing.Size(119, 85)
        Me.Btn_Citas.TabIndex = 12
        Me.Btn_Citas.Text = "Mantenimiento de Cita"
        Me.Tip_Menu_Arención.SetToolTip(Me.Btn_Citas, "Ingresa al formulario de mantenimiento de citas")
        Me.Btn_Citas.UseVisualStyleBackColor = True
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Cerrar.Location = New System.Drawing.Point(154, 118)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(75, 55)
        Me.Btn_Cerrar.TabIndex = 13
        Me.Btn_Cerrar.Text = "Cerrar Sesión"
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Frm_Menu_Atencion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(273, 198)
        Me.Controls.Add(Me.Btn_Cerrar)
        Me.Controls.Add(Me.Btn_Citas)
        Me.Controls.Add(Me.btn_Paciente)
        Me.Controls.Add(Me.Btn_Dueño)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Menu_Atencion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu principal de atencion al cliente"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tip_Menu_Arención As ToolTip
    Friend WithEvents Btn_Dueño As Button
    Friend WithEvents btn_Paciente As Button
    Friend WithEvents Btn_Citas As Button
    Friend WithEvents Btn_Cerrar As Button
End Class
