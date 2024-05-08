namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carOne = new Cars();

            carOne.Make = "Ford";
            carOne.Model = "F-150";
            carOne.Year = 2004;

            Console.WriteLine($"My first car was a {carOne.Year} {carOne.Make} {carOne.Model}");
        }
    }
}
