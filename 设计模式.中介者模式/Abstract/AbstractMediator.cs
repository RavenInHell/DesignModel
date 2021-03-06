﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 设计模式.中介者模式.Abstract
{
    public abstract  class AbstractMediator
    {
        protected AbstractCardPartner A;
        protected AbstractCardPartner B;

        public AbstractMediator(AbstractCardPartner a, AbstractCardPartner b)
        {
            A = a;
            B = b;
        }

        public abstract void AWin(int count);
        public abstract void BWin(int count);



    }
}
