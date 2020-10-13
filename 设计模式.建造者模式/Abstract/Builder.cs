using System;
using System.Collections.Generic;
using System.Text;

namespace 设计模式.建造者模式.Abstract
{
    /// <summary>
    /// 抽象建造者，这个场景下为“组装人”，这里也可以定义为接口
    /// </summary>
    public abstract class Builder
    {
        /// <summary>
        /// 装CPU
        /// </summary>
        public abstract void BuilderPartCPU();
        /// <summary>
        /// 装主板
        /// </summary>
        public abstract void BuilderPartMainBoard();
       
        //装其他部件，省略。。。
        
        /// <summary>
        /// 获取电脑
        /// </summary>
        /// <returns></returns>
        public abstract Computer GetComputer();
    }
}
