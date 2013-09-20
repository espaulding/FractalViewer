namespace FractalViewer
{
    partial class FractalPortal
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
            this.lblSpashMessage = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.MandlebrotLabel = new System.Windows.Forms.Label();
            this.SierpinskiLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnJulia = new System.Windows.Forms.Button();
            this.btnSierpinski = new System.Windows.Forms.Button();
            this.btnMandel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSpashMessage
            // 
            this.lblSpashMessage.AutoSize = true;
            this.lblSpashMessage.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpashMessage.Location = new System.Drawing.Point(224, 14);
            this.lblSpashMessage.Name = "lblSpashMessage";
            this.lblSpashMessage.Size = new System.Drawing.Size(242, 48);
            this.lblSpashMessage.TabIndex = 3;
            this.lblSpashMessage.Text = "Fractal Viewer";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(630, 265);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // MandlebrotLabel
            // 
            this.MandlebrotLabel.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MandlebrotLabel.Location = new System.Drawing.Point(15, 72);
            this.MandlebrotLabel.Name = "MandlebrotLabel";
            this.MandlebrotLabel.Size = new System.Drawing.Size(200, 23);
            this.MandlebrotLabel.TabIndex = 5;
            this.MandlebrotLabel.Text = "Click to View Mandelbrot Fractal";
            this.MandlebrotLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SierpinskiLabel
            // 
            this.SierpinskiLabel.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SierpinskiLabel.Location = new System.Drawing.Point(262, 72);
            this.SierpinskiLabel.Name = "SierpinskiLabel";
            this.SierpinskiLabel.Size = new System.Drawing.Size(200, 23);
            this.SierpinskiLabel.TabIndex = 6;
            this.SierpinskiLabel.Text = "Click to View Sierpisnki Fractal";
            this.SierpinskiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Click to View IFS Fractal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJulia
            // 
            this.btnJulia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnJulia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJulia.Image = global::FractalViewer.Properties.Resources.Fern;
            this.btnJulia.Location = new System.Drawing.Point(505, 98);
            this.btnJulia.Name = "btnJulia";
            this.btnJulia.Size = new System.Drawing.Size(200, 150);
            this.btnJulia.TabIndex = 2;
            this.btnJulia.UseVisualStyleBackColor = true;
            this.btnJulia.Click += new System.EventHandler(this.btnJulia_Click);
            // 
            // btnSierpinski
            // 
            this.btnSierpinski.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSierpinski.Image = global::FractalViewer.Properties.Resources.Sierpinski;
            this.btnSierpinski.Location = new System.Drawing.Point(266, 98);
            this.btnSierpinski.Name = "btnSierpinski";
            this.btnSierpinski.Size = new System.Drawing.Size(200, 150);
            this.btnSierpinski.TabIndex = 1;
            this.btnSierpinski.UseVisualStyleBackColor = true;
            this.btnSierpinski.Click += new System.EventHandler(this.btnSierpinski_Click);
            // 
            // btnMandel
            // 
            this.btnMandel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMandel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMandel.Image = global::FractalViewer.Properties.Resources.MandlebrotImage;
            this.btnMandel.Location = new System.Drawing.Point(15, 98);
            this.btnMandel.Name = "btnMandel";
            this.btnMandel.Size = new System.Drawing.Size(200, 150);
            this.btnMandel.TabIndex = 0;
            this.btnMandel.UseVisualStyleBackColor = true;
            this.btnMandel.Click += new System.EventHandler(this.btnMandel_Click);
            // 
            // FractalPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 313);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SierpinskiLabel);
            this.Controls.Add(this.MandlebrotLabel);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblSpashMessage);
            this.Controls.Add(this.btnJulia);
            this.Controls.Add(this.btnSierpinski);
            this.Controls.Add(this.btnMandel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(738, 337);
            this.MinimumSize = new System.Drawing.Size(738, 337);
            this.Name = "FractalPortal";
            this.Text = "FractalPortal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMandel;
        private System.Windows.Forms.Button btnSierpinski;
        private System.Windows.Forms.Button btnJulia;
        private System.Windows.Forms.Label lblSpashMessage;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label MandlebrotLabel;
        private System.Windows.Forms.Label SierpinskiLabel;
        private System.Windows.Forms.Label label1;
    }
}