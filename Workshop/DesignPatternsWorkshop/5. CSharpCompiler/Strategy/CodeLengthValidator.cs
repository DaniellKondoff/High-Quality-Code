using CSharpCompiler.Exceptions;

namespace CSharpCompiler.Strategy
{
    public class CodeLengthValidator : ICodeValidationStrategy
    {
        public void Validate(string code)
        {
            if (code.Length < 20)
                throw new CompilationException("The code lenght should not be less than 20 symbols");
        }
    }
}
