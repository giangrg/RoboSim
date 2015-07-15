using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboSimLib.Interfaces {
   public interface IPlayer {
      bool MoveUp();
      bool MoveRight();
      bool MoveDown();
      bool MoveLeft();
   }
}
