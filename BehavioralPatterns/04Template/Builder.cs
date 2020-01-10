namespace _04Template
{
    public abstract class Builder
    {
        public void Build()
        {
            Test();
            Lint();
            Assemble();
            Deploy();
        }

        abstract protected void Test();
        abstract protected void Lint();
        abstract protected void Assemble();
        abstract protected void Deploy();
    }
}
