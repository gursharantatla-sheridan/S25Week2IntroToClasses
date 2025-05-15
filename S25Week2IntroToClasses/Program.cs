namespace S25Week2IntroToClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            Product p2 = new Product(101, "Keyboard", 30);

            p1.Id = 102;
            Console.WriteLine(p1.Id);
        }
    }
}
