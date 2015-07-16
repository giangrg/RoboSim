using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RoboSimLib.Classes {
   public class Robot {

      private Image RoboImg { get; set; }
      private const int roboSize = 100;

      private Point _coordinate;
      public Point Coordinate {
         get { return _coordinate; }
         set {
            if ((value.X >= 0 && value.X <= 400) && (value.Y >= 0 && value.Y <= 400)) {
               _coordinate = value;
            }
         }
      }

      public Direction FaceDirection { get; set; }

      public Robot(Image img, Direction imgOr = Direction.North) {
         RoboImg = img;
         RoboImg.RotateFlip(RotateFlipType.Rotate180FlipX);
         FaceDirection = imgOr;

         if (FaceDirection.Equals(Direction.East)) {
            RoboImg.RotateFlip(RotateFlipType.Rotate90FlipNone);
         }
         if (FaceDirection.Equals(Direction.South)) {
            RoboImg.RotateFlip(RotateFlipType.Rotate180FlipNone);
         }
         if (FaceDirection.Equals(Direction.West)) {
            RoboImg.RotateFlip(RotateFlipType.Rotate270FlipNone);
         }
      }

      public void DrawRobo(Graphics table) {
         table.DrawImage(RoboImg, _coordinate.X, _coordinate.Y, roboSize, roboSize);
      }

      public void MoveForward() {
         int xPos = _coordinate.X;
         int yPos = _coordinate.Y;
         
         if (FaceDirection.Equals(Direction.North)) {
            yPos += roboSize;
         }
         if (FaceDirection.Equals(Direction.East)) {
            xPos -= roboSize;
         }
         if (FaceDirection.Equals(Direction.South)) {
            yPos -= roboSize;
         }
         if (FaceDirection.Equals(Direction.West)) {
            xPos += roboSize;
         }

         Coordinate = new Point(xPos, yPos);
      }

      public void RotateRobo(RotateOptions opt) {
         if(opt.Equals(RotateOptions.Left)) {
            RoboImg.RotateFlip(RotateFlipType.Rotate90FlipNone);
            if ((int)FaceDirection < Enum.GetValues(typeof(Direction)).Length - 1) {
               FaceDirection += 1;
            }
            else {
               FaceDirection = (Direction)0;
            }
         } else {
            RoboImg.RotateFlip(RotateFlipType.Rotate270FlipNone);
            if ((int)FaceDirection > 0) {
               FaceDirection -= 1;
            }
            else {
               FaceDirection = (Direction)Enum.GetValues(typeof(Direction)).Length - 1;
            }
         }
      }
   }
}
