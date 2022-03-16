
var ContinueRunning = false;
do
{

    Console.WriteLine($"How many people are being fed?");
    var peopleAsString = Console.ReadLine();
    var TotalSlicesneeded = int.Parse(peopleAsString);
    var PeanutButter = int.Parse(peopleAsString);
    var Jelly = int.Parse(peopleAsString);
    var TotalLoavesNeeded = Math.Ceiling(TotalSlicesneeded / 28m);
    var JarsOfPeanutbutter = Math.Ceiling(PeanutButter / 32m);
    var JarsofJelly = Math.Ceiling(Jelly / 48m);




    Console.WriteLine($"You will need {TotalSlicesneeded * 2} slices of bread, {PeanutButter * 2} ounces of peanut butter, and {Jelly * 4} ounces of jelly.");
    Console.WriteLine($" which is {TotalLoavesNeeded} loaves, {JarsOfPeanutbutter} jars of peanutbutter and {JarsofJelly} jars of jelly. ");

    Console.WriteLine("Would you like to restart? Y for Yes and N for No.");

    var input = Console.ReadLine();
    if (input == "y")
    {
        ContinueRunning = true;
    }
    else
    {
        ContinueRunning = false;
    }
}
while (ContinueRunning == true);



