Console.WriteLine("Welcome please press 'c' to use currency converter or anything else for temperature converter");
string answer  = Console.ReadLine();

if  (answer == "c")
{
    Console.WriteLine("You have selected currency converter");
    Console.WriteLine("Please enter 'a' to convert from pounds or anything else to convert from euros.");
    string choise = Console.ReadLine();

    if (choise == "a")
    {
        Console.WriteLine("Please enter your amount in British pounds.");
        float pounds = float.Parse(Console.ReadLine());
        float euro = pounds * 1.16f;
        Console.WriteLine("The amount in euro is " +  euro.ToString("0.00"));
    }
    else
    {
        Console.WriteLine("Please enter your amount in Euro.");
        float euro = float.Parse(Console.ReadLine());
        float pounds = euro / 1.16f;
        Console.WriteLine("The amount in pounds is " + pounds.ToString("0.00"));
    }
}
else
{
    Console.WriteLine("Welcome to the temperature converter!");
    Console.WriteLine("Please enter 'a' for celsius or anything else to convert from fahrenheit!");
    string choice = Console.ReadLine();

    if (choice == "a")
    {
        Console.WriteLine("Please enter temperature in celsius.");
        float celsius = float.Parse(Console.ReadLine());
        float fahrenheit = celsius * 1.18f + 32f;
        Console.WriteLine("The temperature in fahrenheit is " + fahrenheit);
    }
    else
    {
        Console.WriteLine("Please enter temperature in fahrenheit.");
        float fahrenheit = float.Parse(Console.ReadLine());
        float celsius = (fahrenheit - 32f) / 1.18f;
        Console.WriteLine("The temperature in celsius is " +  celsius);
    }
}