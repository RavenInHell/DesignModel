using System;
using System.Collections.Generic;
using System.Text;

namespace 设计模式.外观模式.Subsystem
{
    /// <summary>
    /// 通知学生选课是否成功的系统
    /// </summary>
    public  class NotifyStudent
    {

        public bool Notify(string studentName)
        {
            Console.WriteLine($"正在向{studentName }发送通知，选课成功！");
            return true;
        }
    }
}
