using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.简单工厂模式.Abstract;

namespace 设计模式.简单工厂模式
{
    /// <summary>
    /// 土豆肉丝这道菜
    /// </summary>
    public  class ShreddedPorkWithPotatoes : Food
    {
        public override void Print()
        {
            Console.WriteLine("一份土豆肉丝");
        }
    }
}
