using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.状态者模式.Abstract;

namespace 设计模式.状态者模式.AccountState
{
    /// <summary>
    /// Silver State 意味着没有利息可以得
    /// </summary>
    public  class SilverState : State
    {
        public SilverState(State state)
            : this(state.Balance ,state.Account)
        {

        }

        public SilverState(double balance, Account account)
        {
            this.Balance = balance;
            this.Account = account;
            Intereset = 0.00;
            LowerLimit = 0.00;
            UpperLimit = 1000.00;
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            Balance += Intereset * Balance;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            StateChangeCheck();
            Balance -= amount;
            StateChangeCheck();
        }

        public void StateChangeCheck()
        {
            if (Balance<=LowerLimit)
            {
                Account.State=new RedState(this);

            }
            else if(Balance>UpperLimit)
            {
                Account.State=new GoldState(this);
            }
        }
    }
}
