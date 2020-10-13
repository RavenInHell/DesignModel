using System;
using 设计模式.建造者模式.Abstract;

namespace 设计模式.建造者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //客户找到电脑城老板说要买电脑，这里要组装两台电脑
            Director director=new Director();
            Builder builderXiaoLi=new ConcreteBuilderXiaoLi();
            Builder builderXiaoWang=new ConcreteBuilderXiaoWang();

            //老板叫小李去组装
            director.Construct(builderXiaoLi);
            //组装完成，组装人员搬来组装好的电脑
            Computer computerXiaoLi = builderXiaoLi.GetComputer();
            computerXiaoLi.Show();

            director.Construct(builderXiaoWang);
            Computer computerXiaoWang = builderXiaoWang.GetComputer();
            computerXiaoWang.Show();
            Console.Read();
        }
    }
}
