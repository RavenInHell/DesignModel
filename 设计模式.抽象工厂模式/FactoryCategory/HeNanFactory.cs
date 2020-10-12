using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.抽象工厂模式.Abstract;
using 设计模式.抽象工厂模式.AllTheCombinations;

namespace 设计模式.抽象工厂模式.FactoryCategory
{
    public class HeNanFactory : AbstractFactory
    {
        public override YaBo CreateYaBo()
        {
            return new HeNanYaBo();
        }

        public override YaJia CreateYaJia()
        {
            return new HeNanYaJia();
        }
    }
}
