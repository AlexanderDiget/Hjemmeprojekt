namespace Menumedarrayosv
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu mainMenu = new Menu();

            mainMenu.Title = "Min fantastiske menu";

            // First menu item
            mainMenu.AddmenuItem("1. Gør dit");
            // Increment with one; same as: ItemCount = ItemCount + 1

            // Second menu item

            mainMenu.AddmenuItem("2. Gør dat");

            // Third menu item
            mainMenu.AddmenuItem("3. Gør noget");

            // Last menu item
            mainMenu.AddmenuItem("4. Få svaret på livet, universet og alting");


            mainMenu.Show();

            Console.ReadLine();
        }
    }
}