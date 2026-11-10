using SkapaKundkonto.Repositories;
using SkapaKundkonto.Services;

// Skapa repository och service
CustomerRepository repository = new();
CustomerService service = new(repository);

// Test 1: skapa ett nytt kundkonto
Console.WriteLine("=== TEST 1: Skapa kundkonto ===");

bool result = service.CreateCustomer(
    "Bygg AB",
    "556123-4567",
    "info@byggab.se",
    "070-123 45 67",
    out string message);

Console.WriteLine(message);

if (result)
{
    Console.WriteLine("Kundkontot skapades.");
}
else
{
    Console.WriteLine("Kundkontot skapades inte.");
}


// Test 2: försöka skapa samma kund igen
Console.WriteLine();
Console.WriteLine("=== TEST 2: Försöka skapa samma kund igen ===");

result = service.CreateCustomer(
    "Bygg AB",
    "556123-4567",
    "info@byggab.se",
    "070-123 45 67",
    out message);

Console.WriteLine(message);

if (result)
{
    Console.WriteLine("Kundkontot skapades.");
}
else
{
    Console.WriteLine("Kundkontot skapades inte.");
}

// Test 3: ogiltiga kunduppgifter
Console.WriteLine();
Console.WriteLine("=== TEST 3: Ogiltiga kunduppgifter ===");

result = service.CreateCustomer(
    "",
    "556999-8888",
    "test@bygg.se",
    "070-987 65 43",
    out message);

Console.WriteLine(message);

if (result)
{
    Console.WriteLine("Kundkontot skapades.");
}
else
{
    Console.WriteLine("Kundkontot skapades inte.");
}