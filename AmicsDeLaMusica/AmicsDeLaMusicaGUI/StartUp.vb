Imports AmicsDeLaMusicaClassLibrary.Common.Container
Imports AmicsDeLaMusicaGUI.Config
Imports AmicsDeLaMusicaGUI.Utils.Console

Public Class StartUp

    Shared Sub Main(cmdArgs() As String)

        Dim _loginForm As FormLogin

        Try

            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            AppConfig.SetupConfig()
            Utils.Setup.SetupApp.SetupOracle()

            _loginForm = AppContainer.GetInstance.GetInstance(Of FormLogin)
            _loginForm.SetUser(ConsoleUtil.GetParameter(Parameters.USERNAME))
            Application.Run(_loginForm)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class
