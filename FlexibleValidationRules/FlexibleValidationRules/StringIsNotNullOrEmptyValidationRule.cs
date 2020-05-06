namespace FlexibleValidationRules
{
    public class StringIsNotNullOrEmptyValidationRule : ValidationRule
    {
        public override bool IsValid(object data)
        {
            string dataAsString = data as string;

            if (dataAsString is null)
            {
                return false;
            }

            return !string.IsNullOrEmpty(dataAsString);
        }
    }
}
