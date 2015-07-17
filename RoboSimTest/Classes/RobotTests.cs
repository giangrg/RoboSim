using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoboSimLib;
using RoboSimLib.Classes;

namespace RoboSimTest {
   [TestClass]
   public class RobotTests {

      private Robot TestRobo;
      private Bitmap TestImg;

      [TestInitialize]
      public void SetUp() {
         TestImg = new Bitmap(100, 100);
         TestRobo = new Robot(TestImg);
         TestRobo.Coordinate = new Point(200, 200);
      }

      [TestMethod]
      public void RejectsOutOfBoundsCoordinate() {
         TestRobo.Coordinate = new Point(501, 0);

         var expected = new Point(200, 200);
         var actual = TestRobo.Coordinate;

         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void CanMoveNorthWhenFacingNorth() {
         TestRobo.MoveForward();

         var expected = 300;
         var actual = TestRobo.Coordinate.Y;

         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void CanMoveEastWhenFacingEast() {
         TestRobo.FaceDirection = Direction.East;
         TestRobo.MoveForward();

         var expected = 300;
         var actual = TestRobo.Coordinate.X;

         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void CanMoveSouthWhenFacingSouth() {
         TestRobo.FaceDirection = Direction.South;
         TestRobo.MoveForward();

         var expected = 100;
         var actual = TestRobo.Coordinate.Y;

         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void CanMoveWestWhenFacingWest() {
         TestRobo.FaceDirection = Direction.West;
         TestRobo.MoveForward();

         var expected = 100;
         var actual = TestRobo.Coordinate.X;

         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void CanRotateLeft() {
         TestRobo.FaceDirection = Direction.East;
         TestRobo.RotateRobo(RotateOptions.Left);

         var expected = Direction.North;
         var actual = TestRobo.FaceDirection;

         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void CanRotateRight() {
         TestRobo.FaceDirection = Direction.East;
         TestRobo.RotateRobo(RotateOptions.Right);

         var expected = Direction.South;
         var actual = TestRobo.FaceDirection;

         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void CanLoopBackFromLeft() {
         TestRobo.RotateRobo(RotateOptions.Left);

         var expected = Direction.West;
         var actual = TestRobo.FaceDirection;

         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void CanLoopBackFromRight() {
         TestRobo.FaceDirection = Direction.West;
         TestRobo.RotateRobo(RotateOptions.Right);

         var expected = Direction.North;
         var actual = TestRobo.FaceDirection;

         Assert.AreEqual(expected, actual);
      }
   }
}
