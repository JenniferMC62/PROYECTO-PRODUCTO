class Product
{
    public string code;
    public string description;
    public decimal price;

    public Product(string code, string description, decimal price)
    {
        this.code = code;
        this.description = description;
        this.price = price;
    }

}

class ProductDB
{
    static void SaveProducts(List<Product> products)
    {
        StreamWriter textOut = new StreamWriter(new FileStream("productos.txt", FileMode.Create, 
                                                                                FileAccess.Write));

        foreach(var p in products)
        {
            textOut.WriteLine($"{p.code}|{p.description}|{p.price}");
        }
        textOut.Close();
    }

    public static SaveProductsBin(List<Product>products)
    {
        FileStream fs = new FileStream("archivobin", FileMode.Create, FileAccess.Write);
        BinaryWriter 
    }
}

class Program 
{
    
}