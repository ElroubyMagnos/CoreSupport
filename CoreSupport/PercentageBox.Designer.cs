namespace CoreSupport
{
    partial class PercentageBox
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
            fixedIntBox1 = new DesktopSupport.FixedIntBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // fixedIntBox1
            // 
            fixedIntBox1.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            fixedIntBox1.Location = new Point(0, 0);
            fixedIntBox1.MaxLength = 3;
            fixedIntBox1.Name = "fixedIntBox1";
            fixedIntBox1.Size = new Size(40, 24);
            fixedIntBox1.TabIndex = 0;
            fixedIntBox1.Text = "0";
            fixedIntBox1.Value = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 4);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 1;
            label1.Text = "%";
            // 
            // PercentageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(fixedIntBox1);
            Name = "PercentageBox";
            Size = new Size(66, 23);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DesktopSupport.FixedIntBox fixedIntBox1;
        private Label label1;
    }
}
