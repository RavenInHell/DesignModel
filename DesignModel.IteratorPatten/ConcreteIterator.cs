using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.IteratorPattern
{
    //具体迭代器
    public class ConcreteIterator : Iterator
    {
        public ConcreteList _list;
        private int _index;

        public ConcreteIterator(ConcreteList list)
        {
            _list = list;
            _index = 0;
        }

        public object GetCurrent()
        {
            return _list.GetElement(_index);
        }

        public bool MoveNext()
        {
            if (_index < _list.Length)
            {
                return true;
            }

            return false;
        }

        public void Next()
        {
            if (_index<_list.Length)
            {
                _index++;
            }
        }

        public void Reset()
        {
            _index = 0;
        }
    }
}
