using AmicsDeLaMusicaClassLibrary.Src.Musician;
using AmicsDeLaMusicaClassLibrary.Src.DataBase;
using AmicsDeLaMusicaClassLibrary.Src.Partner;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AmicsDeLaMusicaClassLibrary.Src.Partner
{
    class PartnerRepository : IPartnerRepository
    {

        #region "SQL"

        private string GetSQLFindAllPartners()
        {
            string query;

            query = @"SELECT 
                    Id, 
                    Name PartnerName, 
                    City, 
                    Street, 
                    StreetNumber, 
                    Email, 
                    Phone,
                    ResponsibleMusician
                    FROM 
                    PARTNERS
                    WHERE
                    Name LIKE '%' || :PartnerName || '%'
                    AND ResponsibleMusician LIKE '%' || :ResponsibleMusician || '%'
                    ORDER BY Id";

            return query;
        }

        private string GetSQLDeletePartner()
        {
            string query;

            query = @"DELETE FROM 
                    PARTNERS
                    WHERE 
                    Id = :Id";

            return query;

        }

        private string GetSQLCities()
        {
            string query;

            query = @"SELECT DISTINCT
                    TRIM(CITY)
                    FROM 
                    PARTNERS
                    WHERE
                    NOT (CITY IS NULL OR CITY = '')
                    ORDER BY CITY";

            return query;
        }

        private string GetSQLStreets()
        {
            string query;

            query = @"SELECT DISTINCT
                    STREET
                    FROM 
                    PARTNERS
                    WHERE
                    NOT (STREET IS NULL OR STREET = '')
                    ORDER BY STREET";

            return query;
        }

        private string GetSQLResponsibleMusicians()
        {
            string query;

            query = @"SELECT DISTINCT
                    RESPONSIBLEMUSICIAN
                    FROM 
                    PARTNERS
                    WHERE
                    NOT (RESPONSIBLEMUSICIAN IS NULL OR RESPONSIBLEMUSICIAN = '')
                    ORDER BY RESPONSIBLEMUSICIAN";

            return query;
        }

        private string GetNextIdSQL()
        {
            string query;

            query = @"SELECT  
                    MIN(id) + 1 NEXT_ID
                    FROM    
                    PARTNERS TABLE1
                    WHERE   
                    NOT EXISTS (
	                    SELECT  NULL
	                    FROM    
	                    PARTNERS TABLE2
	                    WHERE   TABLE2.id = TABLE1.id + 1
                    ) 
                    ";

            return query;
        }

        private string GetInsertSQL(Partner pPartner)
        {
            string query;

            query = $@"INSERT INTO [PARTNERS]
           ([Id]
           ,[Name]
           ,[City]
           ,[Street]
           ,[StreetNumber]
           ,[Email]
           ,[Phone]
           ,[ResponsibleMusician])
     VALUES
           (:Id,
           :PartnerName,
           :City,
           :Street,
           :StreetNumber,
           :Email,
           :Phone,
           :ResponsibleMusician
           );";

            return query;
        }

        private string GetUpdateSQL(Partner pPartner)
        {
            string query;

            query = $@"UPDATE [PARTNERS] 
                       SET 
                          [Name] = :PartnerName,
                          [City] = :City,
                          [Street] = :Street,
                          [StreetNumber] = :StreetNumber,
                          [Email] = :Email,
                          [Phone] = :Phone,
                          [ResponsibleMusician] = :ResponsibleMusician
                       WHERE 
                          Id =:Id;";

            return query;
        }

        #endregion


        private readonly DataBaseService _dbService;

        public PartnerRepository(DataBaseService pDbService)
        {
            _dbService = pDbService;
        }

        IEnumerable<Partner> IPartnerRepository.FindAll(Partner pPartner)
        {
            return _dbService.connection.Query<Partner>(GetSQLFindAllPartners(), pPartner);
        }

        Partner IPartnerRepository.Find(Partner pPartner)
        {
            throw new NotImplementedException();
        }

        bool IPartnerRepository.Exists(Partner pPartner)
        {
            throw new NotImplementedException();
        }

        void IPartnerRepository.Insert(Partner pPartner)
        {
            _dbService.connection.Execute(GetInsertSQL(pPartner), pPartner);
        }

        void IPartnerRepository.Update(Partner pPartner)
        {
            _dbService.connection.Execute(GetUpdateSQL(pPartner), pPartner);
        }

        void IPartnerRepository.Delete(Partner pPartner)
        {
            _dbService.connection.Execute(GetSQLDeletePartner(), pPartner);
        }

        IEnumerable<string> IPartnerRepository.GetCities()
        {
            return _dbService.connection.Query<string>(GetSQLCities());
        }

        IEnumerable<string> IPartnerRepository.GetStreets()
        {
            return _dbService.connection.Query<string>(GetSQLStreets());
        }

        IEnumerable<string> IPartnerRepository.GetResponsibleMusicians()
        {
            return _dbService.connection.Query<string>(GetSQLResponsibleMusicians());
        }

        public int GetNextId()
        {
            return _dbService.connection.Query<int>(GetNextIdSQL()).FirstOrDefault();
        }

    }
}
