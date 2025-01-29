//Menu class
public class Menu
{
    public void Start()
    {
        bool running = true;
        while (running)
        {
            //Menu choices
            Console.WriteLine("Welcome to the Adventure Program!");
            Console.WriteLine("You will choose a scenario, make decisions, and see what fate has in store for you.\n");
            Console.WriteLine("Scenario Options:");
            Console.WriteLine("1. Fantasy");
            Console.WriteLine("2. Pirate");
            Console.WriteLine("3. Random");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            //Fantasy simulation
            if (choice == "1")
            {
                Fantasy adventure = new Fantasy();
                adventure.Start();
            }
            //Pirate simulation
            else if (choice == "2")
            {
                Pirate adventure = new Pirate();
                adventure.Start();
            }
            //Randomly chooses pirate or fantasy simulation
            else if (choice == "3")
            {
                Random random = new Random();
                int randomChoice = random.Next(1, 3);  
                if (randomChoice == 1)
                {
                    Fantasy adventure = new Fantasy();
                    adventure.Start();
                }
                else
                {
                    Pirate adventure = new Pirate();
                    adventure.Start();
                }
            }
            //Exit the program
            else if (choice == "4")
            {
                running = false;
                Console.WriteLine("See you soon.");
            }
            //Catching errors for invalid user number input
            else
            {
                Console.WriteLine("Error. Please choose a number between 1 and 4.");  
            }
        }
    }
}
