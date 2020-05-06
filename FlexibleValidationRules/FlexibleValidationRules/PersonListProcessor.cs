using System;

namespace FlexibleValidationRules
{
    public class PersonListProcessor
    {
        public PersonListProcessor(ValidationEngine validationEngine)
        {
            this.ValidationEngine = validationEngine;
        }

        public ValidationEngine ValidationEngine { get; }

        public void Process(Person[] persons)
        {
            foreach (Person p in persons ?? new Person[0])
            {
                bool isValid = ValidationEngine.IsValid(p);

                if (isValid)
                {
                    // scriu datele persoanei
                    Console.WriteLine($"{p.FirstName} {p.LastName}");
                }
                else
                {
                    // loghez o eroare in consola
                    Console.WriteLine($"Eroare de validare pentru: {p.FirstName} {p.LastName}");
                }
            }
        }
    }
}
