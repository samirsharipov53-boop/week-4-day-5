public class Product
{
    string Name;
    double Price;
    int Quanlity;
    public Product(){}
    public Product(string name,double price,int pcs)
    {
        Name = name;
        Price = price;
        Quanlity = pcs;
    }
    public void PrintProduct()
    {
        System.Console.WriteLine($"{Name}: price {Price}: {Quanlity} pcs");
    }
}