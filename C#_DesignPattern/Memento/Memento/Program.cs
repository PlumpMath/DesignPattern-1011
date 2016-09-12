using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            //大战Boss前
            GameRole lixiaoyao = new GameRole();
            lixiaoyao.GetInitate();
            lixiaoyao.StateDisplay();

            //保存进展
            RoleStateCaretakercs stateAdmin = new RoleStateCaretakercs();
            stateAdmin.Memento = lixiaoyao.SaveState();

            //大战Boss时，损耗严重
            lixiaoyao.Fight();
            lixiaoyao.StateDisplay();

            //恢复之前状态
            lixiaoyao.RecoveryState(stateAdmin.Memento);
            lixiaoyao.StateDisplay();


            Console.Read();
        }
    }
}
