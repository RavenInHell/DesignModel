using System;
using DesignModel.BridgePattern.RealizeAbstract;

namespace DesignModel.BridgePattern
{
    /// <summary>
    /// 设计模式-桥接模式 原文链接地址 https://www.cnblogs.com/zhili/p/BridgePattern.html
    /// </summary>
    class Program
    {
        /*
         * 关于电视遥控器在不同电视机品牌间的问题
         */
        static void Main(string[] args)
        {
            //创建一个遥控器
            RemoteControl remoteControl =new RemoteControl();
            //长虹电视机
            remoteControl.Implementor=new Changhong();
            remoteControl.On();
            remoteControl.SetChannel();
            remoteControl.Off();
            Console.WriteLine("--------------------------");
            remoteControl.Implementor=new Chuangwei();
            remoteControl.On();
            remoteControl.SetChannel();
            remoteControl.Off();

            Console.Read();
        }
    }
}
