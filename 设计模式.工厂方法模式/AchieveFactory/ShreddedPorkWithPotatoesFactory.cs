using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.工厂方法模式.Abstract;
using 设计模式.工厂方法模式.AchieveFood;

namespace 设计模式.工厂方法模式.AchieveFactory
{
    public  class ShreddedPorkWithPotatoesFactory : Creator
    {
        public override Food CreateFoodFactory()
        {
            return new ShreddedPorkWithPotatoes();
        }
    }
}
