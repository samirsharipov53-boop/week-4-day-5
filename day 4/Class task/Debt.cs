public class Dept
{
    double balance;
    double interestRate;
    public Dept(){}
    public Dept(double b, double IR)
    {
        balance=b;
        interestRate=IR;
    }

   public double IntialBalance;
   public  double IntialInterestRate;

   public void PrintBalance()
    {
        System.Console.WriteLine(balance);
    }

    public void WaitOneYear()
    {
        balance*=interestRate;
    }

}