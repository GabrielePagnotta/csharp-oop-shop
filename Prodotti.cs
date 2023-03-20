
public class Prodotti
{
    private int code;
    public int Code { get { return code; } }
    public string name;
    public string description;
    public double price;
    public int tax;

    public Prodotti(int code, string name, string description, double price, int tax)
    {
        this.code = code;
        this.name = name;
        this.description = description;
        this.price = price;
        this.tax = tax;
    }
    public double Fullprice(double price, int tax)
    {
         double Pieceofprice = (price * tax) / 100;
        double Fullprice = Pieceofprice + price;
        return Math.Round(Fullprice,2);
    }

    public string ExtendedName()
    {
        string name = this.name;
        int code = this.code;

        string ExtendedN = $"{code}  {this.name}";
        return ExtendedN;
    }
    
}

