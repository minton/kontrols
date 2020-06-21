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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GlobalWar = new kontrols.HoverTextButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RedDot = new kontrols.HoverImageButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PlayPause = new kontrols.ToggleImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.chkDisableControls = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.diEdge = new kontrols.DesktopIcon();
            this.diExplorer = new kontrols.DesktopIcon();
            this.diPowerShell = new kontrols.DesktopIcon();
            this.btnExit = new kontrols.HoverTextButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RoundedBorderFormSample = new kontrols.HoverTextButton();
            this.SimpleBorderFormSample = new kontrols.HoverTextButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ZoomMenuSample = new kontrols.HoverTextButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GlobalWar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 102);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HoverTextButton";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Move the cursor over this button to see the text color change.";
            // 
            // GlobalWar
            // 
            this.GlobalWar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.GlobalWar.GrayScaleWhenDisabled = true;
            this.GlobalWar.HasBorder = true;
            this.GlobalWar.HoverForeColor = System.Drawing.Color.Cyan;
            this.GlobalWar.Location = new System.Drawing.Point(15, 48);
            this.GlobalWar.Name = "GlobalWar";
            this.GlobalWar.Size = new System.Drawing.Size(158, 35);
            this.GlobalWar.TabIndex = 0;
            this.GlobalWar.Text = "Global Thermal Nuclear War";
            this.GlobalWar.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.RedDot);
            this.groupBox2.Location = new System.Drawing.Point(210, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 102);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HoverImageButton";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Move the cursor over this button to see the image change.";
            // 
            // RedDot
            // 
            this.RedDot.GrayScaleWhenDisabled = true;
            this.RedDot.HoverForeColor = System.Drawing.Color.Empty;
            this.RedDot.HoverImage = global::kontrols.examples.Properties.Resources.BreakpointEnabled_6584_32x;
            this.RedDot.Image = global::kontrols.examples.Properties.Resources.BreakpointDisabled_6585_32x;
            this.RedDot.Location = new System.Drawing.Point(78, 53);
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
            this.groupBox3.Location = new System.Drawing.Point(15, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 102);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ToggleImageButton";
            // 
            // PlayPause
            // 
            this.PlayPause.GrayScaleWhenDisabled = true;
            this.PlayPause.HoverForeColor = System.Drawing.Color.Empty;
            this.PlayPause.Image = global::kontrols.examples.Properties.Resources.StatusAnnotations_Play_32xLG_color;
            this.PlayPause.ImageToggled = global::kontrols.examples.Properties.Resources.StatusAnnotations_Pause_32xLG_color;
            this.PlayPause.Location = new System.Drawing.Point(78, 53);
            this.PlayPause.Name = "PlayPause";
            this.PlayPause.Size = new System.Drawing.Size(32, 32);
            this.PlayPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PlayPause.TabIndex = 2;
            this.PlayPause.Toggled = false;
            this.PlayPause.Click += new System.EventHandler(this.ToggleClicked);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(5, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Click the control to toggle the image.";
            // 
            // chkDisableControls
            // 
            this.chkDisableControls.AutoSize = true;
            this.chkDisableControls.Checked = true;
            this.chkDisableControls.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisableControls.Location = new System.Drawing.Point(294, 496);
            this.chkDisableControls.Name = "chkDisableControls";
            this.chkDisableControls.Size = new System.Drawing.Size(106, 17);
            this.chkDisableControls.TabIndex = 3;
            this.chkDisableControls.Text = "Controls Enabled";
            this.chkDisableControls.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Teal;
            this.groupBox4.Controls.Add(this.diEdge);
            this.groupBox4.Controls.Add(this.diExplorer);
            this.groupBox4.Controls.Add(this.diPowerShell);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(15, 362);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(383, 128);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DesktopIcon";
            // 
            // diEdge
            // 
            this.diEdge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.diEdge.GrayScaleWhenDisabled = true;
            this.diEdge.HoverColor = System.Drawing.Color.Empty;
            this.diEdge.Image = global::kontrols.examples.Properties.Resources.IE;
            this.diEdge.Location = new System.Drawing.Point(241, 18);
            this.diEdge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diEdge.Name = "diEdge";
            this.diEdge.Size = new System.Drawing.Size(90, 98);
            this.diEdge.TabIndex = 6;
            this.diEdge.Text = "Microsoft Edge";
            this.diEdge.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // diExplorer
            // 
            this.diExplorer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.diExplorer.GrayScaleWhenDisabled = true;
            this.diExplorer.HoverColor = System.Drawing.Color.Empty;
            this.diExplorer.Image = global::kontrols.examples.Properties.Resources.explorer;
            this.diExplorer.Location = new System.Drawing.Point(147, 18);
            this.diExplorer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diExplorer.Name = "diExplorer";
            this.diExplorer.Size = new System.Drawing.Size(90, 98);
            this.diExplorer.TabIndex = 6;
            this.diExplorer.Text = "Windows Explorer";
            this.diExplorer.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // diPowerShell
            // 
            this.diPowerShell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.diPowerShell.ForeColor = System.Drawing.Color.White;
            this.diPowerShell.GrayScaleWhenDisabled = true;
            this.diPowerShell.HoverColor = System.Drawing.Color.Empty;
            this.diPowerShell.Image = global::kontrols.examples.Properties.Resources.Powershell;
            this.diPowerShell.Location = new System.Drawing.Point(52, 18);
            this.diPowerShell.Name = "diPowerShell";
            this.diPowerShell.Size = new System.Drawing.Size(90, 98);
            this.diPowerShell.TabIndex = 5;
            this.diPowerShell.Text = "Windows PowerShell";
            this.diPowerShell.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.HasBorder = true;
            this.btnExit.HoverForeColor = System.Drawing.Color.LightCoral;
            this.btnExit.Location = new System.Drawing.Point(332, 7);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 32);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit Demo";
            this.btnExit.Click += new System.EventHandler(this.ExitClicked);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SimpleBorderFormSample);
            this.groupBox5.Location = new System.Drawing.Point(211, 264);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(188, 93);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SimpleBorderForm";
            // 
            // RoundedBorderFormSample
            // 
            this.RoundedBorderFormSample.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RoundedBorderFormSample.GrayScaleWhenDisabled = true;
            this.RoundedBorderFormSample.HasBorder = true;
            this.RoundedBorderFormSample.HoverForeColor = System.Drawing.Color.Cyan;
            this.RoundedBorderFormSample.Location = new System.Drawing.Point(19, 36);
            this.RoundedBorderFormSample.Margin = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.RoundedBorderFormSample.Name = "RoundedBorderFormSample";
            this.RoundedBorderFormSample.Size = new System.Drawing.Size(151, 33);
            this.RoundedBorderFormSample.TabIndex = 1;
            this.RoundedBorderFormSample.Text = "RoundedBorderForm Sample";
            this.RoundedBorderFormSample.Click += new System.EventHandler(this.RoundedBorderFormSampleClicked);
            // 
            // SimpleBorderFormSample
            // 
            this.SimpleBorderFormSample.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SimpleBorderFormSample.GrayScaleWhenDisabled = true;
            this.SimpleBorderFormSample.HasBorder = true;
            this.SimpleBorderFormSample.HoverForeColor = System.Drawing.Color.Cyan;
            this.SimpleBorderFormSample.Location = new System.Drawing.Point(19, 35);
            this.SimpleBorderFormSample.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.SimpleBorderFormSample.Name = "SimpleBorderFormSample";
            this.SimpleBorderFormSample.Size = new System.Drawing.Size(151, 33);
            this.SimpleBorderFormSample.TabIndex = 1;
            this.SimpleBorderFormSample.Text = "SimpleBorderForm Sample";
            this.SimpleBorderFormSample.Click += new System.EventHandler(this.SimpleBorderFormSampleClicked);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.ZoomMenuSample);
            this.groupBox6.Location = new System.Drawing.Point(210, 156);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Size = new System.Drawing.Size(188, 102);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Zoom Menu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightCoral;
            this.label4.Location = new System.Drawing.Point(39, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "This control is in beta.";
            // 
            // ZoomMenuSample
            // 
            this.ZoomMenuSample.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ZoomMenuSample.GrayScaleWhenDisabled = true;
            this.ZoomMenuSample.HasBorder = true;
            this.ZoomMenuSample.HoverForeColor = System.Drawing.Color.Cyan;
            this.ZoomMenuSample.Location = new System.Drawing.Point(36, 47);
            this.ZoomMenuSample.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.ZoomMenuSample.Name = "ZoomMenuSample";
            this.ZoomMenuSample.Size = new System.Drawing.Size(116, 33);
            this.ZoomMenuSample.TabIndex = 1;
            this.ZoomMenuSample.Text = "Launch ZoomMenu";
            this.ZoomMenuSample.Click += new System.EventHandler(this.ZoomMenuSampleClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kontrols.examples.Properties.Resources.kontrols;
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.RoundedBorderFormSample);
            this.groupBox7.Location = new System.Drawing.Point(15, 264);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(188, 93);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "RoundedBorderForm";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 527);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.chkDisableControls);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examples";
            this.TopMost = false;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.CheckBox chkDisableControls;
        private System.Windows.Forms.GroupBox groupBox4;
        private HoverTextButton btnExit;
        private DesktopIcon diPowerShell;
        private DesktopIcon diEdge;
        private DesktopIcon diExplorer;
        private System.Windows.Forms.GroupBox groupBox5;
        private HoverTextButton SimpleBorderFormSample;
        private System.Windows.Forms.GroupBox groupBox6;
        private HoverTextButton ZoomMenuSample;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private HoverTextButton RoundedBorderFormSample;
        private System.Windows.Forms.GroupBox groupBox7;
    }
}

