using System;
using 设计模式.模板方法模式.Abstract;
using 设计模式.模板方法模式.VegetableTemplate;

namespace 设计模式.模板方法模式
{
    /// <summary>
    /// 设计模式-模板方法模式 原文链接 https://www.cnblogs.com/zhili/p/TemplateMethodPattern.html
    /// </summary>
    class Program
    {
        /// <summary>
        /// 以不同的菜，但是其炒菜流程是一样的
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //创建一个菠菜实例并调用模板方法
            Console.WriteLine("炒菠菜");
            Vegetable spinach=new Spinach();
            spinach.CookVegetable();
            spinach.PourOil();
            spinach.HeatOil();
            spinach.PourVegetable();
            spinach.Stir_Fry();

            //Console.WriteLine("-----------------\n");
            //Console.WriteLine("炒白菜");
            //ChineseCabbage chineseCabbage=new ChineseCabbage();
            //chineseCabbage.PourVegetable();
            //Console.WriteLine("-----------------\n");
            Console.Read();
        }
    }
}
