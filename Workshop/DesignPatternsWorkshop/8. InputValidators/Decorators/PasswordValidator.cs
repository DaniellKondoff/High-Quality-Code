using InputValidators.Interfaces;
using System.Linq;

namespace InputValidators.Decorators
{
    public class PasswordValidator : BaseDecorator
    {
        public PasswordValidator(IValidator validator) : base(validator)
        {
        }

        public override bool Validate(string input)
        {
            if (this.validator.Validate(input))
            {
                return input.Any(c => !char.IsDigit(c) && !char.IsLetter(c));
            }

            return false;
        }
    }
}
