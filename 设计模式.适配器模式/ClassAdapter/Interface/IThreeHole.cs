using System;
using System.Collections.Generic;
using System.Text;

namespace 设计模式.适配器模式.ClassAdapter.Interface
{
    /// <summary>
    /// 三个孔的插头，也就是适配器模式中的目标角色
    /// </summary>
    public  interface IThreeHole
    {
        void Request();
    }
}
