using System;
namespace DecoratorExercice
{
	public abstract class TopingDecorator: IPizza
	{
		protected IPizza _pizza;

		public TopingDecorator(IPizza pizza)
		{
			_pizza = pizza;
		}

		public abstract decimal GetCost();

		public abstract string GetDescription();
		
    }
}

