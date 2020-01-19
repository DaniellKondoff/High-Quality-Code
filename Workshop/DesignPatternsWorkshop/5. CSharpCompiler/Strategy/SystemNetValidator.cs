using CSharpCompiler.Exceptions;

namespace CSharpCompiler.Strategy
{
    public class SystemNetValidator : ICodeValidationStrategy
    {
        public void Validate(string code)
        {
            if (!code.Contains("using System.Net"))
                throw new CompilationException("Code does not contain using System.Net reference");
        }
    }
}
