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
            this.maskInstrucLabel = new System.Windows.Forms.Label();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.deselectAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectionListBox
            // 
            this.selectionListBox.FormattingEnabled = true;
            this.selectionListBox.Location = new System.Drawing.Point(12, 12);
            this.selectionListBox.Name = "selectionListBox";
            this.selectionListBox.Size = new System.Drawing.Size(338, 424);
            this.selectionListBox.TabIndex = 0;
            // 
            // acceptButton
            // 
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Location = new System.Drawing.Point(275, 444);
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
            this.maskButton.Location = new System.Drawing.Point(275, 550);
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
            this.maskLabel.Location = new System.Drawing.Point(14, 510);
            this.maskLabel.Name = "maskLabel";
            this.maskLabel.Size = new System.Drawing.Size(84, 13);
            this.maskLabel.TabIndex = 7;
            this.maskLabel.Text = "Mask Parameter";
            // 
            // maskTextBox
            // 
            this.maskTextBox.Location = new System.Drawing.Point(14, 524);
            this.maskTextBox.Name = "maskTextBox";
            this.maskTextBox.Size = new System.Drawing.Size(336, 20);
            this.maskTextBox.TabIndex = 6;
            this.maskTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // maskInstrucLabel
            // 
            this.maskInstrucLabel.AutoSize = true;
            this.maskInstrucLabel.Location = new System.Drawing.Point(14, 555);
            this.maskInstrucLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.maskInstrucLabel.Name = "maskInstrucLabel";
            this.maskInstrucLabel.Size = new System.Drawing.Size(245, 26);
            this.maskInstrucLabel.TabIndex = 9;
            this.maskInstrucLabel.Text = "Use # to remove and * to keep.  You only need to fill to your last # the rest wil" +
    "l be kept by default.";
            // 
            // selectAllButton
            // 
            this.selectAllButton.Location = new System.Drawing.Point(12, 443);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(75, 23);
            this.selectAllButton.TabIndex = 10;
            this.selectAllButton.Text = "Select All";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // deselectAllButton
            // 
            this.deselectAllButton.Location = new System.Drawing.Point(94, 444);
            this.deselectAllButton.Name = "deselectAllButton";
            this.deselectAllButton.Size = new System.Drawing.Size(75, 23);
            this.deselectAllButton.TabIndex = 11;
            this.deselectAllButton.Text = "Deselect All";
            this.deselectAllButton.UseVisualStyleBackColor = true;
            this.deselectAllButton.Click += new System.EventHandler(this.deselectAllButton_Click);
            // 
            // SelectionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 591);
            this.Controls.Add(this.deselectAllButton);
            this.Controls.Add(this.selectAllButton);
            this.Controls.Add(this.maskInstrucLabel);
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
        private System.Windows.Forms.Label maskInstrucLabel;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.Button deselectAllButton;
    }
}