namespace DesktopSupport
{
    partial class CheckTimePicker
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
            Picker = new DateTimePicker();
            CanUse = new CheckBox();
            SuspendLayout();
            // 
            // Picker
            // 
            Picker.CustomFormat = "dd/mm/yyyy";
            Picker.Enabled = false;
            Picker.Format = DateTimePickerFormat.Short;
            Picker.Location = new Point(29, 3);
            Picker.Margin = new Padding(4, 3, 4, 3);
            Picker.Name = "Picker";
            Picker.Size = new Size(233, 23);
            Picker.TabIndex = 1;
            // 
            // CanUse
            // 
            CanUse.AutoSize = true;
            CanUse.Location = new Point(5, 6);
            CanUse.Margin = new Padding(4, 3, 4, 3);
            CanUse.Name = "CanUse";
            CanUse.Size = new Size(15, 14);
            CanUse.TabIndex = 0;
            CanUse.UseVisualStyleBackColor = true;
            CanUse.CheckedChanged += IsEmpty_CheckedChanged;
            // 
            // CheckTimePicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CanUse);
            Controls.Add(Picker);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CheckTimePicker";
            Size = new Size(271, 33);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public System.Windows.Forms.CheckBox CanUse;
        public System.Windows.Forms.DateTimePicker Picker;
    }
}
