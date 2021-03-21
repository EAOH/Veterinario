<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Reporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Reporte))
        Me.gb_Auditoria = New System.Windows.Forms.GroupBox()
        Me.Regresar = New System.Windows.Forms.Button()
        Me.Tabla_Acusado = New System.Windows.Forms.DataGridView()
        Me.Databases = New Proyecto.databases()
        Me.S_REPORTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.S_REPORTETableAdapter = New Proyecto.databasesTableAdapters.S_REPORTETableAdapter()
        Me.TableAdapterManager = New Proyecto.databasesTableAdapters.TableAdapterManager()
        Me.REPSECUENCIADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REPMESHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REPFECHAHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DUECODIGODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEFONOSDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PACCODIGOPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PACNOMBREPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESPCODIGOEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESPESPECIEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CITCODIGOCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CITCALENDARIZADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MEDCODIGOMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gb_Auditoria.SuspendLayout()
        CType(Me.Tabla_Acusado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Databases, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.S_REPORTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_Auditoria
        '
        Me.gb_Auditoria.Controls.Add(Me.Regresar)
        Me.gb_Auditoria.Controls.Add(Me.Tabla_Acusado)
        Me.gb_Auditoria.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Auditoria.Location = New System.Drawing.Point(12, 12)
        Me.gb_Auditoria.Name = "gb_Auditoria"
        Me.gb_Auditoria.Size = New System.Drawing.Size(776, 426)
        Me.gb_Auditoria.TabIndex = 31
        Me.gb_Auditoria.TabStop = False
        Me.gb_Auditoria.Text = "Lista de transacciones"
        '
        'Regresar
        '
        Me.Regresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Regresar.BackColor = System.Drawing.SystemColors.Control
        Me.Regresar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Regresar.Location = New System.Drawing.Point(675, 358)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(89, 54)
        Me.Regresar.TabIndex = 53
        Me.Regresar.Text = "Volver al menu"
        Me.Regresar.UseVisualStyleBackColor = False
        '
        'Tabla_Acusado
        '
        Me.Tabla_Acusado.AllowUserToAddRows = False
        Me.Tabla_Acusado.AllowUserToDeleteRows = False
        Me.Tabla_Acusado.AutoGenerateColumns = False
        Me.Tabla_Acusado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla_Acusado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.REPSECUENCIADataGridViewTextBoxColumn, Me.REPMESHDataGridViewTextBoxColumn, Me.REPFECHAHDataGridViewTextBoxColumn, Me.DUECODIGODDataGridViewTextBoxColumn, Me.NOMBREDDataGridViewTextBoxColumn, Me.TELEFONOSDDataGridViewTextBoxColumn, Me.PACCODIGOPDataGridViewTextBoxColumn, Me.PACNOMBREPDataGridViewTextBoxColumn, Me.ESPCODIGOEDataGridViewTextBoxColumn, Me.ESPESPECIEDataGridViewTextBoxColumn, Me.CITCODIGOCDataGridViewTextBoxColumn, Me.CITCALENDARIZADODataGridViewTextBoxColumn, Me.MEDCODIGOMDataGridViewTextBoxColumn, Me.NOMBREMDataGridViewTextBoxColumn})
        Me.Tabla_Acusado.DataSource = Me.S_REPORTEBindingSource
        Me.Tabla_Acusado.Location = New System.Drawing.Point(15, 28)
        Me.Tabla_Acusado.Name = "Tabla_Acusado"
        Me.Tabla_Acusado.ReadOnly = True
        Me.Tabla_Acusado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Tabla_Acusado.Size = New System.Drawing.Size(749, 324)
        Me.Tabla_Acusado.TabIndex = 52
        '
        'Databases
        '
        Me.Databases.DataSetName = "databases"
        Me.Databases.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'S_REPORTEBindingSource
        '
        Me.S_REPORTEBindingSource.DataMember = "S_REPORTE"
        Me.S_REPORTEBindingSource.DataSource = Me.Databases
        '
        'S_REPORTETableAdapter
        '
        Me.S_REPORTETableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.TEL_DUEÑOTableAdapter = Nothing
        Me.TableAdapterManager.TEL_MÉDICOTableAdapter = Nothing
        Me.TableAdapterManager.TURNOSTableAdapter = Nothing
        Me.TableAdapterManager.TURNOXMÉDICOTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Proyecto.databasesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USUARIOSTableAdapter = Nothing
        '
        'REPSECUENCIADataGridViewTextBoxColumn
        '
        Me.REPSECUENCIADataGridViewTextBoxColumn.DataPropertyName = "REP_SECUENCIA"
        Me.REPSECUENCIADataGridViewTextBoxColumn.HeaderText = "Secuencia"
        Me.REPSECUENCIADataGridViewTextBoxColumn.Name = "REPSECUENCIADataGridViewTextBoxColumn"
        Me.REPSECUENCIADataGridViewTextBoxColumn.ReadOnly = True
        '
        'REPMESHDataGridViewTextBoxColumn
        '
        Me.REPMESHDataGridViewTextBoxColumn.DataPropertyName = "REP_MESH"
        Me.REPMESHDataGridViewTextBoxColumn.HeaderText = "Mes"
        Me.REPMESHDataGridViewTextBoxColumn.Name = "REPMESHDataGridViewTextBoxColumn"
        Me.REPMESHDataGridViewTextBoxColumn.ReadOnly = True
        '
        'REPFECHAHDataGridViewTextBoxColumn
        '
        Me.REPFECHAHDataGridViewTextBoxColumn.DataPropertyName = "REP_FECHAH"
        Me.REPFECHAHDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.REPFECHAHDataGridViewTextBoxColumn.Name = "REPFECHAHDataGridViewTextBoxColumn"
        Me.REPFECHAHDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DUECODIGODDataGridViewTextBoxColumn
        '
        Me.DUECODIGODDataGridViewTextBoxColumn.DataPropertyName = "DUE_CODIGOD"
        Me.DUECODIGODDataGridViewTextBoxColumn.HeaderText = "CODIGO DUEÑO"
        Me.DUECODIGODDataGridViewTextBoxColumn.Name = "DUECODIGODDataGridViewTextBoxColumn"
        Me.DUECODIGODDataGridViewTextBoxColumn.ReadOnly = True
        Me.DUECODIGODDataGridViewTextBoxColumn.Visible = False
        '
        'NOMBREDDataGridViewTextBoxColumn
        '
        Me.NOMBREDDataGridViewTextBoxColumn.DataPropertyName = "NOMBRED"
        Me.NOMBREDDataGridViewTextBoxColumn.HeaderText = "Nombre del dueño"
        Me.NOMBREDDataGridViewTextBoxColumn.Name = "NOMBREDDataGridViewTextBoxColumn"
        Me.NOMBREDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TELEFONOSDDataGridViewTextBoxColumn
        '
        Me.TELEFONOSDDataGridViewTextBoxColumn.DataPropertyName = "TELEFONOSD"
        Me.TELEFONOSDDataGridViewTextBoxColumn.HeaderText = "Tels del Dueño"
        Me.TELEFONOSDDataGridViewTextBoxColumn.Name = "TELEFONOSDDataGridViewTextBoxColumn"
        Me.TELEFONOSDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PACCODIGOPDataGridViewTextBoxColumn
        '
        Me.PACCODIGOPDataGridViewTextBoxColumn.DataPropertyName = "PAC_CODIGOP"
        Me.PACCODIGOPDataGridViewTextBoxColumn.HeaderText = "CODIGO PACIENTE"
        Me.PACCODIGOPDataGridViewTextBoxColumn.Name = "PACCODIGOPDataGridViewTextBoxColumn"
        Me.PACCODIGOPDataGridViewTextBoxColumn.ReadOnly = True
        Me.PACCODIGOPDataGridViewTextBoxColumn.Visible = False
        '
        'PACNOMBREPDataGridViewTextBoxColumn
        '
        Me.PACNOMBREPDataGridViewTextBoxColumn.DataPropertyName = "PAC_NOMBREP"
        Me.PACNOMBREPDataGridViewTextBoxColumn.HeaderText = "Nombre Paciente"
        Me.PACNOMBREPDataGridViewTextBoxColumn.Name = "PACNOMBREPDataGridViewTextBoxColumn"
        Me.PACNOMBREPDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ESPCODIGOEDataGridViewTextBoxColumn
        '
        Me.ESPCODIGOEDataGridViewTextBoxColumn.DataPropertyName = "ESP_CODIGOE"
        Me.ESPCODIGOEDataGridViewTextBoxColumn.HeaderText = "CODIGO ESPECIES"
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
        'CITCODIGOCDataGridViewTextBoxColumn
        '
        Me.CITCODIGOCDataGridViewTextBoxColumn.DataPropertyName = "CIT_CODIGOC"
        Me.CITCODIGOCDataGridViewTextBoxColumn.HeaderText = "CODIGO CITA"
        Me.CITCODIGOCDataGridViewTextBoxColumn.Name = "CITCODIGOCDataGridViewTextBoxColumn"
        Me.CITCODIGOCDataGridViewTextBoxColumn.ReadOnly = True
        Me.CITCODIGOCDataGridViewTextBoxColumn.Visible = False
        '
        'CITCALENDARIZADODataGridViewTextBoxColumn
        '
        Me.CITCALENDARIZADODataGridViewTextBoxColumn.DataPropertyName = "CIT_CALENDARIZADO"
        Me.CITCALENDARIZADODataGridViewTextBoxColumn.HeaderText = "Cita Programada el"
        Me.CITCALENDARIZADODataGridViewTextBoxColumn.Name = "CITCALENDARIZADODataGridViewTextBoxColumn"
        Me.CITCALENDARIZADODataGridViewTextBoxColumn.ReadOnly = True
        '
        'MEDCODIGOMDataGridViewTextBoxColumn
        '
        Me.MEDCODIGOMDataGridViewTextBoxColumn.DataPropertyName = "MED_CODIGOM"
        Me.MEDCODIGOMDataGridViewTextBoxColumn.HeaderText = "CODIGO MEDICO"
        Me.MEDCODIGOMDataGridViewTextBoxColumn.Name = "MEDCODIGOMDataGridViewTextBoxColumn"
        Me.MEDCODIGOMDataGridViewTextBoxColumn.ReadOnly = True
        Me.MEDCODIGOMDataGridViewTextBoxColumn.Visible = False
        '
        'NOMBREMDataGridViewTextBoxColumn
        '
        Me.NOMBREMDataGridViewTextBoxColumn.DataPropertyName = "NOMBREM"
        Me.NOMBREMDataGridViewTextBoxColumn.HeaderText = "Nombre medico"
        Me.NOMBREMDataGridViewTextBoxColumn.Name = "NOMBREMDataGridViewTextBoxColumn"
        Me.NOMBREMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Frm_Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gb_Auditoria)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Reporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte"
        Me.gb_Auditoria.ResumeLayout(False)
        CType(Me.Tabla_Acusado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Databases, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.S_REPORTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_Auditoria As GroupBox
    Friend WithEvents Regresar As Button
    Friend WithEvents Tabla_Acusado As DataGridView
    Friend WithEvents Databases As databases
    Friend WithEvents S_REPORTEBindingSource As BindingSource
    Friend WithEvents S_REPORTETableAdapter As databasesTableAdapters.S_REPORTETableAdapter
    Friend WithEvents TableAdapterManager As databasesTableAdapters.TableAdapterManager
    Friend WithEvents REPSECUENCIADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REPMESHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REPFECHAHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DUECODIGODDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TELEFONOSDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PACCODIGOPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PACNOMBREPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESPCODIGOEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESPESPECIEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CITCODIGOCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CITCALENDARIZADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MEDCODIGOMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
