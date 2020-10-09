using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.中介者模式.Abstract;

namespace 设计模式.中介者模式
{
    public class ParterB : AbstractCardPartner
    {
        public override void ChangeCount(int Count, AbstractMediator mediator)
        {
            mediator.BWin(Count);
        }
    }
}
