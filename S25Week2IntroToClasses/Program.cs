namespace S25Week2IntroToClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product p1 = new Product();
            //Product p2 = new Product(101, "Keyboard", 30);

            //p1.Id = 102;
            //Console.WriteLine(p1.Id);



            Account myAcc = new Account(500);
            Console.WriteLine("Balance = " + myAcc.Balance.ToString("C"));

            myAcc.Deposit(200);
            Console.WriteLine("\nBalance = " + myAcc.Balance.ToString("C"));

            try
            {
                myAcc.Withdraw(4000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n" + ex.Message);
            }

            Console.WriteLine("\nBalance = " + myAcc.Balance.ToString("C"));
        }
    }
}
