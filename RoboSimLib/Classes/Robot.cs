using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoboSimLib.Interfaces;

namespace RoboSimLib.Classes {
   public class Robot : IPlayer {
      public bool MoveUp() {
         return false;
      }

      public bool MoveRight() {
         return false;
      }

      public bool MoveDown() {
         return false;
      }

      public bool MoveLeft() {
         return false;
      }
   }
}
