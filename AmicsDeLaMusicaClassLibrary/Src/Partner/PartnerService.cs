using System.Collections.Generic;
using System.Linq;
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

        public bool Validate()
        {
            return !(HasGap() || FindAllWithoutResponsibleMusician().Count() > 0);
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

        public IEnumerable<string> GetResponsibleMusicians()
        {
            return _repository.GetResponsibleMusicians();
        }

        void IPartnerService.Insert(Src.Partner.Partner pPartner)
        {

            pPartner.Id = _repository.GetNextId();
            _repository.Insert(pPartner);

        }

        void IPartnerService.Update(Src.Partner.Partner pPartner)
        {
            _repository.Update(pPartner);
        }

        public void UpdateID(Src.Partner.Partner pPartner, int pNewID)
        {
            _repository.UpdateID(pPartner, pNewID);
        }

        void IPartnerService.Delete(Src.Partner.Partner pPartner)
        {
            _repository.Delete(pPartner);
        }

        public IEnumerable<Src.Partner.Partner> FindAllWithoutResponsibleMusician()
        {
            return _repository.FindAllWithoutResponsibleMusician();
        }

        public bool HasGap()
        {
            return _repository.HasGap();
        }

        public Src.Partner.Partner MaxPartner()
        {
            return _repository.MaxPartner();
        }

        public int GetNextId()
        {
            return _repository.GetNextId();
        }

    }
}
