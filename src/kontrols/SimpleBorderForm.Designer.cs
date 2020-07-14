namespace kontrols
{
    partial class SimpleBorderForm
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
            this.btnMinimize = new kontrols.HoverImageButton();
            this.btnMaximize = new kontrols.HoverImageButton();
            this.btnClose = new kontrols.HoverImageButton();
            this.SuspendLayout();
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnMinimize.HoverBackColor = System.Drawing.Color.White;
            this.btnMinimize.HoverForeColor = System.Drawing.Color.Empty;
            this.btnMinimize.HoverImage = null;
            this.btnMinimize.Image = null;
            this.btnMinimize.Location = new System.Drawing.Point(675, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimize.TabIndex = 2;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnMaximize.HoverBackColor = System.Drawing.Color.White;
            this.btnMaximize.HoverForeColor = System.Drawing.Color.Empty;
            this.btnMaximize.HoverImage = null;
            this.btnMaximize.Image = null;
            this.btnMaximize.Location = new System.Drawing.Point(700, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(25, 25);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMaximize.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnClose.HoverBackColor = System.Drawing.Color.White;
            this.btnClose.HoverForeColor = System.Drawing.Color.Empty;
            this.btnClose.HoverImage = null;
            this.btnClose.Image = null;
            this.btnClose.Location = new System.Drawing.Point(725, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClose.TabIndex = 0;
            // 
            // SimpleBorderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 465);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnClose);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SimpleBorderForm";
            this.Text = "BaseForm";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private HoverImageButton btnClose;
        private HoverImageButton btnMaximize;
        private HoverImageButton btnMinimize;
    }
}