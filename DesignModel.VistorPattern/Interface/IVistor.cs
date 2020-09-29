using System;
using System.Collections.Generic;
using System.Text;
using DesignModel.VistorPattern.Element;

namespace DesignModel.VistorPattern.Interface
{
 
    /// <summary>
    /// 抽象访问者
    /// </summary>
    public interface IVistor
    {
        void Visit(ElementA a);
        void Visit(ElementB b);
    }
}
