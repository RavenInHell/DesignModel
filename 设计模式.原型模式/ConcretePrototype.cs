using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.原型模式.Abstract;

namespace 设计模式.原型模式
{
    public  class ConcretePrototype:MonkeyKingPrototype
    {
        public ConcretePrototype(string id)
            : base(id)
        {

        }

        public override MonkeyKingPrototype Clone()
        {
            //调用MemberwisecClone 方法实现的是浅拷贝，另外还有深拷贝
            return (MonkeyKingPrototype)this.MemberwiseClone();
        }
    }
}
