using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            IRobot robot = new Robot("#1");
            var invoker = new Invoker(robot);

            invoker.AddCommand(new CommandBeep());
            invoker.AddCommand(new CommandMove(10));
            invoker.AddCommand(new CommandTurn(20));
            invoker.Run();
            invoker.SetRobot(new Robot("#2"));
            invoker.Run();
            Console.ReadLine();

        }
    }
}
