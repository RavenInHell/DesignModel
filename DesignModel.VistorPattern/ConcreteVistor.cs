using System;
using System.Collections.Generic;
using System.Text;
using DesignModel.VistorPattern.Element;
using DesignModel.VistorPattern.Interface;

namespace DesignModel.VistorPattern
{
    public class ConcreteVistor:IVistor
    {
        public void Visit(ElementA a)
        {
            a.Print();
        }
        public void Visit(ElementB b)
        {
            b.Print();
        }
    }
}
