using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 商场管理软件
{
    class CashFactory
    {
        public static CashSuper createCashAccept(string type)
        {
            CashSuper cs = null;
            switch (type)
            {
                case "正常收费":
                    cs = new CashNormal();
                    break;
                case "满300返100":
                    CashReturn cr1 = new CashReturn("300","100");
                    break;
                case "打八折":
                    CashRebate cr2 = new CashRebate("0.8");
                    cs = cr2;
                    break;
            }
            return cs;
        }
    }
}
