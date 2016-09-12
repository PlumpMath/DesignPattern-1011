using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            //老板胡汉三
            Boss huhansan = new Boss();


            //看股票的同事
            StockObserver stockobserver1 = new StockObserver("person1",huhansan);
            NBAObserver nbaobserver1 = new NBAObserver("person2", huhansan);

            huhansan.Update += new EventHandler(stockobserver1.CloseStockMarket);
            huhansan.Update += new EventHandler(nbaobserver1.CloseNBADirectSeeding);

            //老板回来
            huhansan.SubjectState = "我胡汉三回来了！";

            //发出通知
            huhansan.Notify();

            Console.Read();
        }
    }
}
