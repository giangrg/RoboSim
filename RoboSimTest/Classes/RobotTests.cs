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

      [Test]
      public void CanMoveUpImmediatelyOnlyWhenFacingUp() {
         // Arrange
         TestRobo.FaceDirection = Direction.North;

         // Act
         bool[] expected = { true, false, false, false };
         bool[] actual = {
                            TestRobo.MoveUp(),
                            TestRobo.MoveRight(),
                            TestRobo.MoveDown(),
                            TestRobo.MoveLeft()
                         };

         // Assert
         CollectionAssert.AreEqual(expected, actual);
      }

      [Test]
      public void CanMoveRightImmediatelyOnlyWhenFacingRight() {
         // Arrange
         TestRobo.FaceDirection = Direction.East;

         // Act
         bool[] expected = { true, false, false, false };
         bool[] actual = {
                            TestRobo.MoveRight(),
                            TestRobo.MoveUp(),
                            TestRobo.MoveDown(),
                            TestRobo.MoveLeft()
                         };

         // Assert
         CollectionAssert.AreEqual(expected, actual);
      }

      [Test]
      public void CanMoveDownImmediatelyOnlyWhenFacingDown() {
         // Arrange
         TestRobo.FaceDirection = Direction.South;

         // Act
         bool[] expected = { true, false, false, false };
         bool[] actual = {
                            TestRobo.MoveDown(),
                            TestRobo.MoveUp(),
                            TestRobo.MoveRight(),
                            TestRobo.MoveLeft()
                         };

         // Assert
         CollectionAssert.AreEqual(expected, actual);
      }

      [Test]
      public void CanMoveLeftImmediatelyOnlyWhenFacingLeft() {
         // Arrange
         TestRobo.FaceDirection = Direction.West;

         // Act
         bool[] expected = { true, false, false, false };
         bool[] actual = {
                            TestRobo.MoveLeft(),
                            TestRobo.MoveUp(),
                            TestRobo.MoveRight(),
                            TestRobo.MoveDown()
                         };

         // Assert
         CollectionAssert.AreEqual(expected, actual);
      }
   }
}
