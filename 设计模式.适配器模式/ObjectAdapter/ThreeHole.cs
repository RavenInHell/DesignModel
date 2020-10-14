using System;
using System.Collections.Generic;
using System.Text;

namespace 设计模式.适配器模式.ObjectAdapter
{
    /// <summary>
    /// 三个孔的插头，也就是适配器模式中的目标（Target）角色
    /// </summary>
    public  class ThreeHole
    {
        /// <summary>
        /// 客户端需要的方法
        /// </summary>
        public virtual void Request()
        {
            //可以把一般实现放在这里
            Console.WriteLine("我是三插孔的插头");
        }
    }
}
