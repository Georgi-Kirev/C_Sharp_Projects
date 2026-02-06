// Input

int rotation = int.Parse(Console.ReadLine());
List<string> products = new List<string>();

// Checks and Outputs

for (int product = 1; product <= rotation; product++)
{
    string productNames = Console.ReadLine();
    products.Add(productNames);
}

products.Sort();

for (int i = 1; i <= rotation; i++)
{
    Console.WriteLine($"{i}.{products[i - 1]}");
}