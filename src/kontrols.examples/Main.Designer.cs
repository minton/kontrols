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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GlobalWar = new kontrols.HoverTextButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RedDot = new kontrols.HoverImageButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PlayPause = new kontrols.ToggleImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.GlobalWar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HoverTextButton";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Move the cursor over this button to see the text color change.";
            // 
            // GlobalWar
            // 
            this.GlobalWar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GlobalWar.HoverForeColor = System.Drawing.Color.Blue;
            this.GlobalWar.Location = new System.Drawing.Point(206, 52);
            this.GlobalWar.Name = "GlobalWar";
            this.GlobalWar.Size = new System.Drawing.Size(153, 53);
            this.GlobalWar.TabIndex = 0;
            this.GlobalWar.Text = "Global Thermal Nuclear War";
            this.GlobalWar.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.RedDot);
            this.groupBox2.Location = new System.Drawing.Point(12, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 107);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HoverImageButton";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(556, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Move the cursor over this button to see the image change.";
            // 
            // RedDot
            // 
            this.RedDot.HoverForeColor = System.Drawing.Color.Empty;
            this.RedDot.HoverImage = global::kontrols.examples.Properties.Resources.BreakpointEnabled_6584_32x;
            this.RedDot.Image = global::kontrols.examples.Properties.Resources.BreakpointDisabled_6585_32x;
            this.RedDot.Location = new System.Drawing.Point(266, 54);
            this.RedDot.Name = "RedDot";
            this.RedDot.Size = new System.Drawing.Size(32, 32);
            this.RedDot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RedDot.TabIndex = 1;
            this.RedDot.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PlayPause);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(564, 121);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ToggleImageButton";
            // 
            // PlayPause
            // 
            this.PlayPause.HoverForeColor = System.Drawing.Color.Empty;
            this.PlayPause.Image = global::kontrols.examples.Properties.Resources.StatusAnnotations_Play_32xLG_color;
            this.PlayPause.ImageToggled = global::kontrols.examples.Properties.Resources.StatusAnnotations_Pause_32xLG_color;
            this.PlayPause.Location = new System.Drawing.Point(266, 66);
            this.PlayPause.Name = "PlayPause";
            this.PlayPause.Size = new System.Drawing.Size(32, 32);
            this.PlayPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PlayPause.TabIndex = 2;
            this.PlayPause.Toggled = false;
            this.PlayPause.Click += new System.EventHandler(this.ToggleClicked);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(552, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Click the control to toggle the image.";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 391);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Examples";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HoverTextButton GlobalWar;
        private HoverImageButton RedDot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private ToggleImageButton PlayPause;
    }
}

