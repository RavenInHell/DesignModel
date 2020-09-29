using System;
using System.Collections.Generic;
using System.Text;

namespace 设计模式.模板方法模式.Abstract
{
    public abstract class Vegetable
    {
        //模板方法，不要把模板方法定义为vitual或abstract，避免被子类重写，防止更改历程的执行顺序

        public void CookVegetable()
        {
            Console.WriteLine("炒蔬菜的一般做法流程如下：");
        }
        //第一步倒油
        public void PourOil()
        {
            Console.WriteLine("倒油");
        }
        //把油烧热
        public void HeatOil()
        {
            Console.WriteLine("把油烧热");
        }
        /// <summary>
        /// 油烧热后倒蔬菜下去，具体哪种蔬菜由子类决定
        /// </summary>
        public abstract void PourVegetable();

        public void Stir_Fry()
        {
            Console.WriteLine("翻炒");
        }


    }
}
