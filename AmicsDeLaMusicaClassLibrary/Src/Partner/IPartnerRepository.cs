using System.Collections.Generic;

namespace AmicsDeLaMusicaClassLibrary.Src.Partner
{
    public interface IPartnerRepository
    {

        Partner Find(Partner pPartner);
        bool Exists(Partner pPartner);
        IEnumerable<Partner> FindAll(Partner pPartner);
        int GetNextId();

        bool HasGap();
        IEnumerable<Partner> FindAllWithoutResponsibleMusician();
        Partner MaxPartner();

        IEnumerable<string> GetCities();
        IEnumerable<string> GetStreets();
        IEnumerable<string> GetResponsibleMusicians();

        void Insert(Partner pPartner);
        void Update(Partner pPartner);
        void UpdateID(Partner pPartner, int pNewID);
        void Delete(Partner pPartner);

    }
}
