using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Robot : IRobot
    {
        public string Name { get; set; }

        public double Distance { get; set; }

        public double Angle { get; set; }

        public bool IsBeep { get; set; }

        public Robot(string name)
        {
            Name = name;
        }
        public void Beep()
        {
            IsBeep = true;
            Console.WriteLine($"Робот:{Name}. команда: Звуковой сигнал");
        }

        public void Move(double distance)
        {
            Distance += distance;
            Console.WriteLine($"Робот:{Name}. команда: Переместится на {distance}");
        }

        public void Turn(double angle)
        {
            Angle += angle;
            Console.WriteLine($"Робот:{Name}. команда: Пловернутся на {angle}");
        }
    }
}
