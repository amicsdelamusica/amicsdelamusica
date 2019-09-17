using System.Collections.Generic;

namespace AmicsDeLaMusicaClassLibrary.Src.Partner
{
    public interface IPartnerService
    {

        Partner Find(Partner pPartner);
        bool Exists(Partner pPartner);
        IEnumerable<Partner> FindAll(Partner pPartner);

        IEnumerable<string> GetCities();
        IEnumerable<string> GetStreets();
        IEnumerable<string> GetResponsibleMusicians();

        void Insert(Partner pPartner);
        void Update(Partner pPartner);
        void Delete(Partner pPartner);

    }
}
