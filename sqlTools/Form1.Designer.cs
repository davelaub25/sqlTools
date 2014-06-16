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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            Form1.storedProcedureOrderGridView = new System.Windows.Forms.DataGridView();
            this.addRowButton = new System.Windows.Forms.Button();
            this.schema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newProcedure = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.parameters = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.parameterButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.fields = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldsButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.doBy = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.doByInfo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.doByButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.output = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.schemaList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(Form1.storedProcedureOrderGridView)).BeginInit();
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
            this.tableList.Location = new System.Drawing.Point(711, 31);
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
            this.passwordText.Text = "pooper1";
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
            Form1.storedProcedureOrderGridView.AllowUserToAddRows = false;
            Form1.storedProcedureOrderGridView.AllowUserToOrderColumns = true;
            Form1.storedProcedureOrderGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            Form1.storedProcedureOrderGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            Form1.storedProcedureOrderGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            Form1.storedProcedureOrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Form1.storedProcedureOrderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dbase,
            this.schema,
            this.tableName,
            this.name,
            this.newProcedure,
            this.parameters,
            this.parameterButton,
            this.fields,
            this.fieldsButton,
            this.type,
            this.doBy,
            this.doByInfo,
            this.doByButton,
            this.output,
            this.outputButtonColumn});
            Form1.storedProcedureOrderGridView.Location = new System.Drawing.Point(15, 190);
            Form1.storedProcedureOrderGridView.Name = "storedProcedureOrderGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            Form1.storedProcedureOrderGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            Form1.storedProcedureOrderGridView.Size = new System.Drawing.Size(1179, 299);
            Form1.storedProcedureOrderGridView.TabIndex = 12;
            Form1.storedProcedureOrderGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.storedProcedureOrderGridView_cellEdit);
            Form1.storedProcedureOrderGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.storedProcedureOrderGridView_cellClick);
            // 
            // addRowButton
            // 
            this.addRowButton.Location = new System.Drawing.Point(1118, 496);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(75, 23);
            this.addRowButton.TabIndex = 13;
            this.addRowButton.Text = "Add";
            this.addRowButton.UseVisualStyleBackColor = true;
            this.addRowButton.Click += new System.EventHandler(this.addRowButton_Click);
            // 
            // schema
            // 
            this.schema.HeaderText = "Schema";
            this.schema.Name = "schema";
            this.schema.ReadOnly = true;
            this.schema.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.schema.Width = 110;
            // 
            // dbase
            // 
            this.dbase.HeaderText = "Database";
            this.dbase.Name = "dbase";
            this.dbase.ReadOnly = true;
            this.dbase.Width = 110;
            // 
            // tableName
            // 
            this.tableName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.tableName.HeaderText = "Table Name";
            this.tableName.Items.AddRange(new object[] {
            "Test"});
            this.tableName.Name = "tableName";
            this.tableName.Width = 110;
            // 
            // name
            // 
            this.name.HeaderText = "Procedure Name";
            this.name.Name = "name";
            this.name.Width = 110;
            // 
            // newProcedure
            // 
            this.newProcedure.HeaderText = "Create New";
            this.newProcedure.Name = "newProcedure";
            this.newProcedure.Width = 40;
            // 
            // parameters
            // 
            this.parameters.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.parameters.HeaderText = "Parameters";
            this.parameters.Name = "parameters";
            this.parameters.ReadOnly = false;
            this.parameters.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.parameters.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.parameters.Width = 110;
            // 
            // parameterButton
            // 
            this.parameterButton.HeaderText = "...";
            this.parameterButton.Name = "parameterButton";
            this.parameterButton.Text = "...";
            this.parameterButton.UseColumnTextForButtonValue = true;
            this.parameterButton.Width = 22;
            // 
            // fields
            // 
            this.fields.HeaderText = "Fields";
            this.fields.Name = "fields";
            this.fields.Width = 110;
            // 
            // fieldsButton
            // 
            this.fieldsButton.HeaderText = "...";
            this.fieldsButton.Name = "fieldsButton";
            this.fieldsButton.Text = "...";
            this.fieldsButton.UseColumnTextForButtonValue = true;
            this.fieldsButton.Name = "fieldsButton";
            this.fieldsButton.Width = 22;
            // 
            // type
            // 
            this.type.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.type.HeaderText = "Type";
            this.type.Items.AddRange(new object[] {
            "Create", "Read", "Update", "Delete"});
            this.type.Name = "type";
            this.type.Width = 110;
            // 
            // doBy
            // 
            this.doBy.HeaderText = "Do By";
            this.doBy.Name = "doBy";
            this.doBy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.doBy.Width = 40;
            // 
            // doByInfo
            // 
            this.doByInfo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.doByInfo.HeaderText = "Do By Info";
            this.doByInfo.Name = "doByInfo";
            this.doByInfo.Width = 110;
            // 
            // doByButton
            // 
            this.doByButton.HeaderText = "...";
            this.doByButton.Name = "doByButton";
            this.doByButton.Text = "...";
            this.doByButton.UseColumnTextForButtonValue = true;
            this.doByButton.Name = "doByButton";
            this.doByButton.Width = 22;
            // 
            // output
            // 
            this.output.HeaderText = "Output Field(s)";
            this.output.Name = "output";
            this.output.Width = 110;
            // 
            // outputButtonColumn
            // 
            this.outputButtonColumn.HeaderText = "...";
            this.outputButtonColumn.Text = "...";
            this.outputButtonColumn.UseColumnTextForButtonValue = true;
            this.outputButtonColumn.Name = "outputButtonColumn";
            this.outputButtonColumn.Width = 22;
            // 
            // schemaList
            // 
            this.schemaList.FormattingEnabled = true;
            this.schemaList.Location = new System.Drawing.Point(512, 31);
            this.schemaList.Name = "schemaList";
            this.schemaList.Size = new System.Drawing.Size(120, 95);
            this.schemaList.TabIndex = 14;
            this.schemaList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 595);
            this.Controls.Add(this.schemaList);
            this.Controls.Add(this.addRowButton);
            this.Controls.Add(Form1.storedProcedureOrderGridView);
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
            ((System.ComponentModel.ISupportInitialize)(Form1.storedProcedureOrderGridView)).EndInit();
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
        public static System.Windows.Forms.DataGridView storedProcedureOrderGridView;
        private System.Windows.Forms.Button addRowButton;
        private DataGridViewTextBoxColumn schema;
        private DataGridViewTextBoxColumn dbase;
        private DataGridViewComboBoxColumn tableName;
        private DataGridViewTextBoxColumn name;
        private DataGridViewCheckBoxColumn newProcedure;
        private DataGridViewComboBoxColumn parameters;
        private DataGridViewButtonColumn parameterButton;
        private DataGridViewTextBoxColumn fields;
        private DataGridViewButtonColumn fieldsButton;
        private DataGridViewButtonColumn doByButton;
        private DataGridViewComboBoxColumn type;
        private DataGridViewCheckBoxColumn doBy;
        private DataGridViewComboBoxColumn doByInfo;
        private DataGridViewTextBoxColumn output;
        private DataGridViewButtonColumn outputButtonColumn;
        private System.Windows.Forms.ListBox schemaList;
    }
}

