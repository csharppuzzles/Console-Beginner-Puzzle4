
static void ExampleA()
{
    Console.WriteLine("\nExample A");
    Console.WriteLine("~~~~~~~~~");

    // "Magic Numbers" - do not hard code values into your program!
    // Always have a configuration section at the start of the function
    // So they can be easily changed later in one place
    // Larger programs have configuration files or an appsettings.json file for this stuff for the whole program.
    int answer = 0;

    Console.WriteLine("How many Apple users does it take to change a lightbulb?: ");

    int number = Convert.ToInt32(Console.ReadLine());

    if(number == answer)
    {
        Console.WriteLine("Correct! They just buy a new house, without any windows.");
    }
    else
    {
        Console.WriteLine($"Nah, the answer is {answer} - They just buy a new house, without any windows!");
    }
    
}


// Puzzle A - Lightbulbs
//
// Write a program that asks:
//  "How many dead hookers does it take to change a lightbulb?: "
// If the user enters more than 7 display:
//  "Yeah, got to be more than 7, because my basement is STILL dark."
// If the user enters less than 7 display:
//  "Well, I know it's more than 7, because my basement is STILL dark."
// If the user enters exactly 7, display:
//  "That's what I thought. I sent 7 down, but my basement is STILL dark."
// You will need to learn about "greater than" and "less than" symbols.
// Learn about "else if"
static void PuzzleA()
{
    Console.WriteLine("\nPuzzle A");
    Console.WriteLine("~~~~~~~~~");

    int answer = 7;

    Console.WriteLine("How many dead hookers does it take to change a lightbulb?: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number == answer)
    {
        Console.WriteLine($"That's what I thought. I sent {answer} down, but my basement is STILL dark.");
    }
    else if( number > answer)
    {
        Console.WriteLine($"Yeah, got to be more than {answer}, because my basement is STILL dark.");
    }
    else if (number < answer)
    {
        Console.WriteLine($"Well, I know it's more than {answer}, because my basement is STILL dark.");
    }
    else
    {
        Console.WriteLine($"Wow. Unexpected input!");
    }
}


static void ExampleB()
{
    Console.WriteLine("\nExample B");
    Console.WriteLine("~~~~~~~~~");

    Console.WriteLine("Nuclear Missle Launch Program");
    Console.WriteLine("-----------------------------");

    Console.WriteLine("\nWho are we going to Nuke today, Mr President?");
    Console.WriteLine("1: The secret nazi moon base");
    Console.WriteLine("2: The tax department");
    Console.WriteLine("Please enter the number of your selection: ");

    int target = Convert.ToInt32(Console.ReadLine());

    if (target == 1)
    {
        Console.WriteLine("\nOk. Space-Hitler will be mad though...");
        Console.WriteLine("\nDo you confirm the launch to target the secret nazi moon base? Enter \"y\" or \"n\":");
        string? confirmation = Console.ReadLine();

        if(confirmation == "y")
        {
            Console.WriteLine("Launch Confirmed! Bye Bye lunar reich!");
        }
        else if(confirmation == "n") {
            Console.WriteLine("Cancelling launch... Launch aborted!");
        }
        else
        {
            Console.WriteLine("Sorry, I cannot proceed with launch without explicit confirmation. Launch aborted!");
        }

    }
    else if (target == 2)
    {
        Console.WriteLine("\nOk. Time to reduce taxes... to ash");
        Console.WriteLine("\nDo you confirm the launch to target the tax department? Enter \"y\" or \"n\":");
        string? confirmation = Console.ReadLine();

        if (confirmation == "y")
        {
            Console.WriteLine("Launch Confirmed! Bye Bye taxes, hello new car!");
        }
        else if (confirmation == "n")
        {
            Console.WriteLine("Cancelling launch... Launch aborted!");
        }
        else
        {
            Console.WriteLine("Sorry, I cannot proceed with launch without explicit confirmation. Launch aborted!");
        }
    }
    else
    {
        Console.WriteLine("You can't just enter random numbers when launching nukes!");
    }
}


// Puzzle B - Forget About It!
//
// Write a program for an italian pizza restaurant
// Ask the customer if they would like a pizza, a calzone or lasagne
// For all choices, ask them if they want a regular or large
// Then print their order confirmation
// If they enter a wrong choice tell them "Tony Soprano owns this place, so you better order something"
// If they do not choose any of the options give them an error message

static void PuzzleB()
{
    Console.WriteLine("\nPuzzle B");
    Console.WriteLine("~~~~~~~~~");

    Console.WriteLine("Welcome to North Jersey Pizzeria. What would you like?");
    Console.WriteLine("1: Pizza");
    Console.WriteLine("2: Calzone");
    Console.WriteLine("3: Lasagne");
    Console.WriteLine("Please enter the number of your selection: ");

    int choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1)
    {
        Console.WriteLine("\nWould you like a Regular or Large? Enter \"r\" or \"l\":");
        string? mealSize = Console.ReadLine();

        if (mealSize == "r")
        {
            Console.WriteLine("One regular pizza, coming up!");
        }
        else if (mealSize == "l")
        {
            Console.WriteLine("One large pizza, coming up!");
        }
        else
        {
            Console.WriteLine("Tony Soprano owns this place, so you better order something");
        }

    }
    else if (choice == 2)
    {
        Console.WriteLine("\nWould you like a Regular or Large? Enter \"r\" or \"l\":");
        string? mealSize = Console.ReadLine();

        if (mealSize == "r")
        {
            Console.WriteLine("One regular calzone, coming up!");
        }
        else if (mealSize == "l")
        {
            Console.WriteLine("One large calzone, coming up!");
        }
        else
        {
            Console.WriteLine("Tony Soprano owns this place, so you better order something");
        }
    }
    else if (choice == 3)
    {
        Console.WriteLine("\nWould you like a Regular or Large? Enter \"r\" or \"l\":");
        string? mealSize = Console.ReadLine();

        if (mealSize == "r")
        {
            Console.WriteLine("One regular lasagne, coming up!");
        }
        else if (mealSize == "l")
        {
            Console.WriteLine("One large lasagne, coming up!");
        }
        else
        {
            Console.WriteLine("Tony Soprano owns this place, so you better order something");
        }
    }
    else
    {
        Console.WriteLine("Just choose 1,2 or 3!");
    }
}


