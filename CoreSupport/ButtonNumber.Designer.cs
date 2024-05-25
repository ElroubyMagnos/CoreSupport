namespace DesktopSupport
{
    partial class ButtonNumber
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
            this.DecimalAdd = new System.Windows.Forms.TextBox();
            this.Decrement = new DesktopSupport.SkyButton();
            this.Increment = new DesktopSupport.SkyButton();
            this.SuspendLayout();
            // 
            // DecimalAdd
            // 
            this.DecimalAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecimalAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DecimalAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecimalAdd.Location = new System.Drawing.Point(40, 9);
            this.DecimalAdd.Name = "DecimalAdd";
            this.DecimalAdd.Size = new System.Drawing.Size(56, 19);
            this.DecimalAdd.TabIndex = 0;
            this.DecimalAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DecimalAdd.TextChanged += new System.EventHandler(this.DecimalAdd_TextChanged);
            // 
            // Decrement
            // 
            this.Decrement.BackColor = System.Drawing.SystemColors.Highlight;
            this.Decrement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Decrement.DefaultColor = System.Drawing.Color.Empty;
            this.Decrement.Dock = System.Windows.Forms.DockStyle.Left;
            this.Decrement.FlatAppearance.BorderSize = 0;
            this.Decrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decrement.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrement.ForeColor = System.Drawing.SystemColors.Control;
            this.Decrement.Hover = System.Drawing.Color.Empty;
            this.Decrement.Location = new System.Drawing.Point(0, 0);
            this.Decrement.Name = "Decrement";
            this.Decrement.Size = new System.Drawing.Size(37, 40);
            this.Decrement.TabIndex = 2;
            this.Decrement.UseVisualStyleBackColor = false;
            this.Decrement.Click += new System.EventHandler(this.Decrement_Click);
            // 
            // Increment
            // 
            this.Increment.BackColor = System.Drawing.SystemColors.Highlight;
            this.Increment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Increment.DefaultColor = System.Drawing.Color.Empty;
            this.Increment.Dock = System.Windows.Forms.DockStyle.Right;
            this.Increment.FlatAppearance.BorderSize = 0;
            this.Increment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Increment.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Increment.ForeColor = System.Drawing.SystemColors.Control;
            this.Increment.Hover = System.Drawing.Color.Empty;
            this.Increment.Location = new System.Drawing.Point(101, 0);
            this.Increment.Name = "Increment";
            this.Increment.Size = new System.Drawing.Size(37, 40);
            this.Increment.TabIndex = 1;
            this.Increment.UseVisualStyleBackColor = false;
            this.Increment.Click += new System.EventHandler(this.Increment_Click);
            // 
            // ButtonNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Decrement);
            this.Controls.Add(this.Increment);
            this.Controls.Add(this.DecimalAdd);
            this.Name = "ButtonNumber";
            this.Size = new System.Drawing.Size(138, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DecimalAdd;
        private SkyButton Increment;
        private SkyButton Decrement;
    }
}
