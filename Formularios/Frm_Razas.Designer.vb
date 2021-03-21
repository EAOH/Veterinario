<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Razas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Razas))
        Me.Regresar = New System.Windows.Forms.Button()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Btn_Nuevo = New System.Windows.Forms.Button()
        Me.gb_Especie = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RAZCODIGORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAZRAZADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESPCODIGOEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESPESPECIEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESPFAMILIADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAZASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Databases = New Proyecto.databases()
        Me.gbPersonal = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_Generar = New System.Windows.Forms.Button()
        Me.Txt_Familia = New System.Windows.Forms.TextBox()
        Me.Txt_CodigoE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_Especie = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Raza = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_Codigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.RAZASTableAdapter = New Proyecto.databasesTableAdapters.RAZASTableAdapter()
        Me.TableAdapterManager = New Proyecto.databasesTableAdapters.TableAdapterManager()
        Me.gb_Especie.SuspendLayout()
        CType(Me.Datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RAZASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Databases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPersonal.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Regresar
        '
        Me.Regresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Regresar.BackColor = System.Drawing.SystemColors.Control
        Me.Regresar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Regresar.Location = New System.Drawing.Point(297, 325)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(89, 54)
        Me.Regresar.TabIndex = 58
        Me.Regresar.Text = "Volver al menu"
        Me.Regresar.UseVisualStyleBackColor = False
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_Actualizar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Actualizar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_Actualizar.Location = New System.Drawing.Point(279, 325)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(97, 54)
        Me.Btn_Actualizar.TabIndex = 57
        Me.Btn_Actualizar.Text = "Actualizar"
        Me.Btn_Actualizar.UseVisualStyleBackColor = False
        Me.Btn_Actualizar.Visible = False
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_Guardar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Guardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_Guardar.Location = New System.Drawing.Point(153, 325)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(89, 54)
        Me.Btn_Guardar.TabIndex = 56
        Me.Btn_Guardar.Text = "Guardar"
        Me.Btn_Guardar.UseVisualStyleBackColor = False
        Me.Btn_Guardar.Visible = False
        '
        'Btn_Nuevo
        '
        Me.Btn_Nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_Nuevo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Nuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_Nuevo.Location = New System.Drawing.Point(12, 325)
        Me.Btn_Nuevo.Name = "Btn_Nuevo"
        Me.Btn_Nuevo.Size = New System.Drawing.Size(89, 54)
        Me.Btn_Nuevo.TabIndex = 55
        Me.Btn_Nuevo.Text = "Nuevo"
        Me.Btn_Nuevo.UseVisualStyleBackColor = False
        '
        'gb_Especie
        '
        Me.gb_Especie.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_Especie.Controls.Add(Me.BtnEliminar)
        Me.gb_Especie.Controls.Add(Me.Datalistado)
        Me.gb_Especie.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Especie.Location = New System.Drawing.Point(10, 12)
        Me.gb_Especie.Name = "gb_Especie"
        Me.gb_Especie.Size = New System.Drawing.Size(376, 307)
        Me.gb_Especie.TabIndex = 61
        Me.gb_Especie.TabStop = False
        Me.gb_Especie.Text = "Lista de Especies"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnEliminar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnEliminar.Location = New System.Drawing.Point(139, 242)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(89, 54)
        Me.BtnEliminar.TabIndex = 10
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'Datalistado
        '
        Me.Datalistado.AllowUserToAddRows = False
        Me.Datalistado.AllowUserToDeleteRows = False
        Me.Datalistado.AutoGenerateColumns = False
        Me.Datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.RAZCODIGORDataGridViewTextBoxColumn, Me.RAZRAZADataGridViewTextBoxColumn, Me.ESPCODIGOEDataGridViewTextBoxColumn, Me.ESPESPECIEDataGridViewTextBoxColumn, Me.ESPFAMILIADataGridViewTextBoxColumn})
        Me.Datalistado.DataSource = Me.RAZASBindingSource
        Me.Datalistado.Location = New System.Drawing.Point(15, 32)
        Me.Datalistado.Name = "Datalistado"
        Me.Datalistado.ReadOnly = True
        Me.Datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datalistado.Size = New System.Drawing.Size(345, 204)
        Me.Datalistado.TabIndex = 52
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'RAZCODIGORDataGridViewTextBoxColumn
        '
        Me.RAZCODIGORDataGridViewTextBoxColumn.DataPropertyName = "RAZ_CODIGOR"
        Me.RAZCODIGORDataGridViewTextBoxColumn.HeaderText = "CODIGO RAZA"
        Me.RAZCODIGORDataGridViewTextBoxColumn.Name = "RAZCODIGORDataGridViewTextBoxColumn"
        Me.RAZCODIGORDataGridViewTextBoxColumn.ReadOnly = True
        Me.RAZCODIGORDataGridViewTextBoxColumn.Visible = False
        '
        'RAZRAZADataGridViewTextBoxColumn
        '
        Me.RAZRAZADataGridViewTextBoxColumn.DataPropertyName = "RAZ_RAZA"
        Me.RAZRAZADataGridViewTextBoxColumn.HeaderText = "Raza"
        Me.RAZRAZADataGridViewTextBoxColumn.Name = "RAZRAZADataGridViewTextBoxColumn"
        Me.RAZRAZADataGridViewTextBoxColumn.ReadOnly = True
        '
        'ESPCODIGOEDataGridViewTextBoxColumn
        '
        Me.ESPCODIGOEDataGridViewTextBoxColumn.DataPropertyName = "ESP_CODIGOE"
        Me.ESPCODIGOEDataGridViewTextBoxColumn.HeaderText = "CODIGO ESPECIE"
        Me.ESPCODIGOEDataGridViewTextBoxColumn.Name = "ESPCODIGOEDataGridViewTextBoxColumn"
        Me.ESPCODIGOEDataGridViewTextBoxColumn.ReadOnly = True
        Me.ESPCODIGOEDataGridViewTextBoxColumn.Visible = False
        '
        'ESPESPECIEDataGridViewTextBoxColumn
        '
        Me.ESPESPECIEDataGridViewTextBoxColumn.DataPropertyName = "ESP_ESPECIE"
        Me.ESPESPECIEDataGridViewTextBoxColumn.HeaderText = "Especie"
        Me.ESPESPECIEDataGridViewTextBoxColumn.Name = "ESPESPECIEDataGridViewTextBoxColumn"
        Me.ESPESPECIEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ESPFAMILIADataGridViewTextBoxColumn
        '
        Me.ESPFAMILIADataGridViewTextBoxColumn.DataPropertyName = "ESP_FAMILIA"
        Me.ESPFAMILIADataGridViewTextBoxColumn.HeaderText = "Familia"
        Me.ESPFAMILIADataGridViewTextBoxColumn.Name = "ESPFAMILIADataGridViewTextBoxColumn"
        Me.ESPFAMILIADataGridViewTextBoxColumn.ReadOnly = True
        '
        'RAZASBindingSource
        '
        Me.RAZASBindingSource.DataMember = "RAZAS"
        Me.RAZASBindingSource.DataSource = Me.Databases
        '
        'Databases
        '
        Me.Databases.DataSetName = "databases"
        Me.Databases.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gbPersonal
        '
        Me.gbPersonal.Controls.Add(Me.GroupBox1)
        Me.gbPersonal.Controls.Add(Me.Txt_Raza)
        Me.gbPersonal.Controls.Add(Me.Label4)
        Me.gbPersonal.Controls.Add(Me.Txt_Codigo)
        Me.gbPersonal.Controls.Add(Me.Label1)
        Me.gbPersonal.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.gbPersonal.Location = New System.Drawing.Point(12, 12)
        Me.gbPersonal.Name = "gbPersonal"
        Me.gbPersonal.Size = New System.Drawing.Size(230, 307)
        Me.gbPersonal.TabIndex = 60
        Me.gbPersonal.TabStop = False
        Me.gbPersonal.Text = "Informacion"
        Me.gbPersonal.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_Generar)
        Me.GroupBox1.Controls.Add(Me.Txt_Familia)
        Me.GroupBox1.Controls.Add(Me.Txt_CodigoE)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txt_Especie)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(218, 160)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Especies"
        '
        'Btn_Generar
        '
        Me.Btn_Generar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Generar.Location = New System.Drawing.Point(74, 113)
        Me.Btn_Generar.Name = "Btn_Generar"
        Me.Btn_Generar.Size = New System.Drawing.Size(75, 28)
        Me.Btn_Generar.TabIndex = 29
        Me.Btn_Generar.Text = "Generar"
        Me.Btn_Generar.UseVisualStyleBackColor = True
        '
        'Txt_Familia
        '
        Me.Txt_Familia.Enabled = False
        Me.Txt_Familia.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_Familia.Location = New System.Drawing.Point(80, 83)
        Me.Txt_Familia.MaxLength = 50
        Me.Txt_Familia.Name = "Txt_Familia"
        Me.Txt_Familia.Size = New System.Drawing.Size(128, 26)
        Me.Txt_Familia.TabIndex = 28
        '
        'Txt_CodigoE
        '
        Me.Txt_CodigoE.Enabled = False
        Me.Txt_CodigoE.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_CodigoE.Location = New System.Drawing.Point(80, 19)
        Me.Txt_CodigoE.MaxLength = 50
        Me.Txt_CodigoE.Name = "Txt_CodigoE"
        Me.Txt_CodigoE.Size = New System.Drawing.Size(128, 26)
        Me.Txt_CodigoE.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 18)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Codigo:"
        '
        'Txt_Especie
        '
        Me.Txt_Especie.Enabled = False
        Me.Txt_Especie.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_Especie.Location = New System.Drawing.Point(80, 51)
        Me.Txt_Especie.MaxLength = 50
        Me.Txt_Especie.Name = "Txt_Especie"
        Me.Txt_Especie.Size = New System.Drawing.Size(128, 26)
        Me.Txt_Especie.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label3.Location = New System.Drawing.Point(7, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 18)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Familia:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Especie:"
        '
        'Txt_Raza
        '
        Me.Txt_Raza.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_Raza.Location = New System.Drawing.Point(80, 76)
        Me.Txt_Raza.MaxLength = 50
        Me.Txt_Raza.Name = "Txt_Raza"
        Me.Txt_Raza.Size = New System.Drawing.Size(128, 26)
        Me.Txt_Raza.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label4.Location = New System.Drawing.Point(6, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 18)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Raza:"
        '
        'Txt_Codigo
        '
        Me.Txt_Codigo.Enabled = False
        Me.Txt_Codigo.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_Codigo.Location = New System.Drawing.Point(80, 29)
        Me.Txt_Codigo.MaxLength = 50
        Me.Txt_Codigo.Name = "Txt_Codigo"
        Me.Txt_Codigo.Size = New System.Drawing.Size(128, 26)
        Me.Txt_Codigo.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo:"
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_Cancelar.Location = New System.Drawing.Point(414, 328)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(89, 54)
        Me.Btn_Cancelar.TabIndex = 59
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = False
        Me.Btn_Cancelar.Visible = False
        '
        'RAZASTableAdapter
        '
        Me.RAZASTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AUDITORIASTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CIRUGIASTableAdapter = Nothing
        Me.TableAdapterManager.CITASTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.DUEÑOSTableAdapter = Nothing
        Me.TableAdapterManager.ENFERMEDADESTableAdapter = Nothing
        Me.TableAdapterManager.ESPECIESTableAdapter = Nothing
        Me.TableAdapterManager.FECHATableAdapter = Nothing
        Me.TableAdapterManager.MEDICINASTableAdapter = Nothing
        Me.TableAdapterManager.MÉDICOSTableAdapter = Nothing
        Me.TableAdapterManager.PACIENTESTableAdapter = Nothing
        Me.TableAdapterManager.REPORTETableAdapter = Nothing
        Me.TableAdapterManager.TEL_DUEÑOTableAdapter = Nothing
        Me.TableAdapterManager.TEL_MÉDICOTableAdapter = Nothing
        Me.TableAdapterManager.TURNOSTableAdapter = Nothing
        Me.TableAdapterManager.TURNOXMÉDICOTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Proyecto.databasesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USUARIOSTableAdapter = Nothing
        '
        'Frm_Razas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(396, 386)
        Me.Controls.Add(Me.Regresar)
        Me.Controls.Add(Me.Btn_Actualizar)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.Btn_Nuevo)
        Me.Controls.Add(Me.gb_Especie)
        Me.Controls.Add(Me.gbPersonal)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Razas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Razas"
        Me.gb_Especie.ResumeLayout(False)
        CType(Me.Datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RAZASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Databases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPersonal.ResumeLayout(False)
        Me.gbPersonal.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Regresar As Button
    Friend WithEvents Btn_Actualizar As Button
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Btn_Nuevo As Button
    Friend WithEvents gb_Especie As GroupBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Datalistado As DataGridView
    Friend WithEvents gbPersonal As GroupBox
    Friend WithEvents Txt_Codigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_Generar As Button
    Friend WithEvents Txt_Familia As TextBox
    Friend WithEvents Txt_CodigoE As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_Especie As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Raza As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Databases As databases
    Friend WithEvents RAZASBindingSource As BindingSource
    Friend WithEvents RAZASTableAdapter As databasesTableAdapters.RAZASTableAdapter
    Friend WithEvents TableAdapterManager As databasesTableAdapters.TableAdapterManager
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents RAZCODIGORDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RAZRAZADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESPCODIGOEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESPESPECIEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESPFAMILIADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
