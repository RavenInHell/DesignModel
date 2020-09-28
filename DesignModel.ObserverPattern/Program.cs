using System;

namespace DesignModel.ObserverPattern
{
    /// <summary>
    /// 设计模式-观察者模式 原文地址 https://www.cnblogs.com/zhili/p/ObserverPattern.html
    /// </summary>
    class Program
    {
        /*
         * 以订阅微信号，通知所有订阅者为例。这里使用委托进行
         */
        static void Main(string[] args)
        {
            TengXun tengXun = new TengXunGame("TengXunGame", "我是打游戏的订阅");
            Subscriber zhangsan = new Subscriber("张三");
            Subscriber lisi = new Subscriber("李四");
            tengXun.AddObserver(new NotifyEventHandler(zhangsan.ReceiverAndPrint));
            tengXun.AddObserver(new NotifyEventHandler(lisi.ReceiverAndPrint));

            tengXun.Update();


            Console.WriteLine("------------------------\n");

            Console.WriteLine("移除订阅者");
            tengXun.RemoveObserver(new NotifyEventHandler( zhangsan.ReceiverAndPrint));

            tengXun.Update();
            Console.ReadLine();

        }
    }
}
