using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class CommandTurn : ICommand
    {
        private double Angle { get; set; }
        public CommandTurn(double angle)
        {
            Angle = angle;
        }
        public void Execute(IRobot robot)
        {
            robot.Turn(Angle);
        }
    }
}
