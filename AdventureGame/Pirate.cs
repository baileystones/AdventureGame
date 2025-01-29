using System;

//Pirate class
public class Pirate
{
    //Start of the adventure, the user has the option to choose between two ships
    public void Start()
    {
        Console.WriteLine("\nAhoy matey, you are about to embark on a Pirate Adventure!");
        Console.WriteLine("Your journey begins in a bustling port. You are looking for a ship to join to find some treasure and go on an adventure.");
        Console.WriteLine("As you walk down the dock, two ships catch your eye.");
        
        string choice = GetUserChoice("Do you:\n1. Board Ship One\n2. Board Ship Two", 2);

        //Calls the ShipOne method
        if (choice == "1")
        {
            ShipOne();
        }
        //Calls the ShipTwo method
        else if (choice == "2")
        {
            ShipTwo();
        }
    }

    //ShipOne method
    private void ShipOne()
    {
        Console.WriteLine("\nYou board the first ship. The crew welcomes you aboard as the captain explains that you are voyaging to the Mermaid Lagoon.");
        Console.WriteLine("As you are out on the ocean, you suddenly spot an enemy ship approaching fast.");
        string choice = GetUserChoice("Do you:\n1. Help the crew prepare for battle\n2. Hide below deck and wait it out", 2);

        //Calls the Battle method
        if (choice == "1")
        {
            Battle();
        }
        //Calls the HideBelowDeck method
        else if (choice == "2")
        {
            HideBelowDeck();
        }
    }

    //ShipTwo method, going to an island in search of treasure
    private void ShipTwo()
    {
        Console.WriteLine("\nYou board the second ship. The crew seems eager to get to an island rumored to hold grand treasures.");
        Console.WriteLine("After days at sea, you finally approach the island.");
        string choice = GetUserChoice("Do you:\n1. Go ashore to explore the island\n2. Stay aboard and keep watch for danger", 2);

        //Calls the ExploreIsland method
        if (choice == "1")
        {
            ExploreIsland();
        }
        //Calls the StayAboard method
        else if (choice == "2")
        {
            StayAboard();
        }
    }

    //Making sure the user inputs a valid number option
    private string GetUserChoice(string prompt, int numberChoices)
    {
        string choice;
        while (true)
        {
            Console.WriteLine("\n" + prompt);
            Console.Write("Choose an option (1-" + numberChoices + "): ");
            choice = Console.ReadLine();

            if (choice == "1" || (numberChoices == 2 && choice == "2"))
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and " + numberChoices + ".");
            }
        }
    }

    //Battle method
    private void Battle()
    {
        Console.WriteLine("\nYou grab a sword and rush onto the deck to help the crew fight off the enemy pirates.");
        Console.WriteLine("After a fierce battle, you manage to defeat the enemy ship, sending it sinking into the depths.");
        Console.WriteLine("The crew cheers, and the captain thanks you for your bravery. You continue your journey to the Mermaid Lagoon.");
        Console.WriteLine("Once you arrive, you find an underwater treasure chest full of precious gems and ancient artifacts.");
        Console.WriteLine("THE END.");
    }

    //HideBelowDeck method
    private void HideBelowDeck()
    {
        Console.WriteLine("\nYou decide to stay out of the battle and hide below deck, hoping the fight will end quickly.");
        Console.WriteLine("After the battle ends, you learn that the ship has won, but you were too busy being a scaredy-cat.");
        Console.WriteLine("The crew sails to the Mermaid Lagoon, but you're deemed a coward. You return home with a few coins, but no real adventure.");
        Console.WriteLine("THE END.");
    }

    //ExploreIsland method
    private void ExploreIsland()
    {
        Console.WriteLine("\nYou leave the ship and begin exploring the thick jungle and ancient ruins of the island.");
        Console.WriteLine("After hours of searching, you find a hidden cave. Inside, you uncover a chest full of gold, jewels, and a legendary pirate map.");
        string choice = GetUserChoice("Do you:\n1. Take the treasure and return to the ship\n2. Explore further into the cave", 2);

        //Calls the ReturnToShip method
        if (choice == "1")
        {
            ReturnToShip();
        }
        //Calls the DeeperCave method
        else if (choice == "2")
        {
            DeeperCave();
        }
    }

    //StayAboard method
    private void StayAboard()
    {
        Console.WriteLine("\nYou stay aboard the ship and keep a close eye on the shore.");
        Console.WriteLine("As the crew explores the island, you notice smoke rising from a nearby mountain, a possible sign of danger.");
        string choice = GetUserChoice("Do you:\n1. Sound the alarm to warn the crew\n2. Wait to see what happens next", 2);

        //Calls the SoundAlarm method
        if (choice == "1")
        {
            SoundAlarm();
        }
        //Calls the IgnoreDanger method
        else if (choice == "2")
        {
            IgnoreDanger();
        }
    }

    //ReturnToShip method
    private void ReturnToShip()
    {
        Console.WriteLine("\nYou take the treasure and return to the ship, where the crew celebrates your discovery.");
        Console.WriteLine("You sail back home with the riches of the island and the legendary pirate map.");
        Console.WriteLine("THE END.");
    }

    //DeeperCave method
    private void DeeperCave()
    {
        Console.WriteLine("\nYou venture deeper into the cave and soon find yourself trapped in a narrow passage. The treasure is nowhere to be found.");
        Console.WriteLine("Suddenly, you hear the sound of rocks moving. The cave begins to collapse around you!");
        Console.WriteLine("You barely escape, but with no treasure. You return to the ship empty-handed.");
        Console.WriteLine("THE END.");
    }

    //SoundAlarm method
    private void SoundAlarm()
    {
        Console.WriteLine("\nYou sound the alarm, waking the crew in time to avoid a deadly volcanic eruption.");
        Console.WriteLine("The crew thanks you for your bravery. You didn't find treasure, but you were able to save your new crewmates.");
        Console.WriteLine("THE END.");
    }

    //IgnoreDanger method
    private void IgnoreDanger()
    {
        Console.WriteLine("\nYou ignore the signs of danger, but soon the volcano erupts!");
        Console.WriteLine("The crew barely escapes, but the ship is destroyed, and your pirate adventures come to an end.");
        Console.WriteLine("THE END.");
    }
}
