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
            this.SuspendLayout();
            // 
            // selectionListBox
            // 
            this.selectionListBox.FormattingEnabled = true;
            this.selectionListBox.Location = new System.Drawing.Point(12, 12);
            this.selectionListBox.Name = "selectionListBox";
            this.selectionListBox.Size = new System.Drawing.Size(255, 469);
            this.selectionListBox.TabIndex = 0;
            // 
            // acceptButton
            // 
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Location = new System.Drawing.Point(192, 487);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 1;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            // 
            // SelectionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 519);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.selectionListBox);
            this.Name = "SelectionWindow";
            this.Text = "SelectionWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox selectionListBox;
        private System.Windows.Forms.Button acceptButton;
    }
}