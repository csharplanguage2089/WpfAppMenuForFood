using System.Windows;

namespace WpfAppMenuForFood
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeTheMenu();
        }

        private void MakeTheMenu()
        {
            MenuItem[] menuItem1 = new MenuItem[5];

            for (int i = 0; i < 5; i++)
            {
                menuItem1[i] = new MenuItem();

                if (i >= 3)
                {
                    menuItem1[i].proteins = new string[] { "New Barbacoa", "New Carpaccio", "New Enchiladas", "New Gyros" };
                    menuItem1[i].condiments = new string[] { "Jerk Seasoning", "Pizza Seasoning", "Chili Powder", "Cajun Seasoning" };
                    menuItem1[i].breads = new string[] { "New Banana Bread", "New Baguette", "New Breadstick", "New Brioche" };
                }
                menuItem1[i].GenerateMenuItem();
            }

            Item1.Text = " 1. " + menuItem1[0].description;
            Price1.Text = menuItem1[0].priceSt;

            Item2.Text = " 2. " + menuItem1[1].description;
            Price2.Text = menuItem1[1].priceSt;

            Item3.Text = " 3. " + menuItem1[2].description;
            Price3.Text = menuItem1[2].priceSt;

            Item4.Text = " 4. " + menuItem1[3].description;
            Price4.Text = menuItem1[3].priceSt;

            Item5.Text = " 5. " + menuItem1[4].description;
            Price5.Text = menuItem1[4].priceSt;

            MenuItem menuItem2 = new MenuItem();
            {
                menuItem2.proteins = new string[] { "Lechona", "Picanha", "Dongpo pork (Dōngpō ròu)", "Pappardelle al cinghiale" };
                menuItem2.condiments = new string[] { "Poultry Seasoning Spice Rub", "Ras El Hanout", "Zaatar Spice" };
                menuItem2.breads = new string[] { "Focaccia Bread", "Hokkaido Bread", "Multigrain Bread" };
            }
            menuItem2.GenerateMenuItem();

            Item6.Text = " 6. " + menuItem2.description;
            Price6.Text = menuItem2.priceSt;

            MenuItem menuItem3 = new MenuItem();

            decimal a1, a2, a3, a4, a5, a6, result;

            if (decimal.TryParse(Price1.Text, out a1) && decimal.TryParse(Price2.Text, out a2) && decimal.TryParse(Price3.Text, out a3) && decimal.TryParse(Price4.Text, out a4) && decimal.TryParse(Price5.Text, out a5) && decimal.TryParse(Price6.Text, out a6))
            {
                result = a1 + a2 + a3 + a4 + a5 + a6;
                TotalPrice.Text = "Total price: " + result.ToString("c") + ".";
            }
            else
            {
                TotalPrice.Text = "Unknown price";
            }
        }
    }
}
