using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace 设计模式.备忘录模式
{
    /// <summary>
    /// 设计模式-备忘录模式 https://www.cnblogs.com/zhili/p/MementoPattern.html
    /// </summary>
    class Program
    {
        /// <summary>
        /// 下面以备份手机通讯录为例子来实现了备忘录模
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<ContactPerson> persons = new List<ContactPerson>()
            {
                new ContactPerson() {Name = "Learning Hard", MobileNum = "123456"},
                new ContactPerson() {Name = "Tony", MobileNum = "10086"},
                new ContactPerson() {Name = "Jock", MobileNum = "10010"}
            };
            //将联系人列表存储到List
            MobileOwner mobileOwner=new MobileOwner(persons);
            //展示List
            mobileOwner.Show();
            //实例化备份类
            Caretaker caretaker=new Caretaker();
            //进行备份
            caretaker.ContactMementoDis.Add(DateTime.Now.ToString(),mobileOwner.CreateMemento());

            Console.WriteLine("-----------移除最好一个联系人------------");
            //开始移除
            mobileOwner.ContactPersons.RemoveAt(2);//移除的索引
            //显示
            mobileOwner.Show();
            
            //创建第二个备份
            Thread.Sleep(1000);
            caretaker.ContactMementoDis.Add(DateTime.Now.ToString(),mobileOwner.CreateMemento());

            //给予恢复选择
            Console.WriteLine("--------恢复联系人列表，请从下列表选择恢复的日期------");
            var keyCollection = caretaker.ContactMementoDis.Keys;
            foreach (var k in keyCollection)
            {
                
                Console.WriteLine($"Key={k}");
            }

            while (true)
            {
                Console.Write("请输入数字，按窗口的关闭键退出。。。");
                int index = -1;
                try
                {
                    //获取输入的值
                    index = Int32.Parse(Console.ReadLine());

                }
                catch (Exception e)
                {
                    Console.WriteLine("输入的格式错误");
                    continue;
                }

                ContactMemento contactMementor = null;
                if (index<keyCollection.Count&&caretaker.ContactMementoDis.TryGetValue(keyCollection.ElementAt(index),out contactMementor))
                {
                    mobileOwner.RestoreMemento(contactMementor);
                    mobileOwner.Show();
                }
                else
                {
                    Console.WriteLine("输入的索引大于集合的长度！");
                }
            }

        }
    }
}
