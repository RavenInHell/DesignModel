using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.工厂方法模式.Abstract;

namespace 设计模式.工厂方法模式.AchieveFood
{
    public class MincedMeatEggPlant : Food
    {
        public override void Print()
        {
            Console.WriteLine("肉沫茄子好了！");
        }
    }
}
