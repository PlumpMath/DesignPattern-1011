using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flywight
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int extrinsicstate = 22;

            FlyweightFactory f = new FlyweightFactory();

            Flyweight fx = f.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            Flyweight fy = f.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            Flyweight fz = f.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            UnsharedConcreteFlyweight uf = new UnsharedConcreteFlyweight();

            uf.Operation(--extrinsicstate);

             */

            WebSiteFactory f = new WebSiteFactory();
            WebSite fx = f.GetWebSiteCategory("产品展示");
            fx.Use(new User("p1"));

            WebSite fy = f.GetWebSiteCategory("产品展示");
            fy.Use(new User("p2"));

            WebSite fz = f.GetWebSiteCategory("产品展示");
            fz.Use(new User("p2"));

            WebSite f1 = f.GetWebSiteCategory("博客");
            f1.Use(new User("p3"));

            WebSite fm = f.GetWebSiteCategory("博客");
            fm.Use(new User("p3"));

            WebSite fn = f.GetWebSiteCategory("博客");
            fn.Use(new User("p4"));

            Console.WriteLine("网站分类总数为{0}",f.GetWebSiteCount());

            Console.Read();
        }
    }
}
