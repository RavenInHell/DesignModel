using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.DecoratorPattern.DecoratorModule
{
    public  class Accessories:Decorator
    {
        public Accessories(Phone phone)
            : base(phone)
        {

        }


        public override void Print()
        {
            base.Print();
            AddAccessories();
        }

        public void AddAccessories()
        {
            Console.WriteLine("现在给手机挂上挂件");
        }
    }
}
