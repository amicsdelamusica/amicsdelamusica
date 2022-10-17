using AmicsDeLaMusicaClassLibrary.Src.Musician;
using Google.Cloud.Firestore;

namespace AmicsDeLaMusicaClassLibrary.Src.Partner
{
    [FirestoreData]
    public class Partner
    {
        [FirestoreProperty]
        public int Id { get; set; }

        [FirestoreProperty]
        public string PartnerName { get; set; }

        [FirestoreProperty]
        public string City { get; set; }

        [FirestoreProperty]
        public string Street { get; set; }

        [FirestoreProperty]
        public string StreetNumber { get; set; }

        [FirestoreProperty]
        public string Email { get; set; }

        [FirestoreProperty]
        public string Phone { get; set; }

        [FirestoreProperty]
        public string ResponsibleMusician { get; set; }

        public override string ToString()
        {
            return $"{Id} - {PartnerName}";
        }

    }
}
