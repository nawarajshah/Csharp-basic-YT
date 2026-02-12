namespace OopIntro
{
    class Program
    {
        static void Main()
        {
            //Car myCar = new Car();
            //myCar.Color = "Red";
            //myCar.Start();

            //BankAccount myAccount = new BankAccount();
            //myAccount.Deposit(1000);
            //myAccount.CheckBalance();
            //myAccount.Withdraw(100);
            //myAccount.CheckBalance();

            Vehicle v = new Car();
            v.Start();
        }
    }

    public class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("Vehicle Starting");
        }
    }

    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car Starting");
        }
    }

    //public class Vehicle
    //{
    //    public int Speed;

    //    public void Start()
    //    {
    //        Console.WriteLine("Vehicle Started");
    //    }
    //}

    //public class Car : Vehicle
    //{
    //    public string Brand;
    //}

    //public abstract class Vehicle
    //{
    //    public abstract void Start();
    //}

    //public class BankAccount
    //{
    //    private double balance;

    //    public void Deposit(double amount)
    //    {
    //        if (amount > 0)
    //            balance += amount;
    //    }

    //    public void Withdraw(double amount)
    //    {
    //        if (amount > 0 && amount <= balance)
    //            balance -= amount;
    //    }

    //    public void CheckBalance()
    //    {
    //        Console.WriteLine("Balance : " + balance);
    //    }
    //}

    //public class Car
    //{
    //    public string Color;
    //    public string Brand;
    //    public string Speed;

    //    public void Start()
    //    {
    //        Console.WriteLine("Car Started");
    //    }

    //    public void Stop()
    //    {
    //        Console.WriteLine("Car Stopped");
    //    }
    //}
}
