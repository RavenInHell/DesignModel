using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.简单工厂模式.Abstract;

namespace 设计模式.简单工厂模式
{
    /// <summary>
    /// 西红柿炒蛋这道菜
    /// </summary>
    public class TomatoScrambledEggs : Food
    {
        public override void Print()
        {
            Console.WriteLine("一份西红柿炒蛋！");
        }
    }
}
