using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.工厂方法模式.Abstract;

namespace 设计模式.工厂方法模式.AchieveFood
{
    public class ShreddedPorkWithPotatoes : Food
    {
        /// <summary>
        /// 土豆肉丝这道菜
        /// </summary>
        public override void Print()
        {
            Console.WriteLine("土豆肉丝好了！");
        }
    }
}
