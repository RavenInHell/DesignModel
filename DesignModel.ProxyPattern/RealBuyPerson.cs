using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.ProxyPattern
{
    public class RealBuyPerson : Person
    {
        public override void BuyProduct()
        {
            Console.WriteLine("帮助我买一个Apple手机和电脑");
        }
    }
}
