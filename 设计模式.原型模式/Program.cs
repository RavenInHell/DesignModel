using System;
using 设计模式.原型模式.Abstract;

namespace 设计模式.原型模式
{
    /// <summary>
    /// 设计模式-原型模式（Prototype Pattern）  原文链接 https://www.cnblogs.com/zhili/p/PrototypePattern.html
    /// </summary>
    class Program
    {
        /// <summary>
        /// 火影忍者中鸣人的影分身和孙悟空的变都是原型模式
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MonkeyKingPrototype prototypeMonkeyKing=new ConcretePrototype("MonkeyKing");

            MonkeyKingPrototype cloneMonkeyKing = prototypeMonkeyKing.Clone() as ConcretePrototype;
            Console.WriteLine($"Cloned1:\t{cloneMonkeyKing.Id}");

            MonkeyKingPrototype cloneMonkeyKing2 = prototypeMonkeyKing.Clone() as ConcretePrototype;
            Console.WriteLine($"Cloned2:\t {cloneMonkeyKing2.Id}");

            Console.ReadLine();

        }
    }
}
