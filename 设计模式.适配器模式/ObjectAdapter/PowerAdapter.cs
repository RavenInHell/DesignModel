using System;
using System.Collections.Generic;
using System.Text;

namespace 设计模式.适配器模式.ObjectAdapter
{
    /// <summary>
    /// 适配器类，这里适配器没有TwoHole类
    /// 而是引用了TwoHole对象，所以是对象的适配器模式的实现
    /// </summary>
    public  class PowerAdapter:ThreeHole
    {
        //引用两个孔插头的实例，从而将客户端与TwoHole联系起来
        public TwoHole twoHoleAdapter=new TwoHole();

        /// <summary>
        /// 实现三个孔插头接口方法
        /// </summary>
        public override void Request()
        {
            twoHoleAdapter.SpecificRequest();
        }
    }
}
