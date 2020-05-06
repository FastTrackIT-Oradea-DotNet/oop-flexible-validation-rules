namespace FlexibleValidationRules
{
    public class ValidationEngine
    {
        public ValidationEngine(ValidationRule[] rules)
        {
            this.Rules = rules ?? new ValidationRule[0];
        }

        public ValidationRule[] Rules { get; }

        public bool IsValid(object data)
        {
            foreach (ValidationRule rule in this.Rules)
            {
                if (rule is null)
                {
                    continue;
                }

                bool isValid = rule.IsValid(data);

                if (!isValid)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
