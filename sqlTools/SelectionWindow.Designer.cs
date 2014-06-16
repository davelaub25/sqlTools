namespace sqlTools
{
    partial class SelectionWindow
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
            this.selectionListBox = new System.Windows.Forms.CheckedListBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.maskButton = new System.Windows.Forms.Button();
            this.maskLabel = new System.Windows.Forms.Label();
            this.maskTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selectionListBox
            // 
            this.selectionListBox.FormattingEnabled = true;
            this.selectionListBox.Location = new System.Drawing.Point(12, 12);
            this.selectionListBox.Name = "selectionListBox";
            this.selectionListBox.Size = new System.Drawing.Size(305, 424);
            this.selectionListBox.TabIndex = 0;
            // 
            // acceptButton
            // 
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Location = new System.Drawing.Point(242, 447);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 1;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // maskButton
            // 
            this.maskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maskButton.Location = new System.Drawing.Point(155, 490);
            this.maskButton.Name = "maskButton";
            this.maskButton.Size = new System.Drawing.Size(75, 23);
            this.maskButton.TabIndex = 8;
            this.maskButton.Text = "Mask";
            this.maskButton.UseVisualStyleBackColor = true;
            this.maskButton.Click += new System.EventHandler(this.maskButton_Click);
            // 
            // maskLabel
            // 
            this.maskLabel.AutoSize = true;
            this.maskLabel.Location = new System.Drawing.Point(14, 449);
            this.maskLabel.Name = "maskLabel";
            this.maskLabel.Size = new System.Drawing.Size(84, 13);
            this.maskLabel.TabIndex = 7;
            this.maskLabel.Text = "Mask Parameter";
            // 
            // maskTextBox
            // 
            this.maskTextBox.Location = new System.Drawing.Point(14, 463);
            this.maskTextBox.Name = "maskTextBox";
            this.maskTextBox.Size = new System.Drawing.Size(217, 20);
            this.maskTextBox.TabIndex = 6;
            this.maskTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SelectionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 519);
            this.Controls.Add(this.maskButton);
            this.Controls.Add(this.maskLabel);
            this.Controls.Add(this.maskTextBox);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.selectionListBox);
            this.Name = "SelectionWindow";
            this.Text = "SelectionWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox selectionListBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button maskButton;
        private System.Windows.Forms.Label maskLabel;
        private System.Windows.Forms.TextBox maskTextBox;
    }
}