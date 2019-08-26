Namespace Utils.Console

    Public Class ConsoleUtil

        Public Shared Function GetParameter(pParameter As Parameters)

            Return TorrecidClassLibrary.Util.Console.ConsoleUtil.
                GetParameter(My.Application.CommandLineArgs.ToArray, pParameter.ToString)

        End Function

    End Class

End Namespace
