namespace VisionSystem.Particles
{
    partial class InputBox
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
            this.Msg = new System.Windows.Forms.Label();
            this.PassBox = new DesktopSupport.PasswordBox();
            this.Apply = new DesktopSupport.SkyButton();
            this.SuspendLayout();
            // 
            // Msg
            // 
            this.Msg.AutoSize = true;
            this.Msg.Location = new System.Drawing.Point(49, 9);
            this.Msg.Name = "Msg";
            this.Msg.Size = new System.Drawing.Size(106, 13);
            this.Msg.TabIndex = 0;
            this.Msg.Text = "Enter Your Password";
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(43, 28);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(127, 27);
            this.PassBox.TabIndex = 1;
            // 
            // Apply
            // 
            this.Apply.BackColor = System.Drawing.SystemColors.Highlight;
            this.Apply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Apply.DefaultColor = System.Drawing.Color.Empty;
            this.Apply.FlatAppearance.BorderSize = 0;
            this.Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Apply.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apply.ForeColor = System.Drawing.SystemColors.Control;
            this.Apply.Hover = System.Drawing.Color.Empty;
            this.Apply.Location = new System.Drawing.Point(139, 81);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 30);
            this.Apply.TabIndex = 2;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = false;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // InputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 123);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.Msg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InputBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Msg;
        private DesktopSupport.PasswordBox PassBox;
        private DesktopSupport.SkyButton Apply;
    }
}