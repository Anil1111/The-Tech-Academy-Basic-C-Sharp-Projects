using System;

    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Welcome to Package Express.  Pleaes follow the instructions below.");
        Console.WriteLine("Please enter the weight of your package: ");
        var pkgWeight = Console.ReadLine();
        int weight = Convert.ToInt32(pkgWeight);

        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express.  Have a good day.");
            Console.ReadLine();
            Environment.Exit(0);
        }
      
    Console.WriteLine("Please enter the width of your package: ");
    string width = Console.ReadLine();

    Console.WriteLine("Please enter the height of your package: ");
    string height = Console.ReadLine();

    Console.WriteLine("Please enter the length of your package: ");
    string length = Console.ReadLine();

    float dimension = (Convert.ToInt32(width) + Convert.ToInt32(height) + Convert.ToInt32(length));
    float quote = ((dimension * weight) / 100);        

    if (dimension > 50.00)
        {
            Console.WriteLine("Package to big to be shipped via Package Express.");
        }
        else
        {
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));
            Console.WriteLine("Thank you.");
        }
        Console.ReadLine();    
    }
}

