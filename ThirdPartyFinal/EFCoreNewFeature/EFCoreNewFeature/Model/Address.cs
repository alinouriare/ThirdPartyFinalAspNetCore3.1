namespace EFCoreNewFeature.Model
{
    public class Address
    {

        public int Id { get; set; }
         
        public string PhoneNumber { get; set; }

        public int PersonId { get; set; }
        public Person  Person { get; set; }

    }
}
