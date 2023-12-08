namespace WpfAppMenuForFood
{
    internal class MenuItem
    {
        public Random random = new Random();

        public string[] proteins = { "Barbacoa", "Carpaccio", "Enchiladas", "Gyros", "Meat Loaf", "Beef Stew", "Cassoulet", "Quick-Roasted Chicken", "Pasta Bolognese" };
        public string[] condiments = { "French Mustard and Herb Blend", "Porcini Mushroom Rub", "Berbere Spice (Ethiopian Spice Blend)", "Five Spice Powder, Chinese", "Vinegar Powder, White Balsamic", "Canadian Steak Seasoning" };
        public string[] breads = { "Banana Bread", "Baguette", "Breadstick", "Brioche", "Challah" };

        public string description = "";
        public string priceSt;

        public void GenerateMenuItem()
        {
            string randomProtein = proteins[random.Next(proteins.Length)];
            string randomCondiment = condiments[random.Next(condiments.Length)];
            string randomBread = breads[random.Next(breads.Length)];

            description = $"{randomProtein} with {randomCondiment} on {randomBread}";

            decimal bucks = random.Next(1, 10);
            decimal cents = random.Next(90, 100);
            decimal price = bucks + (cents * .01m);

            priceSt = price.ToString();
        }
    }
}
