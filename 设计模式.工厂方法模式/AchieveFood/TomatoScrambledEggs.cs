using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using 设计模式.工厂方法模式.Abstract;

namespace 设计模式.工厂方法模式.AchieveFood
{
    public class TomatoScrambledEggs : Food
    {
        public override void Print()
        {
            Console.WriteLine("西红柿炒蛋好了！");
        }
    }
}