static void ExampleC()
{
    Console.WriteLine("\nExample C");
    Console.WriteLine("~~~~~~~~~");

    Console.WriteLine("Enter a number between 1 and 100: ");
    string? input = Console.ReadLine();

    // Variable "number" has to be outside the "if statement" when we want to access it everywhere
    // Block Level Scope - Any variable created within brackets { } is only acessible within those brackets and sub-brackets.
    int number = 0;

    if (input != "" && input != null)               // You could choose string.Empty instead of ""
    {
        number = Convert.ToInt32(input);

        if (number >= 1 && number <= 100)
        {
            Console.WriteLine("Fantastic, you can follow simple instructions!");
        }
        else
        {
            Console.WriteLine("Silly monkey! Can't count...");
        }
    } else
    {
        Console.WriteLine("Error. You can't just enter blank space");
    }

    Console.WriteLine("\nBecause \"int number = 0;\" was declared outside of the if statement, I can access its final value here.");
    Console.WriteLine($"Number is now {number}");
}


// Puzzle C - Number Guesser
//
// Write a program that asks the user to guess a number
// Display "What number am I thinking of? It's between 1 and 10: "
// Generate a random number between 1 and 10.
// Check that the user's input is not blank or null
// Convert the user's input into an integer
// Check that the number is really between 1 and 10
// If it is within 1 digit of the random number generated ( +1 or -1) tell them
//  "Close! Out by one! Number was {number}"
// Otherwise, tell them
//  "Wrong! It was {number}"

// I'd expect the program to break if they enter a float like 1.52 or a string, that's ok for now.
// But it should not break if they just enter blank or hit return

static void PuzzleC()
{
    Console.WriteLine("\nPuzzle C");
    Console.WriteLine("~~~~~~~~~");

    Random random = new Random();
    int number = random.Next(1, 10);

    Console.WriteLine("What number am I thinking of? It's between 1 and 10: ");
    string? input = Console.ReadLine();

    int guess = 0;

    if (input != "" && input != null)               // You could choose string.Empty instead of ""
    {
        guess = Convert.ToInt32(input);

        if (guess >= 1 && guess <= 10)
        {
            if (guess == number)
            {
                Console.WriteLine("Bingo! Correct guess!");
            }
            else if (guess == number + 1 || guess == number - 1)
            {
                Console.WriteLine($"Close! Out by one! Number was {number}");
            }
            else
            {
                Console.WriteLine($"Wrong! It was {number}");
            }
        }
        else
        {
            Console.WriteLine("Error. You have to enter a number between 1 and 10");
        }
    }
    else
    {
        Console.WriteLine("Error. You can't just enter blank space");
    }
}



// Run the puzzles

//ExampleA();
PuzzleA();

//ExampleB();
PuzzleB();

//ExampleC();
PuzzleC();



Console.WriteLine("\n Press enter to exit the program...");
Console.ReadLine();                                         // Keeps the console app window open until you hit enter
