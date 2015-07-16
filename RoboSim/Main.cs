using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoboSimLib;
using RoboSimLib.Classes;

namespace RoboSim {
   public partial class Main : Form {

      private Robot RoboPlayer;

      public Main() {
         InitializeComponent();
         KeyDown += new KeyEventHandler(Robo_KeyDown);
         InitialiseRobot();
         UpdateStatus();
      }

      private void InitialiseRobot() {
         RoboPlayer = new Robot() {
            Image = AppResource.Robot,
            Size = new Size(100, 100),
            Location = new Point(12, 12),
            FaceDirection = Direction.North,
            BackColor = Color.Transparent
         };
         this.Controls.Add(RoboPlayer);
      }

      private void UpdateStatus() {
         tlstXPos.Text = "X: " + RoboPlayer.Location.X.ToString();
         tlstYPos.Text = "Y: " + RoboPlayer.Location.Y.ToString();
         tlstFDirection.Text = "F: " + RoboPlayer.FaceDirection.ToString();
      }

      private void Robo_KeyDown(object sender, KeyEventArgs e) {

         var currentPos = RoboPlayer.Location;

         if (e.KeyData == Keys.Up) {
            RoboPlayer.MoveRobot(Direction.North);
         }

         if (e.KeyData == Keys.Right) {
            RoboPlayer.MoveRobot(Direction.East);
         }

         if (e.KeyData == Keys.Down) {
            RoboPlayer.MoveRobot(Direction.South);
         }

         if (e.KeyData == Keys.Left) {
            RoboPlayer.MoveRobot(Direction.West);
         }

         UpdateStatus();
      }
   }
}
