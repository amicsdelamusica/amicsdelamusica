Imports TorrecidClassLibrary.Database
Imports TorrecidClassLibrary.Security.Login
Imports TorrecidClassLibrary.Database.DatabaseService


Namespace Common.Container

    Public Class DefaultContainer

        Private Shared _container As SimpleInjector.Container

        Public Shared Function GetInstance(pConfig As Config.AppConfig) As SimpleInjector.Container
            Dim _dbService As DatabaseService

            If _container Is Nothing Then

                _dbService = New DatabaseService()
                _dbService.SetConnection(DatabaseConnection.FINANCE)

                _container = New SimpleInjector.Container

                With _container

                    .Options.AllowOverridingRegistrations = True

                    .RegisterSingleton(pConfig)
                    .RegisterSingleton(_dbService)

                    '.Register(Of IEntityRepository, EntityRepository)(Lifestyle.Singleton)
                    '.Register(Of IEntityService, EntityService)(Lifestyle.Singleton)

                End With

                SecurityUtil.RegisterInContainer(_container)

                _container.Verify()

            End If

            Return _container

        End Function


    End Class

End Namespace
