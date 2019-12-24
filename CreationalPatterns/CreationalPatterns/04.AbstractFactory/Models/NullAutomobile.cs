namespace _04.AbstractFactory.Models
{
    public class NullAutomobile : IAutomobile
    {
        public string Name
        {
            get { return string.Empty; }
        }

        public void TurnOff()
        {
            
        }

        public void TurnOn()
        {
           
        }
    }
}
