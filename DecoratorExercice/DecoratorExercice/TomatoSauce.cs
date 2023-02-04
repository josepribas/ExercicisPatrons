using System;
namespace DecoratorExercice
{
    public class TomatoSauce : TopingDecorator
    {
        public TomatoSauce(IPizza pizza) : base(pizza)
        {
            Console.WriteLine("Afegint base");

            Console.WriteLine("Afegint Tomato Sauce");
        }

        public override decimal GetCost()
        {
            return _pizza.GetCost() + .5M;
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription() + ", tomate sauce";
        }
    }
}

