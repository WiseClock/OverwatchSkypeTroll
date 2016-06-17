namespace OverwatchSkype
{
    partial class OverwatchSkype
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverwatchSkype));
            this.selDevice = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // selDevice
            // 
            this.selDevice.FormattingEnabled = true;
            this.selDevice.Location = new System.Drawing.Point(3, 2);
            this.selDevice.Name = "selDevice";
            this.selDevice.Size = new System.Drawing.Size(330, 21);
            this.selDevice.TabIndex = 0;
            // 
            // OverwatchSkype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 138);
            this.Controls.Add(this.selDevice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OverwatchSkype";
            this.Text = "Overwatch Skype Troll - WiseClock#1745";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox selDevice;

    }
}

