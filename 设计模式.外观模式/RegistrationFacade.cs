using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.外观模式.Subsystem;

namespace 设计模式.外观模式
{
    /// <summary>
    /// 外观类
    /// </summary>
    public class RegistrationFacade
    {
        private RegisterCourse registerCourse;
        private NotifyStudent notifyStudent;

        public RegistrationFacade()
        {
            registerCourse =new RegisterCourse();
            notifyStudent = new NotifyStudent();
        }

        public bool RegisterCourse(string courseName, string studentName)
        {
            //先判断课程人数是否满员
            if (!registerCourse.CheckAvailable(courseName))
            {
                return false;
            }
            //再通知学生是否成功
            return notifyStudent.Notify(studentName);
        }
    }
}
