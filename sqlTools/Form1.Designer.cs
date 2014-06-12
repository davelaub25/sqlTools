using System;
using System.Data;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Web.UI.WebControls;
using System.Windows.Forms;

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
        /// 
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.tableList = new System.Windows.Forms.ListBox();
            this.userText = new System.Windows.Forms.TextBox();
            this.serverList = new System.Windows.Forms.ListBox();
            this.refreshServerListButton = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.dbaseList = new System.Windows.Forms.ListBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.serverListLabel = new System.Windows.Forms.Label();
            this.dbaseListLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.storedProcedureOrderGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.storedProcedureOrderGridView)).BeginInit();
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
            this.tableList.Location = new System.Drawing.Point(511, 31);
            this.tableList.Name = "tableList";
            this.tableList.Size = new System.Drawing.Size(137, 95);
            this.tableList.TabIndex = 1;
            this.tableList.SelectedIndexChanged += new System.EventHandler(this.tableList_SelectedIndexChanged);
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(12, 28);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(198, 20);
            this.userText.TabIndex = 2;
            this.userText.Text = "dlaub";
            this.userText.TextChanged += new System.EventHandler(this.userText_TextChanged);
            this.userText.GotFocus += new System.EventHandler(this.userText_GotFocus);
            // 
            // serverList
            // 
            this.serverList.FormattingEnabled = true;
            this.serverList.Location = new System.Drawing.Point(221, 31);
            this.serverList.Name = "serverList";
            this.serverList.Size = new System.Drawing.Size(140, 95);
            this.serverList.TabIndex = 3;
            this.serverList.SelectedIndexChanged += new System.EventHandler(this.serverList_SelectedIndexChanged);
            // 
            // refreshServerListButton
            // 
            this.refreshServerListButton.Location = new System.Drawing.Point(218, 132);
            this.refreshServerListButton.Name = "refreshServerListButton";
            this.refreshServerListButton.Size = new System.Drawing.Size(75, 23);
            this.refreshServerListButton.TabIndex = 4;
            this.refreshServerListButton.Text = "Refresh";
            this.refreshServerListButton.UseVisualStyleBackColor = true;
            this.refreshServerListButton.Click += new System.EventHandler(this.refreshServerListButton_Click);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(12, 67);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(198, 20);
            this.passwordText.TabIndex = 5;
            this.passwordText.Text = "Password";
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // dbaseList
            // 
            this.dbaseList.FormattingEnabled = true;
            this.dbaseList.Location = new System.Drawing.Point(367, 31);
            this.dbaseList.Name = "dbaseList";
            this.dbaseList.Size = new System.Drawing.Size(138, 95);
            this.dbaseList.TabIndex = 6;
            this.dbaseList.SelectedIndexChanged += new System.EventHandler(this.dbaseList_SelectedIndexChanged);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(9, 12);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(55, 13);
            this.userNameLabel.TabIndex = 7;
            this.userNameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 51);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password";
            // 
            // serverListLabel
            // 
            this.serverListLabel.AutoSize = true;
            this.serverListLabel.Location = new System.Drawing.Point(218, 12);
            this.serverListLabel.Name = "serverListLabel";
            this.serverListLabel.Size = new System.Drawing.Size(89, 13);
            this.serverListLabel.TabIndex = 9;
            this.serverListLabel.Text = "Available Servers";
            // 
            // dbaseListLabel
            // 
            this.dbaseListLabel.AutoSize = true;
            this.dbaseListLabel.Location = new System.Drawing.Point(367, 12);
            this.dbaseListLabel.Name = "dbaseListLabel";
            this.dbaseListLabel.Size = new System.Drawing.Size(104, 13);
            this.dbaseListLabel.TabIndex = 10;
            this.dbaseListLabel.Text = "Available Databases";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(300, 132);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(61, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // storedProcedureOrderGridView
            // 
            this.storedProcedureOrderGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.storedProcedureOrderGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.storedProcedureOrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storedProcedureOrderGridView.Location = new System.Drawing.Point(15, 190);
            this.storedProcedureOrderGridView.Name = "storedProcedureOrderGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.storedProcedureOrderGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.storedProcedureOrderGridView.Size = new System.Drawing.Size(1014, 299);
            this.storedProcedureOrderGridView.TabIndex = 12;
            this.storedProcedureOrderGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 595);
            this.Controls.Add(this.storedProcedureOrderGridView);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dbaseListLabel);
            this.Controls.Add(this.serverListLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.dbaseList);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.refreshServerListButton);
            this.Controls.Add(this.serverList);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.tableList);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.storedProcedureOrderGridView)).EndInit();
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
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label serverListLabel;
        private System.Windows.Forms.Label dbaseListLabel;
        private Table table1;
        private Table spTable;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView storedProcedureOrderGridView;
    }
}

