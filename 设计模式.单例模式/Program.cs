using System;

namespace 设计模式.单例模式
{
    class Program
    {
        static void Main(string[] args)
        {
           Singleton a=  Singleton.GetInstance();
           a.Id = 99;

           var b = a.Id;

           Singleton c = Singleton.GetInstance();
           var d = c.Id;
           c = null;
           Singleton e = Singleton.GetInstance();
           var f = e.Id;
           Singleton.SingletonClose();
           Singleton t = Singleton.GetInstance();
        }
    }
}
