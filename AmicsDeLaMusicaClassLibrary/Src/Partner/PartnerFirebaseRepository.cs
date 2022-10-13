using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmicsDeLaMusicaClassLibrary.Src.Partner
{
    public class PartnerFirebaseRepository : IPartnerRepository
    {
        private const string PARTNERS_PATH = "partners";
        FirestoreDb db;
        CollectionReference collection;
      
        public PartnerFirebaseRepository() 
        {

            StreamReader r = new StreamReader("firebase.json");
            string json = r.ReadToEnd();

            db = new FirestoreDbBuilder
            {
                ProjectId = "amicsdelamusica-df31d",
                JsonCredentials = json
            }.Build();

            r.Dispose();

            collection = db.Collection(PARTNERS_PATH);

        }

        public void Delete(Partner pPartner)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Partner pPartner)
        {
            throw new NotImplementedException();
        }

        public Partner Find(Partner pPartner)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Partner> FindAll(Partner pPartner)
        {

            IEnumerable<Partner> results;
            
            QuerySnapshot snapshot = collection.
                OrderBy("Id").
                GetSnapshotAsync().Result;



            results = snapshot.Documents.ToList().Select(doc => doc.ConvertTo<Partner>()).ToList();

            if (!string.IsNullOrWhiteSpace(pPartner.ResponsibleMusician))
                results = results.Where(r => r.ResponsibleMusician.ToUpper().Contains(pPartner.ResponsibleMusician.ToUpper())).ToList();


            if (!string.IsNullOrWhiteSpace(pPartner.PartnerName))
                results = results.Where(r => r.PartnerName.ToUpper().Contains(pPartner.PartnerName.ToUpper())).ToList();

            return results;
            
        }

        public IEnumerable<Partner> FindAllWithoutResponsibleMusician()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetCities()
        {

            QuerySnapshot snapshot = collection.
                Select("City").
                GetSnapshotAsync().Result;

            return snapshot.Documents.ToList().Select(doc => doc.ConvertTo<Partner>().City).Distinct().ToList();

        }

        public int GetNextId()
        {
            IEnumerable<int> ids;
            QuerySnapshot snapshot = collection.
                Select("Id").
                OrderBy("Id").
                GetSnapshotAsync().Result;

            ids = snapshot.Documents.ToList().Select(doc => doc.ConvertTo<Partner>().Id).Distinct().ToList();

            return ids.FirstOrDefault(id => !ids.Contains(id + 1)) + 1;
        }

        public IEnumerable<string> GetResponsibleMusicians()
        {

            CollectionReference partnerReference = db.Collection(PARTNERS_PATH);
            QuerySnapshot snapshot = partnerReference.
                Select("ResponsibleMusician").GetSnapshotAsync().Result;

            return snapshot.Documents.ToList().Select(doc => doc.ConvertTo<Partner>().ResponsibleMusician).Distinct().ToList();
        }

        public IEnumerable<string> GetStreets()
        {
            CollectionReference partnerReference = db.Collection(PARTNERS_PATH);
            QuerySnapshot snapshot = partnerReference.
                Select("Street").GetSnapshotAsync().Result;

            return snapshot.Documents.ToList().Select(doc => doc.ConvertTo<Partner>().Street).Distinct().ToList();
        }

        public bool HasGap()
        {
            throw new NotImplementedException();
        }

        public void Insert(Partner pPartner)
        {
            var _ = collection.AddAsync(pPartner).Result;
        }

        public Partner MaxPartner()
        {
            throw new NotImplementedException();
        }

        public void Update(Partner pPartner)
        {
            throw new NotImplementedException();
        }

        public void UpdateID(Partner pPartner, int pNewID)
        {
            throw new NotImplementedException();
        }
    }
}
