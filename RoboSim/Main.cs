using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
      }

      private void Main_Load(object sender, EventArgs e) {
         // Set the combobox items to use the Direction enum
         cmbF.DataSource = Enum.GetValues(typeof(Direction));
      }

      private void pnlTable_Paint(object sender, PaintEventArgs e) {
         Table = e.Graphics;
         
         // Set the origin to the South-West corner
         Table.Transform = new Matrix(1, 0, 0, -1, 0, pnlTable.Height);

         // Draw the robot on the panel
         if (RoboPlayer != null) {
            RoboPlayer.DrawRobo(Table);
         }
      }

      private void btnPlace_Click(object sender, EventArgs e) {
         try {
            int xPos = 0, yPos = 0;

            // Get the values from the textboxes
            xPos = Convert.ToInt32(txtX.Text);
            yPos = Convert.ToInt32(txtY.Text);

            // Place a robot on the table
            RoboPlayer = new Robot(AppResource.Robot, (Direction)cmbF.SelectedIndex);
            RoboPlayer.Coordinate = new Point(xPos, yPos);

            // Activate controls
            grbxMoveCtrl.Enabled = true;
            grbxUtilityCtrl.Enabled = true;

            pnlTable.Refresh();
         }
         catch (Exception) {
            MessageBox.Show("Error: Invalid X or Y value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
         }
      }

      #region Movement_Events
      private void btnLeft_Click(object sender, EventArgs e) {
         RoboPlayer.RotateRobo(RotateOptions.Left);
         pnlTable.Refresh();
      }

      private void btnRight_Click(object sender, EventArgs e) {
         RoboPlayer.RotateRobo(RotateOptions.Right);
         pnlTable.Refresh();
      }

      private void btnMove_Click(object sender, EventArgs e) {
         RoboPlayer.MoveForward();
         pnlTable.Refresh();
      }
      #endregion Movement_Events

      #region Utility_Events
      private void btnImport_Click(object sender, EventArgs e) {
         if (ofdImportFile.ShowDialog() == DialogResult.OK) {
            if (File.Exists(ofdImportFile.FileName)) {
               using (StreamReader filereader = new StreamReader(ofdImportFile.FileName)) {
                  var line = filereader.ReadLine();
               }
            }
         }

      }

      private void btnReport_Click(object sender, EventArgs e) {
         StringBuilder reportStr = new StringBuilder();
         reportStr.AppendLine("X: " + RoboPlayer.Coordinate.X);
         reportStr.AppendLine("Y: " + RoboPlayer.Coordinate.Y);
         reportStr.AppendLine("F: " + RoboPlayer.FaceDirection.ToString());

         MessageBox.Show(reportStr.ToString(), "Robot Status", MessageBoxButtons.OK);
      }
      #endregion Utility Events
   }
}
