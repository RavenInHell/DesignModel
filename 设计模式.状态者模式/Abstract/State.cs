using System;
using System.Collections.Generic;
using System.Text;

namespace 设计模式.状态者模式.Abstract

{
    //抽象状态类
    public abstract class State
    {
        public Account Account { get; set; }
        /// <summary>
        /// 余额
        /// </summary>
        public double Balance { get; set; }
        /// <summary>
        /// 利率
        /// </summary>
        public double Intereset { get; set; }
        /// <summary>
        /// 下限
        /// </summary>
        public double LowerLimit { get; set; }
        /// <summary>
        /// 上限
        /// </summary>
        public double  UpperLimit { get; set; }

        /// <summary>
        /// 存款
        /// </summary>
        /// <param name="amount"></param>
        public abstract void Deposit(double amount);
        /// <summary>
        /// 取钱
        /// </summary>
        /// <param name="amount"></param>
        public abstract void Withdraw(double amount);
        /// <summary>
        /// 获得的利息
        /// </summary>
        public abstract void PayInterest();


    }
}
