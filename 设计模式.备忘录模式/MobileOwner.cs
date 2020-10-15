using System;
using System.Collections.Generic;
using System.Text;

namespace 设计模式.备忘录模式
{
    /// <summary>
    /// 发起人
    /// </summary>
    public class MobileOwner
    {
        public List<ContactPerson> ContactPersons { get; set; }

        public MobileOwner(List<ContactPerson> persons)
        {
            ContactPersons = persons;
        }

        /// <summary>
        /// 创建备忘录，将当期要保存的联系人列表导入到备忘录中
        /// </summary>
        /// <returns></returns>
        public ContactMemento CreateMemento()
        {
            //这里也应该传递深拷贝，new list 方式传递的是浅拷贝
            //因为ContactPerson类中都是string类型，所以这里new list 方式对contactPerson对象执行深拷贝
            //如果ContactPerson 包括非String 的引用类型就会有问题，所以这里也应该用序列化传递深拷贝

            return new ContactMemento(new List<ContactPerson>(this.ContactPersons));
        }

        public void RestoreMemento(ContactMemento memento)
        {
            if (memento!=null)
            {
                this.ContactPersons = memento.ContactPersonsBack;
            }
        }

        public void Show()
        {
            Console.WriteLine($"联系人列表中有{ContactPersons.Count},列表如下：");
            foreach (var person in ContactPersons)
            {
                Console.WriteLine($"姓名：{person.Name}   \t电话号码：{person.MobileNum}");
            }
        }
    }
}
