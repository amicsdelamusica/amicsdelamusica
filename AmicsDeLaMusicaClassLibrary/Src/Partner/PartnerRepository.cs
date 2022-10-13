using AmicsDeLaMusicaClassLibrary.Src.DataBase;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AmicsDeLaMusicaClassLibrary.Src.Partner
{
    public class PartnerRepository : IPartnerRepository
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

        private string GetMaxSQL()
        {
            string query;

            query = @"
                    SELECT
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
                    Id = (
                        SELECT 
                        MAX(Id)
                        FROM 
                        PARTNERS
                    )";

            return query;
        }

        private string GetPartnerWithoutResponsibleMusicianSQL()
        {
            string query;

            query = @"SELECT 
                    Id, 
                    Name PartnerName
                    FROM 
                    PARTNERS
                    WHERE
                    RESPONSIBLEMUSICIAN IS NULL OR RESPONSIBLEMUSICIAN = ''";

            return query;
        }

        private string GetInsertSQL()
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

        private string GetUpdateSQL()
        {
            string query;

            query = $@"UPDATE [PARTNERS] 
                       SET 
                          [Id] = :Id,
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

        private string GetUpdateIDSQL(int pNewID)
        {
            string query;

            query = $@"UPDATE [PARTNERS] 
                       SET 
                          [Id] = {pNewID}
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
            _dbService.connection.Execute(GetInsertSQL(), pPartner);
        }

        void IPartnerRepository.Update(Partner pPartner)
        {
            _dbService.connection.Execute(GetUpdateSQL(), pPartner);
        }

        public void UpdateID(Partner pPartner, int pNewID)
        {
            _dbService.connection.Execute(GetUpdateIDSQL(pNewID), pPartner);
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

        public bool HasGap()
        {
           return GetNextId() - 1 != MaxPartner().Id;
        }

        public IEnumerable<Partner> FindAllWithoutResponsibleMusician()
        {
          return _dbService.connection.Query<Partner>(GetPartnerWithoutResponsibleMusicianSQL());
        }

        public Partner MaxPartner()
        {
            return _dbService.connection.Query<Partner>(GetMaxSQL()).FirstOrDefault();
        }

    }
}
