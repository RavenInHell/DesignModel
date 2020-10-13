using System;
using System.Collections.Generic;
using System.Text;

namespace 设计模式.建造者模式
{
    /// <summary>
    /// 电脑类
    /// </summary>
    public class Computer
    {
        //电脑组件集合
        private IList<string > parts=new List<string>();
        //把单个组件添加到电脑组件集合中
        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("电脑开始组装。。。。");
            foreach (var part in parts)
            {
                Console.WriteLine($"组件{part}已经装好");
            }
            Console.WriteLine("电脑组装好了。");
        }
    }
}
