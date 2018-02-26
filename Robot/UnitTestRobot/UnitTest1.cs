using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot;

namespace UnitTestRobot
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerificationCommandsRobot()
        {
            var robot = new Robot.Robot("#1");
            var invoker = new Invoker(robot);

            invoker.AddCommand(new CommandBeep());
            invoker.AddCommand(new CommandMove(10));
            invoker.AddCommand(new CommandTurn(20));
            invoker.Run();
            Assert.IsTrue(robot.IsBeep,"Не отработала команда beep");
            Assert.AreEqual(robot.Distance,10,0, "Не отработала команда move");
            Assert.AreEqual(robot.Angle, 20, 0, "Не отработала команда trun");
        }

        [TestMethod]
        public void VerificationCommandsRobots()
        {
            var robot1 = new Robot.Robot("#1");
            var invoker = new Invoker(robot1);

            invoker.AddCommand(new CommandBeep());
            invoker.AddCommand(new CommandMove(10));
            invoker.AddCommand(new CommandTurn(20));
            invoker.Run();
            for (var i = 0; i < 10; i++)
            {
                var robot2 = new Robot.Robot($"#{i}");
                invoker.SetRobot(robot2);
                invoker.Run();
                Assert.AreEqual(robot1.IsBeep, robot2.IsBeep, "Не совпадают команды beep");
                Assert.AreEqual(robot1.Distance, robot2.Distance, 0, "Не совпадают команды move");
                Assert.AreEqual(robot1.Angle, robot2.Angle, 0, "Не совпадают команды trun");
            }
            
        }

    }
}
