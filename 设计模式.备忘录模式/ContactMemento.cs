using System;
using System.Collections.Generic;
using System.Text;

namespace 设计模式.备忘录模式
{
    /// <summary>
    /// 备忘录
    /// </summary>
    public  class ContactMemento
    {
        public List<ContactPerson> ContactPersonsBack { get; set; }

        public ContactMemento(List<ContactPerson> persons)
        {
            ContactPersonsBack = persons;
        }

        
    }
}
