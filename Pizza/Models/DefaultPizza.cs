using Pizza.Abstracts;

namespace Pizza.Models
{
    public class DefaultPizza : AbstractPizza
    {
        public override int GetAmountOfComponent()
        {
            return 0;
        }

        public override int GetCost()
        {
            return 10;
        }
    }
}
