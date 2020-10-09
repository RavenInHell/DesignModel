using System;
using System.Collections.Generic;
using System.Text;

namespace 设计模式.命令模式
{
    /// <summary>
    /// 命令接收者-学生
    /// </summary>
    public  class Receiver
    {
        public void Run1000Meters()
        {
            Console.WriteLine("跑1000米");
        }

        public void HandInHomework()
        {
            Console.WriteLine("交作业");
        }
    }
}
