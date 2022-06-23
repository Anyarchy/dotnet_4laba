using Pizza.Decorators;
using Pizza.Models;
using System;

namespace Pizza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DefaultPizza dp = new DefaultPizza();
            Console.WriteLine(dp.GetAmountOfComponent());
            var beckonCheesePizza = new BeckonPizzaDecorator(new CheesePizzaDecorator(new DefaultPizza()));
            Console.WriteLine(beckonCheesePizza.GetAmountOfComponent());
            Console.WriteLine(beckonCheesePizza.GetCost());
            var beckonCheesePeperoniPizza = new BeckonPizzaDecorator(new CheesePizzaDecorator(new PeperoniPizzaDecorator(new DefaultPizza())));
            Console.WriteLine(beckonCheesePeperoniPizza.GetAmountOfComponent());
            Console.WriteLine(beckonCheesePeperoniPizza.GetCost());
        }
    }
}
