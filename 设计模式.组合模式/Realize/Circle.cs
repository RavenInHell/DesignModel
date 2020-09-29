using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.组合模式.Abstract;

namespace 设计模式.组合模式.Realize
{
    /// <summary>
    /// 简单图形类-圆
    /// </summary>
    public class Circle : Graphics
    {
        public Circle(string name)
            : base(name)
        {

        }
        public override void Add(Graphics g)
        {
            throw new NotImplementedException("不能向简单图形Circle添加其他图形");
        }

        public override void Draw()
        {
            Console.WriteLine($"画 {Name}");
        }

        public override void Remove(Graphics g)
        {
            throw new NotImplementedException("不能向简单图Circle形添加其他图形");
        }
    }
}
