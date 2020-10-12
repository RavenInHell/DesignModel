using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.工厂方法模式.Abstract;
using 设计模式.工厂方法模式.AchieveFood;

namespace 设计模式.工厂方法模式.AchieveFactory
{
    /// <summary>
    /// 肉沫茄子工厂类，负责创建肉沫茄子这道菜
    /// </summary>
    public class MincedMeatEggplantFactory : Creator
    {
        public override Food CreateFoodFactory()
        {
           return new MincedMeatEggPlant();
        }
    }
}
