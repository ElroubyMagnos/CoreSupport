﻿namespace VisionSystem
{
    partial class ForBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.Box = new DesktopSupport.FixedIntBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "For";
            // 
            // Box
            // 
            this.Box.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Box.Location = new System.Drawing.Point(35, 0);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(100, 24);
            this.Box.TabIndex = 1;
            this.Box.Text = "";
            this.Box.Value = 0;
            // 
            // ForBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Box);
            this.Controls.Add(this.label1);
            this.Name = "ForBox";
            this.Size = new System.Drawing.Size(143, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public DesktopSupport.FixedIntBox Box;
    }
}
