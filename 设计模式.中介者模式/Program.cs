using System;
using System.Threading.Tasks.Dataflow;
using 设计模式.中介者模式.Abstract;

namespace 设计模式.中介者模式
{
    /// <summary>
    /// 设计模式-中介者模式 原文链接 https://www.cnblogs.com/zhili/p/MediatorPattern.html
    /// </summary>
    class Program
    {
        /// <summary>
        /// 以打牌进行交互
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            AbstractCardPartner A=new ParterA();
            AbstractCardPartner B=new ParterB();
            //初始钱
            A.MoneyCount = 20;
            B.MoneyCount = 20;

            AbstractMediator mediator=new MediatorPater(A,B);

            //A赢了

            A.ChangeCount(5,mediator);
            Console.WriteLine($"A现在的钱是：{A.MoneyCount}");
            Console.WriteLine($"B现在的钱是：{B.MoneyCount}");
            //B赢了

            B.ChangeCount(10, mediator);
            Console.WriteLine($"A现在的钱是：{A.MoneyCount}");
            Console.WriteLine($"B现在的钱是：{B.MoneyCount}");
        }
    }
}
