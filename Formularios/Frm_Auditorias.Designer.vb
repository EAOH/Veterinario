<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Auditorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Auditorias))
        Me.gb_Auditoria = New System.Windows.Forms.GroupBox()
        Me.Regresar = New System.Windows.Forms.Button()
        Me.Tabla_Acusado = New System.Windows.Forms.DataGridView()
        Me.USUUSUARIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AUDPROCESODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AUDFECHAHORADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AUDTABLADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AUDITORIASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Databases = New Proyecto.databases()
        Me.AUDITORIASTableAdapter = New Proyecto.databasesTableAdapters.AUDITORIASTableAdapter()
        Me.TableAdapterManager = New Proyecto.databasesTableAdapters.TableAdapterManager()
        Me.gb_Auditoria.SuspendLayout()
        CType(Me.Tabla_Acusado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDITORIASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Databases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_Auditoria
        '
        Me.gb_Auditoria.Controls.Add(Me.Regresar)
        Me.gb_Auditoria.Controls.Add(Me.Tabla_Acusado)
        Me.gb_Auditoria.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Auditoria.Location = New System.Drawing.Point(12, 12)
        Me.gb_Auditoria.Name = "gb_Auditoria"
        Me.gb_Auditoria.Size = New System.Drawing.Size(480, 426)
        Me.gb_Auditoria.TabIndex = 30
        Me.gb_Auditoria.TabStop = False
        Me.gb_Auditoria.Text = "Lista de transacciones"
        '
        'Regresar
        '
        Me.Regresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Regresar.BackColor = System.Drawing.SystemColors.Control
        Me.Regresar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Regresar.Location = New System.Drawing.Point(379, 358)
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
        Me.Tabla_Acusado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.USUUSUARIODataGridViewTextBoxColumn, Me.AUDPROCESODataGridViewTextBoxColumn, Me.AUDFECHAHORADataGridViewTextBoxColumn, Me.AUDTABLADataGridViewTextBoxColumn})
        Me.Tabla_Acusado.DataSource = Me.AUDITORIASBindingSource
        Me.Tabla_Acusado.Location = New System.Drawing.Point(15, 28)
        Me.Tabla_Acusado.Name = "Tabla_Acusado"
        Me.Tabla_Acusado.ReadOnly = True
        Me.Tabla_Acusado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Tabla_Acusado.Size = New System.Drawing.Size(454, 324)
        Me.Tabla_Acusado.TabIndex = 52
        '
        'USUUSUARIODataGridViewTextBoxColumn
        '
        Me.USUUSUARIODataGridViewTextBoxColumn.DataPropertyName = "USU_USUARIO"
        Me.USUUSUARIODataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.USUUSUARIODataGridViewTextBoxColumn.Name = "USUUSUARIODataGridViewTextBoxColumn"
        Me.USUUSUARIODataGridViewTextBoxColumn.ReadOnly = True
        '
        'AUDPROCESODataGridViewTextBoxColumn
        '
        Me.AUDPROCESODataGridViewTextBoxColumn.DataPropertyName = "AUD_PROCESO"
        Me.AUDPROCESODataGridViewTextBoxColumn.HeaderText = "Proceso"
        Me.AUDPROCESODataGridViewTextBoxColumn.Name = "AUDPROCESODataGridViewTextBoxColumn"
        Me.AUDPROCESODataGridViewTextBoxColumn.ReadOnly = True
        '
        'AUDFECHAHORADataGridViewTextBoxColumn
        '
        Me.AUDFECHAHORADataGridViewTextBoxColumn.DataPropertyName = "AUD_FECHAHORA"
        Me.AUDFECHAHORADataGridViewTextBoxColumn.HeaderText = "Hora y fecha"
        Me.AUDFECHAHORADataGridViewTextBoxColumn.Name = "AUDFECHAHORADataGridViewTextBoxColumn"
        Me.AUDFECHAHORADataGridViewTextBoxColumn.ReadOnly = True
        '
        'AUDTABLADataGridViewTextBoxColumn
        '
        Me.AUDTABLADataGridViewTextBoxColumn.DataPropertyName = "AUD_TABLA"
        Me.AUDTABLADataGridViewTextBoxColumn.HeaderText = "Tabla"
        Me.AUDTABLADataGridViewTextBoxColumn.Name = "AUDTABLADataGridViewTextBoxColumn"
        Me.AUDTABLADataGridViewTextBoxColumn.ReadOnly = True
        '
        'AUDITORIASBindingSource
        '
        Me.AUDITORIASBindingSource.DataMember = "AUDITORIAS"
        Me.AUDITORIASBindingSource.DataSource = Me.Databases
        '
        'Databases
        '
        Me.Databases.DataSetName = "databases"
        Me.Databases.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AUDITORIASTableAdapter
        '
        Me.AUDITORIASTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AUDITORIASTableAdapter = Me.AUDITORIASTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CIRUGIASTableAdapter = Nothing
        Me.TableAdapterManager.CITASTableAdapter = Nothing
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
        'Frm_Auditorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(505, 450)
        Me.Controls.Add(Me.gb_Auditoria)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Auditorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de transacciones"
        Me.gb_Auditoria.ResumeLayout(False)
        CType(Me.Tabla_Acusado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDITORIASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Databases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_Auditoria As GroupBox
    Friend WithEvents Regresar As Button
    Friend WithEvents Tabla_Acusado As DataGridView
    Friend WithEvents Databases As databases
    Friend WithEvents AUDITORIASBindingSource As BindingSource
    Friend WithEvents AUDITORIASTableAdapter As databasesTableAdapters.AUDITORIASTableAdapter
    Friend WithEvents TableAdapterManager As databasesTableAdapters.TableAdapterManager
    Friend WithEvents USUUSUARIODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AUDPROCESODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AUDFECHAHORADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AUDTABLADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
