namespace Builder
{
    public class PersonBuilder // facade 
    {
        // the object we're going to build
        protected Person Person = new(); // this is a reference!

        public PersonAddressBuilder Lives => new(Person);
        public PersonJobBuilder Works => new(Person);

        public static implicit operator Person(PersonBuilder pb)
        {
            return pb.Person;
        }
    }
}