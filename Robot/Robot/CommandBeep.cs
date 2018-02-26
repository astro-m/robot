using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class CommandBeep : ICommand
    {
        public void Execute(IRobot robot)
        {
            robot.Beep();
        }
    }
}
