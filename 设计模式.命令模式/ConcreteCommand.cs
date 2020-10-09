using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.命令模式.Abstract;

namespace 设计模式.命令模式
{
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver)
            : base(receiver)
        {

        }
        public override void Action()
        {
            //调用接收的方法，因为执行命令的是学生
            _receiver.Run1000Meters();
            _receiver.HandInHomework();
        }
    }
}
