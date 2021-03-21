<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Especies
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Especies))
        Me.Regresar = New System.Windows.Forms.Button()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Btn_Nuevo = New System.Windows.Forms.Button()
        Me.gb_Especie = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ESPCODIGOEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESPESPECIEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESPFAMILIADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESPECIESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Databases = New Proyecto.databases()
        Me.gbPersonal = New System.Windows.Forms.GroupBox()
        Me.Combo_Familia = New System.Windows.Forms.ComboBox()
        Me.Txt_Especie = New System.Windows.Forms.TextBox()
        Me.Txt_Codigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.ESPECIESTableAdapter = New Proyecto.databasesTableAdapters.ESPECIESTableAdapter()
        Me.TableAdapterManager = New Proyecto.databasesTableAdapters.TableAdapterManager()
        Me.gb_Especie.SuspendLayout()
        CType(Me.Datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESPECIESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Databases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPersonal.SuspendLayout()
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
        Me.Regresar.TabIndex = 51
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
        Me.Btn_Actualizar.TabIndex = 50
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
        Me.Btn_Guardar.TabIndex = 49
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
        Me.Btn_Nuevo.TabIndex = 48
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
        Me.gb_Especie.TabIndex = 54
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
        Me.Datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.ESPCODIGOEDataGridViewTextBoxColumn, Me.ESPESPECIEDataGridViewTextBoxColumn, Me.ESPFAMILIADataGridViewTextBoxColumn})
        Me.Datalistado.DataSource = Me.ESPECIESBindingSource
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
        'ESPCODIGOEDataGridViewTextBoxColumn
        '
        Me.ESPCODIGOEDataGridViewTextBoxColumn.DataPropertyName = "ESP_CODIGOE"
        Me.ESPCODIGOEDataGridViewTextBoxColumn.HeaderText = "CODIGO"
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
        'ESPECIESBindingSource
        '
        Me.ESPECIESBindingSource.DataMember = "ESPECIES"
        Me.ESPECIESBindingSource.DataSource = Me.Databases
        '
        'Databases
        '
        Me.Databases.DataSetName = "databases"
        Me.Databases.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gbPersonal
        '
        Me.gbPersonal.Controls.Add(Me.Combo_Familia)
        Me.gbPersonal.Controls.Add(Me.Txt_Especie)
        Me.gbPersonal.Controls.Add(Me.Txt_Codigo)
        Me.gbPersonal.Controls.Add(Me.Label3)
        Me.gbPersonal.Controls.Add(Me.Label2)
        Me.gbPersonal.Controls.Add(Me.Label1)
        Me.gbPersonal.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.gbPersonal.Location = New System.Drawing.Point(12, 12)
        Me.gbPersonal.Name = "gbPersonal"
        Me.gbPersonal.Size = New System.Drawing.Size(230, 307)
        Me.gbPersonal.TabIndex = 53
        Me.gbPersonal.TabStop = False
        Me.gbPersonal.Text = "Informacion"
        Me.gbPersonal.Visible = False
        '
        'Combo_Familia
        '
        Me.Combo_Familia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Familia.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Combo_Familia.FormattingEnabled = True
        Me.Combo_Familia.Items.AddRange(New Object() {"Anfibios", "Aves", "Roedores", "Felinos", "Peces", "Canes", "Reptiles", "Bóvinos", "Equinos", "Quélidos"})
        Me.Combo_Familia.Location = New System.Drawing.Point(80, 209)
        Me.Combo_Familia.Name = "Combo_Familia"
        Me.Combo_Familia.Size = New System.Drawing.Size(128, 27)
        Me.Combo_Familia.TabIndex = 17
        '
        'Txt_Especie
        '
        Me.Txt_Especie.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_Especie.Location = New System.Drawing.Point(80, 113)
        Me.Txt_Especie.MaxLength = 50
        Me.Txt_Especie.Name = "Txt_Especie"
        Me.Txt_Especie.Size = New System.Drawing.Size(128, 26)
        Me.Txt_Especie.TabIndex = 10
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label3.Location = New System.Drawing.Point(7, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Familia:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.Location = New System.Drawing.Point(6, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Especie:"
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
        Me.Btn_Cancelar.TabIndex = 52
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = False
        Me.Btn_Cancelar.Visible = False
        '
        'ESPECIESTableAdapter
        '
        Me.ESPECIESTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AUDITORIASTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CIRUGIASTableAdapter = Nothing
        Me.TableAdapterManager.CITASTableAdapter = Nothing
        Me.TableAdapterManager.DUEÑOSTableAdapter = Nothing
        Me.TableAdapterManager.ENFERMEDADESTableAdapter = Nothing
        Me.TableAdapterManager.ESPECIESTableAdapter = Me.ESPECIESTableAdapter
        Me.TableAdapterManager.FECHATableAdapter = Nothing
        Me.TableAdapterManager.MEDICINASTableAdapter = Nothing
        Me.TableAdapterManager.PACIENTESTableAdapter = Nothing
        Me.TableAdapterManager.REPORTETableAdapter = Nothing
        Me.TableAdapterManager.TEL_DUEÑOTableAdapter = Nothing
        Me.TableAdapterManager.TEL_MÉDICOTableAdapter = Nothing
        Me.TableAdapterManager.TURNOSTableAdapter = Nothing
        Me.TableAdapterManager.TURNOXMÉDICOTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Proyecto.databasesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USUARIOSTableAdapter = Nothing
        '
        'Frm_Especies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(398, 394)
        Me.Controls.Add(Me.Regresar)
        Me.Controls.Add(Me.Btn_Actualizar)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.Btn_Nuevo)
        Me.Controls.Add(Me.gb_Especie)
        Me.Controls.Add(Me.gbPersonal)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Especies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Especies"
        Me.gb_Especie.ResumeLayout(False)
        CType(Me.Datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESPECIESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Databases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPersonal.ResumeLayout(False)
        Me.gbPersonal.PerformLayout()
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
    Friend WithEvents Txt_Especie As TextBox
    Friend WithEvents Txt_Codigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Databases As databases
    Friend WithEvents ESPECIESBindingSource As BindingSource
    Friend WithEvents ESPECIESTableAdapter As databasesTableAdapters.ESPECIESTableAdapter
    Friend WithEvents TableAdapterManager As databasesTableAdapters.TableAdapterManager
    Friend WithEvents Combo_Familia As ComboBox
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents ESPCODIGOEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESPESPECIEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESPFAMILIADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
