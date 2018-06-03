namespace InnoStofGUI {
    partial class Innostof {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.powerbutton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.groupBoxGamification = new System.Windows.Forms.GroupBox();
            this.recordtimeLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.RecordLabel = new System.Windows.Forms.Label();
            this.TijdsduurLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxGamification.SuspendLayout();
            this.SuspendLayout();
            // 
            // powerbutton
            // 
            this.powerbutton.Location = new System.Drawing.Point(97, 321);
            this.powerbutton.Name = "powerbutton";
            this.powerbutton.Size = new System.Drawing.Size(318, 108);
            this.powerbutton.TabIndex = 0;
            this.powerbutton.Text = "Aan";
            this.powerbutton.UseVisualStyleBackColor = true;
            this.powerbutton.Click += new System.EventHandler(this.powerbutton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(449, 96);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(438, 111);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "InnoStof";
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.Location = new System.Drawing.Point(97, 465);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(72, 72);
            this.plusButton.TabIndex = 2;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            // 
            // minusButton
            // 
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.Location = new System.Drawing.Point(343, 468);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(72, 72);
            this.minusButton.TabIndex = 3;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            // 
            // groupBoxGamification
            // 
            this.groupBoxGamification.Controls.Add(this.recordtimeLabel);
            this.groupBoxGamification.Controls.Add(this.timeLabel);
            this.groupBoxGamification.Controls.Add(this.RecordLabel);
            this.groupBoxGamification.Controls.Add(this.TijdsduurLabel);
            this.groupBoxGamification.Location = new System.Drawing.Point(902, 291);
            this.groupBoxGamification.Name = "groupBoxGamification";
            this.groupBoxGamification.Size = new System.Drawing.Size(364, 233);
            this.groupBoxGamification.TabIndex = 4;
            this.groupBoxGamification.TabStop = false;
            // 
            // recordtimeLabel
            // 
            this.recordtimeLabel.AutoSize = true;
            this.recordtimeLabel.Location = new System.Drawing.Point(173, 113);
            this.recordtimeLabel.Name = "recordtimeLabel";
            this.recordtimeLabel.Size = new System.Drawing.Size(39, 13);
            this.recordtimeLabel.TabIndex = 3;
            this.recordtimeLabel.Text = "m:s:ms";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(173, 30);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(39, 13);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "m:s:ms";
            // 
            // RecordLabel
            // 
            this.RecordLabel.AutoSize = true;
            this.RecordLabel.Location = new System.Drawing.Point(3, 113);
            this.RecordLabel.Name = "RecordLabel";
            this.RecordLabel.Size = new System.Drawing.Size(42, 13);
            this.RecordLabel.TabIndex = 1;
            this.RecordLabel.Text = "Record";
            // 
            // TijdsduurLabel
            // 
            this.TijdsduurLabel.AutoSize = true;
            this.TijdsduurLabel.Location = new System.Drawing.Point(3, 30);
            this.TijdsduurLabel.Name = "TijdsduurLabel";
            this.TijdsduurLabel.Size = new System.Drawing.Size(50, 13);
            this.TijdsduurLabel.TabIndex = 0;
            this.TijdsduurLabel.Text = "Tijdsduur";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Innostof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 782);
            this.Controls.Add(this.groupBoxGamification);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.powerbutton);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Innostof";
            this.Text = "InnostofGUI";
            this.Load += new System.EventHandler(this.Innostof_Load);
            this.groupBoxGamification.ResumeLayout(false);
            this.groupBoxGamification.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button powerbutton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.GroupBox groupBoxGamification;
        private System.Windows.Forms.Label RecordLabel;
        private System.Windows.Forms.Label TijdsduurLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label recordtimeLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

