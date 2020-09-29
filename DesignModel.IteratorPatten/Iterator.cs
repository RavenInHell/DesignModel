using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.IteratorPattern
{
    /// <summary>
    /// 迭代器抽象类
    /// </summary>
    public interface Iterator
    {
        bool MoveNext();
        object GetCurrent();
        void Next();
        void Reset();
    }
}
