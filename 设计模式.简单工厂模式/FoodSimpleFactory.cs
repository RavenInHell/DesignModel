using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.简单工厂模式.Abstract;

namespace 设计模式.简单工厂模式
{
    //简单工厂负责炒菜
    public static class FoodSimpleFactory
    {
        public static Food CreateFood(string type)
        {
            Food food = null;
            if (type.Equals("土豆肉丝"))
            {
                food=new ShreddedPorkWithPotatoes();
            }
            else if (type.Equals("西红柿炒蛋"))
            {
                food=new TomatoScrambledEggs();
            }

            return food;
        }

        

    }
}
