using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmicsDeLaMusicaClassLibrary.Src.Partner
{
    public class PartnerFirebaseRepository : IPartnerRepository
    {
        private const string FIREBASE_CONFIGURATION_FILE = "firebase.json";
        private const string PROJECT_ID = "amicsdelamusica-df31d";

        private const string PARTNERS_PATH = "partners";

        private const string ID_FIELD_NAME = "Id";
        private const string RESPONSIBLE_MUSICIAN_FIELD_NAME = "ResponsibleMusician";
        private const string CITY_FIELD_NAME = "City";
        private const string STREET_FIELD_NAME = "Street";

        readonly CollectionReference collection;
      
        public PartnerFirebaseRepository() 
        {

            FirestoreDb db;

            StreamReader r = new StreamReader(FIREBASE_CONFIGURATION_FILE);
            string json = r.ReadToEnd();

            db = new FirestoreDbBuilder
            {
                ProjectId = PROJECT_ID,
                JsonCredentials = json
            }.Build();

            r.Dispose();

            collection = db.Collection(PARTNERS_PATH);

        }

        public void Delete(Partner pPartner)
        {
            DocumentReference documentReference = FindDocumentReferenceByParnerId(pPartner.Id);

           var _ = documentReference.DeleteAsync().Result;
        }

        public IEnumerable<Partner> FindAll(Partner pPartner)
        {

            IEnumerable<Partner> results;
            
            QuerySnapshot snapshot = collection.
                OrderBy(ID_FIELD_NAME).
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

            QuerySnapshot snapshot = collection.
                OrderBy(ID_FIELD_NAME).
                WhereEqualTo(RESPONSIBLE_MUSICIAN_FIELD_NAME, string.Empty).
                GetSnapshotAsync().Result;

            return snapshot.Documents.ToList().Select(doc => doc.ConvertTo<Partner>()).ToList();

        }

        public IEnumerable<string> GetCities()
        {

            QuerySnapshot snapshot = collection.
                Select(CITY_FIELD_NAME).
                GetSnapshotAsync().Result;

            return snapshot.Documents.ToList().Select(doc => doc.ConvertTo<Partner>().City).Distinct().ToList();

        }

        public int GetNextId()
        {
            IEnumerable<int> ids;
            QuerySnapshot snapshot = collection.
                Select(ID_FIELD_NAME).
                OrderBy(ID_FIELD_NAME).
                GetSnapshotAsync().Result;

            ids = snapshot.Documents.ToList().Select(doc => doc.ConvertTo<Partner>().Id).Distinct().ToList();

            return ids.FirstOrDefault(id => !ids.Contains(id + 1)) + 1;
        }

        public IEnumerable<string> GetResponsibleMusicians()
        {

            QuerySnapshot snapshot = collection.
                Select(RESPONSIBLE_MUSICIAN_FIELD_NAME).GetSnapshotAsync().Result;

            return snapshot.Documents.ToList().Select(doc => doc.ConvertTo<Partner>().ResponsibleMusician).Distinct().ToList();
        }

        public IEnumerable<string> GetStreets()
        {
 
            QuerySnapshot snapshot = collection.
                Select(STREET_FIELD_NAME).GetSnapshotAsync().Result;

            return snapshot.Documents.ToList().Select(doc => doc.ConvertTo<Partner>().Street).Distinct().ToList();
        }

        public void Insert(Partner pPartner)
        {
            var _ = collection.AddAsync(pPartner).Result;
        }

        public Partner MaxPartner()
        {
            QuerySnapshot snapshot = collection.
               OrderByDescending(ID_FIELD_NAME).
               Limit(1).
               GetSnapshotAsync().Result;

            return snapshot.Documents.ToList().Select(doc => doc.ConvertTo<Partner>()).FirstOrDefault();
        }

        private DocumentReference FindDocumentReferenceByParnerId(int id) 
        { 
            string documentId;

            QuerySnapshot snapshot = collection.
              WhereEqualTo(ID_FIELD_NAME, id).
              Limit(1).
              GetSnapshotAsync().Result;

            documentId = snapshot.Documents.FirstOrDefault().Id;

            return collection.Document(documentId);
        }

        public void Update(Partner pPartner)
        {

            DocumentReference documentReference = FindDocumentReferenceByParnerId(pPartner.Id);
            var _ = documentReference.SetAsync(pPartner).Result;

        }

        public void UpdateID(Partner pPartner, int pNewID)
        {
            DocumentReference documentReference = FindDocumentReferenceByParnerId(pPartner.Id);
            pPartner.Id = pNewID;
            var _ = documentReference.SetAsync(pPartner).Result;
        }
    }
}
