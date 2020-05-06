using System;

namespace FlexibleValidationRules
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidationEngine validationEngine = new ValidationEngine(new ValidationRule[] 
            {
                new PersonlValidationRule()
            });

            PersonListProcessor processor = new PersonListProcessor(validationEngine);

            processor.Process(new[]
            {
                new Person
                {
                    FirstName = "John",
                    LastName = "Doe",
                    CNP = "123433443",
                    DateOfBirth = new DateTime(1980, 1, 20)
                },
                new Person
                {
                    FirstName = "Johnny",
                    LastName = "Deep",
                    CNP = "",
                    DateOfBirth = new DateTime(1976, 5, 20)
                }
            });
        }
    }
}
