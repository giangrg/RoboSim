using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RoboSimLib.Classes {
   public class Robot {

      // Defines the number of pixels per unit.
      private const int roboSize = 100;
      private Image RoboImg { get; set; }

      #region Properties
      private Point _coordinate;
      /// <summary>
      /// Get or set the current position of the robot.
      /// </summary>
      public Point Coordinate {
         get { return _coordinate; }
         set {
            if ((value.X >= 0 && value.X <= 500 - roboSize) && (value.Y >= 0 && value.Y <= 500 - roboSize)) {
               _coordinate = value;
            }
         }
      }

      /// <summary>
      /// Get or set the direction the robot's cardinal direction.
      /// </summary>
      public Direction FaceDirection { get; set; }
      #endregion Properties

      /// <summary>
      /// Instantiates a Robot object
      /// </summary>
      /// <param name="img">Image</param>
      /// <param name="imgOr">Cardinal direction</param>
      public Robot(Image img, Direction imgOr = Direction.North) {
         RoboImg = img;
         RoboImg.RotateFlip(RotateFlipType.Rotate180FlipNone);
         FaceDirection = imgOr;

         if (FaceDirection.Equals(Direction.East)) {
            RoboImg.RotateFlip(RotateFlipType.Rotate270FlipNone);
         }
         if (FaceDirection.Equals(Direction.South)) {
            RoboImg.RotateFlip(RotateFlipType.Rotate180FlipNone);
         }
         if (FaceDirection.Equals(Direction.West)) {
            RoboImg.RotateFlip(RotateFlipType.Rotate90FlipNone);
         }
      }

      #region Methods
      /// <summary>
      /// Draws the robot.
      /// </summary>
      /// <param name="table">Table where the robot will be placed</param>
      public void DrawRobo(Graphics table) {
         table.DrawImage(RoboImg, _coordinate.X, _coordinate.Y, roboSize, roboSize);
      }

      /// <summary>
      /// Moves the robot 1 unit forward in the direction it is facing.
      /// </summary>
      public void MoveForward() {
         int xPos = _coordinate.X;
         int yPos = _coordinate.Y;
         
         if (FaceDirection.Equals(Direction.North)) {
            yPos += roboSize;
         }
         if (FaceDirection.Equals(Direction.East)) {
            xPos += roboSize;
         }
         if (FaceDirection.Equals(Direction.South)) {
            yPos -= roboSize;
         }
         if (FaceDirection.Equals(Direction.West)) {
            xPos -= roboSize;
         }

         Coordinate = new Point(xPos, yPos);
      }

      /// <summary>
      /// Rotates the robot 1 cardinal point to the left or right.
      /// </summary>
      /// <param name="opt">Direction to rotate the robot</param>
      public void RotateRobo(RotateOptions opt) {
         if(opt.Equals(RotateOptions.Left)) {
            RoboImg.RotateFlip(RotateFlipType.Rotate90FlipNone);
            if ((int)FaceDirection > 0) {
               FaceDirection -= 1;
            }
            else {
               FaceDirection = (Direction)Enum.GetValues(typeof(Direction)).Length - 1;
            }
         } else {
            RoboImg.RotateFlip(RotateFlipType.Rotate270FlipNone);
            if ((int)FaceDirection < Enum.GetValues(typeof(Direction)).Length - 1) {
               FaceDirection += 1;
            }
            else {
               FaceDirection = (Direction)0;
            }
         }
      }
      #endregion Methods
   }
}
