﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboSimLib {

   /// <summary>
   /// Contains all the valid orientations
   /// </summary>
   public enum Direction {
      North = 0,
      East = 1,
      South = 2,
      West = 3
   }

   /// <summary>
   /// List of all the valid rotation options
   /// </summary>
   public enum RotateOptions {
      Left = 0,
      Right = 1
   }

   /// <summary>
   /// List of all valid commands
   /// </summary>
   public enum CommandOptions {
      PLACE = 0,
      MOVE = 1,
      LEFT = 2,
      RIGHT = 3,
      REPORT = 4
   }
}
