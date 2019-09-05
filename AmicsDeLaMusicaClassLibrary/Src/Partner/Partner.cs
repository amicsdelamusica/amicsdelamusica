using AmicsDeLaMusicaClassLibrary.Src.Musician;

namespace AmicsDeLaMusicaClassLibrary.Src.Partner
{
    public class Partner
    {
        public int Id { get; set; }

        public string PartnerName { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string StreetNumber { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public Musician.Musician ResponsibleMusician { get; set; }

        public override string ToString()
        {
            return $"{Id} - {PartnerName}";
        }

    }
}
