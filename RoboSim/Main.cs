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
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoboSimLib;
using RoboSimLib.Classes;

namespace RoboSim {
   public partial class Main : Form {

      private Robot RoboPlayer = null;
      private Graphics Table = null;
      private const int magnitude = 100; // Pixels in 1 unit.

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

      #region Command_Events
      private void btnPlace_Click(object sender, EventArgs e) {
         try {
            int xPos = 0, yPos = 0;

            // Get the values from the textboxes
            xPos = Convert.ToInt32(txtX.Text) * magnitude;
            yPos = Convert.ToInt32(txtY.Text) * magnitude;

            // Place a robot on the table
            RoboPlayer = new Robot(AppResource.Robot, (Direction)cmbF.SelectedIndex);
            RoboPlayer.Coordinate = new Point(xPos, yPos);

            // Activate controls
            EnableControls();

            pnlTable.Refresh();
         }
         catch (Exception) {
            MessageBox.Show("Error: Invalid X or Y value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
         }
      }

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
      #endregion Command_Events

      #region Utility_Events
      private void btnImport_Click(object sender, EventArgs e) {
         if (ofdImportFile.ShowDialog() == DialogResult.OK) {
            if (File.Exists(ofdImportFile.FileName)) {
               using (StreamReader filereader = new StreamReader(ofdImportFile.FileName)) {
                  string line = string.Empty;
                  while ((line = filereader.ReadLine()) != null) {
                     ProcessInputCommands(line);
                  }
               }
            }
         }
      }

      private void ProcessInputCommands(string comLine) {
         // Split command at index [0] and parameter at index [1]
         var data = comLine.Split(' ').ToList();
         // Process command
         var command = (CommandOptions)Enum.Parse(typeof(CommandOptions), data[0], true);
         if (command.Equals(CommandOptions.PLACE)) {
            // Process parameters
            List<string> parameters;
            if (data.Count > 1) {
               parameters = data[1].Split(',').ToList();
               txtX.Text = parameters[0];
               txtY.Text = parameters[1];
               cmbF.Text = parameters[2];
               btnPlace_Click(null, null);
            }
         }
         if (command.Equals(CommandOptions.MOVE)) {
            btnMove_Click(null, null);
         }
         if (command.Equals(CommandOptions.LEFT)) {
            btnLeft_Click(null, null);
         }
         if (command.Equals(CommandOptions.RIGHT)) {
            btnRight_Click(null, null);
         }
         if (command.Equals(CommandOptions.REPORT)) {
            btnReport_Click(null, null);
         }
      }

      private void EnableControls() {
         grbxMoveCtrl.Enabled = true;
         grbxUtilityCtrl.Enabled = true;
      }

      private void btnReport_Click(object sender, EventArgs e) {
         StringBuilder reportStr = new StringBuilder();
         reportStr.AppendLine("X: " + RoboPlayer.Coordinate.X/magnitude);
         reportStr.AppendLine("Y: " + RoboPlayer.Coordinate.Y/magnitude);
         reportStr.AppendLine("F: " + RoboPlayer.FaceDirection.ToString());

         MessageBox.Show(reportStr.ToString(), "Robot Status", MessageBoxButtons.OK);
      }
      #endregion Utility Events
   }
}
