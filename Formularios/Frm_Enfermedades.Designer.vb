<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Enfermedades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Enfermedades))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Tap1 = New System.Windows.Forms.TabPage()
        Me.Regresar = New System.Windows.Forms.Button()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Btn_Nuevo = New System.Windows.Forms.Button()
        Me.gb_Enfermedad = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ENFCODIGOEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENFENFERMEDADDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENFERMEDADESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Databases = New Proyecto.databases()
        Me.gbPersonal = New System.Windows.Forms.GroupBox()
        Me.Txt_Enfermedad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_Codigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Tab2 = New System.Windows.Forms.TabPage()
        Me.Btn_Finalizar = New System.Windows.Forms.Button()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.gb_Especie = New System.Windows.Forms.GroupBox()
        Me.Data_Intermedia = New System.Windows.Forms.DataGridView()
        Me.Btn_Quitar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Btn_Generar = New System.Windows.Forms.Button()
        Me.Txt_CodigoR = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_R = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txt_E = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_CodigoE = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ENFERMEDADESTableAdapter = New Proyecto.databasesTableAdapters.ENFERMEDADESTableAdapter()
        Me.TableAdapterManager = New Proyecto.databasesTableAdapters.TableAdapterManager()
        Me.ENFERMEDADXRAZABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ENFERMEDADXRAZATableAdapter = New Proyecto.databasesTableAdapters.ENFERMEDADXRAZATableAdapter()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ENFCODIGOEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAZCODIGORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENFENFERMEDADDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAZRAZADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.Tap1.SuspendLayout()
        Me.gb_Enfermedad.SuspendLayout()
        CType(Me.Datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ENFERMEDADESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Databases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPersonal.SuspendLayout()
        Me.Tab2.SuspendLayout()
        Me.gb_Especie.SuspendLayout()
        CType(Me.Data_Intermedia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ENFERMEDADXRAZABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.Tap1)
        Me.TabControl1.Controls.Add(Me.Tab2)
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(390, 414)
        Me.TabControl1.TabIndex = 69
        '
        'Tap1
        '
        Me.Tap1.Controls.Add(Me.Regresar)
        Me.Tap1.Controls.Add(Me.Btn_Actualizar)
        Me.Tap1.Controls.Add(Me.Btn_Guardar)
        Me.Tap1.Controls.Add(Me.Btn_Nuevo)
        Me.Tap1.Controls.Add(Me.gb_Enfermedad)
        Me.Tap1.Controls.Add(Me.gbPersonal)
        Me.Tap1.Controls.Add(Me.Btn_Cancelar)
        Me.Tap1.Location = New System.Drawing.Point(4, 28)
        Me.Tap1.Name = "Tap1"
        Me.Tap1.Padding = New System.Windows.Forms.Padding(3)
        Me.Tap1.Size = New System.Drawing.Size(387, 382)
        Me.Tap1.TabIndex = 0
        Me.Tap1.Text = "Enfermedades"
        Me.Tap1.UseVisualStyleBackColor = True
        '
        'Regresar
        '
        Me.Regresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Regresar.BackColor = System.Drawing.SystemColors.Control
        Me.Regresar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Regresar.Location = New System.Drawing.Point(286, 322)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(89, 54)
        Me.Regresar.TabIndex = 72
        Me.Regresar.Text = "Volver al menu"
        Me.Regresar.UseVisualStyleBackColor = False
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_Actualizar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Actualizar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_Actualizar.Location = New System.Drawing.Point(279, 322)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(97, 54)
        Me.Btn_Actualizar.TabIndex = 71
        Me.Btn_Actualizar.Text = "Actualizar"
        Me.Btn_Actualizar.UseVisualStyleBackColor = False
        Me.Btn_Actualizar.Visible = False
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_Guardar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Guardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_Guardar.Location = New System.Drawing.Point(153, 322)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(89, 54)
        Me.Btn_Guardar.TabIndex = 70
        Me.Btn_Guardar.Text = "Guardar"
        Me.Btn_Guardar.UseVisualStyleBackColor = False
        Me.Btn_Guardar.Visible = False
        '
        'Btn_Nuevo
        '
        Me.Btn_Nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_Nuevo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Nuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_Nuevo.Location = New System.Drawing.Point(12, 322)
        Me.Btn_Nuevo.Name = "Btn_Nuevo"
        Me.Btn_Nuevo.Size = New System.Drawing.Size(89, 54)
        Me.Btn_Nuevo.TabIndex = 69
        Me.Btn_Nuevo.Text = "Nuevo"
        Me.Btn_Nuevo.UseVisualStyleBackColor = False
        '
        'gb_Enfermedad
        '
        Me.gb_Enfermedad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_Enfermedad.Controls.Add(Me.BtnEliminar)
        Me.gb_Enfermedad.Controls.Add(Me.Datalistado)
        Me.gb_Enfermedad.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Enfermedad.Location = New System.Drawing.Point(-1, 9)
        Me.gb_Enfermedad.Name = "gb_Enfermedad"
        Me.gb_Enfermedad.Size = New System.Drawing.Size(376, 307)
        Me.gb_Enfermedad.TabIndex = 75
        Me.gb_Enfermedad.TabStop = False
        Me.gb_Enfermedad.Text = "Lista de Enfermedades"
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
        Me.Datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.ENFCODIGOEDataGridViewTextBoxColumn, Me.ENFENFERMEDADDataGridViewTextBoxColumn})
        Me.Datalistado.DataSource = Me.ENFERMEDADESBindingSource
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
        'ENFCODIGOEDataGridViewTextBoxColumn
        '
        Me.ENFCODIGOEDataGridViewTextBoxColumn.DataPropertyName = "ENF_CODIGOE"
        Me.ENFCODIGOEDataGridViewTextBoxColumn.HeaderText = "Codigo Enfermedad"
        Me.ENFCODIGOEDataGridViewTextBoxColumn.Name = "ENFCODIGOEDataGridViewTextBoxColumn"
        Me.ENFCODIGOEDataGridViewTextBoxColumn.ReadOnly = True
        Me.ENFCODIGOEDataGridViewTextBoxColumn.Visible = False
        '
        'ENFENFERMEDADDataGridViewTextBoxColumn
        '
        Me.ENFENFERMEDADDataGridViewTextBoxColumn.DataPropertyName = "ENF_ENFERMEDAD"
        Me.ENFENFERMEDADDataGridViewTextBoxColumn.HeaderText = "Enfermedad"
        Me.ENFENFERMEDADDataGridViewTextBoxColumn.Name = "ENFENFERMEDADDataGridViewTextBoxColumn"
        Me.ENFENFERMEDADDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ENFERMEDADESBindingSource
        '
        Me.ENFERMEDADESBindingSource.DataMember = "ENFERMEDADES"
        Me.ENFERMEDADESBindingSource.DataSource = Me.Databases
        '
        'Databases
        '
        Me.Databases.DataSetName = "databases"
        Me.Databases.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gbPersonal
        '
        Me.gbPersonal.Controls.Add(Me.Txt_Enfermedad)
        Me.gbPersonal.Controls.Add(Me.Label4)
        Me.gbPersonal.Controls.Add(Me.Txt_Codigo)
        Me.gbPersonal.Controls.Add(Me.Label1)
        Me.gbPersonal.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.gbPersonal.Location = New System.Drawing.Point(12, 9)
        Me.gbPersonal.Name = "gbPersonal"
        Me.gbPersonal.Size = New System.Drawing.Size(230, 307)
        Me.gbPersonal.TabIndex = 74
        Me.gbPersonal.TabStop = False
        Me.gbPersonal.Text = "Informacion"
        Me.gbPersonal.Visible = False
        '
        'Txt_Enfermedad
        '
        Me.Txt_Enfermedad.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_Enfermedad.Location = New System.Drawing.Point(9, 177)
        Me.Txt_Enfermedad.MaxLength = 50
        Me.Txt_Enfermedad.Name = "Txt_Enfermedad"
        Me.Txt_Enfermedad.Size = New System.Drawing.Size(199, 26)
        Me.Txt_Enfermedad.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label4.Location = New System.Drawing.Point(55, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 18)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Enfermedad:"
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
        Me.Btn_Cancelar.Location = New System.Drawing.Point(414, 325)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(89, 54)
        Me.Btn_Cancelar.TabIndex = 73
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = False
        Me.Btn_Cancelar.Visible = False
        '
        'Tab2
        '
        Me.Tab2.Controls.Add(Me.Btn_Finalizar)
        Me.Tab2.Controls.Add(Me.Btn_Agregar)
        Me.Tab2.Controls.Add(Me.gb_Especie)
        Me.Tab2.Controls.Add(Me.GroupBox2)
        Me.Tab2.Location = New System.Drawing.Point(4, 28)
        Me.Tab2.Name = "Tab2"
        Me.Tab2.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab2.Size = New System.Drawing.Size(382, 382)
        Me.Tab2.TabIndex = 1
        Me.Tab2.Text = "Razas vulnerables"
        Me.Tab2.UseVisualStyleBackColor = True
        '
        'Btn_Finalizar
        '
        Me.Btn_Finalizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Finalizar.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_Finalizar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Finalizar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_Finalizar.Location = New System.Drawing.Point(256, 319)
        Me.Btn_Finalizar.Name = "Btn_Finalizar"
        Me.Btn_Finalizar.Size = New System.Drawing.Size(89, 54)
        Me.Btn_Finalizar.TabIndex = 72
        Me.Btn_Finalizar.Text = "Finalizar"
        Me.Btn_Finalizar.UseVisualStyleBackColor = False
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_Agregar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_Agregar.Location = New System.Drawing.Point(6, 319)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(89, 54)
        Me.Btn_Agregar.TabIndex = 69
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.UseVisualStyleBackColor = False
        '
        'gb_Especie
        '
        Me.gb_Especie.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_Especie.Controls.Add(Me.Data_Intermedia)
        Me.gb_Especie.Controls.Add(Me.Btn_Quitar)
        Me.gb_Especie.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Especie.Location = New System.Drawing.Point(0, 6)
        Me.gb_Especie.Name = "gb_Especie"
        Me.gb_Especie.Size = New System.Drawing.Size(376, 307)
        Me.gb_Especie.TabIndex = 75
        Me.gb_Especie.TabStop = False
        Me.gb_Especie.Text = "Lista deRazas vulnerables"
        '
        'Data_Intermedia
        '
        Me.Data_Intermedia.AllowUserToAddRows = False
        Me.Data_Intermedia.AllowUserToDeleteRows = False
        Me.Data_Intermedia.AutoGenerateColumns = False
        Me.Data_Intermedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Data_Intermedia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.ENFCODIGOEDataGridViewTextBoxColumn1, Me.RAZCODIGORDataGridViewTextBoxColumn, Me.ENFENFERMEDADDataGridViewTextBoxColumn1, Me.RAZRAZADataGridViewTextBoxColumn})
        Me.Data_Intermedia.DataSource = Me.ENFERMEDADXRAZABindingSource
        Me.Data_Intermedia.Location = New System.Drawing.Point(15, 25)
        Me.Data_Intermedia.Name = "Data_Intermedia"
        Me.Data_Intermedia.ReadOnly = True
        Me.Data_Intermedia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Data_Intermedia.Size = New System.Drawing.Size(345, 204)
        Me.Data_Intermedia.TabIndex = 53
        '
        'Btn_Quitar
        '
        Me.Btn_Quitar.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_Quitar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Quitar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_Quitar.Location = New System.Drawing.Point(139, 242)
        Me.Btn_Quitar.Name = "Btn_Quitar"
        Me.Btn_Quitar.Size = New System.Drawing.Size(89, 54)
        Me.Btn_Quitar.TabIndex = 10
        Me.Btn_Quitar.Text = "Quitar"
        Me.Btn_Quitar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Txt_E)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_CodigoE)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(230, 307)
        Me.GroupBox2.TabIndex = 74
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Btn_Generar)
        Me.GroupBox3.Controls.Add(Me.Txt_CodigoR)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txt_R)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 173)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(218, 123)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Raza"
        '
        'Btn_Generar
        '
        Me.Btn_Generar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Generar.Location = New System.Drawing.Point(60, 83)
        Me.Btn_Generar.Name = "Btn_Generar"
        Me.Btn_Generar.Size = New System.Drawing.Size(75, 28)
        Me.Btn_Generar.TabIndex = 29
        Me.Btn_Generar.Text = "Generar"
        Me.Btn_Generar.UseVisualStyleBackColor = True
        '
        'Txt_CodigoR
        '
        Me.Txt_CodigoR.Enabled = False
        Me.Txt_CodigoR.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_CodigoR.Location = New System.Drawing.Point(80, 19)
        Me.Txt_CodigoR.MaxLength = 50
        Me.Txt_CodigoR.Name = "Txt_CodigoR"
        Me.Txt_CodigoR.Size = New System.Drawing.Size(128, 26)
        Me.Txt_CodigoR.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label6.Location = New System.Drawing.Point(6, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 18)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Codigo:"
        '
        'txt_R
        '
        Me.txt_R.Enabled = False
        Me.txt_R.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.txt_R.Location = New System.Drawing.Point(80, 51)
        Me.txt_R.MaxLength = 50
        Me.txt_R.Name = "txt_R"
        Me.txt_R.Size = New System.Drawing.Size(128, 26)
        Me.txt_R.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label8.Location = New System.Drawing.Point(6, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 18)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Raza:"
        '
        'Txt_E
        '
        Me.Txt_E.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_E.Location = New System.Drawing.Point(6, 113)
        Me.Txt_E.MaxLength = 50
        Me.Txt_E.Name = "Txt_E"
        Me.Txt_E.Size = New System.Drawing.Size(199, 26)
        Me.Txt_E.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label9.Location = New System.Drawing.Point(48, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 18)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Enfermedad:"
        '
        'txt_CodigoE
        '
        Me.txt_CodigoE.Enabled = False
        Me.txt_CodigoE.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.txt_CodigoE.Location = New System.Drawing.Point(80, 29)
        Me.txt_CodigoE.MaxLength = 50
        Me.txt_CodigoE.Name = "txt_CodigoE"
        Me.txt_CodigoE.Size = New System.Drawing.Size(128, 26)
        Me.txt_CodigoE.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label10.Location = New System.Drawing.Point(6, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 18)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Codigo:"
        '
        'ENFERMEDADESTableAdapter
        '
        Me.ENFERMEDADESTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AUDITORIASTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CIRUGIASTableAdapter = Nothing
        Me.TableAdapterManager.CITASTableAdapter = Nothing
        Me.TableAdapterManager.DUEÑOSTableAdapter = Nothing
        Me.TableAdapterManager.ENFERMEDADESTableAdapter = Me.ENFERMEDADESTableAdapter
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
        'ENFERMEDADXRAZABindingSource
        '
        Me.ENFERMEDADXRAZABindingSource.DataMember = "ENFERMEDADXRAZA"
        Me.ENFERMEDADXRAZABindingSource.DataSource = Me.Databases
        '
        'ENFERMEDADXRAZATableAdapter
        '
        Me.ENFERMEDADXRAZATableAdapter.ClearBeforeFill = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Eliminar"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'ENFCODIGOEDataGridViewTextBoxColumn1
        '
        Me.ENFCODIGOEDataGridViewTextBoxColumn1.DataPropertyName = "ENF_CODIGOE"
        Me.ENFCODIGOEDataGridViewTextBoxColumn1.HeaderText = "Codigo Enfermedad"
        Me.ENFCODIGOEDataGridViewTextBoxColumn1.Name = "ENFCODIGOEDataGridViewTextBoxColumn1"
        Me.ENFCODIGOEDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ENFCODIGOEDataGridViewTextBoxColumn1.Visible = False
        '
        'RAZCODIGORDataGridViewTextBoxColumn
        '
        Me.RAZCODIGORDataGridViewTextBoxColumn.DataPropertyName = "RAZ_CODIGOR"
        Me.RAZCODIGORDataGridViewTextBoxColumn.HeaderText = "Codigo Raza"
        Me.RAZCODIGORDataGridViewTextBoxColumn.Name = "RAZCODIGORDataGridViewTextBoxColumn"
        Me.RAZCODIGORDataGridViewTextBoxColumn.ReadOnly = True
        Me.RAZCODIGORDataGridViewTextBoxColumn.Visible = False
        '
        'ENFENFERMEDADDataGridViewTextBoxColumn1
        '
        Me.ENFENFERMEDADDataGridViewTextBoxColumn1.DataPropertyName = "ENF_ENFERMEDAD"
        Me.ENFENFERMEDADDataGridViewTextBoxColumn1.HeaderText = "Enfermedad"
        Me.ENFENFERMEDADDataGridViewTextBoxColumn1.Name = "ENFENFERMEDADDataGridViewTextBoxColumn1"
        Me.ENFENFERMEDADDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'RAZRAZADataGridViewTextBoxColumn
        '
        Me.RAZRAZADataGridViewTextBoxColumn.DataPropertyName = "RAZ_RAZA"
        Me.RAZRAZADataGridViewTextBoxColumn.HeaderText = "Raza"
        Me.RAZRAZADataGridViewTextBoxColumn.Name = "RAZRAZADataGridViewTextBoxColumn"
        Me.RAZRAZADataGridViewTextBoxColumn.ReadOnly = True
        '
        'Frm_Enfermedades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(414, 437)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Enfermedades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enfermedades"
        Me.TabControl1.ResumeLayout(False)
        Me.Tap1.ResumeLayout(False)
        Me.gb_Enfermedad.ResumeLayout(False)
        CType(Me.Datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ENFERMEDADESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Databases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPersonal.ResumeLayout(False)
        Me.gbPersonal.PerformLayout()
        Me.Tab2.ResumeLayout(False)
        Me.gb_Especie.ResumeLayout(False)
        CType(Me.Data_Intermedia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ENFERMEDADXRAZABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Tap1 As TabPage
    Friend WithEvents Regresar As Button
    Friend WithEvents Btn_Actualizar As Button
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Btn_Nuevo As Button
    Friend WithEvents gb_Enfermedad As GroupBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Datalistado As DataGridView
    Friend WithEvents gbPersonal As GroupBox
    Friend WithEvents Txt_Enfermedad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_Codigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Tab2 As TabPage
    Friend WithEvents Btn_Finalizar As Button
    Friend WithEvents Btn_Agregar As Button
    Friend WithEvents gb_Especie As GroupBox
    Friend WithEvents Btn_Quitar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Btn_Generar As Button
    Friend WithEvents Txt_CodigoR As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_R As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Txt_E As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_CodigoE As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Data_Intermedia As DataGridView
    Friend WithEvents Databases As databases
    Friend WithEvents ENFERMEDADESBindingSource As BindingSource
    Friend WithEvents ENFERMEDADESTableAdapter As databasesTableAdapters.ENFERMEDADESTableAdapter
    Friend WithEvents TableAdapterManager As databasesTableAdapters.TableAdapterManager
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents ENFCODIGOEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ENFENFERMEDADDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ENFERMEDADXRAZABindingSource As BindingSource
    Friend WithEvents ENFERMEDADXRAZATableAdapter As databasesTableAdapters.ENFERMEDADXRAZATableAdapter
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents ENFCODIGOEDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents RAZCODIGORDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ENFENFERMEDADDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents RAZRAZADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
