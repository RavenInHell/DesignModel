using System;
using System.Collections.Generic;
using System.Text;

namespace 设计模式.享元模式.Abstract
{
    /// <summary>
    /// 抽象享元类，提供具体享元类具有的方法
    /// </summary>
    public abstract class Flyweight
    {
        public abstract void Operation(int extrinsicstate);
    }
}
