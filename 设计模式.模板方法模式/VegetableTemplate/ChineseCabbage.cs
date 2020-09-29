using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.模板方法模式.Abstract;

namespace 设计模式.模板方法模式.VegetableTemplate
{
    public  class ChineseCabbage : Vegetable
    {
        public override void PourVegetable()
        {
            Console.WriteLine("倒入大白菜到锅中");
        }
    }
}
