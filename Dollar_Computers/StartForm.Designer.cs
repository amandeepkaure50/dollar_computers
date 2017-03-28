namespace Dollar_Computers
{
    partial class StartForm
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
            this.startButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.headLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.startButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startButton.Location = new System.Drawing.Point(450, 425);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(141, 30);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "START ORDER";
            this.startButton.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(63, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "START ORDER";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(260, 425);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "START ORDER";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // headLabel
            // 
            this.headLabel.AutoSize = true;
            this.headLabel.Location = new System.Drawing.Point(201, 45);
            this.headLabel.Name = "headLabel";
            this.headLabel.Size = new System.Drawing.Size(212, 20);
            this.headLabel.TabIndex = 5;
            this.headLabel.Text = "Order your Computer Today !";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(136, 152);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(326, 251);
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 526);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.headLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.startButton);
            this.Name = "StartForm";
            this.Text = "StartForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label headLabel;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}