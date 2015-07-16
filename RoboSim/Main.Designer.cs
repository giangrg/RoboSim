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
         this.pnlTable = new System.Windows.Forms.Panel();
         this.grbxControls = new System.Windows.Forms.GroupBox();
         this.btnReport = new System.Windows.Forms.Button();
         this.btnRight = new System.Windows.Forms.Button();
         this.btnLeft = new System.Windows.Forms.Button();
         this.btnPlace = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.txtY = new System.Windows.Forms.TextBox();
         this.lblX = new System.Windows.Forms.Label();
         this.txtX = new System.Windows.Forms.TextBox();
         this.btnMove = new System.Windows.Forms.Button();
         this.cmbF = new System.Windows.Forms.ComboBox();
         this.grbxControls.SuspendLayout();
         this.SuspendLayout();
         // 
         // pnlTable
         // 
         this.pnlTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.pnlTable.BackgroundImage = global::RoboSim.AppResource.Table;
         this.pnlTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.pnlTable.Location = new System.Drawing.Point(288, 8);
         this.pnlTable.Name = "pnlTable";
         this.pnlTable.Size = new System.Drawing.Size(500, 500);
         this.pnlTable.TabIndex = 1;
         this.pnlTable.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTable_Paint);
         // 
         // grbxControls
         // 
         this.grbxControls.Controls.Add(this.cmbF);
         this.grbxControls.Controls.Add(this.btnMove);
         this.grbxControls.Controls.Add(this.btnReport);
         this.grbxControls.Controls.Add(this.btnRight);
         this.grbxControls.Controls.Add(this.btnLeft);
         this.grbxControls.Controls.Add(this.btnPlace);
         this.grbxControls.Controls.Add(this.label2);
         this.grbxControls.Controls.Add(this.label1);
         this.grbxControls.Controls.Add(this.txtY);
         this.grbxControls.Controls.Add(this.lblX);
         this.grbxControls.Controls.Add(this.txtX);
         this.grbxControls.Location = new System.Drawing.Point(13, 8);
         this.grbxControls.Name = "grbxControls";
         this.grbxControls.Size = new System.Drawing.Size(269, 500);
         this.grbxControls.TabIndex = 2;
         this.grbxControls.TabStop = false;
         this.grbxControls.Text = "Controls";
         // 
         // btnReport
         // 
         this.btnReport.Location = new System.Drawing.Point(22, 271);
         this.btnReport.Name = "btnReport";
         this.btnReport.Size = new System.Drawing.Size(206, 35);
         this.btnReport.TabIndex = 10;
         this.btnReport.Text = "Report";
         this.btnReport.UseVisualStyleBackColor = true;
         // 
         // btnRight
         // 
         this.btnRight.Location = new System.Drawing.Point(128, 230);
         this.btnRight.Name = "btnRight";
         this.btnRight.Size = new System.Drawing.Size(100, 35);
         this.btnRight.TabIndex = 9;
         this.btnRight.Text = "Right";
         this.btnRight.UseVisualStyleBackColor = true;
         this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
         // 
         // btnLeft
         // 
         this.btnLeft.Location = new System.Drawing.Point(22, 230);
         this.btnLeft.Name = "btnLeft";
         this.btnLeft.Size = new System.Drawing.Size(100, 35);
         this.btnLeft.TabIndex = 8;
         this.btnLeft.Text = "Left";
         this.btnLeft.UseVisualStyleBackColor = true;
         this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
         // 
         // btnPlace
         // 
         this.btnPlace.Location = new System.Drawing.Point(22, 148);
         this.btnPlace.Name = "btnPlace";
         this.btnPlace.Size = new System.Drawing.Size(206, 35);
         this.btnPlace.TabIndex = 7;
         this.btnPlace.Text = "Place";
         this.btnPlace.UseVisualStyleBackColor = true;
         this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
         // 
         // label2
         // 
         this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label2.Location = new System.Drawing.Point(22, 110);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(100, 23);
         this.label2.TabIndex = 6;
         this.label2.Text = "F Direction";
         // 
         // label1
         // 
         this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label1.Location = new System.Drawing.Point(22, 77);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(100, 23);
         this.label1.TabIndex = 4;
         this.label1.Text = "Y Position";
         // 
         // txtY
         // 
         this.txtY.Location = new System.Drawing.Point(128, 77);
         this.txtY.Name = "txtY";
         this.txtY.Size = new System.Drawing.Size(100, 22);
         this.txtY.TabIndex = 3;
         this.txtY.Text = "0";
         // 
         // lblX
         // 
         this.lblX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.lblX.Location = new System.Drawing.Point(22, 43);
         this.lblX.Name = "lblX";
         this.lblX.Size = new System.Drawing.Size(100, 23);
         this.lblX.TabIndex = 2;
         this.lblX.Text = "X Position";
         // 
         // txtX
         // 
         this.txtX.Location = new System.Drawing.Point(128, 43);
         this.txtX.Name = "txtX";
         this.txtX.Size = new System.Drawing.Size(100, 22);
         this.txtX.TabIndex = 0;
         this.txtX.Text = "0";
         // 
         // btnMove
         // 
         this.btnMove.Location = new System.Drawing.Point(22, 189);
         this.btnMove.Name = "btnMove";
         this.btnMove.Size = new System.Drawing.Size(206, 35);
         this.btnMove.TabIndex = 11;
         this.btnMove.Text = "Move";
         this.btnMove.UseVisualStyleBackColor = true;
         this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
         // 
         // cmbF
         // 
         this.cmbF.FormattingEnabled = true;
         this.cmbF.Location = new System.Drawing.Point(128, 110);
         this.cmbF.Name = "cmbF";
         this.cmbF.Size = new System.Drawing.Size(100, 24);
         this.cmbF.TabIndex = 12;
         // 
         // Main
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.ClientSize = new System.Drawing.Size(800, 513);
         this.Controls.Add(this.grbxControls);
         this.Controls.Add(this.pnlTable);
         this.DoubleBuffered = true;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "Main";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "RoboSim";
         this.Load += new System.EventHandler(this.Main_Load);
         this.grbxControls.ResumeLayout(false);
         this.grbxControls.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel pnlTable;
      private System.Windows.Forms.GroupBox grbxControls;
      private System.Windows.Forms.Label lblX;
      private System.Windows.Forms.TextBox txtX;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtY;
      private System.Windows.Forms.Button btnPlace;
      private System.Windows.Forms.Button btnLeft;
      private System.Windows.Forms.Button btnRight;
      private System.Windows.Forms.Button btnReport;
      private System.Windows.Forms.Button btnMove;
      private System.Windows.Forms.ComboBox cmbF;
   }
}

