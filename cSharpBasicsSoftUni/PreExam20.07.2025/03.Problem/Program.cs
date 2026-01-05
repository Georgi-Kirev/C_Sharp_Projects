// Courier Express

double weight = double.Parse(Console.ReadLine());
string typeOfTransport = Console.ReadLine();
double distanceInKm = double.Parse(Console.ReadLine());


double pricePerKm = 0.0;
double priceforExpressTotal = 0.0;

if (typeOfTransport == "standard" && weight < 1) // 3 дни доставка
{
    pricePerKm = 0.03;
}
else if (typeOfTransport == "standard" && weight >= 1 && weight < 10)
{
    pricePerKm = 0.05;
}
else if (typeOfTransport == "standard" && weight >= 10 && weight < 40)
{
    pricePerKm = 0.10;
}
else if (typeOfTransport == "standard" && weight >= 40 && weight < 90)
{
    pricePerKm = 0.15;
}
else if (typeOfTransport == "standard" && weight >= 90 && weight < 150)
{
    pricePerKm = 0.20;
}



if (typeOfTransport == "express" && weight < 1) // 1 дни доставка
{
    pricePerKm = 0.03;
    priceforExpressTotal = (0.024 * weight) * distanceInKm; // добавяме 80% от цената на стандартната доставка
}
else if (typeOfTransport == "express" && weight >= 1 && weight < 10)
{
    pricePerKm = 0.05;
    priceforExpressTotal = (0.02 * weight) * distanceInKm; // добавяме 40% от цената на стандартната доставка
}
else if (typeOfTransport == "express" && weight >= 10 && weight < 40)
{
    pricePerKm = 0.10;
    priceforExpressTotal = (0.005 * weight) * distanceInKm; // добавяме 5% от цената на стандартната доставка
}
else if (typeOfTransport == "express" && weight >= 40 && weight < 90)
{
    pricePerKm = 0.15;
    priceforExpressTotal = (0.003 * weight) * distanceInKm;
}
else if (typeOfTransport == "express" && weight >= 90 && weight < 150)
{
    pricePerKm = 0.20;
    priceforExpressTotal = (0.002 * weight) * distanceInKm;
}

double totalPrice = pricePerKm * distanceInKm;
if (typeOfTransport == "express")
{
    double totalExpressPrice = totalPrice + priceforExpressTotal;
    Console.WriteLine($"The delivery of your shipment with weight of {weight:F3} kg. would cost {totalExpressPrice:F2} lv.");
}
else
    Console.WriteLine($"The delivery of your shipment with weight of {weight:F3} kg. would cost {totalPrice:F2} lv.");

