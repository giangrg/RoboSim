using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoboSimLib;
using RoboSimLib.Classes;

namespace RoboSim {
   public partial class Main : Form {

      private Robot RoboPlayer = null;
      private Graphics Table = null;

      public Main() {
         InitializeComponent();
         RoboPlayer = new Robot(AppResource.Robot);
      }

      private void pnlTable_Paint(object sender, PaintEventArgs e) {
         Table = e.Graphics;
         
         // Set the origin to the South-West corner
         Table.Transform = new Matrix(1, 0, 0, -1, 0, pnlTable.Height);

         RoboPlayer.DrawRobo(Table);
      }

      private void btnPlace_Click(object sender, EventArgs e) {
         int xPos = 0, yPos = 0;
         Int32.TryParse(txtX.Text, out xPos);
         Int32.TryParse(txtY.Text, out yPos);
         RoboPlayer.Coordinate = new Point(xPos, yPos);
         pnlTable.Refresh();
      }
   }
}
