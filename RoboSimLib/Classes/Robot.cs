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

      public bool MoveUp() {
         if (!FaceDirection.Equals(Direction.North)) {
            FaceDirection = Direction.North;
            return false;
         }
         return true;
      }

      public bool MoveRight() {
         if (!FaceDirection.Equals(Direction.East)) {
            FaceDirection = Direction.East;
            return false;
         }
         return true;
      }

      public bool MoveDown() {
         if (!FaceDirection.Equals(Direction.South)) {
            FaceDirection = Direction.South;
            return false;
         }
         return true;
      }

      public bool MoveLeft() {
         if (!FaceDirection.Equals(Direction.West)) {
            FaceDirection = Direction.West;
            return false;
         }
         return true;
      }
   }
}
