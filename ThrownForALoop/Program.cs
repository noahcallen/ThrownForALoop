// string greeting = @"Welcome to Thrown For a Loop Your one-stop shot for used sporting equipment";
// Console.WriteLine(greeting);
// Console.WriteLine("Please enter a product name: ");

// string response = Console.ReadLine();

// Console.WriteLine($"You chose: {response}");

List<Product> products = new List<Product>()
{
  new Product()
  {
    Name = "Football",
    Price = 15,
    Sold = false,
    StockDate = new DateTime(2022, 10, 20),
    ManufactureYear = 2010
  },
  new Product()
  {
    Name = "Hockey Stick",
    Price = 12,
    Sold = false,
    StockDate = new DateTime(2021, 10, 20),
    ManufactureYear = 2014
  }
};

DateTime now = DateTime.Now;

Console.WriteLine("Products:");
for (int i = 0; i < products.Count; i++)
{
  Console.WriteLine($"{i + 1}. {products[i].Name}");
}
Console.Write("Please enter a product number: ");

int response = int.Parse(Console.ReadLine().Trim());

while (response > products.Count || response < 1)
{
  Product chosenProduct= products[response-1];
  TimeSpan timeInStock = now - chosenProduct.StockDate;
Console.WriteLine(@$"You chose: 
{chosenProduct.Name}, which costs {chosenProduct.Price} dollars.
It is {now.Year - chosenProduct.ManufactureYear} years old. 
It {(chosenProduct.Sold ? "is not available." : $"has been in stock for {timeInStock.Days} days.")}");
}
