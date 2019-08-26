<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStripApp = New System.Windows.Forms.MenuStrip()
        Me.ApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelCompanyName = New System.Windows.Forms.Label()
        Me.LabelAppName = New System.Windows.Forms.Label()
        Me.GBLogin = New System.Windows.Forms.GroupBox()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.TBPassword = New System.Windows.Forms.TextBox()
        Me.TBUsername = New System.Windows.Forms.TextBox()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.LabelUsuario = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStripApp.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GBLogin.SuspendLayout()
        Me.SuspendLayout()
        Me.AcceptButton = Me.ButtonLogin
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(12, 45)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 223)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'MenuStripApp
        '
        Me.MenuStripApp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplicationToolStripMenuItem})
        Me.MenuStripApp.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripApp.Name = "MenuStripApp"
        Me.MenuStripApp.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStripApp.Size = New System.Drawing.Size(635, 24)
        Me.MenuStripApp.TabIndex = 11
        Me.MenuStripApp.Text = "MenuStrip1"
        '
        'ApplicationToolStripMenuItem
        '
        Me.ApplicationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ApplicationToolStripMenuItem.Name = "ApplicationToolStripMenuItem"
        Me.ApplicationToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ApplicationToolStripMenuItem.Text = "Application"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelCompanyName)
        Me.GroupBox1.Controls.Add(Me.LabelAppName)
        Me.GroupBox1.Location = New System.Drawing.Point(157, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(466, 100)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'LabelCompanyName
        '
        Me.LabelCompanyName.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold)
        Me.LabelCompanyName.ForeColor = System.Drawing.Color.Gray
        Me.LabelCompanyName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelCompanyName.Location = New System.Drawing.Point(26, 13)
        Me.LabelCompanyName.Name = "LabelCompanyName"
        Me.LabelCompanyName.Size = New System.Drawing.Size(415, 32)
        Me.LabelCompanyName.TabIndex = 4
        Me.LabelCompanyName.Text = "TORRECID, S.A."
        Me.LabelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelAppName
        '
        Me.LabelAppName.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LabelAppName.ForeColor = System.Drawing.Color.Gray
        Me.LabelAppName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelAppName.Location = New System.Drawing.Point(26, 56)
        Me.LabelAppName.Name = "LabelAppName"
        Me.LabelAppName.Size = New System.Drawing.Size(415, 32)
        Me.LabelAppName.TabIndex = 3
        Me.LabelAppName.Text = "App Name"
        Me.LabelAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GBLogin
        '
        Me.GBLogin.Controls.Add(Me.ButtonExit)
        Me.GBLogin.Controls.Add(Me.ButtonLogin)
        Me.GBLogin.Controls.Add(Me.TBPassword)
        Me.GBLogin.Controls.Add(Me.TBUsername)
        Me.GBLogin.Controls.Add(Me.LabelPassword)
        Me.GBLogin.Controls.Add(Me.LabelUsuario)
        Me.GBLogin.Location = New System.Drawing.Point(157, 151)
        Me.GBLogin.Name = "GBLogin"
        Me.GBLogin.Size = New System.Drawing.Size(466, 117)
        Me.GBLogin.TabIndex = 13
        Me.GBLogin.TabStop = False
        '
        'ButtonExit
        '
        Me.ButtonExit.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ButtonExit.Image = CType(resources.GetObject("ButtonExit.Image"), System.Drawing.Image)
        Me.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonExit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonExit.Location = New System.Drawing.Point(288, 63)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(124, 37)
        Me.ButtonExit.TabIndex = 5
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ButtonLogin.Image = CType(resources.GetObject("ButtonLogin.Image"), System.Drawing.Image)
        Me.ButtonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonLogin.Location = New System.Drawing.Point(288, 20)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(124, 37)
        Me.ButtonLogin.TabIndex = 4
        Me.ButtonLogin.Text = "Accept"
        Me.ButtonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'TBPassword
        '
        Me.TBPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBPassword.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.TBPassword.Location = New System.Drawing.Point(99, 58)
        Me.TBPassword.MaxLength = 30
        Me.TBPassword.Name = "TBPassword"
        Me.TBPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBPassword.Size = New System.Drawing.Size(145, 26)
        Me.TBPassword.TabIndex = 3
        '
        'TBUsername
        '
        Me.TBUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBUsername.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.TBUsername.Location = New System.Drawing.Point(99, 26)
        Me.TBUsername.MaxLength = 15
        Me.TBUsername.Name = "TBUsername"
        Me.TBUsername.Size = New System.Drawing.Size(145, 26)
        Me.TBUsername.TabIndex = 2
        Me.TBUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        'LabelPassword
        '
        Me.LabelPassword.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.LabelPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelPassword.Location = New System.Drawing.Point(20, 62)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(73, 16)
        Me.LabelPassword.TabIndex = 1
        Me.LabelPassword.Text = "Password:"
        Me.LabelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelUsuario
        '
        Me.LabelUsuario.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.LabelUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelUsuario.Location = New System.Drawing.Point(33, 28)
        Me.LabelUsuario.Name = "LabelUsuario"
        Me.LabelUsuario.Size = New System.Drawing.Size(60, 16)
        Me.LabelUsuario.TabIndex = 0
        Me.LabelUsuario.Text = "User:"
        Me.LabelUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(635, 290)
        Me.Controls.Add(Me.GBLogin)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStripApp)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStripApp
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStripApp.ResumeLayout(False)
        Me.MenuStripApp.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GBLogin.ResumeLayout(False)
        Me.GBLogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStripApp As System.Windows.Forms.MenuStrip
    Friend WithEvents ApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelCompanyName As System.Windows.Forms.Label
    Friend WithEvents LabelAppName As System.Windows.Forms.Label
    Friend WithEvents GBLogin As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents ButtonLogin As System.Windows.Forms.Button
    Friend WithEvents TBPassword As System.Windows.Forms.TextBox
    Friend WithEvents TBUsername As System.Windows.Forms.TextBox
    Friend WithEvents LabelPassword As System.Windows.Forms.Label
    Friend WithEvents LabelUsuario As System.Windows.Forms.Label
End Class
