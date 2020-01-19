using InputValidators.Interfaces;

namespace InputValidators.Decorators
{
    public class LengthValidator : BaseDecorator
    {
        private readonly int minLenght;
        private readonly int maxLenght;
        public LengthValidator(IValidator validator) : base(validator) 
        {
        }

        public LengthValidator(int minLenght, int maxLenght, IValidator validator) : base(validator)
        {
            this.minLenght = minLenght;
            this.maxLenght = maxLenght;
        }

        public override bool Validate(string input)
        {
            if (this.validator.Validate(input))
            {
                return input.Length >= minLenght && input.Length <= maxLenght;
            }

            return false;
        }
    }
}
