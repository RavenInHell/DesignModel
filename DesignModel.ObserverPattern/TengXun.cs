using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.ObserverPattern
{
    //委托充当订阅者接口类
    public delegate void NotifyEventHandler(object sender);
    public class TengXun
    {
        public NotifyEventHandler NotifyEvent;

        public string Symbol { get; set; }

        public string Info { get; set; }

        public TengXun(string symbol, string info)
        {
            this.Symbol = symbol;
            this.Info = info;
        }


        #region 新增对订阅号列表的维护操作

        /// <summary>
        /// 添加订阅人员
        /// </summary>
        /// <param name="obj"></param>
        public void AddObserver(NotifyEventHandler obj)
        {
            NotifyEvent += obj;
        }
        /// <summary>
        /// 移除订阅人员
        /// </summary>
        /// <param name="obj"></param>
        public void RemoveObserver(NotifyEventHandler obj)
        {
            NotifyEvent -= obj;
        } 
        #endregion


        public void Update()
        {
            if (NotifyEvent!=null)
            {
                NotifyEvent(this);
            }
        }

    }
}
