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

      public Robot() {

      }

      public Robot(Image img) {
         RoboImg = img;
         RoboImg.RotateFlip(RotateFlipType.Rotate180FlipX);
      }

      public void DrawRobo(Graphics table) {
         table.DrawImage(RoboImg, _coordinate.X, _coordinate.Y, roboSize, roboSize);
      }
   }
}
