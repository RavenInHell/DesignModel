using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.中介者模式.Abstract;

namespace 设计模式.中介者模式
{
    public class MediatorPater : AbstractMediator
    {
        public MediatorPater(AbstractCardPartner a, AbstractCardPartner b)
            : base(a, b)
        {

        }
        public override void AWin(int count)
        {
            A.MoneyCount += count;
            B.MoneyCount -= count;
        }

        public override void BWin(int count)
        {
            B.MoneyCount += count;
            A.MoneyCount -= count;
        }
    }
}
