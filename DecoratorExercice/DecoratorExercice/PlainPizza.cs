using System;
namespace DecoratorExercice
{
	public class PlainPizza: IPizza
	{
        public decimal GetCost()
        {
            return 4.0M;
        }

        public string GetDescription()
        {
            return "Massa de pizza";
        }
    }
}

