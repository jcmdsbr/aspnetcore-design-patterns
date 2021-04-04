using static System.Console;

namespace Singleton
{
    public class Demo
    {
        private static void Main()
        {
            var db = SingletonDatabase.Instance;

            // works just fine while you're working with a real database.
            const string city = "Tokyo";
            WriteLine($"{city} has population {db.GetPopulation(city)}");

            // now some tests
        }
    }
}