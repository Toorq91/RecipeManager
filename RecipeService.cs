namespace RecipeManager
{
    internal class RecipeService
    {
        private List<Recipe> _recipes;

        public RecipeService()
        {
            _recipes = new List<Recipe>();
            AddApplePieRecipe();
            AddPepperoniPizzaRecipe();
            AddDumplingsRecipe();
        }

        private void AddDumplingsRecipe()
        {
            var recipe = new Recipe("Dumplings", "Main Course", "Mix ingredients and cook.", 30);
            recipe.AddIngredient(2, "cups", "all-purpose flour");
            recipe.AddIngredient(0.5f, "cups", "warm water", "(more if needed)");
            recipe.AddIngredient(1, "pinch", "salt");

            // Filling
            recipe.AddIngredient(0.5f, "pound", "ground pork (or chicken, beef, or shrimp)");
            recipe.AddIngredient(1, "cup", "finely chopped cabbage");
            recipe.AddIngredient(0.25f, "cup", "finely chopped scallions (green onions)");
            recipe.AddIngredient(2, "cloves", "garlic, minced");
            recipe.AddIngredient(1, "tablespoon", "soy sauce");
            recipe.AddIngredient(1, "tablespoon", "sesame oil");
            recipe.AddIngredient(1, "tablespoon", "grated ginger");
            recipe.AddIngredient(0.5f, "teaspoon", "salt");
            recipe.AddIngredient(0.25f, "teaspoon", "ground white pepper");

            // Dipping Sauce
            recipe.AddIngredient(2, "tablespoons", "soy sauce");
            recipe.AddIngredient(1, "tablespoon", "rice vinegar");
            recipe.AddIngredient(1, "teaspoon", "sesame oil");
            recipe.AddIngredient(0.5f, "teaspoon", "sugar (optional)");
            recipe.AddIngredient(1, "teaspoon", "finely chopped scallions (optional)");
            recipe.AddIngredient(1, "teaspoon", "chili flakes or chili oil (optional)");
        }

        private void AddPepperoniPizzaRecipe()
        {
            var recipe = new Recipe("Pepperoni Pizza", "Main Course", "Prepare dough, add toppings, and bake.", 45);
            recipe.AddIngredient(1, "package", "active dry yeast");
            recipe.AddIngredient(1.5f, "cups", "warm water (110°F)");
            recipe.AddIngredient(3.5f, "to 4 cups", "all-purpose flour");
            recipe.AddIngredient(2, "tablespoons", "olive oil");
            recipe.AddIngredient(1, "teaspoon", "sugar");
            recipe.AddIngredient(1, "teaspoon", "salt");
            recipe.AddIngredient(1, "cup", "tomato sauce");
            recipe.AddIngredient(1, "teaspoon", "dried oregano");
            recipe.AddIngredient(1, "teaspoon", "dried basil");
            recipe.AddIngredient(0.5f, "teaspoon", "garlic powder");
            recipe.AddIngredient(0.5f, "teaspoon", "onion powder");
            recipe.AddIngredient(0.5f, "teaspoon", "sugar (optional, to taste)");
            recipe.AddIngredient( 1,"to taste", "Salt and pepper");
            recipe.AddIngredient(2, "cups", "shredded mozzarella cheese");
            recipe.AddIngredient(1, "cup", "sliced pepperoni");
            recipe.AddIngredient( 1,"optional", "Fresh basil leaves (for garnish)");
            recipe.AddIngredient( 1,"for brushing", "Olive oil (the crust)");

            _recipes.Add(recipe);

        }

        private void AddApplePieRecipe()
        {
            var recipe = new Recipe("Apple Pie", "Dessert", "Prepare crust, add filling, and bake.", 60);
            recipe.AddIngredient(2.5f, "cups", "all-purpose flour");
            recipe.AddIngredient(1, "cup", "unsalted butter, chilled and diced");
            recipe.AddIngredient(0.5f, "teaspoon", "salt");
            recipe.AddIngredient(0.5f, "cup", "ice water");
            recipe.AddIngredient(7, "cups", "thinly sliced, peeled apples");
            recipe.AddIngredient(1, "cup", "granulated sugar");
            recipe.AddIngredient(0.5f, "cup", "packed brown sugar");
            recipe.AddIngredient(2, "tablespoons", "all-purpose flour");
            recipe.AddIngredient(1, "teaspoon", "ground cinnamon");
            recipe.AddIngredient(0.25f, "teaspoon", "ground nutmeg");
            recipe.AddIngredient(1, "tablespoon", "lemon juice");

            _recipes.Add(recipe);
        }
    }
}