using System;
using DesignModel.DecoratorPattern.DecoratorModule;

namespace DesignModel.DecoratorPattern
{
    /// <summary>
    /// 设计模式-装饰器模式 原文地址 https://www.cnblogs.com/zhili/p/DecoratorPattern.html
    /// </summary>
    class Program
    {
        /*
         * 以手机这个对象，对其实现贴膜和加挂件装饰品 等额外功能的拓展
         */
        static void Main(string[] args)
        {
            
            Phone phone=new ApplePhone();
            //现在想贴膜了
            Decorator applePhoneWithSticker=new Sticker(phone);
            //拓展贴膜行为
            applePhoneWithSticker.Print();
            Console.WriteLine("---------------------------\n");


            //现在我想要挂件了
            Decorator applePhoneWithAccessories=new Accessories(phone);
            //拓展挂件行为
            applePhoneWithAccessories.Print();
            Console.WriteLine("---------------------------\n");


            //现在想贴膜了
            Sticker sticker=new Sticker(phone);
            //现在想要挂件了
            Accessories applePhoneWithAccessoriesAndSticker=new Accessories(sticker);
            //拓展贴膜行为和挂件行为
            applePhoneWithAccessoriesAndSticker.Print();
            Console.ReadLine();
        }
    }
}
