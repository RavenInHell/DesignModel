using System;
using System.Collections.Generic;

namespace DesignModel.IteratorPattern
{
    /// <summary>
    /// 设计模式-迭代器模式 原文链接 https://www.cnblogs.com/zhili/p/IteratorPattern.html
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region 迭代器调用
            Iterator iterator;
            IListCollection list = new ConcreteList();
            iterator = list.GetIterTerator();

            while (iterator.MoveNext())
            {
                int i = (int)iterator.GetCurrent();
                Console.WriteLine($"迭代到的数值：{i.ToString()}");
                iterator.Next();
            }

            Console.Read();
            #endregion

            #region 题外话-测试下 yield return；
            foreach (var item in GetNumbers())
                Console.WriteLine("Main process. item = " + item); 
            #endregion
        }

        static IEnumerable<int> GetNumbers()
        {
            // 以[0, 1, 2] 初始化数列 list
            Console.WriteLine("Initializating...");
            List<int> list = new List<int>();
            for (int i = 0; i < 3; i++)
                list.Add(i);

            // 每次 yield return 返回一个list的数据
            Console.WriteLine("Processing...");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Yield called.");
                yield return list[i];
            }
            Console.WriteLine("Done.");
        }
    }
}
