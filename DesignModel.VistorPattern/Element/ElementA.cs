using DesignModel.VistorPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.VistorPattern.Element
{
    /// <summary>
    /// 具体元素A
    /// </summary>
    public class ElementA : Abstract.Element
    {
        public override void Accept(IVistor vistor)
        {
           vistor.Visit(this);
        }

        public override void Print()
        {
            Console.WriteLine("我是元素A");
        }
    }
}
