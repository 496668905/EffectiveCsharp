using EffectiveCsharp._1To25;
using System;
using static System.Console;
namespace EffectiveCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Choujiang c = new Choujiang();
            c.cj += c_choujiang;

            Console.WriteLine("请填写你的名字");
            string name = "";
            while ((name=Console.ReadLine())!="")
            {
                c.CjFun(name);
                 Console.WriteLine("请填写你的名字");
            }
        }

        static void c_choujiang(object sender, CjEventArg e)
        {
            Console.WriteLine($"{e.date}恭喜你中奖了");
            Environment.Exit(0);
        }
    }

    class Choujiang
    {
        public event EventHandler<CjEventArg> cj;
        public void CjFun(string name)
        {
            if (name == "xx")
            {
                CjEventArg cc = new CjEventArg();
                cc.date = DateTime.Now;
                cj.Invoke(this,cc);
               
            }
        }
    }

    class CjEventArg : EventArgs
    {
        public DateTime date;
    }
}
