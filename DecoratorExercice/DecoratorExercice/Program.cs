namespace DecoratorExercice;
class Program
{
    static void Main(string[] args)
    {
        IPizza basicPizza = new TomatoSauce(new Mozzarella(new PlainPizza()));
        Console.WriteLine(basicPizza.GetDescription());
        Console.WriteLine(basicPizza.GetCost());

    }
}

