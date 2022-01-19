namespace Wincubate.Labs04.Model
{
    class Developer
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public Amount Amount { get; init; }

        //public Person(string firstName, string lastName)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;    
        //}

        public string FullName => $"{FirstName} {LastName}";
        public override string ToString()
        {
            return $"{FullName} [{Amount}]";
        }
    }
}