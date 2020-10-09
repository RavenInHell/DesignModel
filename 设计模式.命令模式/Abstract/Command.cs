using System;
using System.Collections.Generic;
using System.Text;

namespace 设计模式.命令模式.Abstract
{
    /// <summary>
    /// 命令抽象类
    /// </summary>
    public abstract class Command
    {
        //命令应该知道接收者是谁所以要有Receiver这个成员变量
        protected Receiver _receiver;

        public Command(Receiver receiver)
        {
            this._receiver = receiver;
        }
        //命令执行方法
        public abstract void Action();

    }
}
