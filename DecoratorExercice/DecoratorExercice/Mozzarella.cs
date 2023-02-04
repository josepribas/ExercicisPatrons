using System;
namespace DecoratorExercice
{
	public class Mozzarella: TopingDecorator
	{
        public Mozzarella(IPizza pizza) : base(pizza)
        {
            Console.WriteLine("Afegint base");

            Console.WriteLine("Afegint Mozzarella");
        }

        public override decimal GetCost()
        {
            return _pizza.GetCost() + 2.0M;
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription() + ", mozzarella";
        }
    }
}

