namespace FractalViewer
{
    partial class IFSGUI
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
            this.displayPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbIFSTypes = new System.Windows.Forms.ComboBox();
            this.lblTypes = new System.Windows.Forms.Label();
            this.desktopImageButton = new System.Windows.Forms.Button();
            this.Color4Label = new System.Windows.Forms.Label();
            this.color4Box = new System.Windows.Forms.PictureBox();
            this.Color3Label = new System.Windows.Forms.Label();
            this.color3Box = new System.Windows.Forms.PictureBox();
            this.Color2Label = new System.Windows.Forms.Label();
            this.color2Box = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.Color1Label = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color4Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color3Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color2Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color1Box)).BeginInit();
            this.SuspendLayout();
            // 
            // displayPanel
            // 
            this.displayPanel.AutoScroll = true;
            this.displayPanel.AutoSize = true;
            this.displayPanel.Location = new System.Drawing.Point(12, 12);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(0, 0);
            this.displayPanel.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbIFSTypes);
            this.panel1.Controls.Add(this.lblTypes);
            this.panel1.Controls.Add(this.desktopImageButton);
            this.panel1.Controls.Add(this.Color4Label);
            this.panel1.Controls.Add(this.color4Box);
            this.panel1.Controls.Add(this.Color3Label);
            this.panel1.Controls.Add(this.color3Box);
            this.panel1.Controls.Add(this.Color2Label);
            this.panel1.Controls.Add(this.color2Box);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.Color1Label);
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
            this.panel1.Location = new System.Drawing.Point(624, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 556);
            this.panel1.TabIndex = 19;
            // 
            // cbIFSTypes
            // 
            this.cbIFSTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIFSTypes.FormattingEnabled = true;
            this.cbIFSTypes.Items.AddRange(new object[] {
            "Fern",
            "FernPlant",
            "Maple Leaf",
            "Tree",
            "Dragon",
            "Spiral"});
            this.cbIFSTypes.Location = new System.Drawing.Point(3, 404);
            this.cbIFSTypes.Name = "cbIFSTypes";
            this.cbIFSTypes.Size = new System.Drawing.Size(152, 21);
            this.cbIFSTypes.TabIndex = 32;
            this.cbIFSTypes.SelectedIndexChanged += new System.EventHandler(this.cbIFSTypes_SelectedIndexChanged);
            // 
            // lblTypes
            // 
            this.lblTypes.AutoSize = true;
            this.lblTypes.Location = new System.Drawing.Point(3, 388);
            this.lblTypes.Name = "lblTypes";
            this.lblTypes.Size = new System.Drawing.Size(55, 13);
            this.lblTypes.TabIndex = 33;
            this.lblTypes.Text = "IFS Types";
            // 
            // desktopImageButton
            // 
            this.desktopImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.desktopImageButton.Location = new System.Drawing.Point(3, 501);
            this.desktopImageButton.Name = "desktopImageButton";
            this.desktopImageButton.Size = new System.Drawing.Size(152, 23);
            this.desktopImageButton.TabIndex = 40;
            this.desktopImageButton.Text = "Set Image to Desktop";
            this.desktopImageButton.UseVisualStyleBackColor = true;
            this.desktopImageButton.Click += new System.EventHandler(this.desktopImageButton_Click);
            // 
            // Color4Label
            // 
            this.Color4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color4Label.Location = new System.Drawing.Point(75, 125);
            this.Color4Label.Name = "Color4Label";
            this.Color4Label.Size = new System.Drawing.Size(48, 18);
            this.Color4Label.TabIndex = 39;
            this.Color4Label.Text = "Right Leaf";
            this.Color4Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // color4Box
            // 
            this.color4Box.Location = new System.Drawing.Point(75, 146);
            this.color4Box.Name = "color4Box";
            this.color4Box.Size = new System.Drawing.Size(48, 31);
            this.color4Box.TabIndex = 38;
            this.color4Box.TabStop = false;
            this.color4Box.Click += new System.EventHandler(this.colorBox_Click);
            // 
            // Color3Label
            // 
            this.Color3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color3Label.Location = new System.Drawing.Point(22, 125);
            this.Color3Label.Name = "Color3Label";
            this.Color3Label.Size = new System.Drawing.Size(42, 18);
            this.Color3Label.TabIndex = 37;
            this.Color3Label.Text = "Left Leaf";
            this.Color3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // color3Box
            // 
            this.color3Box.Location = new System.Drawing.Point(21, 146);
            this.color3Box.Name = "color3Box";
            this.color3Box.Size = new System.Drawing.Size(48, 31);
            this.color3Box.TabIndex = 36;
            this.color3Box.TabStop = false;
            this.color3Box.Click += new System.EventHandler(this.colorBox_Click);
            // 
            // Color2Label
            // 
            this.Color2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color2Label.Location = new System.Drawing.Point(75, 66);
            this.Color2Label.Name = "Color2Label";
            this.Color2Label.Size = new System.Drawing.Size(48, 18);
            this.Color2Label.TabIndex = 35;
            this.Color2Label.Text = "Top Leaf";
            this.Color2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // color2Box
            // 
            this.color2Box.Location = new System.Drawing.Point(75, 91);
            this.color2Box.Name = "color2Box";
            this.color2Box.Size = new System.Drawing.Size(48, 31);
            this.color2Box.TabIndex = 34;
            this.color2Box.TabStop = false;
            this.color2Box.Click += new System.EventHandler(this.colorBox_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(3, 446);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(152, 49);
            this.btnStop.TabIndex = 31;
            this.btnStop.Text = "Stop Calculating";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // Color1Label
            // 
            this.Color1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color1Label.Location = new System.Drawing.Point(19, 66);
            this.Color1Label.Name = "Color1Label";
            this.Color1Label.Size = new System.Drawing.Size(48, 18);
            this.Color1Label.TabIndex = 28;
            this.Color1Label.Text = "Trunk";
            this.Color1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // color1Box
            // 
            this.color1Box.Location = new System.Drawing.Point(21, 91);
            this.color1Box.Name = "color1Box";
            this.color1Box.Size = new System.Drawing.Size(48, 31);
            this.color1Box.TabIndex = 25;
            this.color1Box.TabStop = false;
            this.color1Box.Click += new System.EventHandler(this.colorBox_Click);
            // 
            // btnDetailLevel
            // 
            this.btnDetailLevel.Location = new System.Drawing.Point(3, 256);
            this.btnDetailLevel.Name = "btnDetailLevel";
            this.btnDetailLevel.Size = new System.Drawing.Size(152, 23);
            this.btnDetailLevel.TabIndex = 24;
            this.btnDetailLevel.Text = "Apply Detail Level";
            this.btnDetailLevel.UseVisualStyleBackColor = true;
            this.btnDetailLevel.Click += new System.EventHandler(this.applyDetail_Click);
            // 
            // txtDetailLevel
            // 
            this.txtDetailLevel.Location = new System.Drawing.Point(80, 232);
            this.txtDetailLevel.MaxLength = 7;
            this.txtDetailLevel.Name = "txtDetailLevel";
            this.txtDetailLevel.Size = new System.Drawing.Size(75, 20);
            this.txtDetailLevel.TabIndex = 23;
            // 
            // lblDetailLevel
            // 
            this.lblDetailLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailLevel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDetailLevel.Location = new System.Drawing.Point(3, 233);
            this.lblDetailLevel.Name = "lblDetailLevel";
            this.lblDetailLevel.Size = new System.Drawing.Size(80, 20);
            this.lblDetailLevel.TabIndex = 22;
            this.lblDetailLevel.Text = "Detail Level:";
            // 
            // btnPortal
            // 
            this.btnPortal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPortal.Location = new System.Drawing.Point(3, 530);
            this.btnPortal.Name = "btnPortal";
            this.btnPortal.Size = new System.Drawing.Size(97, 23);
            this.btnPortal.TabIndex = 19;
            this.btnPortal.Text = "Back to Portal";
            this.btnPortal.UseVisualStyleBackColor = true;
            this.btnPortal.Click += new System.EventHandler(this.btnPortal_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(103, 530);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(52, 23);
            this.btnQuit.TabIndex = 18;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // resolutionButton
            // 
            this.resolutionButton.Location = new System.Drawing.Point(3, 341);
            this.resolutionButton.Name = "resolutionButton";
            this.resolutionButton.Size = new System.Drawing.Size(152, 23);
            this.resolutionButton.TabIndex = 17;
            this.resolutionButton.Text = "Apply Resolution";
            this.resolutionButton.UseVisualStyleBackColor = true;
            this.resolutionButton.Click += new System.EventHandler(this.resolutionButton_Click);
            // 
            // resYBox
            // 
            this.resYBox.Location = new System.Drawing.Point(80, 317);
            this.resYBox.MaxLength = 4;
            this.resYBox.Name = "resYBox";
            this.resYBox.Size = new System.Drawing.Size(75, 20);
            this.resYBox.TabIndex = 16;
            // 
            // resXBox
            // 
            this.resXBox.Location = new System.Drawing.Point(80, 300);
            this.resXBox.MaxLength = 4;
            this.resXBox.Name = "resXBox";
            this.resXBox.Size = new System.Drawing.Size(75, 20);
            this.resXBox.TabIndex = 15;
            // 
            // resYLabel
            // 
            this.resYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resYLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resYLabel.Location = new System.Drawing.Point(3, 318);
            this.resYLabel.Name = "resYLabel";
            this.resYLabel.Size = new System.Drawing.Size(80, 20);
            this.resYLabel.TabIndex = 14;
            this.resYLabel.Text = "Y Resolution:";
            // 
            // resXLabel
            // 
            this.resXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resXLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resXLabel.Location = new System.Drawing.Point(3, 301);
            this.resXLabel.Name = "resXLabel";
            this.resXLabel.Size = new System.Drawing.Size(80, 20);
            this.resXLabel.TabIndex = 13;
            this.resXLabel.Text = "X Resolution:";
            // 
            // colorApply
            // 
            this.colorApply.Location = new System.Drawing.Point(21, 183);
            this.colorApply.Name = "colorApply";
            this.colorApply.Size = new System.Drawing.Size(102, 23);
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
            this.colorDialogLabel.Size = new System.Drawing.Size(158, 56);
            this.colorDialogLabel.TabIndex = 6;
            this.colorDialogLabel.Text = "Color Selection\r\nClick Color Box to Change Color";
            this.colorDialogLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IFSGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.displayPanel);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "IFSGUI";
            this.Text = "IFSGUI";
            this.Load += new System.EventHandler(this.IFSGUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color4Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color3Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color2Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color1Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.Label Color1Label;
        private System.Windows.Forms.PictureBox color1Box;
        private System.Windows.Forms.Button btnDetailLevel;
        private System.Windows.Forms.TextBox txtDetailLevel;
        private System.Windows.Forms.Label colorDialogLabel;
        private System.Windows.Forms.Label lblDetailLevel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPortal;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button resolutionButton;
        private System.Windows.Forms.TextBox resYBox;
        private System.Windows.Forms.TextBox resXBox;
        private System.Windows.Forms.Label resYLabel;
        private System.Windows.Forms.Label resXLabel;
        private System.Windows.Forms.Button colorApply;
        private System.Windows.Forms.Label Color4Label;
        private System.Windows.Forms.PictureBox color4Box;
        private System.Windows.Forms.Label Color3Label;
        private System.Windows.Forms.PictureBox color3Box;
        private System.Windows.Forms.Label Color2Label;
        private System.Windows.Forms.PictureBox color2Box;
        protected System.Windows.Forms.Button desktopImageButton;
        private System.Windows.Forms.ComboBox cbIFSTypes;
        private System.Windows.Forms.Label lblTypes;

    }
}