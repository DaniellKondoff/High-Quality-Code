namespace _06.Prototype
{
    public class Sheep
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public Sheep(string name, string category)
        {
            Name = name;
            Category = category;
        }

        public Sheep Clone()
        {
            return MemberwiseClone() as Sheep;
        }
    }
}
