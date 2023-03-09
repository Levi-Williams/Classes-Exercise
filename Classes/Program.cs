namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var silverado = new Car()
            {
                Model = "Silverado",
                Make = "Chevrolet",
                Year = 2012
            };
            
            Console.WriteLine($"Here is the selected car model: {silverado.Model} and its make: {silverado.Make} and it is a {silverado.Year}");
        }
    }
}
