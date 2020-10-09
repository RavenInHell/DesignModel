using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.命令模式.Abstract;

namespace 设计模式.命令模式
{
    /// <summary>
    /// 教官，负责调用命令对对象执行请求
    /// </summary>
    public class Invoke
    {
        public Command _command;


        public Invoke(Command command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command.Action();
           
        }
    }
}
