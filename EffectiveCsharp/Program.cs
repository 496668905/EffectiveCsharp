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
            c.cj += c_ThresholdReached;

            Console.WriteLine("press 'a' key to increase total");
            string name = "";
            while ((name=Console.ReadLine())!="")
            {
                c.CjFun(name);
            }
        }

        static void c_ThresholdReached(object sender, CjEventArg e)
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
