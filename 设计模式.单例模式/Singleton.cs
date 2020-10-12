using System;
using System.Collections.Generic;
using System.Text;

namespace 设计模式.单例模式
{
    /// <summary>
    /// 单例模式的实现
    /// </summary>
    public class Singleton
    {
        private int id;
        public int Id
        {
            get { return id;}
            set { id = value; }
        }
        //定义一个静态变量来保存类的实例
        private static Singleton uniqueInstance;

        //定义一个标识确保线程同步
        private static readonly object locker=new object();

        //定义私有构造函数，使得外界不能创建该类的实例
        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if (uniqueInstance==null)
            {
                lock (locker)
                {
                    if (uniqueInstance==null)
                    {
                        uniqueInstance=new Singleton();
                    }
                }
            }

            return uniqueInstance;
        }

        public static void SingletonClose()
        {
            uniqueInstance = null;
            
        }
    }
}
