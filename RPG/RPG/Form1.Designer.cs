namespace RPG
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.aragornName = new System.Windows.Forms.Label();
            this.aragornTrackBar = new System.Windows.Forms.TrackBar();
            this.aragornHpLabel = new System.Windows.Forms.Label();
            this.aragornAtackPowerLabel = new System.Windows.Forms.Label();
            this.legolasName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.legolasHpLabel = new System.Windows.Forms.Label();
            this.legolasTrackBar = new System.Windows.Forms.TrackBar();
            this.legolasAtackPowerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aragornTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.legolasTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Informacje o bohaterze";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aragornName
            // 
            this.aragornName.AutoSize = true;
            this.aragornName.Location = new System.Drawing.Point(12, 9);
            this.aragornName.Name = "aragornName";
            this.aragornName.Size = new System.Drawing.Size(35, 13);
            this.aragornName.TabIndex = 1;
            this.aragornName.Text = "label1";
            // 
            // aragornTrackBar
            // 
            this.aragornTrackBar.LargeChange = 1;
            this.aragornTrackBar.Location = new System.Drawing.Point(103, 25);
            this.aragornTrackBar.Maximum = 100;
            this.aragornTrackBar.Name = "aragornTrackBar";
            this.aragornTrackBar.Size = new System.Drawing.Size(158, 45);
            this.aragornTrackBar.TabIndex = 2;
            this.aragornTrackBar.Scroll += new System.EventHandler(this.aragornTrackBar_Scroll);
            // 
            // aragornHpLabel
            // 
            this.aragornHpLabel.AutoSize = true;
            this.aragornHpLabel.Location = new System.Drawing.Point(100, 9);
            this.aragornHpLabel.Name = "aragornHpLabel";
            this.aragornHpLabel.Size = new System.Drawing.Size(88, 13);
            this.aragornHpLabel.TabIndex = 3;
            this.aragornHpLabel.Text = "Żywotność:100%";
            // 
            // aragornAtackPowerLabel
            // 
            this.aragornAtackPowerLabel.AutoSize = true;
            this.aragornAtackPowerLabel.Location = new System.Drawing.Point(100, 66);
            this.aragornAtackPowerLabel.Name = "aragornAtackPowerLabel";
            this.aragornAtackPowerLabel.Size = new System.Drawing.Size(35, 13);
            this.aragornAtackPowerLabel.TabIndex = 4;
            this.aragornAtackPowerLabel.Text = "label1";
            // 
            // legolasName
            // 
            this.legolasName.AutoSize = true;
            this.legolasName.Location = new System.Drawing.Point(12, 124);
            this.legolasName.Name = "legolasName";
            this.legolasName.Size = new System.Drawing.Size(35, 13);
            this.legolasName.TabIndex = 5;
            this.legolasName.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Informacje o bohaterze";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // legolasHpLabel
            // 
            this.legolasHpLabel.AutoSize = true;
            this.legolasHpLabel.Location = new System.Drawing.Point(103, 124);
            this.legolasHpLabel.Name = "legolasHpLabel";
            this.legolasHpLabel.Size = new System.Drawing.Size(35, 13);
            this.legolasHpLabel.TabIndex = 7;
            this.legolasHpLabel.Text = "label1";
            // 
            // legolasTrackBar
            // 
            this.legolasTrackBar.Location = new System.Drawing.Point(106, 141);
            this.legolasTrackBar.Maximum = 100;
            this.legolasTrackBar.Name = "legolasTrackBar";
            this.legolasTrackBar.Size = new System.Drawing.Size(155, 45);
            this.legolasTrackBar.TabIndex = 8;
            this.legolasTrackBar.Scroll += new System.EventHandler(this.legolasTrackBar_Scroll);
            // 
            // legolasAtackPowerLabel
            // 
            this.legolasAtackPowerLabel.AutoSize = true;
            this.legolasAtackPowerLabel.Location = new System.Drawing.Point(106, 178);
            this.legolasAtackPowerLabel.Name = "legolasAtackPowerLabel";
            this.legolasAtackPowerLabel.Size = new System.Drawing.Size(35, 13);
            this.legolasAtackPowerLabel.TabIndex = 9;
            this.legolasAtackPowerLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.legolasAtackPowerLabel);
            this.Controls.Add(this.legolasTrackBar);
            this.Controls.Add(this.legolasHpLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.legolasName);
            this.Controls.Add(this.aragornAtackPowerLabel);
            this.Controls.Add(this.aragornHpLabel);
            this.Controls.Add(this.aragornTrackBar);
            this.Controls.Add(this.aragornName);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.aragornTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.legolasTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label aragornName;
        private System.Windows.Forms.TrackBar aragornTrackBar;
        private System.Windows.Forms.Label aragornHpLabel;
        private System.Windows.Forms.Label aragornAtackPowerLabel;
        private System.Windows.Forms.Label legolasName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label legolasHpLabel;
        private System.Windows.Forms.TrackBar legolasTrackBar;
        private System.Windows.Forms.Label legolasAtackPowerLabel;
    }
}

