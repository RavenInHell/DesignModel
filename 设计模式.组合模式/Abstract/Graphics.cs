using System;
using System.Collections.Generic;
using System.Text;

namespace 设计模式.组合模式.Abstract
{
    /// <summary>
    /// 图形抽象类
    /// </summary>
    public  abstract class Graphics
    {
        public string Name { get; set; }

        public Graphics(string name)
        {
            this.Name = name;
        }
        // 移除了Add和Remove方法
        // 把管理子对象的方法放到了ComplexGraphics类中进行管理
        // 因为这些方法只在复杂图形中才有意义
        public abstract void Draw();
        //public abstract void Add(Graphics g);
        //public abstract void Remove(Graphics g);

    }
}
