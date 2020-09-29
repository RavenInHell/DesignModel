using System;
using 设计模式.组合模式.Realize;

namespace 设计模式.组合模式
{
    /// <summary>
    /// 设计模式-组合模式 原文链接 https://www.cnblogs.com/zhili/p/CompositePattern.html
    /// </summary>
    class Program
    {
        /// <summary>
        /// 以画图形简单图形自由组合
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ComplexGraphics complexGraphics=new ComplexGraphics("一个复杂图形和两条线段组成的复杂图形");
            complexGraphics.Add(new Line("线段A"));
            ComplexGraphics complexCG=new ComplexGraphics("一个圆形和一条线组成的复杂图形");
            complexCG.Add(new Circle("圆"));
            complexCG.Add(new Circle("线段B"));
            //复杂图形和简单图形的组合
            complexGraphics.Add(complexCG);

            Line line = new Line("线段C");
            complexGraphics.Add(line);
            //complexGraphics.Add(new Line("线段C"));
            //显示复杂图形的画法
            Console.WriteLine("复杂图形的绘制如下：");
            Console.WriteLine("-------------------\n");
            complexGraphics.Draw();
            Console.WriteLine("复杂图形的绘制完成");
            Console.WriteLine("-------------------\n");
    
            //移除一个组件在显示复杂图形的画法
            complexGraphics.Remove(line);
            Console.WriteLine("移除线段C后,复杂图形的绘制如下：");
            Console.WriteLine("------------------\n");
            complexGraphics.Draw();
            Console.WriteLine("复杂图形绘制完成");
            Console.WriteLine("-------------------\n");


            Console.Read();

        }
    }
}
