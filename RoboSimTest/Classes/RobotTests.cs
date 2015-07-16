using System;
using System.Drawing;
using NUnit.Framework;
using RoboSimLib;
using RoboSimLib.Classes;

namespace RoboSimTest {
   [TestFixture]
   public class RobotTests {

      private Robot TestRobo;
      private Bitmap TestImg;

      [SetUp]
      public void SetUp() {
         TestImg = new Bitmap(100, 100);
         TestRobo = new Robot(TestImg);
         TestRobo.Coordinate = new Point(200, 200);
      }

      [Test]
      public void RejectsOutOfBoundsCoordinate() {
         TestRobo.Coordinate = new Point(501, 0);

         var expected = new Point(200, 200);
         var actual = TestRobo.Coordinate;

         Assert.AreEqual(expected, actual);
      }

      [Test]
      public void CanMoveNorthWhenFacingNorth() {
         TestRobo.MoveForward();

         var expected = 300;
         var actual = TestRobo.Coordinate.Y;

         Assert.AreEqual(expected, actual);
      }

      [Test]
      public void CanMoveEastWhenFacingEast() {
         TestRobo.FaceDirection = Direction.East;
         TestRobo.MoveForward();

         var expected = 300;
         var actual = TestRobo.Coordinate.X;

         Assert.AreEqual(expected, actual);
      }

      [Test]
      public void CanMoveSouthWhenFacingSouth() {
         TestRobo.FaceDirection = Direction.South;
         TestRobo.MoveForward();

         var expected = 100;
         var actual = TestRobo.Coordinate.Y;

         Assert.AreEqual(expected, actual);
      }

      [Test]
      public void CanMoveWestWhenFacingWest() {
         TestRobo.FaceDirection = Direction.West;
         TestRobo.MoveForward();

         var expected = 100;
         var actual = TestRobo.Coordinate.X;

         Assert.AreEqual(expected, actual);
      }

      [Test]
      public void CanRotateLeft() {
         TestRobo.FaceDirection = Direction.East;
         TestRobo.RotateRobo(RotateOptions.Left);

         var expected = Direction.North;
         var actual = TestRobo.FaceDirection;

         Assert.AreEqual(expected, actual);
      }

      [Test]
      public void CanRotateRight() {
         TestRobo.FaceDirection = Direction.East;
         TestRobo.RotateRobo(RotateOptions.Right);

         var expected = Direction.South;
         var actual = TestRobo.FaceDirection;

         Assert.AreEqual(expected, actual);
      }

      [Test]
      public void CanLoopBackFromLeft() {
         TestRobo.RotateRobo(RotateOptions.Left);

         var expected = Direction.West;
         var actual = TestRobo.FaceDirection;

         Assert.AreEqual(expected, actual);
      }

      [Test]
      public void CanLoopBackFromRight() {
         TestRobo.FaceDirection = Direction.West;
         TestRobo.RotateRobo(RotateOptions.Right);

         var expected = Direction.North;
         var actual = TestRobo.FaceDirection;

         Assert.AreEqual(expected, actual);
      }
   }
}
