namespace FractalViewer
{
    partial class SierpinskiGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.desktopImageButton = new System.Windows.Forms.Button();
            this.btnChoosePoints = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.Color3Label = new System.Windows.Forms.Label();
            this.Color2Label = new System.Windows.Forms.Label();
            this.Color1Label = new System.Windows.Forms.Label();
            this.color3Box = new System.Windows.Forms.PictureBox();
            this.color2Box = new System.Windows.Forms.PictureBox();
            this.color1Box = new System.Windows.Forms.PictureBox();
            this.btnDetailLevel = new System.Windows.Forms.Button();
            this.txtDetailLevel = new System.Windows.Forms.TextBox();
            this.lblDetailLevel = new System.Windows.Forms.Label();
            this.btnPortal = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.resolutionButton = new System.Windows.Forms.Button();
            this.resYBox = new System.Windows.Forms.TextBox();
            this.resXBox = new System.Windows.Forms.TextBox();
            this.resYLabel = new System.Windows.Forms.Label();
            this.resXLabel = new System.Windows.Forms.Label();
            this.colorApply = new System.Windows.Forms.Button();
            this.colorDialogLabel = new System.Windows.Forms.Label();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color3Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color2Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color1Box)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.desktopImageButton);
            this.panel1.Controls.Add(this.btnChoosePoints);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.Color3Label);
            this.panel1.Controls.Add(this.Color2Label);
            this.panel1.Controls.Add(this.Color1Label);
            this.panel1.Controls.Add(this.color3Box);
            this.panel1.Controls.Add(this.color2Box);
            this.panel1.Controls.Add(this.color1Box);
            this.panel1.Controls.Add(this.btnDetailLevel);
            this.panel1.Controls.Add(this.txtDetailLevel);
            this.panel1.Controls.Add(this.lblDetailLevel);
            this.panel1.Controls.Add(this.btnPortal);
            this.panel1.Controls.Add(this.btnQuit);
            this.panel1.Controls.Add(this.resolutionButton);
            this.panel1.Controls.Add(this.resYBox);
            this.panel1.Controls.Add(this.resXBox);
            this.panel1.Controls.Add(this.resYLabel);
            this.panel1.Controls.Add(this.resXLabel);
            this.panel1.Controls.Add(this.colorApply);
            this.panel1.Controls.Add(this.colorDialogLabel);
            this.panel1.Location = new System.Drawing.Point(608, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 557);
            this.panel1.TabIndex = 14;
            // 
            // desktopImageButton
            // 
            this.desktopImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.desktopImageButton.Location = new System.Drawing.Point(3, 505);
            this.desktopImageButton.Name = "desktopImageButton";
            this.desktopImageButton.Size = new System.Drawing.Size(169, 23);
            this.desktopImageButton.TabIndex = 17;
            this.desktopImageButton.Text = "Set Image to Desktop";
            this.desktopImageButton.UseVisualStyleBackColor = true;
            this.desktopImageButton.Click += new System.EventHandler(this.desktopImageButton_Click);
            // 
            // btnChoosePoints
            // 
            this.btnChoosePoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoosePoints.Location = new System.Drawing.Point(3, 414);
            this.btnChoosePoints.Name = "btnChoosePoints";
            this.btnChoosePoints.Size = new System.Drawing.Size(169, 30);
            this.btnChoosePoints.TabIndex = 32;
            this.btnChoosePoints.Text = "Choose New Points";
            this.btnChoosePoints.UseVisualStyleBackColor = true;
            this.btnChoosePoints.Click += new System.EventHandler(this.btnChoosePoints_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(3, 450);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(169, 49);
            this.btnStop.TabIndex = 31;
            this.btnStop.Text = "Stop Calculating";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // Color3Label
            // 
            this.Color3Label.Location = new System.Drawing.Point(111, 78);
            this.Color3Label.Name = "Color3Label";
            this.Color3Label.Size = new System.Drawing.Size(51, 11);
            this.Color3Label.TabIndex = 30;
            this.Color3Label.Text = "Color 3";
            this.Color3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Color2Label
            // 
            this.Color2Label.Location = new System.Drawing.Point(54, 78);
            this.Color2Label.Name = "Color2Label";
            this.Color2Label.Size = new System.Drawing.Size(51, 11);
            this.Color2Label.TabIndex = 29;
            this.Color2Label.Text = "Color 2";
            this.Color2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Color1Label
            // 
            this.Color1Label.Location = new System.Drawing.Point(0, 78);
            this.Color1Label.Name = "Color1Label";
            this.Color1Label.Size = new System.Drawing.Size(51, 11);
            this.Color1Label.TabIndex = 28;
            this.Color1Label.Text = "Color 1";
            this.Color1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // color3Box
            // 
            this.color3Box.Location = new System.Drawing.Point(111, 92);
            this.color3Box.Name = "color3Box";
            this.color3Box.Size = new System.Drawing.Size(48, 31);
            this.color3Box.TabIndex = 27;
            this.color3Box.TabStop = false;
            this.color3Box.Click += new System.EventHandler(this.colorBox_Click);
            // 
            // color2Box
            // 
            this.color2Box.Location = new System.Drawing.Point(57, 92);
            this.color2Box.Name = "color2Box";
            this.color2Box.Size = new System.Drawing.Size(48, 31);
            this.color2Box.TabIndex = 26;
            this.color2Box.TabStop = false;
            this.color2Box.Click += new System.EventHandler(this.colorBox_Click);
            // 
            // color1Box
            // 
            this.color1Box.Location = new System.Drawing.Point(3, 92);
            this.color1Box.Name = "color1Box";
            this.color1Box.Size = new System.Drawing.Size(48, 31);
            this.color1Box.TabIndex = 25;
            this.color1Box.TabStop = false;
            this.color1Box.Click += new System.EventHandler(this.colorBox_Click);
            // 
            // btnDetailLevel
            // 
            this.btnDetailLevel.Location = new System.Drawing.Point(3, 215);
            this.btnDetailLevel.Name = "btnDetailLevel";
            this.btnDetailLevel.Size = new System.Drawing.Size(169, 23);
            this.btnDetailLevel.TabIndex = 24;
            this.btnDetailLevel.Text = "Apply Detail Level";
            this.btnDetailLevel.UseVisualStyleBackColor = true;
            this.btnDetailLevel.Click += new System.EventHandler(this.applyDetail_Click);
            // 
            // txtDetailLevel
            // 
            this.txtDetailLevel.Location = new System.Drawing.Point(77, 191);
            this.txtDetailLevel.MaxLength = 7;
            this.txtDetailLevel.Name = "txtDetailLevel";
            this.txtDetailLevel.Size = new System.Drawing.Size(95, 20);
            this.txtDetailLevel.TabIndex = 23;
            // 
            // lblDetailLevel
            // 
            this.lblDetailLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailLevel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDetailLevel.Location = new System.Drawing.Point(3, 192);
            this.lblDetailLevel.Name = "lblDetailLevel";
            this.lblDetailLevel.Size = new System.Drawing.Size(77, 20);
            this.lblDetailLevel.TabIndex = 22;
            this.lblDetailLevel.Text = "Detail Level:";
            // 
            // btnPortal
            // 
            this.btnPortal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPortal.Location = new System.Drawing.Point(3, 534);
            this.btnPortal.Name = "btnPortal";
            this.btnPortal.Size = new System.Drawing.Size(87, 23);
            this.btnPortal.TabIndex = 19;
            this.btnPortal.Text = "Back to Portal";
            this.btnPortal.UseVisualStyleBackColor = true;
            this.btnPortal.Click += new System.EventHandler(this.btnPortal_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(91, 534);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(81, 23);
            this.btnQuit.TabIndex = 18;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // resolutionButton
            // 
            this.resolutionButton.Location = new System.Drawing.Point(3, 323);
            this.resolutionButton.Name = "resolutionButton";
            this.resolutionButton.Size = new System.Drawing.Size(169, 23);
            this.resolutionButton.TabIndex = 17;
            this.resolutionButton.Text = "Apply Resolution";
            this.resolutionButton.UseVisualStyleBackColor = true;
            this.resolutionButton.Click += new System.EventHandler(this.resolutionButton_Click);
            // 
            // resYBox
            // 
            this.resYBox.Location = new System.Drawing.Point(77, 300);
            this.resYBox.MaxLength = 4;
            this.resYBox.Name = "resYBox";
            this.resYBox.Size = new System.Drawing.Size(95, 20);
            this.resYBox.TabIndex = 16;
            // 
            // resXBox
            // 
            this.resXBox.Location = new System.Drawing.Point(77, 283);
            this.resXBox.MaxLength = 4;
            this.resXBox.Name = "resXBox";
            this.resXBox.Size = new System.Drawing.Size(95, 20);
            this.resXBox.TabIndex = 15;
            // 
            // resYLabel
            // 
            this.resYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resYLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resYLabel.Location = new System.Drawing.Point(0, 300);
            this.resYLabel.Name = "resYLabel";
            this.resYLabel.Size = new System.Drawing.Size(80, 20);
            this.resYLabel.TabIndex = 14;
            this.resYLabel.Text = "Y Resolution:";
            // 
            // resXLabel
            // 
            this.resXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resXLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resXLabel.Location = new System.Drawing.Point(0, 283);
            this.resXLabel.Name = "resXLabel";
            this.resXLabel.Size = new System.Drawing.Size(80, 20);
            this.resXLabel.TabIndex = 13;
            this.resXLabel.Text = "X Resolution:";
            // 
            // colorApply
            // 
            this.colorApply.Location = new System.Drawing.Point(3, 129);
            this.colorApply.Name = "colorApply";
            this.colorApply.Size = new System.Drawing.Size(156, 23);
            this.colorApply.TabIndex = 3;
            this.colorApply.Text = "Apply Color";
            this.colorApply.UseVisualStyleBackColor = true;
            this.colorApply.Click += new System.EventHandler(this.colorApply_Click);
            // 
            // colorDialogLabel
            // 
            this.colorDialogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorDialogLabel.Location = new System.Drawing.Point(0, 0);
            this.colorDialogLabel.Name = "colorDialogLabel";
            this.colorDialogLabel.Size = new System.Drawing.Size(165, 56);
            this.colorDialogLabel.TabIndex = 6;
            this.colorDialogLabel.Text = "Color Selection\r\nClick Color Box to Change Color";
            this.colorDialogLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayPanel
            // 
            this.displayPanel.AutoScroll = true;
            this.displayPanel.AutoSize = true;
            this.displayPanel.Location = new System.Drawing.Point(16, 24);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(0, 0);
            this.displayPanel.TabIndex = 11;
            // 
            // SierpinskiGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.displayPanel);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "SierpinskiGUI";
            this.Text = "SierpinskiGUI";
            this.Load += new System.EventHandler(this.SierpinskiGUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color3Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color2Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color1Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDetailLevel;
        private System.Windows.Forms.Label lblDetailLevel;
        private System.Windows.Forms.Button btnPortal;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button resolutionButton;
        private System.Windows.Forms.TextBox resYBox;
        private System.Windows.Forms.TextBox resXBox;
        private System.Windows.Forms.Label resYLabel;
        private System.Windows.Forms.Label resXLabel;
        private System.Windows.Forms.Button colorApply;
        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label colorDialogLabel;
        private System.Windows.Forms.Button btnDetailLevel;
        private System.Windows.Forms.Label Color3Label;
        private System.Windows.Forms.Label Color2Label;
        private System.Windows.Forms.Label Color1Label;
        private System.Windows.Forms.PictureBox color3Box;
        private System.Windows.Forms.PictureBox color2Box;
        private System.Windows.Forms.PictureBox color1Box;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnChoosePoints;
        private System.Windows.Forms.Button desktopImageButton;
    }
}