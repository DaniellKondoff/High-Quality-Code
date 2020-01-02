namespace _01.Facade
{
    class Customer
    {
        private string name;

        // Constructor

        public Customer(string name)
        {
            this.name = name;
        }

        // Gets the name

        public string Name
        {
            get { return name; }
        }
    }
}