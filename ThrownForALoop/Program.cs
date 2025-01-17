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
    Sold = false
  },
  new Product()
  {
    Name = "Hockey Stick",
    Price = 12,
    Sold = false
  }
};

// Console.WriteLine(@"Products:
// 1. Football
// 2. Hockey Stick
// 3. Boomerang
// 4. Frisbee
// 5. Golf Putter");

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
  Console.WriteLine($"You chose: , {chosenProduct.Name}, which cost {chosenProduct.Price} dollars and is {(chosenProduct.Sold ? "" : "not ")}sold.");
}
