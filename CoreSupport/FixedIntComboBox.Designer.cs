﻿namespace DesktopSupport
{
    partial class FixedIntComboBox
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
            this.SuspendLayout();
            // 
            // FixedIntBox
            // 
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FixedIntBox_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
