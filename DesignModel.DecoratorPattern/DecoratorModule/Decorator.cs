using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.DecoratorPattern.DecoratorModule
{
    /// <summary>
    /// 装饰抽象类，要让装饰完全取代抽象组件，所以必须继承自Phone
    /// </summary>
    public class Decorator : Phone
    {
        private Phone phone;

        public Decorator(Phone phone)
        {
            this.phone = phone;
        }
        public override void Print()
        {
            if (phone != null)
            {
                phone.Print();
            }
        }
    }
}
