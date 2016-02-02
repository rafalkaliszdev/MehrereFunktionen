namespace Mehrere_Funktionen_2 {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tcBlank = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tcImplementingActivitiesModule = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.bSendXml = new System.Windows.Forms.Button();
            this.bRemoveActivity = new System.Windows.Forms.Button();
            this.bAddNewRecord = new System.Windows.Forms.Button();
            this.dgvImplementingActivities = new System.Windows.Forms.DataGridView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.tcBlank.SuspendLayout();
            this.tcImplementingActivitiesModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImplementingActivities)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tcBlank);
            this.tabControl1.Controls.Add(this.tcImplementingActivitiesModule);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(870, 614);
            this.tabControl1.TabIndex = 0;
            // 
            // tcBlank
            // 
            this.tcBlank.Controls.Add(this.label1);
            this.tcBlank.Location = new System.Drawing.Point(4, 22);
            this.tcBlank.Name = "tcBlank";
            this.tcBlank.Padding = new System.Windows.Forms.Padding(3);
            this.tcBlank.Size = new System.Drawing.Size(862, 588);
            this.tcBlank.TabIndex = 0;
            this.tcBlank.Text = "Blank Start Page";
            this.tcBlank.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(98, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(763, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "here should be some sort of summary of the last day";
            // 
            // tcImplementingActivitiesModule
            // 
            this.tcImplementingActivitiesModule.Controls.Add(this.textBox1);
            this.tcImplementingActivitiesModule.Controls.Add(this.tbPort);
            this.tcImplementingActivitiesModule.Controls.Add(this.tbIP);
            this.tcImplementingActivitiesModule.Controls.Add(this.bSendXml);
            this.tcImplementingActivitiesModule.Controls.Add(this.bRemoveActivity);
            this.tcImplementingActivitiesModule.Controls.Add(this.bAddNewRecord);
            this.tcImplementingActivitiesModule.Controls.Add(this.dgvImplementingActivities);
            this.tcImplementingActivitiesModule.Location = new System.Drawing.Point(4, 22);
            this.tcImplementingActivitiesModule.Name = "tcImplementingActivitiesModule";
            this.tcImplementingActivitiesModule.Padding = new System.Windows.Forms.Padding(3);
            this.tcImplementingActivitiesModule.Size = new System.Drawing.Size(862, 588);
            this.tcImplementingActivitiesModule.TabIndex = 1;
            this.tcImplementingActivitiesModule.Text = "Implementing Activities Module";
            this.tcImplementingActivitiesModule.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(6, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(677, 165);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(710, 241);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(100, 20);
            this.tbPort.TabIndex = 5;
            this.tbPort.Text = "1024";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(710, 215);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(100, 20);
            this.tbIP.TabIndex = 4;
            this.tbIP.Text = "127.0.0.1";
            // 
            // bSendXml
            // 
            this.bSendXml.Location = new System.Drawing.Point(710, 149);
            this.bSendXml.Name = "bSendXml";
            this.bSendXml.Size = new System.Drawing.Size(120, 60);
            this.bSendXml.TabIndex = 3;
            this.bSendXml.Text = "Send Xml";
            this.bSendXml.UseVisualStyleBackColor = true;
            this.bSendXml.Click += new System.EventHandler(this.bSendXml_Click);
            // 
            // bRemoveActivity
            // 
            this.bRemoveActivity.Location = new System.Drawing.Point(710, 83);
            this.bRemoveActivity.Name = "bRemoveActivity";
            this.bRemoveActivity.Size = new System.Drawing.Size(120, 60);
            this.bRemoveActivity.TabIndex = 2;
            this.bRemoveActivity.Text = "Remove Selected Activity";
            this.bRemoveActivity.UseVisualStyleBackColor = true;
            this.bRemoveActivity.Click += new System.EventHandler(this.bRemoveActivity_Click);
            // 
            // bAddNewRecord
            // 
            this.bAddNewRecord.Location = new System.Drawing.Point(710, 17);
            this.bAddNewRecord.Name = "bAddNewRecord";
            this.bAddNewRecord.Size = new System.Drawing.Size(120, 60);
            this.bAddNewRecord.TabIndex = 1;
            this.bAddNewRecord.Text = "Add New Activity";
            this.bAddNewRecord.UseVisualStyleBackColor = true;
            this.bAddNewRecord.Click += new System.EventHandler(this.bAddNewRecord_Click);
            // 
            // dgvImplementingActivities
            // 
            this.dgvImplementingActivities.AllowUserToResizeColumns = false;
            this.dgvImplementingActivities.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvImplementingActivities.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvImplementingActivities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImplementingActivities.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvImplementingActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImplementingActivities.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvImplementingActivities.Location = new System.Drawing.Point(8, 174);
            this.dgvImplementingActivities.MultiSelect = false;
            this.dgvImplementingActivities.Name = "dgvImplementingActivities";
            this.dgvImplementingActivities.RowHeadersVisible = false;
            this.dgvImplementingActivities.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvImplementingActivities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImplementingActivities.Size = new System.Drawing.Size(675, 406);
            this.dgvImplementingActivities.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "MehrereFunktionen";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 614);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MehrereFunktionen 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDoubleClick);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tcBlank.ResumeLayout(false);
            this.tcBlank.PerformLayout();
            this.tcImplementingActivitiesModule.ResumeLayout(false);
            this.tcImplementingActivitiesModule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImplementingActivities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tcBlank;
        private System.Windows.Forms.TabPage tcImplementingActivitiesModule;
        private System.Windows.Forms.DataGridView dgvImplementingActivities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAddNewRecord;
        private System.Windows.Forms.Button bRemoveActivity;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Button bSendXml;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

