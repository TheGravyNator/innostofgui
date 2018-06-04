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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TijdsduurLabel = new System.Windows.Forms.Label();
            this.RecordLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.recordtimeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // powerbutton
            // 
            this.powerbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.powerbutton.FlatAppearance.BorderSize = 0;
            this.powerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powerbutton.Font = new System.Drawing.Font("Bookshelf Symbol 7", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.powerbutton.Location = new System.Drawing.Point(149, 251);
            this.powerbutton.Name = "powerbutton";
            this.powerbutton.Size = new System.Drawing.Size(266, 82);
            this.powerbutton.TabIndex = 0;
            this.powerbutton.Text = "A A N";
            this.powerbutton.UseVisualStyleBackColor = false;
            this.powerbutton.Click += new System.EventHandler(this.powerbutton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Bookshelf Symbol 7", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TitleLabel.Location = new System.Drawing.Point(324, 76);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(731, 111);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "I N N O S T O F";
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.plusButton.FlatAppearance.BorderSize = 0;
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusButton.Font = new System.Drawing.Font("Bookshelf Symbol 7", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.plusButton.Location = new System.Drawing.Point(343, 384);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(72, 72);
            this.plusButton.TabIndex = 2;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.minusButton.FlatAppearance.BorderSize = 0;
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusButton.Font = new System.Drawing.Font("Bookshelf Symbol 7", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.minusButton.Location = new System.Drawing.Point(149, 384);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(72, 72);
            this.minusButton.TabIndex = 3;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TijdsduurLabel
            // 
            this.TijdsduurLabel.AutoSize = true;
            this.TijdsduurLabel.Font = new System.Drawing.Font("Bookshelf Symbol 7", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TijdsduurLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(209)))), ((int)(((byte)(116)))));
            this.TijdsduurLabel.Location = new System.Drawing.Point(20, 45);
            this.TijdsduurLabel.Name = "TijdsduurLabel";
            this.TijdsduurLabel.Size = new System.Drawing.Size(143, 32);
            this.TijdsduurLabel.TabIndex = 0;
            this.TijdsduurLabel.Text = "Tijdsduur";
            this.TijdsduurLabel.UseWaitCursor = true;
            // 
            // RecordLabel
            // 
            this.RecordLabel.AutoSize = true;
            this.RecordLabel.Font = new System.Drawing.Font("Bookshelf Symbol 7", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(209)))), ((int)(((byte)(116)))));
            this.RecordLabel.Location = new System.Drawing.Point(20, 113);
            this.RecordLabel.Name = "RecordLabel";
            this.RecordLabel.Size = new System.Drawing.Size(110, 32);
            this.RecordLabel.TabIndex = 1;
            this.RecordLabel.Text = "Record";
            this.RecordLabel.UseWaitCursor = true;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Bookshelf Symbol 7", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(214, 45);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(117, 32);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "m:s:ms";
            this.timeLabel.UseWaitCursor = true;
            // 
            // recordtimeLabel
            // 
            this.recordtimeLabel.AutoSize = true;
            this.recordtimeLabel.Font = new System.Drawing.Font("Bookshelf Symbol 7", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordtimeLabel.ForeColor = System.Drawing.Color.White;
            this.recordtimeLabel.Location = new System.Drawing.Point(214, 113);
            this.recordtimeLabel.Name = "recordtimeLabel";
            this.recordtimeLabel.Size = new System.Drawing.Size(117, 32);
            this.recordtimeLabel.TabIndex = 3;
            this.recordtimeLabel.Text = "m:s:ms";
            this.recordtimeLabel.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(127)))), ((int)(((byte)(100)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.recordtimeLabel);
            this.panel1.Controls.Add(this.RecordLabel);
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Controls.Add(this.TijdsduurLabel);
            this.panel1.Location = new System.Drawing.Point(833, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 205);
            this.panel1.TabIndex = 5;
            // 
            // Innostof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(209)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1348, 782);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.powerbutton);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Innostof";
            this.Text = "InnostofGUI";
            this.Load += new System.EventHandler(this.Innostof_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button powerbutton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TijdsduurLabel;
        private System.Windows.Forms.Label RecordLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label recordtimeLabel;
        private System.Windows.Forms.Panel panel1;
    }
}

