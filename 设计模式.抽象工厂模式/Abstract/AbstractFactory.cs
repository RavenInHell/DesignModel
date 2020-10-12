using System;
using System.Collections.Generic;
using System.Text;


namespace 设计模式.抽象工厂模式.Abstract
{
    /// <summary>
    /// 抽象工厂类，提供创建两个不同地方的鸭架和鸭脖
    /// </summary>
    public abstract class AbstractFactory
    {
        //抽象工厂提供创建一系列产品的接口，这里作为例子，只给出了绝味鸭脖和鸭架的创建接口
        public abstract YaBo CreateYaBo();
        public abstract YaJia CreateYaJia();
    }
}
