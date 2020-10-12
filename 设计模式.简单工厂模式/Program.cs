using System;
using 设计模式.简单工厂模式.Abstract;

namespace 设计模式.简单工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("我要吃西红柿炒蛋");
            Food food1 = FoodSimpleFactory.CreateFood("西红柿炒蛋");
            food1.Print();

            Console.WriteLine("我要吃土豆肉丝");
            Food food2 = FoodSimpleFactory.CreateFood("土豆肉丝");
            food2.Print();
        }
    }
}
