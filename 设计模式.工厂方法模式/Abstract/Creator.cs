using System;
using System.Collections.Generic;
using System.Text;

namespace 设计模式.工厂方法模式.Abstract
{
    public abstract class Creator
    {
        //工厂方法
        public abstract Food CreateFoodFactory();
    }
}
