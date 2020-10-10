
using System;

namespace 设计模式.状态者模式
{
    class Program
    {
        static void Main(string[] args)
        {
           Account account=new Account("Learning Hard");
           account.Withdraw(2000.00);
            account.Deposit(1000.00);
            account.Deposit(200.00);
            account.Deposit(600);

            account.PayInterest();

            account.Withdraw(2000.00);
            account.Withdraw(500.00);
            Console.ReadKey();

        }
    }
}
