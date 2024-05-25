namespace DesktopSupport.SmallForms
{
    partial class WithExpireDate
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
            this.skyButton1 = new DesktopSupport.SkyButton();
            this.skyButton2 = new DesktopSupport.SkyButton();
            this.SuspendLayout();
            // 
            // skyButton1
            // 
            this.skyButton1.BackColor = System.Drawing.SystemColors.Highlight;
            this.skyButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skyButton1.DefaultColor = System.Drawing.SystemColors.Highlight;
            this.skyButton1.FlatAppearance.BorderSize = 0;
            this.skyButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skyButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.skyButton1.Hover = System.Drawing.Color.Empty;
            this.skyButton1.Location = new System.Drawing.Point(64, 12);
            this.skyButton1.Name = "skyButton1";
            this.skyButton1.Size = new System.Drawing.Size(176, 30);
            this.skyButton1.TabIndex = 0;
            this.skyButton1.Text = "With Expire Date";
            this.skyButton1.UseVisualStyleBackColor = false;
            this.skyButton1.Click += new System.EventHandler(this.skyButton1_Click);
            // 
            // skyButton2
            // 
            this.skyButton2.BackColor = System.Drawing.SystemColors.Highlight;
            this.skyButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skyButton2.DefaultColor = System.Drawing.SystemColors.Highlight;
            this.skyButton2.FlatAppearance.BorderSize = 0;
            this.skyButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skyButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyButton2.ForeColor = System.Drawing.SystemColors.Control;
            this.skyButton2.Hover = System.Drawing.Color.Empty;
            this.skyButton2.Location = new System.Drawing.Point(64, 66);
            this.skyButton2.Name = "skyButton2";
            this.skyButton2.Size = new System.Drawing.Size(176, 30);
            this.skyButton2.TabIndex = 1;
            this.skyButton2.Text = "Without Expire Date";
            this.skyButton2.UseVisualStyleBackColor = false;
            this.skyButton2.Click += new System.EventHandler(this.skyButton2_Click);
            // 
            // WithExpireDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 120);
            this.Controls.Add(this.skyButton2);
            this.Controls.Add(this.skyButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "WithExpireDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expire Date";
            this.ResumeLayout(false);

        }

        #endregion

        private SkyButton skyButton1;
        private SkyButton skyButton2;
    }
}