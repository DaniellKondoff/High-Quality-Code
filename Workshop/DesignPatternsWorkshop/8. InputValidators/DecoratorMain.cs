using InputValidators.Decorators;

namespace InputValidaotrs
{
    public class DecoratorMain
    {
        public static void Main()
        {
            var validator = new AlphanumericValidator(
                new LengthValidator(0, 10,
                    new SimpleValidator()));

            System.Console.WriteLine(validator.Validate("a"));
        }
    }
}
