Imports AmicsDeLaMusicaGUI.Config
Imports AmicsDeLaMusicaGUI.Utils.Security
Imports TorrecidClassLibrary.Security.Login
Imports TorrecidClassLibrary.Security.SingleSignOn
Imports TorrecidClassLibrary.Security.UsersManagement.UserPrograms
Imports TorrecidClassLibrary.Security.UsersManagement.Program

Public Class FormLogin


    Private _securityService As ISecurityService
    Private _singleSignOnService As ISingleSignOnService
    Private _user As String

    
    Public Sub New(pSecurityService As ISecurityService, pSingleSignOnService As ISingleSignOnService)

        InitializeComponent()

        _securityService = pSecurityService
        _singleSignOnService = pSingleSignOnService

    End Sub

    Public Sub SetUser(value As String)
        _user = value
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Close()
    End Sub


    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click

        Me.Cursor = Cursors.WaitCursor
        Application.DoEvents()

        Try

            Login.CurrentUser = _securityService.Login(AppConfig.GetConfig.CompanyCode, TBUsername.Text, TBPassword.Text, AppConfig.GetConfig.AppCode)
            SetupSecurityAccess()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            TBPassword.Focus()
            TBPassword.SelectAll()
        End Try

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub SetupSecurityAccess()
        'BaseToolStripMenuItem.Enabled = True

        'Dim _form As FormEntityList = AppContainer.GetInstance.GetInstance(Of FormEntityList)()
        '_form.ShowDialog()

    End Sub


    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            SetupForm()
            SingleSignOn()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Close()
        End Try

    End Sub

    Private Sub SetupForm()
        Text = AppConfig.GetConfig.CompanyName
        LabelCompanyName.Text = AppConfig.GetConfig.CompanyName
        LabelAppName.Text = AppConfig.GetConfig.AppName
        PictureBox1.ImageLocation = AppConfig.GetConfig.CompanyLogoLocation
    End Sub

     Private Sub SingleSignOn()

        Dim _userQuery As UserPrograms

        If _user Is Nothing Then Return

        TBUsername.Text = _user

        If _singleSignOnService.HasActiveSession(_user) Then

            _userQuery = New UserPrograms With {
                .CompanyCode = AppConfig.GetConfig.CompanyCode,
                .Username = _user,
                .Program = New Program With {
                    .Code = AppConfig.GetConfig.AppCode
                }
            }

            GBLogin.Enabled = False
            Login.CurrentUser = _securityService.LoginByName(_userQuery)
            SetupSecurityAccess()
        End If

    End Sub

    Private Sub FormLogin_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If TBUsername.Text.Trim.Length > 0 AndAlso Login.CurrentUser Is Nothing Then
            TBPassword.Focus()
        End If
    End Sub

End Class
