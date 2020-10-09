using System;
using 设计模式.命令模式.Abstract;

namespace 设计模式.命令模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //院领导

            //初始化Receiver(接收者)、Invoke（调用）、Command（命令)
            //命令接收者
            Receiver receiver=new Receiver();
            Command command=new ConcreteCommand(receiver);
            Invoke invoke=new Invoke(command);
            //院领导发出命令
            //
            invoke.ExecuteCommand();

        }
    }
}
