using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.组合模式.Abstract;

namespace 设计模式.组合模式.Realize
{
    /// <summary>
    /// 简单图形-线
    /// </summary>
    public class Line : Graphics
    {
        public Line(string name) :
            base(name)
        {

        }
        // 因为简单图形在添加或移除其他图形，所以简单图形Add或Remove方法没有任何意义
        // 如果客户端调用了简单图形的Add或Remove方法将会在运行时抛出异常
        // 我们可以在客户端捕获该类移除并处理
        //public override void Add(Graphics g)
        //{
        //    throw new NotImplementedException("不能向简单图形Line添加其他图形");
        //}

        public override void Draw()
        {
           Console.WriteLine($"画 {Name}");
        }

        //public override void Remove(Graphics g)
        //{
        //    throw new NotImplementedException("不能向简单图形Line移除其他图形");
        //}
    }
}
