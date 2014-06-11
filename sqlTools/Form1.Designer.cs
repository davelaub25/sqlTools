using System;
using System.Web.UI.WebControls;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dBaseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schemaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newProcedureColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.parametersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procedureTypeColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.doByColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.doByParameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.storedProcedureOrderGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.storedProcedureOrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storedProcedureOrderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dBaseColumn,
            this.schemaColumn,
            this.nameColumn,
            this.newProcedureColumn,
            this.parametersColumn,
            this.fieldsColumn,
            this.procedureTypeColumn,
            this.doByColumn,
            this.doByParameter,
            this.outputColumn,
            this.tableNameColumn});
            this.storedProcedureOrderGridView.Location = new System.Drawing.Point(15, 190);
            this.storedProcedureOrderGridView.Name = "storedProcedureOrderGridView";
            this.storedProcedureOrderGridView.Size = new System.Drawing.Size(1014, 299);
            this.storedProcedureOrderGridView.TabIndex = 12;
            this.storedProcedureOrderGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dBaseColumn
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dBaseColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dBaseColumn.HeaderText = "Database";
            this.dBaseColumn.Name = "dBaseColumn";
            // 
            // schemaColumn
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schemaColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.schemaColumn.HeaderText = "Schema";
            this.schemaColumn.Name = "schemaColumn";
            // 
            // nameColumn
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.nameColumn.HeaderText = "Procedure Name";
            this.nameColumn.Name = "nameColumn";
            // 
            // newProcedureColumn
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.NullValue = false;
            this.newProcedureColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.newProcedureColumn.HeaderText = "Create New Procedure";
            this.newProcedureColumn.Name = "newProcedureColumn";
            this.newProcedureColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.newProcedureColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.newProcedureColumn.Width = 65;
            // 
            // parametersColumn
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parametersColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.parametersColumn.HeaderText = "Parameters";
            this.parametersColumn.Name = "parametersColumn";
            // 
            // fieldsColumn
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldsColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.fieldsColumn.HeaderText = "Fields";
            this.fieldsColumn.Name = "fieldsColumn";
            // 
            // procedureTypeColumn
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.NullValue = false;
            this.procedureTypeColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.procedureTypeColumn.HeaderText = "Procedure Type";
            this.procedureTypeColumn.Name = "procedureTypeColumn";
            this.procedureTypeColumn.Width = 55;
            // 
            // doByColumn
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.NullValue = false;
            this.doByColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.doByColumn.HeaderText = "Run By";
            this.doByColumn.Name = "doByColumn";
            this.doByColumn.Width = 45;
            // 
            // doByParameter
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doByParameter.DefaultCellStyle = dataGridViewCellStyle10;
            this.doByParameter.HeaderText = "Run By Parameter";
            this.doByParameter.Name = "doByParameter";
            // 
            // outputColumn
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.outputColumn.HeaderText = "Output Fields";
            this.outputColumn.Name = "outputColumn";
            // 
            // tableNameColumn
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNameColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.tableNameColumn.HeaderText = "Table Name";
            this.tableNameColumn.Name = "tableNameColumn";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dBaseColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schemaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn newProcedureColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parametersColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldsColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn procedureTypeColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn doByColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doByParameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableNameColumn;
    }
}

