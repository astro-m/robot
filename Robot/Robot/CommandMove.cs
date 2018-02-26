using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class CommandMove : ICommand
    {
        private double Distance { get; set; }

        public CommandMove(double distance)
        {
            Distance = distance;
        }
        public void Execute(IRobot robot)
        {
            robot.Move(Distance);
        }
    }
}
