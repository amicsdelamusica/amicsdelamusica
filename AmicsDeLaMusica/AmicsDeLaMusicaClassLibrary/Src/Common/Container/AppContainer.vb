Namespace Common.Container

    Public Class AppContainer

        Private Shared _container As SimpleInjector.Container


        Public Shared Sub Initialize(pConfig As Config.AppConfig)
            _container = DefaultContainer.GetInstance(pConfig)
        End Sub


        Public Shared Function GetInstance() As SimpleInjector.Container
            Return _container
        End Function

    End Class

End Namespace

