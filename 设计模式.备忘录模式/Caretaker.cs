using System;
using System.Collections.Generic;
using System.Text;

namespace 设计模式.备忘录模式
{
    /// <summary>
    /// 管理角色
    /// </summary>
    public class Caretaker
    {
        /// <summary>
        /// 使用多个备忘录来存储多个备份点
        /// </summary>
        public Dictionary<string, ContactMemento> ContactMementoDis { get; set; }

        public Caretaker()
        {
            ContactMementoDis=new Dictionary<string, ContactMemento>();
        }
    }
}
