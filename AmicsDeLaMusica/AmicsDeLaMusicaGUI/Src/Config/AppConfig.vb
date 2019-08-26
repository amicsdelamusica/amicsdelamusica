Imports AmicsDeLaMusicaClassLibrary.Common.Container
Imports AmicsDeLaMusicaGUI.Utils.Console

Namespace Config

    Public Class AppConfig

        Private Shared config As Object
        Private Shared classLibraryConfig As AmicsDeLaMusicaClassLibrary.Config.AppConfig


        Public Shared Function GetConfig() As Object
            Return config
        End Function

        Public Shared Function GetClassLibraryConfig() As AmicsDeLaMusicaClassLibrary.Config.AppConfig
            Return classLibraryConfig
        End Function


        Public Shared Sub SetupConfig()

            config = GetConfig(ConsoleUtil.GetParameter(Parameters.COMPANY))
            If config Is Nothing Then Throw New Exception("Configuration file not found. Please, call IT department")

            SetupClassLibraryConfig()

            AppContainer.Initialize(GetClassLibraryConfig)

        End Sub

        Private Shared Function GetConfig(parameter As String) As Object

            Select Case parameter

                Case "2"
                    Return SpainConfig.Default
                Case Else
                    Return Nothing

            End Select

        End Function

        Private Shared Sub SetupClassLibraryConfig()

            classLibraryConfig = New AmicsDeLaMusicaClassLibrary.Config.AppConfig
            With classLibraryConfig
                .CompanyCode = config.CompanyCode
            End With

        End Sub


    End Class

End Namespace
