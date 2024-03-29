﻿using Pizza.Abstracts;

namespace Pizza.Decorators
{
    public class PeperoniPizzaDecorator : PizzaDecorator
    {
        public PeperoniPizzaDecorator(AbstractPizza pizza) : base(pizza) { }

        public override int GetAmountOfComponent()
        {
            return _pizza.GetAmountOfComponent() + 1;
        }

        public override int GetCost()
        {
            return _pizza.GetCost() + 150;
        }
    }
}
