using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.状态者模式.Abstract;

namespace 设计模式.状态者模式.AccountState
{
    /// <summary>
    /// RedState意味着Account透支
    /// </summary>
     public class RedState : State
    {

        public RedState(State state)
        {
            this.Balance = state.Balance;
            this.Account = state.Account;
            Intereset = 0.00;
            LowerLimit = -100.00;
            UpperLimit = 0.00;
        }
        /// <summary>
        /// 存款
        /// </summary>
        /// <param name="amount"></param>
        public override void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck();
        }
        /// <summary>
        /// 利息
        /// </summary>
        public override void PayInterest()
        {
            Console.WriteLine($"当前状态为{this.GetType().Name},无利息！");
        }

        /// <summary>
        /// 取款
        /// </summary>
        /// <param name="amount"></param>
        public override void Withdraw(double amount)
        {
            Console.WriteLine("已无余额！");
        }

        /// <summary>
        /// 存钱后状态是否发生改变
        /// </summary>
        public void StateChangeCheck()
        {
            //余额大于上限
            if (Balance>UpperLimit)
            {
                Account.State=new SilverState(this);
            }
        }
    }
}
