using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.状态者模式.Abstract;
using 设计模式.状态者模式.AccountState;

namespace 设计模式.状态者模式
{
     public class Account
    {
        public State State { get; set; }

        public string Owner { get; set; }

        public Account(string owner)
        {
            this.Owner = owner;
            this.State=new SilverState(0.0,this);
        }
        /// <summary>
        /// 余额
        /// </summary>
        public double Balance
        {
            get { return State.Balance; }
        }

        public void Deposit(double amount)
        {
            State.Deposit(amount);
            Console.WriteLine($"存款金额为{amount}");
            Console.WriteLine($"账户余额为{this.Balance}");
            Console.WriteLine($"账户状态为：{this.State.GetType().Name}");
            Console.WriteLine();
        }

        public void Withdraw(double amount)
        {
       
            State.Withdraw(amount);
            Console.WriteLine($"取款金额为{amount}");
            Console.WriteLine($"账户余额为{this.Balance}");
            Console.WriteLine($"账户状态为：{this.State.GetType().Name}");
            Console.WriteLine();
        }

        public void PayInterest()
        {
            State.PayInterest();
            Console.WriteLine("Interest Paid --- ");
            Console.WriteLine($"账户余额为{this.Balance}");
            Console.WriteLine($"账户状态为：{this.State.GetType().Name}");
            Console.WriteLine();
        }
    }
}
