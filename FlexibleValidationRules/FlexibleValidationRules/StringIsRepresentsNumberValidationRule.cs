using System;

namespace FlexibleValidationRules
{
    public class StringIsRepresentsNumberValidationRule : ValidationRule
    {
        public override bool IsValid(object data)
        {
            string dataAsString = data as string;

            if (string.IsNullOrWhiteSpace(dataAsString))
            {
                return false;
            }

            foreach (Char c in dataAsString.ToCharArray())
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
