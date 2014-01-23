namespace kontrols.examples
{
    partial class Main
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
            this.hoverTextButton1 = new kontrols.HoverTextButton();
            this.SuspendLayout();
            // 
            // hoverTextButton1
            // 
            this.hoverTextButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hoverTextButton1.HoverForeColor = System.Drawing.Color.Blue;
            this.hoverTextButton1.Location = new System.Drawing.Point(225, 90);
            this.hoverTextButton1.Name = "hoverTextButton1";
            this.hoverTextButton1.Size = new System.Drawing.Size(186, 84);
            this.hoverTextButton1.TabIndex = 0;
            this.hoverTextButton1.Text = "Global Thermal Nuclear War";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 395);
            this.Controls.Add(this.hoverTextButton1);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private HoverTextButton hoverTextButton1;
    }
}

