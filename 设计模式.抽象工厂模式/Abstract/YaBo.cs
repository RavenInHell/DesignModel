using System;
using System.Collections.Generic;
using System.Text;

namespace 设计模式.抽象工厂模式.Abstract
{
    /// <summary>
    /// 鸭脖抽象类，供每个地方的鸭脖类继承
    /// </summary>
    public abstract class YaBo
    {
        /// <summary>
        /// 打印方法，输出信息
        /// </summary>
        public abstract void Print();
    }
}
