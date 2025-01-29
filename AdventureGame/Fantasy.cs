using System;

//Fantasy class
public class Fantasy
{
    // Start of the adventure, the user has the option to follow a fairy or throw a stick at it
    public void Start()
    {
        Console.WriteLine("\nWelcome, you are about to embark on a Fantasy Adventure!");
        Console.WriteLine("Your journey begins in the Flittering Forest. It is your grandma's birthday, and you are on your way to find her an enchanted apple.");
        Console.WriteLine("All of a sudden, a blue fairy darts past you.");

        string choice = GetUserChoice("Do you:\n1. Follow the fairy\n2. Throw a stick at the fairy", 2);

        // Calls the FollowFairy method
        if (choice == "1")
        {
            FollowFairy();
        }
        // Calls the ThrowStick method
        else if (choice == "2")
        {
            ThrowStick();
        }
    }

    // FollowFairy method
    private void FollowFairy()
    {
        Console.WriteLine("\nYou follow the fairy, curious about where it may lead. It takes you to a magic tree in the middle of a clearing.");
        Console.WriteLine("The fairy notices you following and beckons you inside a hole at the base of the tree.");
        string choice = GetUserChoice("Do you:\n1. Follow the fairy into the hole in the tree\n2. Shake your head and walk back out of the clearing", 2);

        // Calls the InsideTree method
        if (choice == "1")
        {
            InsideTree();
        }
        // Calls the AngryFairy method
        else if (choice == "2")
        {
            AngryFairy();
        }
    }

    // ThrowStick method
    private void ThrowStick()
    {
        Console.WriteLine("\nYou mischievously throw a stick at the fairy. She is not happy and flies into a fit of rage.");

        string choice = GetUserChoice("Do you:\n1. Apologize and try to make peace with her\n2. Run away as fast as you can", 2);

        // Calls the MakePeace method
        if (choice == "1")
        {
            MakePeace();
        }
        // Calls the RunAway method
        else if (choice == "2")
        {
            RunAway();
        }
    }

    // Making sure the user inputs a valid number option
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

    // InsideTree method
    private void InsideTree()
    {
        Console.WriteLine("\nYou crawl into the tree and find a hidden world inside.");
        Console.WriteLine("Fairies flutter around, gnomes waddle by, and unicorns prance along. All of a sudden, the movement stops.");
        Console.WriteLine("The creatures turn and stare. The chosen one! They believe you will save them from the terrible dragon that has cursed the land.");
        
        string choice = GetUserChoice("Do you:\n1. Thank them, but turn down their request\n2. Agree to fight the dragon", 2);

        // Calls the TurnDown method
        if (choice == "1")
        {
            TurnDown();
        }
        // Calls the FightDragon method
        else if (choice == "2")
        {
            FightDragon();
        }
    }

    // AngryFairy method
    private void AngryFairy()
    {
        Console.WriteLine("\nThe fairy is enraged by your rudeness. She demands that you follow her into the magic tree.");
        
        string choice = GetUserChoice("Do you:\n1. Agree to go inside the tree\n2. Tell the fairy it is your grandmother's birthday so you cannot", 2);

        // Calls the InsideTree method
        if (choice == "1")
        {
            InsideTree();
        }
        // Calls the BirthdayParty method
        else if (choice == "2")
        {
            BirthdayParty();
        }
    }

    // MakePeace method
    private void MakePeace()
    {
        Console.WriteLine("\nThe fairy accepts your apology and insists that you come with her through a hole at the base of a magical tree.");

        string choice = GetUserChoice("Do you:\n1. Agree to go inside the tree\n2. Politely decline and continue on your way", 2);

        // Calls the InsideTree method
        if (choice == "1")
        {
            InsideTree();
        }
        // End of adventure
        else if (choice == "2")
        {
            Console.WriteLine("\nHow boring of you! You do not get a fun adventure and instead have an unsuccessful day of apple hunting for your grandmother.");
            Console.WriteLine("THE END.");
        }
    }

    // RunAway method and end of adventure
    private void RunAway()
    {
        Console.WriteLine("\nYou are trying to outrun a magical flying fairy with your tiny human feet. She catches up to you in a heartbeat.");
        Console.WriteLine("You are cursed for your tomfoolery! Because of this curse, you are only able to find carrots and no magic apples, so your grandmother has to settle for a carrot pie for her birthday.");
        Console.WriteLine("THE END.");
    }

    // TurnDown method and end of adventure
    private void TurnDown()
    {
        Console.WriteLine("\nYou turn down the creatures' request to fight the dragon. They are sad but beg you to spend time with them.");
        Console.WriteLine("You agree, but only if your grandma can come. The magic creatures bring her to the magic tree, where they throw the grandest birthday party in all the land.");
        Console.WriteLine("THE END.");
    }

    // FightDragon method and end of adventure
    private void FightDragon()
    {
        Console.WriteLine("\nYou agree to fight the dragon. The magic creatures equip you with enchanted armor, and you face off with the beast.");
        Console.WriteLine("At the end of a crazy fight, you shoot an arrow through the dragon's heart, killing him and ending the terror in the land.");
        Console.WriteLine("You return victorious, and the magical creatures crown you the Champion of Flittering Forest. You have one last request.");
        Console.WriteLine("The magic creatures grant your request, and you throw a grand birthday for your grandmother with plenty of magic apple pie.");
        Console.WriteLine("THE END.");
    }

    // BirthdayParty method and end of adventure
    private void BirthdayParty()
    {
        Console.WriteLine("\nThe fairy softens her heart and explains that she loves parties. Together, you throw a wonderful party for your grandmother with a magic apple pie and fireworks.");
        Console.WriteLine("THE END.");
    }
}
