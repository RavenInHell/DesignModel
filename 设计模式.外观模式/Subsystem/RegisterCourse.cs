using System;
using System.Collections.Generic;
using System.Text;

namespace 设计模式.外观模式.Subsystem
{
    /// <summary>
    /// 验证选课人数是否已满的系统
    /// </summary>
    public  class RegisterCourse
    {
        public bool CheckAvailable(string courseName)
        {
            Console.WriteLine($"正在验证课程{courseName}是否人数已满");
            return true;
        }
    }
}
