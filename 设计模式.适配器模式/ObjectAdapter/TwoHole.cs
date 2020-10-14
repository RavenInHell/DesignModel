using System;
using System.Collections.Generic;
using System.Text;

namespace 设计模式.适配器模式.ObjectAdapter
{
    /// <summary>
    /// 两个孔的插头，源角色-需要适配的类
    /// </summary>
    public  class TwoHole
    {
        public void SpecificRequest()
        {
            Console.WriteLine("我是两个孔的插头");
        }
    }
}
