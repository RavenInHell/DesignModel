using System;

namespace DesignModel.VistorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStructure objectStructure=new ObjectStructure();
            foreach (Abstract.Element e in objectStructure.Elements)
            {
                e.Accept(new ConcreteVistor());
            }

            Console.Read();
        }
    }
}
