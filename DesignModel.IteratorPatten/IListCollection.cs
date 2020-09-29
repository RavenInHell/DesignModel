using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.IteratorPattern
{
    /// <summary>
    /// 抽象聚合类
    /// </summary>
    public  interface IListCollection
    {
        Iterator GetIterTerator();
    }
}
