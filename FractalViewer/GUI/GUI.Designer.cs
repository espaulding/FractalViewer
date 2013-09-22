
namespace FractalViewer
{
    partial class GUI
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
            if (buffer != null) { buffer.Dispose(); }
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
            this.fractalViewerPanel = new System.Windows.Forms.Panel();
            this.fractalStatus = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setImageToDesktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fractalInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fractalViewerPanel
            // 
            this.fractalViewerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fractalViewerPanel.AutoSize = true;
            this.fractalViewerPanel.BackColor = System.Drawing.Color.LawnGreen;
            this.fractalViewerPanel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.fractalViewerPanel.Location = new System.Drawing.Point(2, 27);
            this.fractalViewerPanel.MinimumSize = new System.Drawing.Size(500, 500);
            this.fractalViewerPanel.Name = "fractalViewerPanel";
            this.fractalViewerPanel.Size = new System.Drawing.Size(500, 500);
            this.fractalViewerPanel.TabIndex = 5;
            this.fractalViewerPanel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.fractalViewerPanel_Scroll);
            this.fractalViewerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.fractalViewerPanel_Paint);
            // 
            // fractalStatus
            // 
            this.fractalStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fractalStatus.Location = new System.Drawing.Point(2, 536);
            this.fractalStatus.Name = "fractalStatus";
            this.fractalStatus.Size = new System.Drawing.Size(500, 23);
            this.fractalStatus.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageToolStripMenuItem,
            this.setImageToDesktopToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // setImageToDesktopToolStripMenuItem
            // 
            this.setImageToDesktopToolStripMenuItem.Name = "setImageToDesktopToolStripMenuItem";
            this.setImageToDesktopToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.setImageToDesktopToolStripMenuItem.Text = "Set Image to Desktop";
            this.setImageToDesktopToolStripMenuItem.Click += new System.EventHandler(this.desktopImageButton_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManualToolStripMenuItem,
            this.fractalInfoToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // userManualToolStripMenuItem
            // 
            this.userManualToolStripMenuItem.Name = "userManualToolStripMenuItem";
            this.userManualToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.userManualToolStripMenuItem.Text = "User Manual";
            // 
            // fractalInfoToolStripMenuItem
            // 
            this.fractalInfoToolStripMenuItem.Name = "fractalInfoToolStripMenuItem";
            this.fractalInfoToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.fractalInfoToolStripMenuItem.Text = "Fractal Info";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.fractalStatus);
            this.Controls.Add(this.fractalViewerPanel);
            this.Name = "GUI";
            this.Text = "GUI";
            this.ResizeEnd += new System.EventHandler(this.GUI_ResizeEnd);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel fractalViewerPanel;
        protected volatile System.Windows.Forms.ProgressBar fractalStatus;
        protected System.Windows.Forms.MenuStrip menuStrip1;
        protected System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem setImageToDesktopToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem userManualToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem fractalInfoToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}