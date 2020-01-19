namespace InputValidators.Decorators
{
    using InputValidators.Interfaces;

    public class SimpleValidator : IValidator
    {
        public bool Validate(string input)
        {
            return input != null;
        }
    }
}
