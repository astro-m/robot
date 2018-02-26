using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
   public class Invoker
    {
        /// <summary>
        /// Список команд
        /// </summary>
        private List<ICommand> Command { get; set; }
        /// <summary>
        ///  Текущий робот, который будет исполнять команды
        /// </summary>
        private IRobot Robot { get; set; }
        /// <summary>
        /// Инициализация объекта вызыва
        /// </summary>
        /// <param name="robot">Текущий робот</param>
        public Invoker(IRobot robot)
        {
            Robot = robot;
            Command = new List<ICommand>();
        }
        /// <summary>
        /// Добавить команду
        /// </summary>
        /// <param name="com">Добавить команду в очередь</param>
        public void AddCommand(ICommand com)
        {
            Command.Add(com);
        }
        /// <summary>
        /// Установить нового робота
        /// </summary>
        /// <param name="robot">Новый робот</param>
        public void SetRobot(IRobot robot)
        {
            Robot = robot;
        } 
        /// <summary>
        /// Исполнить все команды
        /// </summary>
        public void Run()
        {
            foreach (var com in Command)
            {
                com.Execute(Robot);
            }
        }
    }
}
