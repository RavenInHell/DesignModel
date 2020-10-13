using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.建造者模式.Abstract;
namespace 设计模式.建造者模式
{
    /// <summary>
    /// 具体创建者，具体的某个人为具体创建者，例如：装机小王
    /// </summary>
    public  class ConcreteBuilderXiaoWang : Builder
    {
        Computer computer=new Computer();
        public override void BuilderPartCPU()
        {
            computer.Add("CPU1");
        }

        public override void BuilderPartMainBoard()
        {
            computer.Add("Main board1");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}
