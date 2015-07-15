namespace RoboSim {
   partial class Main {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.tlstXPos = new System.Windows.Forms.ToolStripStatusLabel();
         this.tlstYPos = new System.Windows.Forms.ToolStripStatusLabel();
         this.tlstFDirection = new System.Windows.Forms.ToolStripStatusLabel();
         this.statusStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // statusStrip1
         // 
         this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstXPos,
            this.tlstYPos,
            this.tlstFDirection});
         this.statusStrip1.Location = new System.Drawing.Point(0, 511);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(523, 25);
         this.statusStrip1.TabIndex = 0;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // tlstXPos
         // 
         this.tlstXPos.Name = "tlstXPos";
         this.tlstXPos.Size = new System.Drawing.Size(33, 20);
         this.tlstXPos.Text = "X: 0";
         // 
         // tlstYPos
         // 
         this.tlstYPos.Name = "tlstYPos";
         this.tlstYPos.Size = new System.Drawing.Size(32, 20);
         this.tlstYPos.Text = "Y: 0";
         // 
         // tlstFDirection
         // 
         this.tlstFDirection.Name = "tlstFDirection";
         this.tlstFDirection.Size = new System.Drawing.Size(61, 20);
         this.tlstFDirection.Text = "F: North";
         // 
         // Main
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = global::RoboSim.AppResource.Table;
         this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.ClientSize = new System.Drawing.Size(523, 536);
         this.Controls.Add(this.statusStrip1);
         this.DoubleBuffered = true;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "Main";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "RoboSim";
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.ToolStripStatusLabel tlstXPos;
      private System.Windows.Forms.ToolStripStatusLabel tlstYPos;
      private System.Windows.Forms.ToolStripStatusLabel tlstFDirection;
   }
}

