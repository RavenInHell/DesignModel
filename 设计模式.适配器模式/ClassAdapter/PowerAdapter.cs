using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.适配器模式.ClassAdapter.Abstract;
using 设计模式.适配器模式.ClassAdapter.Interface;

namespace 设计模式.适配器模式.ClassAdapter
{
    /// <summary>
    /// 适配器类，接口要放在类的后面(先实现基类，再实现接口)
    /// 适配器类提供了三个孔插头的行为但是本质调用的是两个孔插头的方法
    /// </summary>
    class PowerAdapter : TwoHole, IThreeHole
    {
        /// <summary>
        /// 实现三个孔插头接口方法
        /// </summary>
        public void Request()
        {
            //调用两个孔插头方法
            this.SpecificRequest();
        }
    }
}
