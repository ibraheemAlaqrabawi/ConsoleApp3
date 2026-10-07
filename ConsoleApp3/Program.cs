
Console.WriteLine("enter the price");
double price = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter the quantity");
int quantity = Convert.ToInt32(Console.ReadLine());
double total;
total = price * quantity;
Console.WriteLine($" the total ={total}");
Console.WriteLine("add another product?");
bool test = Convert.ToBoolean(Console.ReadLine());
if (test == true)
{
    Console.WriteLine("enter the price");
    price = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("enter the quantity");
    quantity = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"  the total in new product={price*quantity}");
    total =  total+(price * quantity);
    Console.WriteLine($" the total of all product ={total}");
    Console.WriteLine("thank you");
}
else 
{
    Console.WriteLine($" the total ={total}");
    Console.WriteLine("thank you");
}
