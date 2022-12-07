namespace Person.MVC01.Models
{
    public class PersonEntity
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        public bool IsActive { get; set; }

        public DateTime DateRegistration { get; set; }
    }
}
