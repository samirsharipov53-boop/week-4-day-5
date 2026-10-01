public class Account
{
   public  double Sum;
   public string Owner{get;set;}
   public void GetInfo(string a)
    {
        Console.WriteLine(a+" account balance: ");
    }
   public Account(){}
   public Account(double sum)
    {
        Sum = sum;
    }
   public double Send(double a)
    {
        return Sum+a;
    }
    public double Minus(double m)
    {
        return Sum-m;
    }
}