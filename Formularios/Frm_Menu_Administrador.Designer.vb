<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Menu_Administrador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Menu_Administrador))
        Me.Tip_Menu_Administrador = New System.Windows.Forms.ToolTip(Me.components)
        Me.Btn_Cerrar = New System.Windows.Forms.Button()
        Me.Btn_Auditoria = New System.Windows.Forms.Button()
        Me.btn_Reportes = New System.Windows.Forms.Button()
        Me.Btn_Cirugia = New System.Windows.Forms.Button()
        Me.Btn_Medicos = New System.Windows.Forms.Button()
        Me.Btn_Turnos = New System.Windows.Forms.Button()
        Me.Btn_Medicinas = New System.Windows.Forms.Button()
        Me.Btn_Enfermedades = New System.Windows.Forms.Button()
        Me.Btn_Razas = New System.Windows.Forms.Button()
        Me.Btn_Especies = New System.Windows.Forms.Button()
        Me.Btn_Usuario = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tip_Menu_Administrador
        '
        Me.Tip_Menu_Administrador.BackColor = System.Drawing.Color.White
        Me.Tip_Menu_Administrador.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Tip_Menu_Administrador.ToolTipTitle = "Informacion"
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Cerrar.Location = New System.Drawing.Point(437, 232)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(75, 55)
        Me.Btn_Cerrar.TabIndex = 9
        Me.Btn_Cerrar.Text = "Cerrar Sesión"
        Me.Tip_Menu_Administrador.SetToolTip(Me.Btn_Cerrar, "Finaliza la sesión y retorna al login")
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Btn_Auditoria
        '
        Me.Btn_Auditoria.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Auditoria.Location = New System.Drawing.Point(33, 25)
        Me.Btn_Auditoria.Name = "Btn_Auditoria"
        Me.Btn_Auditoria.Size = New System.Drawing.Size(110, 81)
        Me.Btn_Auditoria.TabIndex = 2
        Me.Btn_Auditoria.Text = "Mostrar tabla auditoria"
        Me.Tip_Menu_Administrador.SetToolTip(Me.Btn_Auditoria, "Muestra la tabla de auditorias")
        Me.Btn_Auditoria.UseVisualStyleBackColor = True
        '
        'btn_Reportes
        '
        Me.btn_Reportes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Reportes.Location = New System.Drawing.Point(33, 112)
        Me.btn_Reportes.Name = "btn_Reportes"
        Me.btn_Reportes.Size = New System.Drawing.Size(110, 81)
        Me.btn_Reportes.TabIndex = 3
        Me.btn_Reportes.Text = "Mostrar tabla de Reportes"
        Me.Tip_Menu_Administrador.SetToolTip(Me.btn_Reportes, "Muestra la tabla de Reporte")
        Me.btn_Reportes.UseVisualStyleBackColor = True
        '
        'Btn_Cirugia
        '
        Me.Btn_Cirugia.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cirugia.Location = New System.Drawing.Point(246, 115)
        Me.Btn_Cirugia.Name = "Btn_Cirugia"
        Me.Btn_Cirugia.Size = New System.Drawing.Size(114, 84)
        Me.Btn_Cirugia.TabIndex = 16
        Me.Btn_Cirugia.Text = "Cirugias"
        Me.Tip_Menu_Administrador.SetToolTip(Me.Btn_Cirugia, "Ingresa al formulario para administrar la tabla de Cirugia")
        Me.Btn_Cirugia.UseVisualStyleBackColor = True
        '
        'Btn_Medicos
        '
        Me.Btn_Medicos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Medicos.Location = New System.Drawing.Point(246, 25)
        Me.Btn_Medicos.Name = "Btn_Medicos"
        Me.Btn_Medicos.Size = New System.Drawing.Size(114, 84)
        Me.Btn_Medicos.TabIndex = 15
        Me.Btn_Medicos.Text = "Médicos"
        Me.Tip_Menu_Administrador.SetToolTip(Me.Btn_Medicos, "Ingresa al formulario para administrar la tabla de Médicos")
        Me.Btn_Medicos.UseVisualStyleBackColor = True
        '
        'Btn_Turnos
        '
        Me.Btn_Turnos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Turnos.Location = New System.Drawing.Point(126, 115)
        Me.Btn_Turnos.Name = "Btn_Turnos"
        Me.Btn_Turnos.Size = New System.Drawing.Size(114, 84)
        Me.Btn_Turnos.TabIndex = 14
        Me.Btn_Turnos.Text = "Turno"
        Me.Tip_Menu_Administrador.SetToolTip(Me.Btn_Turnos, "Ingresa al formulario para administrar la tabla de Turnos")
        Me.Btn_Turnos.UseVisualStyleBackColor = True
        '
        'Btn_Medicinas
        '
        Me.Btn_Medicinas.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Medicinas.Location = New System.Drawing.Point(6, 115)
        Me.Btn_Medicinas.Name = "Btn_Medicinas"
        Me.Btn_Medicinas.Size = New System.Drawing.Size(114, 84)
        Me.Btn_Medicinas.TabIndex = 13
        Me.Btn_Medicinas.Text = "Medicinas"
        Me.Tip_Menu_Administrador.SetToolTip(Me.Btn_Medicinas, "Ingresa al formulario para administrar la tabla de Medicinas")
        Me.Btn_Medicinas.UseVisualStyleBackColor = True
        '
        'Btn_Enfermedades
        '
        Me.Btn_Enfermedades.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Enfermedades.Location = New System.Drawing.Point(125, 205)
        Me.Btn_Enfermedades.Name = "Btn_Enfermedades"
        Me.Btn_Enfermedades.Size = New System.Drawing.Size(114, 84)
        Me.Btn_Enfermedades.TabIndex = 12
        Me.Btn_Enfermedades.Text = "Enfermedades"
        Me.Tip_Menu_Administrador.SetToolTip(Me.Btn_Enfermedades, "Ingresa al formulario para administrar la tabla de Enfermedades")
        Me.Btn_Enfermedades.UseVisualStyleBackColor = True
        '
        'Btn_Razas
        '
        Me.Btn_Razas.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Razas.Location = New System.Drawing.Point(5, 205)
        Me.Btn_Razas.Name = "Btn_Razas"
        Me.Btn_Razas.Size = New System.Drawing.Size(114, 84)
        Me.Btn_Razas.TabIndex = 11
        Me.Btn_Razas.Text = "Razas"
        Me.Tip_Menu_Administrador.SetToolTip(Me.Btn_Razas, "Ingresa al formulario para administrar la tabla de Razas")
        Me.Btn_Razas.UseVisualStyleBackColor = True
        '
        'Btn_Especies
        '
        Me.Btn_Especies.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Especies.Location = New System.Drawing.Point(126, 25)
        Me.Btn_Especies.Name = "Btn_Especies"
        Me.Btn_Especies.Size = New System.Drawing.Size(114, 84)
        Me.Btn_Especies.TabIndex = 10
        Me.Btn_Especies.Text = "Especies"
        Me.Tip_Menu_Administrador.SetToolTip(Me.Btn_Especies, "Ingresa al formulario para administrar la tabla de especies" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.Btn_Especies.UseVisualStyleBackColor = True
        '
        'Btn_Usuario
        '
        Me.Btn_Usuario.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Usuario.Location = New System.Drawing.Point(6, 25)
        Me.Btn_Usuario.Name = "Btn_Usuario"
        Me.Btn_Usuario.Size = New System.Drawing.Size(114, 84)
        Me.Btn_Usuario.TabIndex = 9
        Me.Btn_Usuario.Text = "Usuarios"
        Me.Tip_Menu_Administrador.SetToolTip(Me.Btn_Usuario, "Ingresa al formulario para administrar la tabla de usuarios")
        Me.Btn_Usuario.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_Reportes)
        Me.GroupBox1.Controls.Add(Me.Btn_Auditoria)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(393, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 199)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informes de control"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Btn_Cirugia)
        Me.GroupBox2.Controls.Add(Me.Btn_Medicos)
        Me.GroupBox2.Controls.Add(Me.Btn_Turnos)
        Me.GroupBox2.Controls.Add(Me.Btn_Medicinas)
        Me.GroupBox2.Controls.Add(Me.Btn_Enfermedades)
        Me.GroupBox2.Controls.Add(Me.Btn_Razas)
        Me.GroupBox2.Controls.Add(Me.Btn_Especies)
        Me.GroupBox2.Controls.Add(Me.Btn_Usuario)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(375, 304)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mantenimiento"
        '
        'Frm_Menu_Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(591, 332)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btn_Cerrar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Menu_Administrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu del administrador"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tip_Menu_Administrador As ToolTip
    Friend WithEvents Btn_Cerrar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_Reportes As Button
    Friend WithEvents Btn_Auditoria As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btn_Cirugia As Button
    Friend WithEvents Btn_Medicos As Button
    Friend WithEvents Btn_Turnos As Button
    Friend WithEvents Btn_Medicinas As Button
    Friend WithEvents Btn_Enfermedades As Button
    Friend WithEvents Btn_Razas As Button
    Friend WithEvents Btn_Especies As Button
    Friend WithEvents Btn_Usuario As Button
End Class
