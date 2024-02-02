namespace GenericStacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var countries = new Stack<string>();

            countries.Push("Switzerland");
            countries.Push("Germany");
            countries.Push("Dubai");
            countries.Push("United States of America");

            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }

            var previouslyListedCountry = countries.Peek();
            Console.WriteLine($"The previously visited country was: {previouslyListedCountry}");

            var lastCountry = countries.Pop();

            Console.WriteLine($"Hello, {lastCountry}");

        }
    }
}