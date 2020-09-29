using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.IteratorPattern
{
    /// <summary>
    /// 具体聚合类
    /// </summary>
    public class ConcreteList : IListCollection
    {
        private int[] collection;

        public ConcreteList()
        {
            collection = new[] {2, 4, 6, 8, 10};
        }

        public Iterator GetIterTerator()
        {
            
            return new ConcreteIterator(this);
        }

        public int Length
        {
            get { return collection.Length; }
        }

        public int GetElement(int index)
        {
             return collection[index];
        }
    }
}
