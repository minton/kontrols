namespace kontrols.examples
{
    partial class ZoomMenuExampleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZoomMenuExampleForm));
            this.zoomMenu1 = new kontrols.ZoomMenu();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zoomMenu1
            // 
            this.zoomMenu1.BackColor = System.Drawing.Color.Teal;
            this.zoomMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zoomMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomMenu1.HoverForeColor = System.Drawing.Color.DarkBlue;
            this.zoomMenu1.Location = new System.Drawing.Point(0, 0);
            this.zoomMenu1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.zoomMenu1.Name = "zoomMenu1";
            this.zoomMenu1.Size = new System.Drawing.Size(1218, 488);
            this.zoomMenu1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightCoral;
            this.label4.Location = new System.Drawing.Point(0, 488);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1218, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "This control is in beta.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ZoomMenuExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1218, 519);
            this.Controls.Add(this.zoomMenu1);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZoomMenuExampleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ZoomMenu Example - BETA";
            this.ResumeLayout(false);

        }

        #endregion

        private ZoomMenu zoomMenu1;
        private System.Windows.Forms.Label label4;
    }
}