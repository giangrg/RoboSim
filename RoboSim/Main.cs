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

      private void Robo_KeyDown(object sender, KeyEventArgs e) {

         int x = RoboPlayer.Location.X;
         int y = RoboPlayer.Location.Y;

         if (e.KeyData == Keys.Up) {
            y -= 100;
         }

         if (e.KeyData == Keys.Right) {
            x += 100;
         }

         if (e.KeyData == Keys.Down) {
            y += 100;
         }

         if (e.KeyData == Keys.Left) {
            x -= 100;
         }

         tlstXPos.Text = "X: " + x.ToString();
         tlstYPos.Text = "Y: " + y.ToString();
         tlstFDirection.Text = "F: " + RoboPlayer.FaceDirection.ToString();
         RoboPlayer.Location = new Point(x, y);
      }
   }
}
