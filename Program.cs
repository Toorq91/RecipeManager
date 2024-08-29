// Create a recipe manager where users can:
//    Add, edit, and delete recipes with details like ingredients, instructions, and preparation time.
//    Search for recipes by ingredient or title.
//    Categorize recipes (e.g., desserts, main courses, appetizers).

namespace RecipeManager
{

    class Program
    {
        static void Main(string[] args)
        {
            var recipes = new RecipeService();


            Console.WriteLine("Write 1 to add a recipe.");
            Console.WriteLine("Write 2 to edit a recipe.");
            Console.WriteLine("Write 3 to delete a recipe.");
            Console.WriteLine("Write 4 to see the different recipes menu or search for a specific one.");
            var input = Console.ReadLine();

            Console.ReadKey();
        }

    }
}