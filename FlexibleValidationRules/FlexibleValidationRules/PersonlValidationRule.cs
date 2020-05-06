namespace FlexibleValidationRules
{
    public class PersonlValidationRule : ValidationRule
    {
        private readonly ValidationRule stringIsNotNullOrEmptyRule = new StringIsNotNullOrEmptyValidationRule();
        private readonly ValidationRule stringRepresentsNumberRule = new StringIsRepresentsNumberValidationRule();
        private readonly ValidationRule numberIsInIntervalRule = new IntegerIsInIntervalValidationRule(18, 120);

        public override bool IsValid(object data)
        {
            Person p = data as Person;

            if (p is null)
            {
                return false;
            }

            return stringIsNotNullOrEmptyRule.IsValid(p.FirstName) &&
                   stringIsNotNullOrEmptyRule.IsValid(p.LastName) &&
                   stringRepresentsNumberRule.IsValid(p.CNP) &&
                   numberIsInIntervalRule.IsValid(p.Age);
        }
    }
}
