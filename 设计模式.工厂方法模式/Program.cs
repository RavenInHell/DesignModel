using System;
using 设计模式.工厂方法模式.Abstract;
using 设计模式.工厂方法模式.AchieveFactory;

namespace 设计模式.工厂方法模式
{
    /// <summary>
    /// 设计模式-工厂方法模式 原文链接 https://www.cnblogs.com/zhili/p/FactoryMethod.html
    /// </summary>
    class Program
    {
        /// <summary>
        /// 以客人吃饭为例
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //初始化做菜的工厂
            Creator shreddedPorkWithPotatoesFactory=new ShreddedPorkWithPotatoesFactory();
            Creator tomatoScreambledEggFactory=new TomatoScrambledEggsFactory();
            //开始做西红柿炒蛋
            Console.WriteLine("我要吃一份番茄炒蛋");
            Food tomatoScrambleEggs = tomatoScreambledEggFactory.CreateFoodFactory();
            tomatoScrambleEggs.Print();
            Console.WriteLine("我要吃土豆肉丝");
            Food shreddedPorkWithPotatoes = shreddedPorkWithPotatoesFactory.CreateFoodFactory();
            shreddedPorkWithPotatoes.Print();


            Console.WriteLine("新加菜谱：肉末茄子");
            //初始化工厂
            MincedMeatEggplantFactory mincedMeatEggplantFactory=new MincedMeatEggplantFactory();
            //使用肉沫茄子的工厂来创建肉沫茄子这道菜
            Food mincedMeatEggplant= mincedMeatEggplantFactory.CreateFoodFactory();
            mincedMeatEggplant.Print();
        }
    }
}
