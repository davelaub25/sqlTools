namespace sqlTools
{
    partial class MultiSelectionWindow
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
            this.multiSelectionGridView = new System.Windows.Forms.DataGridView();
            this.parameterColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.equalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.addRowButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskLabel = new System.Windows.Forms.Label();
            this.maskButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.multiSelectionGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // multiSelectionGridView
            // 
            this.multiSelectionGridView.AllowUserToAddRows = false;
            this.multiSelectionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.multiSelectionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parameterColumn,
            this.equalColumn,
            this.fieldColumn});
            this.multiSelectionGridView.Location = new System.Drawing.Point(13, 13);
            this.multiSelectionGridView.Name = "multiSelectionGridView";
            this.multiSelectionGridView.Size = new System.Drawing.Size(333, 392);
            this.multiSelectionGridView.TabIndex = 0;
            // 
            // parameterColumn
            // 
            this.parameterColumn.HeaderText = "Parameter";
            this.parameterColumn.Name = "parameterColumn";
            this.parameterColumn.Width = 130;
            // 
            // equalColumn
            // 
            this.equalColumn.HeaderText = "=";
            this.equalColumn.Name = "equalColumn";
            this.equalColumn.ReadOnly = true;
            this.equalColumn.Width = 30;
            // 
            // fieldColumn
            // 
            this.fieldColumn.HeaderText = "Field";
            this.fieldColumn.Name = "fieldColumn";
            this.fieldColumn.Width = 130;
            // 
            // addRowButton
            // 
            this.addRowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRowButton.Location = new System.Drawing.Point(271, 411);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(75, 23);
            this.addRowButton.TabIndex = 1;
            this.addRowButton.Text = "Add";
            this.addRowButton.UseVisualStyleBackColor = true;
            this.addRowButton.Click += new System.EventHandler(this.addRowButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Location = new System.Drawing.Point(270, 459);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 2;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 426);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 3;
            // 
            // maskLabel
            // 
            this.maskLabel.AutoSize = true;
            this.maskLabel.Location = new System.Drawing.Point(13, 412);
            this.maskLabel.Name = "maskLabel";
            this.maskLabel.Size = new System.Drawing.Size(84, 13);
            this.maskLabel.TabIndex = 4;
            this.maskLabel.Text = "Mask Parameter";
            // 
            // maskButton
            // 
            this.maskButton.Location = new System.Drawing.Point(154, 453);
            this.maskButton.Name = "maskButton";
            this.maskButton.Size = new System.Drawing.Size(75, 23);
            this.maskButton.TabIndex = 5;
            this.maskButton.Text = "Mask";
            this.maskButton.UseVisualStyleBackColor = true;
            // 
            // MultiSelectionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 494);
            this.Controls.Add(this.maskButton);
            this.Controls.Add(this.maskLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.addRowButton);
            this.Controls.Add(this.multiSelectionGridView);
            this.Name = "MultiSelectionWindow";
            this.Text = "MultiSelectionWindow";
            this.Load += new System.EventHandler(this.MultiSelectionWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.multiSelectionGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView multiSelectionGridView;
        private System.Windows.Forms.Button addRowButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.DataGridViewComboBoxColumn parameterColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equalColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn fieldColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label maskLabel;
        private System.Windows.Forms.Button maskButton;
    }
}