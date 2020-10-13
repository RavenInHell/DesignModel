using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.建造者模式.Abstract;
namespace 设计模式.建造者模式
{
    class ConcreteBuilderXiaoLi:Builder
    {

        Computer computer = new Computer();
        public override void BuilderPartCPU()
        {
            computer.Add("CPU2");
        }

        public override void BuilderPartMainBoard()
        {
            computer.Add("Main board2");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}
