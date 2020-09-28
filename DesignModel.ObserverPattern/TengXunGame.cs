using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.ObserverPattern
{
    /// <summary>
    /// 具体订阅号类
    /// </summary>
    public class TengXunGame : TengXun
    {
        public TengXunGame(string symbol, string info)
            : base(symbol, info)
        {

        }
    }
}
