using System.Text;

namespace _05._Builder.FlientInterface
{
    public class Burger
    {
        private int mSize;
        private bool mCheese;
        private bool mPepperoni;
        private bool mLettuce;
        private bool mTomato;

        public Burger(BurgerBuilder builder)
        {
            this.mSize = builder.Size;
            this.mCheese = builder.Cheese;
            this.mPepperoni = builder.Pepperoni;
            this.mLettuce = builder.Lettuce;
            this.mTomato = builder.Tomato;
        }

        public string GetDescription()
        {
            var sb = new StringBuilder();
            sb.Append($"This is {this.mSize} inch Burger. ");
            return sb.ToString();
        }
    }
}
