
Namespace Utils.Setup

    Public Class SetupApp

        Private Const ENVIRONMENT_VARIABLE_TNS_ADMIN As String = "TNS_ADMIN"

        Public Shared Sub SetupOracle()
            Environment.SetEnvironmentVariable(ENVIRONMENT_VARIABLE_TNS_ADMIN, Config.AppConfig.GetConfig.TNS_ADMIN, EnvironmentVariableTarget.Process)
        End Sub

    End Class

End Namespace
