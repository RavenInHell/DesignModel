using System;
using 设计模式.抽象工厂模式.Abstract;
using 设计模式.抽象工厂模式.FactoryCategory;

namespace 设计模式.抽象工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory shangHaiFactory=new ShangHaiFactory();
            Console.WriteLine("上海工厂做的产品：");
            shangHaiFactory.CreateYaBo().Print();
            shangHaiFactory.CreateYaJia().Print();
            AbstractFactory nanChangFactory=new NanChangFactory();
            Console.WriteLine("南昌工厂做的产品：");
            nanChangFactory.CreateYaBo().Print();
            nanChangFactory.CreateYaJia().Print();

            Console.WriteLine("新开设了河南工厂，制作：");
            AbstractFactory heNanFactory=new HeNanFactory();
            heNanFactory.CreateYaBo().Print();
            heNanFactory.CreateYaJia().Print();

            Console.ReadKey();
        }
    }
}
