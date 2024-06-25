//Recipe Manager

//Create a recipe manager where users can:

//    Add, edit, and delete recipes with details like ingredients, instructions, and preparation time.
//    Search for recipes by ingredient or title.
//    Categorize recipes (e.g., desserts, main courses, appetizers).

namespace RecipeManager
{

    class Program
    {
        static void Main(string[] args)
        {
            //var MainCourse = new List<string>();
            var Desserts = new List<Recipe>();
            //var Appetizers = new List<string>();
            var Cake = new Recipe("Apple Pie");
            Cake.Show();
            Console.ReadKey();
        }

    }
}
