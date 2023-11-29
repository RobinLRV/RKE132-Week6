
string[] snacks = { "sushi", "pizza", "burger", "chicken wings", "asian" };

Random rand = new Random();

int randomIndex = rand.Next(0, snacks.Length);

Console.WriteLine($"Winner: {snacks[randomIndex]}!");
