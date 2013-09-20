using FractalViewer.Common;

namespace FractalViewer
{
    partial class MandelGUI
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTypes = new System.Windows.Forms.Label();
            this.previousZoom = new System.Windows.Forms.Button();
            this.cbMandelTypes = new System.Windows.Forms.ComboBox();
            this.colorDialogLabel = new System.Windows.Forms.Label();
            this.zoomIndexLabel = new System.Windows.Forms.TextBox();
            this.txtColorR = new System.Windows.Forms.TextBox();
            this.txtColorG = new System.Windows.Forms.TextBox();
            this.colorApply = new System.Windows.Forms.Button();
            this.txtColorB = new System.Windows.Forms.TextBox();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.desktopImageButton = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.mandelPanel1 = new System.Windows.Forms.Panel();
            this.resYBox = new System.Windows.Forms.TextBox();
            this.resXBox = new System.Windows.Forms.TextBox();
            this.txtDetailLevel = new System.Windows.Forms.TextBox();
            this.resolutionButton = new System.Windows.Forms.Button();
            this.applyDetail = new System.Windows.Forms.Button();
            this.lblDetailLevel = new System.Windows.Forms.Label();
            this.btnPortal = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.resYLabel = new System.Windows.Forms.Label();
            this.resXLabel = new System.Windows.Forms.Label();
            this.zoomDisplayBox = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.mandelPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lblTypes);
            this.panel2.Controls.Add(this.previousZoom);
            this.panel2.Controls.Add(this.cbMandelTypes);
            this.panel2.Controls.Add(this.colorDialogLabel);
            this.panel2.Controls.Add(this.zoomIndexLabel);
            this.panel2.Controls.Add(this.txtColorR);
            this.panel2.Controls.Add(this.txtColorG);
            this.panel2.Controls.Add(this.colorApply);
            this.panel2.Controls.Add(this.txtColorB);
            this.panel2.Controls.Add(this.redLabel);
            this.panel2.Controls.Add(this.blueLabel);
            this.panel2.Controls.Add(this.greenLabel);
            this.panel2.Location = new System.Drawing.Point(505, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 311);
            this.panel2.TabIndex = 25;
            // 
            // lblTypes
            // 
            this.lblTypes.AutoSize = true;
            this.lblTypes.Location = new System.Drawing.Point(3, 141);
            this.lblTypes.Name = "lblTypes";
            this.lblTypes.Size = new System.Drawing.Size(92, 13);
            this.lblTypes.TabIndex = 31;
            this.lblTypes.Text = "Mandelbrot Types";
            // 
            // previousZoom
            // 
            this.previousZoom.Location = new System.Drawing.Point(3, 204);
            this.previousZoom.Name = "previousZoom";
            this.previousZoom.Size = new System.Drawing.Size(118, 23);
            this.previousZoom.TabIndex = 10;
            this.previousZoom.Text = "Previous Zoom";
            this.previousZoom.UseVisualStyleBackColor = true;
            this.previousZoom.Click += new System.EventHandler(this.previousZoom_Click);
            // 
            // cbMandelTypes
            // 
            this.cbMandelTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMandelTypes.FormattingEnabled = true;
            this.cbMandelTypes.Items.AddRange(new object[] {
            "Mandelbrot",
            "Mandelbrot3",
            "Mandelbrot4",
            "Julia",
            "Julia3",
            "Julia_SanMarco"});
            this.cbMandelTypes.Location = new System.Drawing.Point(3, 157);
            this.cbMandelTypes.Name = "cbMandelTypes";
            this.cbMandelTypes.Size = new System.Drawing.Size(118, 21);
            this.cbMandelTypes.TabIndex = 30;
            this.cbMandelTypes.SelectedIndexChanged += new System.EventHandler(this.cbMandelTypes_SelectedIndexChanged);
            // 
            // colorDialogLabel
            // 
            this.colorDialogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorDialogLabel.Location = new System.Drawing.Point(3, 0);
            this.colorDialogLabel.Name = "colorDialogLabel";
            this.colorDialogLabel.Size = new System.Drawing.Size(118, 17);
            this.colorDialogLabel.TabIndex = 6;
            this.colorDialogLabel.Text = "Color Selection";
            this.colorDialogLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zoomIndexLabel
            // 
            this.zoomIndexLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zoomIndexLabel.Location = new System.Drawing.Point(6, 185);
            this.zoomIndexLabel.Name = "zoomIndexLabel";
            this.zoomIndexLabel.ReadOnly = true;
            this.zoomIndexLabel.Size = new System.Drawing.Size(86, 13);
            this.zoomIndexLabel.TabIndex = 11;
            this.zoomIndexLabel.Text = "zooms here";
            // 
            // txtColorR
            // 
            this.txtColorR.Location = new System.Drawing.Point(56, 22);
            this.txtColorR.MaxLength = 3;
            this.txtColorR.Name = "txtColorR";
            this.txtColorR.Size = new System.Drawing.Size(65, 20);
            this.txtColorR.TabIndex = 7;
            // 
            // txtColorG
            // 
            this.txtColorG.Location = new System.Drawing.Point(56, 48);
            this.txtColorG.MaxLength = 3;
            this.txtColorG.Name = "txtColorG";
            this.txtColorG.Size = new System.Drawing.Size(65, 20);
            this.txtColorG.TabIndex = 8;
            // 
            // colorApply
            // 
            this.colorApply.Location = new System.Drawing.Point(3, 100);
            this.colorApply.Name = "colorApply";
            this.colorApply.Size = new System.Drawing.Size(118, 23);
            this.colorApply.TabIndex = 3;
            this.colorApply.Text = "Apply Color";
            this.colorApply.UseVisualStyleBackColor = true;
            this.colorApply.Click += new System.EventHandler(this.colorApply_Click);
            // 
            // txtColorB
            // 
            this.txtColorB.Location = new System.Drawing.Point(56, 74);
            this.txtColorB.MaxLength = 3;
            this.txtColorB.Name = "txtColorB";
            this.txtColorB.Size = new System.Drawing.Size(65, 20);
            this.txtColorB.TabIndex = 9;
            // 
            // redLabel
            // 
            this.redLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel.Location = new System.Drawing.Point(3, 22);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(47, 20);
            this.redLabel.TabIndex = 10;
            this.redLabel.Text = "Red:";
            this.redLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // blueLabel
            // 
            this.blueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel.Location = new System.Drawing.Point(3, 74);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(47, 20);
            this.blueLabel.TabIndex = 11;
            this.blueLabel.Text = "Blue:";
            this.blueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // greenLabel
            // 
            this.greenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenLabel.Location = new System.Drawing.Point(3, 48);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(47, 20);
            this.greenLabel.TabIndex = 12;
            this.greenLabel.Text = "Green:";
            this.greenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // desktopImageButton
            // 
            this.desktopImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.desktopImageButton.Location = new System.Drawing.Point(3, 256);
            this.desktopImageButton.Name = "desktopImageButton";
            this.desktopImageButton.Size = new System.Drawing.Size(147, 23);
            this.desktopImageButton.TabIndex = 16;
            this.desktopImageButton.Text = "Set Image to Desktop";
            this.desktopImageButton.UseVisualStyleBackColor = true;
            this.desktopImageButton.Click += new System.EventHandler(this.desktopImageButton_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(3, 204);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(147, 49);
            this.btnStop.TabIndex = 25;
            this.btnStop.Text = "Stop Calculating";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // mandelPanel1
            // 
            this.mandelPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mandelPanel1.Controls.Add(this.btnStop);
            this.mandelPanel1.Controls.Add(this.desktopImageButton);
            this.mandelPanel1.Controls.Add(this.resYBox);
            this.mandelPanel1.Controls.Add(this.resXBox);
            this.mandelPanel1.Controls.Add(this.txtDetailLevel);
            this.mandelPanel1.Controls.Add(this.resolutionButton);
            this.mandelPanel1.Controls.Add(this.applyDetail);
            this.mandelPanel1.Controls.Add(this.lblDetailLevel);
            this.mandelPanel1.Controls.Add(this.btnPortal);
            this.mandelPanel1.Controls.Add(this.btnQuit);
            this.mandelPanel1.Controls.Add(this.resYLabel);
            this.mandelPanel1.Controls.Add(this.resXLabel);
            this.mandelPanel1.Location = new System.Drawing.Point(627, 245);
            this.mandelPanel1.Name = "mandelPanel1";
            this.mandelPanel1.Size = new System.Drawing.Size(154, 311);
            this.mandelPanel1.TabIndex = 24;
            // 
            // resYBox
            // 
            this.resYBox.Location = new System.Drawing.Point(84, 129);
            this.resYBox.MaxLength = 4;
            this.resYBox.Name = "resYBox";
            this.resYBox.Size = new System.Drawing.Size(66, 20);
            this.resYBox.TabIndex = 29;
            // 
            // resXBox
            // 
            this.resXBox.Location = new System.Drawing.Point(84, 109);
            this.resXBox.MaxLength = 4;
            this.resXBox.Name = "resXBox";
            this.resXBox.Size = new System.Drawing.Size(66, 20);
            this.resXBox.TabIndex = 28;
            // 
            // txtDetailLevel
            // 
            this.txtDetailLevel.Location = new System.Drawing.Point(79, 19);
            this.txtDetailLevel.MaxLength = 5;
            this.txtDetailLevel.Name = "txtDetailLevel";
            this.txtDetailLevel.Size = new System.Drawing.Size(71, 20);
            this.txtDetailLevel.TabIndex = 27;
            // 
            // resolutionButton
            // 
            this.resolutionButton.Location = new System.Drawing.Point(3, 155);
            this.resolutionButton.Name = "resolutionButton";
            this.resolutionButton.Size = new System.Drawing.Size(147, 23);
            this.resolutionButton.TabIndex = 17;
            this.resolutionButton.Text = "Apply Resolution";
            this.resolutionButton.UseVisualStyleBackColor = true;
            this.resolutionButton.Click += new System.EventHandler(this.resolutionButton_Click);
            // 
            // applyDetail
            // 
            this.applyDetail.Location = new System.Drawing.Point(3, 45);
            this.applyDetail.Name = "applyDetail";
            this.applyDetail.Size = new System.Drawing.Size(147, 23);
            this.applyDetail.TabIndex = 24;
            this.applyDetail.Text = "Apply Detail";
            this.applyDetail.UseVisualStyleBackColor = true;
            this.applyDetail.Click += new System.EventHandler(this.applyDetail_Click);
            // 
            // lblDetailLevel
            // 
            this.lblDetailLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailLevel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDetailLevel.Location = new System.Drawing.Point(3, 22);
            this.lblDetailLevel.Name = "lblDetailLevel";
            this.lblDetailLevel.Size = new System.Drawing.Size(83, 20);
            this.lblDetailLevel.TabIndex = 22;
            this.lblDetailLevel.Text = "Detail Level:";
            // 
            // btnPortal
            // 
            this.btnPortal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPortal.Location = new System.Drawing.Point(3, 282);
            this.btnPortal.Name = "btnPortal";
            this.btnPortal.Size = new System.Drawing.Size(93, 23);
            this.btnPortal.TabIndex = 19;
            this.btnPortal.Text = "Back to Portal";
            this.btnPortal.UseVisualStyleBackColor = true;
            this.btnPortal.Click += new System.EventHandler(this.btnPortal_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(97, 282);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(53, 23);
            this.btnQuit.TabIndex = 18;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // resYLabel
            // 
            this.resYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resYLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resYLabel.Location = new System.Drawing.Point(3, 132);
            this.resYLabel.Name = "resYLabel";
            this.resYLabel.Size = new System.Drawing.Size(83, 20);
            this.resYLabel.TabIndex = 14;
            this.resYLabel.Text = "Y Resolution:";
            // 
            // resXLabel
            // 
            this.resXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resXLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resXLabel.Location = new System.Drawing.Point(3, 112);
            this.resXLabel.Name = "resXLabel";
            this.resXLabel.Size = new System.Drawing.Size(83, 20);
            this.resXLabel.TabIndex = 13;
            this.resXLabel.Text = "X Resolution:";
            // 
            // zoomDisplayBox
            // 
            this.zoomDisplayBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomDisplayBox.Location = new System.Drawing.Point(505, 27);
            this.zoomDisplayBox.Name = "zoomDisplayBox";
            this.zoomDisplayBox.Size = new System.Drawing.Size(276, 212);
            this.zoomDisplayBox.TabIndex = 15;
            this.zoomDisplayBox.Paint += new System.Windows.Forms.PaintEventHandler(this.zoomDisplayBox_Paint);
            // 
            // MandelGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mandelPanel1);
            this.Controls.Add(this.zoomDisplayBox);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MandelGUI";
            this.Text = "Mandelbrot Fractal";
            this.Load += new System.EventHandler(this.MandelGUI_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.mandelPanel1.ResumeLayout(false);
            this.mandelPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel zoomDisplayBox;
        protected System.Windows.Forms.Panel mandelPanel1;
        protected System.Windows.Forms.Label lblTypes;
        protected System.Windows.Forms.ComboBox cbMandelTypes;
        protected System.Windows.Forms.TextBox resYBox;
        protected System.Windows.Forms.TextBox resXBox;
        protected System.Windows.Forms.TextBox txtDetailLevel;
        protected System.Windows.Forms.Button resolutionButton;
        protected System.Windows.Forms.Button applyDetail;
        protected System.Windows.Forms.Label lblDetailLevel;
        protected System.Windows.Forms.Button btnPortal;
        protected System.Windows.Forms.Button btnQuit;
        protected System.Windows.Forms.Label resYLabel;
        protected System.Windows.Forms.Label resXLabel;
        protected volatile System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Button desktopImageButton;
        protected volatile System.Windows.Forms.Button btnStop;
        protected System.Windows.Forms.Button previousZoom;
        protected System.Windows.Forms.Label colorDialogLabel;
        protected System.Windows.Forms.TextBox zoomIndexLabel;
        protected System.Windows.Forms.TextBox txtColorR;
        protected System.Windows.Forms.TextBox txtColorG;
        protected System.Windows.Forms.Button colorApply;
        protected System.Windows.Forms.TextBox txtColorB;
        protected System.Windows.Forms.Label redLabel;
        protected System.Windows.Forms.Label blueLabel;
        protected System.Windows.Forms.Label greenLabel;
    }
}