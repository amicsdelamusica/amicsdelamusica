using System.Collections.Generic;
using AmicsDeLaMusicaClassLibrary.Src.Partner;

namespace AmicsDeLaMusicaClassLibrary.src.Partner
{
    class PartnerService : IPartnerService
    {

        private readonly IPartnerRepository _repository;

        public PartnerService(IPartnerRepository pRepository)
        {
            _repository = pRepository;
        }

        public bool Exists(Src.Partner.Partner pPartner)
        {
            throw new System.NotImplementedException();
        }

        public Src.Partner.Partner Find(Src.Partner.Partner pPartner)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Src.Partner.Partner> FindAll(Src.Partner.Partner pPartner)
        {
            return _repository.FindAll(pPartner);
        }

        public void Insert(Src.Partner.Partner pPartner)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Src.Partner.Partner pPartner)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Src.Partner.Partner pPartner)
        {
            _repository.Delete(pPartner);
        }

        Src.Partner.Partner IPartnerService.Find(Src.Partner.Partner pPartner)
        {
            throw new System.NotImplementedException();
        }

        bool IPartnerService.Exists(Src.Partner.Partner pPartner)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<Src.Partner.Partner> IPartnerService.FindAll(Src.Partner.Partner pPartner)
        {
            return _repository.FindAll(pPartner);
        }

        IEnumerable<string> IPartnerService.GetCities()
        {
            return _repository.GetCities();
        }

        IEnumerable<string> IPartnerService.GetStreets()
        {
            return _repository.GetStreets();
        }

        void IPartnerService.Insert(Src.Partner.Partner pPartner)
        {
            throw new System.NotImplementedException();
        }

        void IPartnerService.Update(Src.Partner.Partner pPartner)
        {
            throw new System.NotImplementedException();
        }

        void IPartnerService.Delete(Src.Partner.Partner pPartner)
        {
            throw new System.NotImplementedException();
        }
    }
}
