using InputValidators.Interfaces;
using System.Linq;

namespace InputValidators.Decorators
{
    public class AlphanumericValidator : BaseDecorator
    {
        public AlphanumericValidator(IValidator validator) : base(validator)
        {
        }

        public override bool Validate(string input)
        {
            if (this.validator.Validate(input))
            {
                return input.All(c => char.IsLetterOrDigit(c));
            }

            return false;
        }
    }
}
