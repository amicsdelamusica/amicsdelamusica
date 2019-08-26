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
                    Id
                    FROM PARTNERS";

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

        #endregion


        private readonly DataBaseService _dbService;

        public PartnerRepository(DataBaseService pDbService)
        {
            _dbService = pDbService;
        }

        IEnumerable<Partner> IPartnerRepository.FindAll(Partner pPartner)
        {
            return _dbService.connection.Query<Partner, 
                Musician.Musician, Partner>(GetSQLFindAllPartners(), MapPartner, pPartner);
        }

        private Partner MapPartner(Partner pPartner, Musician.Musician pMusician)
        {
            pPartner.ResponsibleMusician = pMusician;

            return pPartner;

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
            throw new NotImplementedException();
        }

        void IPartnerRepository.Update(Partner pPartner)
        {
            throw new NotImplementedException();
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
    }
}
