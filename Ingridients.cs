namespace RecipeManager
{
    internal class Ingredient
    {
        public float Amount { get; }
        public string Unit { get; }
        public string Name { get; }
        public Recipe Recipe { get; }
        public string Comment { get; }

        /*
            public Ingredient(float amount, string unit, string name, string comment = null)
            {
                Amount = amount;
                Unit = unit;
                Name = name;
                Comment = comment;
            }
         */
        public Ingredient(float amount, string unit, string name, string comment = null)
            : this(amount, unit, name, null, comment)
        {
        }

        public Ingredient(float amount, string unit, Recipe recipe, string comment = null)
            : this(amount, unit, null, recipe, comment)
        {
        }

        private Ingredient(float amount, string unit, string name, Recipe recipe, string comment = null)
        {
            Amount = amount;
            Unit = unit;
            Name = name;
            Comment = comment;
            Recipe = recipe;
        }

        public void Show()
        {

        }
    }
}