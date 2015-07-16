using System;
using NUnit.Framework;
using RoboSimLib;
using RoboSimLib.Classes;

namespace RoboSimTest {
   [TestFixture]
   public class RobotTests {

      private Robot TestRobo;

      [SetUp]
      public void SetUp() {
         TestRobo = new Robot();
      }
   }
}
