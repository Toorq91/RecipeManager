namespace RecipeManager
{
    internal class Recipe
    {
        private string _title;
        private static List<Ingredient> _ingredients;
        private string _instructions;
        private int _preparationTimeMinutes;
        private string _category;

        public Recipe(string title, string category, string instructions, int preparationTimeMinutes)
        {
            _title = title;
            _category = category;
            _instructions = instructions;
        }

        public void AddIngredient(float amount, string unit, string name, string comment = null)
        {
            var ingredient = new Ingredient(amount, unit, name, comment);
            _ingredients.Add(ingredient);
        }

        internal void Show()
        {
            foreach (var ingredient in _ingredients)
            {
                Console.WriteLine(ingredient);
            }
        }
    }
}