namespace IntroTillOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            Console.WriteLine($"Cirkel #1 har Omkretsen: {circle1.Circumference()}");
            Console.WriteLine($"Cirkel #2 har Omkretsen: {circle2.Circumference()}\n");

            Console.WriteLine($"Cirkel #1 har Arean: {circle1.GetArea()}");
            Console.WriteLine($"Cirkel #2 har Arean: {circle2.GetArea()}\n");

            Console.WriteLine($"Cirkel #1 har Volymen: {circle1.Volumme()}");
            Console.WriteLine($"Cirkel #2 har Volymen: {circle2.Volumme()}\n");

            Console.ReadKey();

        }
    }
}
