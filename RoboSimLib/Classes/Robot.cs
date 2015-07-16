using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace RoboSimLib.Classes {
   public class Robot : PictureBox {

      private const int moveSpeed = 100;

      public Direction FaceDirection { get; set; }

      public bool MoveRobot(Direction dir) {
         var newPos = Location;

         if (!FaceDirection.Equals(dir)) {
            FaceDirection = dir;
            return false;
         }

         if (dir.Equals(Direction.North)) {
            newPos.Y -= moveSpeed;
         }
         if (dir.Equals(Direction.East)) {
            newPos.X += moveSpeed;
         }
         if (dir.Equals(Direction.South)) {
            newPos.Y += moveSpeed;
         }
         if (dir.Equals(Direction.West)) {
            newPos.X -= moveSpeed;
         }

         Location = newPos;

         return true;
      }

      public bool CheckBoundsX(Point pos) {
         if((pos.X >= 12 && pos.X <= 500)) {
            return true;
         }
         return false;
      }
   }
}
