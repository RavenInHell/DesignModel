using System;
using System.Collections.Generic;
using System.Text;

namespace 设计模式.适配器模式.ClassAdapter.Abstract
{
    /// <summary>
    /// 两个孔的插头，源角色-需要适配的类
    /// </summary>
    public abstract class TwoHole
    {
        /// <summary>
        /// 
        /// </summary>
        public void SpecificRequest()
        {
            Console.WriteLine("我是两个孔的插头");
        }
    }
}
