using System;
using System.Collections.Generic;
using System.Text;

namespace 设计模式.中介者模式.Abstract
{
    public abstract class AbstractCardPartner
    {
        public int MoneyCount { get; set; }

        public AbstractCardPartner()
        {
            MoneyCount = 0;
        }

        public abstract void ChangeCount(int Count, AbstractMediator mediator);
    }
}
