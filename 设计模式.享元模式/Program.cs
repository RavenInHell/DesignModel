using System;
using 设计模式.享元模式.Abstract;

namespace 设计模式.享元模式
{
    /// <summary>
    /// 设计模式-享元模式（Flyweight pattern） 原文链接 https://www.cnblogs.com/zhili/p/FlyweightPattern.html
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //定义外部状态，例如字母的位置等信息
            int externalstate = 10;
            //初始化享元工厂
            FlyweightFactory factory=new FlyweightFactory();
            ;
            //判断是否已经创建了字母A，如果已经创建就直接使用创建的对象A
            Flyweight fA = factory.GetFlyweight("A");
            if (fA!=null)
            {
                //把外部状态作为享元对象的方法调用参数
                fA.Operation(--externalstate);
            }

            //判断是否已经创建了字母B
            Flyweight fB = factory.GetFlyweight("B");
            if (fB!=null)
            {
                fB.Operation(--externalstate);
            }

            Flyweight fC = factory.GetFlyweight("C");
            if (fC != null)
            {
                fC.Operation(--externalstate);
            }

            Flyweight fD = factory.GetFlyweight("D");
            if (fD!=null)
            {
                fD.Operation(--externalstate);
            }
            else
            {
                Console.WriteLine("驻留池中不存在字符串D");
                Console.WriteLine("向驻留池添加字符D。。。。");
                ConcreteFlyweight d = new ConcreteFlyweight("D");
                factory.flyweights.Add("D",d);
            }

            Flyweight fD2 = factory.GetFlyweight("D");
            if (fD2!=null)
            {
                fD2.Operation(--externalstate);
            }
            Console.Read();
        }
    }

    /*
     * 享元模式——运用共享技术有效地支持大量细粒度的对象。享元模式可以避免大量相似类的开销，在软件开
     * 发中如果需要生成大量细粒度的类实例来表示数据，如果这些实例除了几个参数外基本上都是相同的，这时
     * 候就可以使用享元模式来大幅度减少需要实例化类的数量。如果能把这些参数（指的这些类实例不同的参数）
     * 移动类实例外面，在方法调用时将他们传递进来，这样就可以通过共享大幅度地减少单个实例的数目。（这
     * 个也是享元模式的实现要领）,然而我们把类实例外面的参数称为享元对象的外部状态，把在享元对象内部定
     * 义称为内部状态。具体享元对象的内部状态与外部状态的定义为：内部状态：在享元对象的内部并且不会随着
     * 环境的改变而改变的共享部分外部状态：随环境改变而改变的，不可以共享的状态。
     */
}
