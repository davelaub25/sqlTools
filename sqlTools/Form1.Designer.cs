namespace sqlTools
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.tableList = new System.Windows.Forms.ListBox();
            this.userText = new System.Windows.Forms.TextBox();
            this.serverList = new System.Windows.Forms.ListBox();
            this.refreshServerListButton = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.dbaseList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableList
            // 
            this.tableList.FormattingEnabled = true;
            this.tableList.Location = new System.Drawing.Point(550, 111);
            this.tableList.Name = "tableList";
            this.tableList.Size = new System.Drawing.Size(120, 394);
            this.tableList.TabIndex = 1;
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(12, 12);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(140, 20);
            this.userText.TabIndex = 2;
            this.userText.Text = "User Name";
            this.userText.TextChanged += new System.EventHandler(this.userText_TextChanged);
            this.userText.GotFocus += new System.EventHandler(this.userText_GotFocus);
            // 
            // serverList
            // 
            this.serverList.FormattingEnabled = true;
            this.serverList.Location = new System.Drawing.Point(12, 38);
            this.serverList.Name = "serverList";
            this.serverList.Size = new System.Drawing.Size(140, 95);
            this.serverList.TabIndex = 3;
            this.serverList.SelectedIndexChanged += new System.EventHandler(this.serverList_SelectedIndexChanged);
            // 
            // refreshServerListButton
            // 
            this.refreshServerListButton.Location = new System.Drawing.Point(12, 139);
            this.refreshServerListButton.Name = "refreshServerListButton";
            this.refreshServerListButton.Size = new System.Drawing.Size(75, 23);
            this.refreshServerListButton.TabIndex = 4;
            this.refreshServerListButton.Text = "Refresh";
            this.refreshServerListButton.UseVisualStyleBackColor = true;
            this.refreshServerListButton.Click += new System.EventHandler(this.refreshServerListButton_Click);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(158, 12);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(138, 20);
            this.passwordText.TabIndex = 5;
            this.passwordText.Text = "Password";
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // dbaseList
            // 
            this.dbaseList.FormattingEnabled = true;
            this.dbaseList.Location = new System.Drawing.Point(158, 38);
            this.dbaseList.Name = "dbaseList";
            this.dbaseList.Size = new System.Drawing.Size(138, 95);
            this.dbaseList.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 595);
            this.Controls.Add(this.dbaseList);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.refreshServerListButton);
            this.Controls.Add(this.serverList);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.tableList);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox tableList;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.ListBox serverList;
        private System.Windows.Forms.Button refreshServerListButton;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.ListBox dbaseList;
    }
}

