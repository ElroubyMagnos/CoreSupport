namespace DesktopSupport
{
    partial class PasswordBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PasswordContainer = new System.Windows.Forms.TextBox();
            this.PassShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasswordContainer
            // 
            this.PasswordContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordContainer.Location = new System.Drawing.Point(2, 2);
            this.PasswordContainer.Name = "PasswordContainer";
            this.PasswordContainer.Size = new System.Drawing.Size(97, 20);
            this.PasswordContainer.TabIndex = 0;
            this.PasswordContainer.UseSystemPasswordChar = true;
            // 
            // PassShow
            // 
            this.PassShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PassShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PassShow.Location = new System.Drawing.Point(99, 1);
            this.PassShow.Name = "PassShow";
            this.PassShow.Size = new System.Drawing.Size(25, 23);
            this.PassShow.TabIndex = 1;
            this.PassShow.UseVisualStyleBackColor = true;
            this.PassShow.Click += new System.EventHandler(this.PassShow_Click);
            // 
            // PasswordBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PassShow);
            this.Controls.Add(this.PasswordContainer);
            this.Name = "PasswordBox";
            this.Size = new System.Drawing.Size(127, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PassShow;
        public System.Windows.Forms.TextBox PasswordContainer;
    }
}
