using System;

namespace FlexibleValidationRules
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CNP { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get
            {
                return DateTime.Today.Year - DateOfBirth.Year;
            }
        }
    }
}
