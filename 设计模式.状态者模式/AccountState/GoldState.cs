using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.状态者模式.Abstract;

namespace 设计模式.状态者模式.AccountState
{
    public class GoldState : State
    {
        public GoldState(State state)
        {
            this.Balance = state.Balance;
            this.Account = state.Account;
            Intereset = 0.05;
            LowerLimit = 1000.00;
            UpperLimit = 1000000.00;
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
            Balance -= amount;
            StateChangeCheck();
        }

        public void StateChangeCheck()
        {
            if (Balance<0.0)
            {
                Account.State=new RedState(this);
            }
            else if (Balance<LowerLimit)
            {
                Account.State=new SilverState(this);
            }
        }
    }
}
