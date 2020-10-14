using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 设计模式.享元模式.Abstract;

namespace 设计模式.享元模式
{
    /// <summary>
    /// 享元工厂，负责创建和管理享元对象
    /// </summary>
    public class FlyweightFactory
    {
        //最好使用泛型
        public Dictionary<string, Flyweight> flyweights = new Dictionary<string, Flyweight>();
        //public Hashtable flyweights=new Hashtable();

        public FlyweightFactory()
        {
            flyweights.Add("A", new ConcreteFlyweight("A"));
            flyweights.Add("B", new ConcreteFlyweight("B"));
            flyweights.Add("C", new ConcreteFlyweight("C"));
        }

        public Flyweight GetFlyweight(string key)
        {

            if (!flyweights.ContainsKey(key))
                return null;

            Flyweight flyweight = flyweights[key] as Flyweight;
            if (flyweight == null)
            {
                Console.WriteLine($"驻留池中不存在字符串{key}");
                flyweight=new ConcreteFlyweight(key);
            }

            return flyweight;
           // return flyweights[key] as Flyweight;
        }
    }
}
