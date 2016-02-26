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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tcBlank = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tcPositiveHabitsModule = new System.Windows.Forms.TabPage();
            this.bRemovePositiveHabit = new System.Windows.Forms.Button();
            this.bAddNewPositiveHabit = new System.Windows.Forms.Button();
            this.dgvPositiveHabits = new System.Windows.Forms.DataGridView();
            this.tcStrategicObjectivesModule = new System.Windows.Forms.TabPage();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.tcBlank.SuspendLayout();
            this.tcPositiveHabitsModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositiveHabits)).BeginInit();
            this.tcStrategicObjectivesModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tcBlank);
            this.tabControl1.Controls.Add(this.tcPositiveHabitsModule);
            this.tabControl1.Controls.Add(this.tcStrategicObjectivesModule);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(812, 250);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // tcPositiveHabitsModule
            // 
            this.tcPositiveHabitsModule.Controls.Add(this.bRemovePositiveHabit);
            this.tcPositiveHabitsModule.Controls.Add(this.bAddNewPositiveHabit);
            this.tcPositiveHabitsModule.Controls.Add(this.dgvPositiveHabits);
            this.tcPositiveHabitsModule.Location = new System.Drawing.Point(4, 22);
            this.tcPositiveHabitsModule.Name = "tcPositiveHabitsModule";
            this.tcPositiveHabitsModule.Padding = new System.Windows.Forms.Padding(3);
            this.tcPositiveHabitsModule.Size = new System.Drawing.Size(862, 588);
            this.tcPositiveHabitsModule.TabIndex = 1;
            this.tcPositiveHabitsModule.Text = "PositiveHabitsModule";
            this.tcPositiveHabitsModule.UseVisualStyleBackColor = true;
            // 
            // bRemovePositiveHabit
            // 
            this.bRemovePositiveHabit.Location = new System.Drawing.Point(689, 73);
            this.bRemovePositiveHabit.Name = "bRemovePositiveHabit";
            this.bRemovePositiveHabit.Size = new System.Drawing.Size(170, 61);
            this.bRemovePositiveHabit.TabIndex = 2;
            this.bRemovePositiveHabit.Text = "Remove Selected Positive Habit";
            this.bRemovePositiveHabit.UseVisualStyleBackColor = true;
            this.bRemovePositiveHabit.Click += new System.EventHandler(this.bRemovePositiveHabit_Click);
            // 
            // bAddNewPositiveHabit
            // 
            this.bAddNewPositiveHabit.Location = new System.Drawing.Point(689, 6);
            this.bAddNewPositiveHabit.Name = "bAddNewPositiveHabit";
            this.bAddNewPositiveHabit.Size = new System.Drawing.Size(170, 61);
            this.bAddNewPositiveHabit.TabIndex = 1;
            this.bAddNewPositiveHabit.Text = "Add New Positive Habit";
            this.bAddNewPositiveHabit.UseVisualStyleBackColor = true;
            this.bAddNewPositiveHabit.Click += new System.EventHandler(this.bAddNewRecord_Click);
            // 
            // dgvPositiveHabits
            // 
            this.dgvPositiveHabits.AllowUserToResizeColumns = false;
            this.dgvPositiveHabits.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPositiveHabits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPositiveHabits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPositiveHabits.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPositiveHabits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPositiveHabits.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvPositiveHabits.Location = new System.Drawing.Point(8, 6);
            this.dgvPositiveHabits.MultiSelect = false;
            this.dgvPositiveHabits.Name = "dgvPositiveHabits";
            this.dgvPositiveHabits.RowHeadersVisible = false;
            this.dgvPositiveHabits.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPositiveHabits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPositiveHabits.Size = new System.Drawing.Size(675, 574);
            this.dgvPositiveHabits.TabIndex = 0;
            // 
            // tcStrategicObjectivesModule
            // 
            this.tcStrategicObjectivesModule.Controls.Add(this.trackBar4);
            this.tcStrategicObjectivesModule.Controls.Add(this.trackBar3);
            this.tcStrategicObjectivesModule.Controls.Add(this.trackBar2);
            this.tcStrategicObjectivesModule.Controls.Add(this.trackBar1);
            this.tcStrategicObjectivesModule.Location = new System.Drawing.Point(4, 22);
            this.tcStrategicObjectivesModule.Name = "tcStrategicObjectivesModule";
            this.tcStrategicObjectivesModule.Size = new System.Drawing.Size(862, 588);
            this.tcStrategicObjectivesModule.TabIndex = 2;
            this.tcStrategicObjectivesModule.Text = "StrategicObjectivesModule";
            this.tcStrategicObjectivesModule.UseVisualStyleBackColor = true;
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(20, 177);
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.RightToLeftLayout = true;
            this.trackBar4.Size = new System.Drawing.Size(556, 45);
            this.trackBar4.TabIndex = 3;
            this.trackBar4.TickFrequency = 5;
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(20, 126);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.RightToLeftLayout = true;
            this.trackBar3.Size = new System.Drawing.Size(556, 45);
            this.trackBar3.TabIndex = 2;
            this.trackBar3.TickFrequency = 5;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(20, 75);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.RightToLeftLayout = true;
            this.trackBar2.Size = new System.Drawing.Size(556, 45);
            this.trackBar2.TabIndex = 1;
            this.trackBar2.TickFrequency = 5;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(20, 24);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeftLayout = true;
            this.trackBar1.Size = new System.Drawing.Size(556, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickFrequency = 5;
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
            this.tcPositiveHabitsModule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositiveHabits)).EndInit();
            this.tcStrategicObjectivesModule.ResumeLayout(false);
            this.tcStrategicObjectivesModule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tcBlank;
        private System.Windows.Forms.TabPage tcPositiveHabitsModule;
        private System.Windows.Forms.DataGridView dgvPositiveHabits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAddNewPositiveHabit;
        private System.Windows.Forms.Button bRemovePositiveHabit;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabPage tcStrategicObjectivesModule;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
    }
}

