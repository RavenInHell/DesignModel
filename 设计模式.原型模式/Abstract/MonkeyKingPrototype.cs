using System;
using System.Collections.Generic;
using System.Text;

namespace 设计模式.原型模式.Abstract
{
    /// <summary>
    /// 孙悟空原型
    /// </summary>
    public abstract class MonkeyKingPrototype
    {
        public string Id { get; set; }

        public MonkeyKingPrototype(string id)
        {
            this.Id = id;
        }

        /// <summary>
        /// 克隆方法，即孙大圣说“变”
        /// </summary>
        /// <returns></returns>
        public abstract MonkeyKingPrototype Clone();
    }
}
