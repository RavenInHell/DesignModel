using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.建造者模式.Abstract;

namespace 设计模式.建造者模式
{
    /// <summary>
    /// 小王和小李难道会自愿地去组装嘛，谁不想休息的，这必须有一个人叫他们去组装才会去的
    /// 这个人当然就是老板了，也就是建造者模式中的指挥者
    /// 指挥创建过程类
    /// </summary>
    public class Director
    {
        //组装电脑
        public void Construct(Builder builder)
        {
            builder.BuilderPartCPU();
            builder.BuilderPartMainBoard();
        }
    }
}
