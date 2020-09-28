using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.ObserverPattern
{
    /// <summary>
    /// 具体订阅者类
    /// </summary>
    public class Subscriber
    {
        public string Name { get; set; }

        public Subscriber(string name)
        {
            this.Name = name;
        }


        public void ReceiverAndPrint(object obj)
        {
            TengXun tengXun=obj as TengXun;
            if (tengXun!=null)
            {
                Console.WriteLine($"订阅者{Name},订阅{tengXun.Symbol}了{tengXun.Info}");
            }
        }
    }
}
