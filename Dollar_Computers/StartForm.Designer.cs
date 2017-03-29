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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.ExitButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.OpenSavedbutton = new System.Windows.Forms.Button();
            this.headLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.DarkGray;
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitButton.Location = new System.Drawing.Point(460, 425);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(141, 30);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.DarkGray;
            this.StartButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartButton.Location = new System.Drawing.Point(46, 425);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(141, 30);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start new order";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // OpenSavedbutton
            // 
            this.OpenSavedbutton.BackColor = System.Drawing.Color.DarkGray;
            this.OpenSavedbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OpenSavedbutton.Location = new System.Drawing.Point(231, 425);
            this.OpenSavedbutton.Name = "OpenSavedbutton";
            this.OpenSavedbutton.Size = new System.Drawing.Size(184, 30);
            this.OpenSavedbutton.TabIndex = 4;
            this.OpenSavedbutton.Text = "Open a Saved Order";
            this.OpenSavedbutton.UseVisualStyleBackColor = false;
            this.OpenSavedbutton.Click += new System.EventHandler(this.OpenSavedbutton_Click);
            // 
            // headLabel
            // 
            this.headLabel.AutoSize = true;
            this.headLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headLabel.Location = new System.Drawing.Point(132, 31);
            this.headLabel.Name = "headLabel";
            this.headLabel.Size = new System.Drawing.Size(353, 29);
            this.headLabel.TabIndex = 5;
            this.headLabel.Text = "Order your Computer Today !";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(170, 106);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(303, 251);
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(645, 526);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.headLabel);
            this.Controls.Add(this.OpenSavedbutton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ExitButton);
            this.Name = "StartForm";
            this.Text = "StartForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button OpenSavedbutton;
        private System.Windows.Forms.Label headLabel;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}