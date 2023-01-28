namespace Custom_Controls
{
    partial class ComboBoxControl
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
            this.ccTxtbox = new System.Windows.Forms.TextBox();
            this.ccComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ccTxtbox
            // 
            this.ccTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccTxtbox.Location = new System.Drawing.Point(189, 36);
            this.ccTxtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ccTxtbox.Name = "ccTxtbox";
            this.ccTxtbox.ReadOnly = true;
            this.ccTxtbox.Size = new System.Drawing.Size(148, 26);
            this.ccTxtbox.TabIndex = 3;
            // 
            // ccComboBox
            // 
            this.ccComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ccComboBox.FormattingEnabled = true;
            this.ccComboBox.Location = new System.Drawing.Point(4, 36);
            this.ccComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ccComboBox.Name = "ccComboBox";
            this.ccComboBox.Size = new System.Drawing.Size(180, 21);
            this.ccComboBox.TabIndex = 2;
            this.ccComboBox.SelectedIndexChanged += new System.EventHandler(this.ccComboBox_SelectedIndexChanged);
            // 
            // ComboBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ccTxtbox);
            this.Controls.Add(this.ccComboBox);
            this.Name = "ComboBoxControl";
            this.Size = new System.Drawing.Size(361, 105);
            this.Load += new System.EventHandler(this.ComboBoxControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ccTxtbox;
        private System.Windows.Forms.ComboBox ccComboBox;
    }
}
