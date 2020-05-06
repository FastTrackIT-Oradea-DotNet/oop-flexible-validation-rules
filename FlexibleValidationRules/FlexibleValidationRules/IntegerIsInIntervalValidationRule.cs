namespace FlexibleValidationRules
{
    public class IntegerIsInIntervalValidationRule : ValidationRule
    {
        public IntegerIsInIntervalValidationRule(int from, int to)
        {
            this.From = from;
            this.To = to;
        }

        public int From { get; }

        public int To { get; }

        public override bool IsValid(object data)
        {
            if (data is int dataAsInt)
            {
                return (this.From <= dataAsInt) && (dataAsInt <= this.To);
            }

            return false;
        }
    }
}
