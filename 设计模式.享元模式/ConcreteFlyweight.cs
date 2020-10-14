﻿using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.享元模式.Abstract;

namespace 设计模式.享元模式
{
    /// <summary>
    /// 具体的享元对象，这样我们不把每个字母设计成一个单独的类了，而是
    /// 作为把共享的字母作为享元对象的内部状态
    /// </summary>
    public class ConcreteFlyweight : Flyweight
    {
        //内部状态
        private string intrinsicstate;

        public ConcreteFlyweight(string innerState)
        {
            this.intrinsicstate = innerState;
        }

        /// <summary>
        /// 享元类的实例方法
        /// </summary>
        /// <param name="extrinsicstate">外部状态</param>
        public override void Operation(int extrinsicstate)
        {
           Console.WriteLine($"具体实现类：intrinsicstate:{intrinsicstate},extrincicstate:{extrinsicstate}");
        }
    }
}
