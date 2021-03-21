<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Login))
        Me.Btn_Ingresar = New System.Windows.Forms.Button()
        Me.Txt_Contraseña = New System.Windows.Forms.TextBox()
        Me.Txt_Usuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Databases = New Proyecto.databases()
        Me.USUARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USUARIOSTableAdapter = New Proyecto.databasesTableAdapters.USUARIOSTableAdapter()
        Me.TableAdapterManager = New Proyecto.databasesTableAdapters.TableAdapterManager()
        Me.USU_USUARIOLabel1 = New System.Windows.Forms.Label()
        Me.USU_CONTRASEÑALabel1 = New System.Windows.Forms.Label()
        Me.USU_TIPOLabel1 = New System.Windows.Forms.Label()
        Me.Tip_Login = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Databases, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USUARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Ingresar
        '
        Me.Btn_Ingresar.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_Ingresar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Ingresar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_Ingresar.Location = New System.Drawing.Point(197, 65)
        Me.Btn_Ingresar.Name = "Btn_Ingresar"
        Me.Btn_Ingresar.Size = New System.Drawing.Size(83, 35)
        Me.Btn_Ingresar.TabIndex = 17
        Me.Btn_Ingresar.Text = "Ingresar"
        Me.Tip_Login.SetToolTip(Me.Btn_Ingresar, "Presione para autentificar su usuario")
        Me.Btn_Ingresar.UseVisualStyleBackColor = False
        '
        'Txt_Contraseña
        '
        Me.Txt_Contraseña.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Contraseña.Location = New System.Drawing.Point(253, 33)
        Me.Txt_Contraseña.Name = "Txt_Contraseña"
        Me.Txt_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.Txt_Contraseña.Size = New System.Drawing.Size(100, 26)
        Me.Txt_Contraseña.TabIndex = 15
        Me.Tip_Login.SetToolTip(Me.Txt_Contraseña, "Ingrese su contraseña en este campo")
        '
        'Txt_Usuario
        '
        Me.Txt_Usuario.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Usuario.Location = New System.Drawing.Point(133, 33)
        Me.Txt_Usuario.Name = "Txt_Usuario"
        Me.Txt_Usuario.Size = New System.Drawing.Size(100, 26)
        Me.Txt_Usuario.TabIndex = 14
        Me.Tip_Login.SetToolTip(Me.Txt_Usuario, "Ingrese su usuario en este campo")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(251, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Contraseña:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(150, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Usuario:"
        '
        'Databases
        '
        Me.Databases.DataSetName = "databases"
        Me.Databases.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'USUARIOSBindingSource
        '
        Me.USUARIOSBindingSource.DataMember = "USUARIOS"
        Me.USUARIOSBindingSource.DataSource = Me.Databases
        '
        'USUARIOSTableAdapter
        '
        Me.USUARIOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AUDITORIASTableAdapter = Nothing
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
        Me.TableAdapterManager.USUARIOSTableAdapter = Me.USUARIOSTableAdapter
        '
        'USU_USUARIOLabel1
        '
        Me.USU_USUARIOLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOSBindingSource, "USU_USUARIO", True))
        Me.USU_USUARIOLabel1.Location = New System.Drawing.Point(561, 16)
        Me.USU_USUARIOLabel1.Name = "USU_USUARIOLabel1"
        Me.USU_USUARIOLabel1.Size = New System.Drawing.Size(100, 23)
        Me.USU_USUARIOLabel1.TabIndex = 19
        Me.USU_USUARIOLabel1.Text = "Label3"
        '
        'USU_CONTRASEÑALabel1
        '
        Me.USU_CONTRASEÑALabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOSBindingSource, "USU_CONTRASEÑA", True))
        Me.USU_CONTRASEÑALabel1.Location = New System.Drawing.Point(561, 39)
        Me.USU_CONTRASEÑALabel1.Name = "USU_CONTRASEÑALabel1"
        Me.USU_CONTRASEÑALabel1.Size = New System.Drawing.Size(100, 23)
        Me.USU_CONTRASEÑALabel1.TabIndex = 20
        Me.USU_CONTRASEÑALabel1.Text = "Label3"
        '
        'USU_TIPOLabel1
        '
        Me.USU_TIPOLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOSBindingSource, "USU_TIPO", True))
        Me.USU_TIPOLabel1.Location = New System.Drawing.Point(548, 64)
        Me.USU_TIPOLabel1.Name = "USU_TIPOLabel1"
        Me.USU_TIPOLabel1.Size = New System.Drawing.Size(100, 23)
        Me.USU_TIPOLabel1.TabIndex = 21
        Me.USU_TIPOLabel1.Text = "Label3"
        '
        'Tip_Login
        '
        Me.Tip_Login.BackColor = System.Drawing.Color.White
        Me.Tip_Login.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Tip_Login.ToolTipTitle = "Informacion"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto.My.Resources.Resources.Login
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(390, 116)
        Me.Controls.Add(Me.USU_TIPOLabel1)
        Me.Controls.Add(Me.USU_CONTRASEÑALabel1)
        Me.Controls.Add(Me.USU_USUARIOLabel1)
        Me.Controls.Add(Me.Btn_Ingresar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Txt_Contraseña)
        Me.Controls.Add(Me.Txt_Usuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar sesión"
        CType(Me.Databases, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USUARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Ingresar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Txt_Contraseña As TextBox
    Friend WithEvents Txt_Usuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Databases As databases
    Friend WithEvents USUARIOSBindingSource As BindingSource
    Friend WithEvents USUARIOSTableAdapter As databasesTableAdapters.USUARIOSTableAdapter
    Friend WithEvents TableAdapterManager As databasesTableAdapters.TableAdapterManager
    Friend WithEvents USU_USUARIOLabel1 As Label
    Friend WithEvents USU_CONTRASEÑALabel1 As Label
    Friend WithEvents USU_TIPOLabel1 As Label
    Friend WithEvents Tip_Login As ToolTip
End Class
