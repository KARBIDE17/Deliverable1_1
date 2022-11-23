using System.Runtime.CompilerServices;

do
{   //Prompt user to enter number of sandwiches
    Console.WriteLine("How many people do we need to make PB and J sandwiches for?");

    //Take user input
    int sandwiches = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    //Calculate different amounts of ingredients
    decimal slicesOfBread = sandwiches * 2;
    decimal tbsOfPb = sandwiches * 2;
    decimal tspOfJelly = sandwiches * 4;

    //Display number of ingredients to user
    Console.WriteLine("You need:");
    Console.WriteLine();
    Console.WriteLine(slicesOfBread + " slices of bread.");
    Console.WriteLine(tbsOfPb + " tablespoons of peanut butter.");
    Console.WriteLine(tspOfJelly + " teaspoons of jelly");
    Console.WriteLine();
    Console.WriteLine("which is...");
    Console.WriteLine();

    //Calculate number of loaves of Bread¿, jars of Pb, Jars of Jelly
    decimal loavesOfBread = (slicesOfBread / 28);
    decimal jarsOfPb = tbsOfPb / 32;
    decimal jarsOfJelly = tspOfJelly / 48;

    //Convert each to display rounded up values to nearest int
    Console.WriteLine(Math.Ceiling(loavesOfBread) + " loaves of bread.");
    Console.WriteLine(Math.Ceiling(jarsOfPb) + " jars of peanut butter.");
    Console.WriteLine(Math.Ceiling(jarsOfJelly) + " jars of jelly.");
    Console.WriteLine();

    //Ask user if theyd like to try again
    Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
    string restart = Console.ReadLine();

    //Restart Program if user types "y" or "yes", close on any other input
    while (restart != "y" && restart != "yes")
    {
        Console.WriteLine("Goodbye!");
        Environment.Exit(0);
    }
} while (true);
