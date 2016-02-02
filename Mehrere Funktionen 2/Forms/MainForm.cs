using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Mehrere_Funktionen_2.ImplementingActivitiesModule;
using System.Threading;
using System.Globalization; //CultureInfo
using System.IO;
using System.Net.Sockets; //net feature

namespace Mehrere_Funktionen_2 {
    public partial class MainForm : Form {
        // this collection needs to be global
        public List<Activity> collectionActivities;

        //Constructor ---------------------------------------------------------------
        public MainForm() {
            InitializeComponent();
        }
        //Standard (UI) Event Handlers ----------------------------------------------
        private void MainForm_Load(object sender, EventArgs e) {
            // better in MainForm_Load() than constructor MainForm()
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us"); //exceptions in eng

            tabControl1.SelectedIndex = 1;

            //collection initialization
            collectionActivities = new List<Activity>();

            //properties
            dgvImplementingActivities.EditMode = DataGridViewEditMode.EditOnEnter; //ComboBox responds on 1-click
            dgvImplementingActivities.AllowUserToAddRows = false; //removes blank row on bottom

            // events
            dgvImplementingActivities.CellContentClick += DgvImplementingActivities_CellContentClick;
            dgvImplementingActivities.CellValueChanged += DgvImplementingActivities_CellValueChanged;
            dgvImplementingActivities.CurrentCellDirtyStateChanged += DgvImplementingActivities_CurrentCellDirtyStateChanged;

            bool isSchemeReady = LoadDgvScheme();
            LoadXmltoList(isSchemeReady);    //XML objects
            UpdateDgvRecordsFromCollection();
        }
        //---------------------------------------------------------------------------
        /// <summary>
        /// EH firing closing methods
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            DataTable dataTable = LoadDataTableColumns();
            LoadDataTableRowsAndSaveXml(dataTable);
        }
        //---------------------------------------------------------------------------
        /// <summary>
        /// EH handling adding new record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bAddNewRecord_Click(object sender, EventArgs e) {
            AddNewRowForm addNewRowForm = new AddNewRowForm();

            Activity tempActivity = new Activity();
            addNewRowForm.NewActivity = tempActivity;
            this.Hide();
            DialogResult dialogResult = addNewRowForm.ShowDialog();

            if (dialogResult == DialogResult.Yes) {
                //MessageBox.Show("Successfully created new Activity !"); //test
                collectionActivities.Add(tempActivity);
                UpdateDgvRecordsFromCollection();
            }
            else if (dialogResult == DialogResult.No) {
                //MessageBox.Show("Creating aborted !"); //test
            }

            this.Show();
        }
        //---------------------------------------------------------------------------
        /// <summary>
        /// EH for removing record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRemoveActivity_Click(object sender, EventArgs e) {
            DialogResult tempDialogResult = MessageBox.Show(
                "For sure ?",
                "Delete selected record",
                MessageBoxButtons.YesNo
                );
            if (tempDialogResult == DialogResult.Yes) {
                //wenn ich es könnte besser sein?
                foreach (DataGridViewRow row in this.dgvImplementingActivities.SelectedRows) {
                    for (int i = 0; i < collectionActivities.Count; ++i) {
                        if (collectionActivities[i].CoreDescription == (string)row.Cells[0].Value) {
                            collectionActivities.Remove(collectionActivities[i]);
                        }
                    }
                    UpdateDgvRecordsFromCollection();
                }
            }
        }
        //---------------------------------------------------------------------------
        /// <summary>
        /// Button sending to seprated console application XML file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSendXml_Click(object sender, EventArgs e) {
            MessageBox.Show("this feature is not available yet");
            //ruru

            //tbIP.Text;
            //tbPort.Text;
            //TcpListener tcpListener 
        }
        //Customized Event Handlers -------------------------------------------------
        private void DgvImplementingActivities_CurrentCellDirtyStateChanged(object sender, EventArgs e) {
            // this EH fires 1st, then again 3rd
            if (this.dgvImplementingActivities.IsCurrentCellDirty) {
                // this metod fires EH DgvImplementingActivities_CellValueChanged() (directly below)
                dgvImplementingActivities.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        //---------------------------------------------------------------------------
        /// <summary>
        /// EH changing ComboBoxCell value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvImplementingActivities_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            // this EH fires as 2nd
            DataGridViewComboBoxCell dgvComboBoxCell = (DataGridViewComboBoxCell)dgvImplementingActivities.Rows[e.RowIndex].Cells[1];
            if (dgvComboBoxCell != null) {
                try {
                    Activity.ActivityFrequency tempFrequency = (Activity.ActivityFrequency)dgvComboBoxCell.Value;

                    collectionActivities[e.RowIndex].Frequency = tempFrequency; //one of enum value
                    collectionActivities[e.RowIndex].LastCheckedInComboBox = DateTime.Now.Date; //today's date

                    dgvComboBoxCell.FlatStyle = FlatStyle.Popup; //changes ComboBox appearance
                    dgvComboBoxCell.Style.BackColor = System.Drawing.Color.LimeGreen; //changes color
                    dgvComboBoxCell.ReadOnly = true; //disables further modification                    
                }
                catch (System.ArgumentOutOfRangeException ex) {
                    MessageBox.Show("don't tinker here !\n\n" + ex.ToString());
                }
            } 
        }
        //---------------------------------------------------------------------------
        /// <summary>
        /// EH opening new form that supplies detailed information about record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvImplementingActivities_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            DataGridView senderObject = (DataGridView)sender;
            // 1st condition checks whether clicked column has correct type
            // 2nd condition insists that row must be equal or bigger than 0
            if (senderObject.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) {
                DetailedActivityInformationForm detailedForm = new DetailedActivityInformationForm();

                try {
                    detailedForm.SendCurrentInformations(collectionActivities[e.RowIndex]);
                    this.Hide();
                    detailedForm.ShowDialog();                    
                }
                catch (System.ArgumentOutOfRangeException ex) {
                    MessageBox.Show("just clicked on this record with blank values, eh?");
                }
                this.Show();
            }
        }
        //---------------------------------------------------------------------------
        private void MainForm_Resize(object sender, EventArgs e) {

            notifyIcon1.Icon = System.Drawing.SystemIcons.Application;

            notifyIcon1.BalloonTipText = "Program minimalized to tray";

            if (FormWindowState.Minimized == this.WindowState) {                
                this.ShowInTaskbar = false; //better for this purpose
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1500);
            }
        }
        //---------------------------------------------------------------------------
        private void MainForm_MouseDoubleClick(object sender, MouseEventArgs e) {
            this.WindowState = FormWindowState.Normal; //maximalizes THIS form
            this.ShowInTaskbar = true; //better for this purpose
            notifyIcon1.Visible = false;
        }
        //Methods -------------------------------------------------------------------
        //added #region for test
        #region Methods
        private bool LoadDgvScheme() {
            DataGridViewTextBoxColumn coreDescriptionColumn = new DataGridViewTextBoxColumn();
            {
                coreDescriptionColumn.HeaderText = "Core Description";
                coreDescriptionColumn.Visible = true;
                coreDescriptionColumn.Width = 120;      // 120px fits good
                coreDescriptionColumn.ReadOnly = true;
                dgvImplementingActivities.Columns.Add(coreDescriptionColumn);
            }
            DataGridViewComboBoxColumn frequencyColumn = new DataGridViewComboBoxColumn();
            {
                frequencyColumn.HeaderText = "Frequency Estimation";
                frequencyColumn.Visible = true;
                // this first intruction solves DataGridView:System.ArgumentException: 
                // "DataGridViewComboBoxCell value is not valid."
                frequencyColumn.ValueType = typeof(Activity.ActivityFrequency);
                frequencyColumn.Items.Add(Activity.ActivityFrequency.NOT_DOING);
                frequencyColumn.Items.Add(Activity.ActivityFrequency.TOO_LITTLE);
                frequencyColumn.Items.Add(Activity.ActivityFrequency.SATYSFYING);
                frequencyColumn.Items.Add(Activity.ActivityFrequency.ALWAYS);
                dgvImplementingActivities.Columns.Add(frequencyColumn);
            }
            DataGridViewTextBoxColumn categoryColumn = new DataGridViewTextBoxColumn();
            {
                categoryColumn.HeaderText = "Category";
                categoryColumn.Visible = true;
                categoryColumn.Width = 150;
                categoryColumn.ReadOnly = true;
                dgvImplementingActivities.Columns.Add(categoryColumn);
            }
            DataGridViewTextBoxColumn commonDenominatorColumn = new DataGridViewTextBoxColumn();
            {
                commonDenominatorColumn.HeaderText = "Common Denominator";
                commonDenominatorColumn.Visible = true;
                commonDenominatorColumn.ReadOnly = true;
                dgvImplementingActivities.Columns.Add(commonDenominatorColumn);
            }
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            {
                buttonColumn.HeaderText = "";
                buttonColumn.UseColumnTextForButtonValue = true; // all buttons will have the same Text
                buttonColumn.Text = "Full Info";
                dgvImplementingActivities.Columns.Add(buttonColumn);
            }

            //this bool just makes sure that sequence of call stack will be correct
            bool isSchemeReady = true; 
            return isSchemeReady;
        }
        //---------------------------------------------------------------------------
        private void LoadXmltoList(bool isSchemeReady) {
            if (isSchemeReady) { //wenn ich es könnte besser sein?
                DataTable dataTable = new DataTable();

                try {
                    dataTable.ReadXml("MehrereFunktionenDataBase.xml");
                }
                catch (FileNotFoundException ex) {
                    dataTable.TableName = "ActivityRecord";
                    dataTable.WriteXml("MehrereFunktionenDataBase.xml", XmlWriteMode.WriteSchema);

                    //and try again, now it won't fire Exception
                    dataTable.ReadXml("MehrereFunktionenDataBase.xml");
                }

                foreach (DataRow dataRow in dataTable.AsEnumerable()) {
                    Activity activity = new Activity();

                    activity.CoreDescription =
                        ((dataRow[0] == DBNull.Value /*null*/) ? string.Empty : (string)dataRow[0]);

                    activity.Frequency = (Activity.ActivityFrequency)dataRow[1];
                    activity.Category = (Activity.ActivityCategory)dataRow[2];
                    activity.CommonDenominator = (Activity.ActivityCommonDenominatorCategory)dataRow[3];

                    activity.FullDescription = 
                        ((dataRow[4] == DBNull.Value /*null*/) ? string.Empty : (string)dataRow[4]);
                    activity.ReasonOfNotDoing = 
                        ((dataRow[5] == DBNull.Value /*null*/) ? string.Empty : (string)dataRow[5]);
                    activity.PossibleSolution = 
                        ((dataRow[6] == DBNull.Value /*null*/) ? string.Empty : (string)dataRow[6]);

                    activity.LastCheckedInComboBox = (DateTime)dataRow[7];                    

                    collectionActivities.Add(activity);
                }                
            }
        }
        //---------------------------------------------------------------------------
        /// <summary>
        /// Method updating DGV from List<T> - often calling
        /// </summary>
        private void UpdateDgvRecordsFromCollection() {
            dgvImplementingActivities.Rows.Clear();
            foreach (Activity activity in collectionActivities) {
                //for each object in collection, add this object as Row to DGV (with specified Values)
                //this way does not destroy DataGridView Scheme
                dgvImplementingActivities.Rows.Add(activity.CoreDescription, activity.Frequency, activity.Category, activity.CommonDenominator);
            }
            DisableAlreadyCheckedComboBoxes(); //need to disable again ComboBoxes
        }
        //---------------------------------------------------------------------------
        private DataTable LoadDataTableColumns() {
            // exit call stack 1/2
            DataTable dataTable = new DataTable();

            //wenn ich es könnte besser sein? 
            //nie wiem jak wydobyć typ i nazwę Właściwości klasy Activities

            //CoreDescription
            DataColumn dataColumn = new DataColumn();
            dataColumn.ColumnName = "CoreDescription";
            dataColumn.DataType = typeof(string);
            dataTable.Columns.Add(dataColumn);
            //Frequency
            DataColumn dataColumn1 = new DataColumn();
            dataColumn1.ColumnName = "Frequency";
            dataColumn1.DataType = typeof(Activity.ActivityFrequency); //był string
            dataTable.Columns.Add(dataColumn1);
            //Category
            DataColumn dataColumn2 = new DataColumn();
            dataColumn2.ColumnName = "Category";
            dataColumn2.DataType = typeof(Activity.ActivityCategory); //był string
            dataTable.Columns.Add(dataColumn2);
            //CommonDenominator
            DataColumn dataColumn3 = new DataColumn();
            dataColumn3.ColumnName = "CommonDenominator";
            dataColumn3.DataType = typeof(Activity.ActivityCommonDenominatorCategory); //był string
            dataTable.Columns.Add(dataColumn3);
            //FullDescription
            DataColumn dataColumn4 = new DataColumn();
            dataColumn4.ColumnName = "FullDescription";
            dataColumn4.DataType = typeof(string);
            dataTable.Columns.Add(dataColumn4);
            //ReasonOfNotDoing
            DataColumn dataColumn5 = new DataColumn();
            dataColumn5.ColumnName = "ReasonOfNotDoing";
            dataColumn5.DataType = typeof(string);
            dataTable.Columns.Add(dataColumn5);
            //PossibleSolution
            DataColumn dataColumn6 = new DataColumn();
            dataColumn6.ColumnName = "PossibleSolution";
            dataColumn6.DataType = typeof(string);
            dataTable.Columns.Add(dataColumn6);
            //PossibleSolution
            DataColumn dataColumn7 = new DataColumn();
            dataColumn7.ColumnName = "LastCheckedInComboBox";
            dataColumn7.DataType = typeof(DateTime);
            dataTable.Columns.Add(dataColumn7);

            return dataTable;
        }
        //---------------------------------------------------------------------------
        private void LoadDataTableRowsAndSaveXml(DataTable dataTable) {
            // exit call stack 1/2

            //wenn ich es könnte besser sein?

            foreach (Activity activity in collectionActivities) {
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = activity.CoreDescription;
                dataRow[1] = activity.Frequency;
                dataRow[2] = activity.Category;
                dataRow[3] = activity.CommonDenominator;
                dataRow[4] = activity.FullDescription;
                dataRow[5] = activity.ReasonOfNotDoing;
                dataRow[6] = activity.PossibleSolution;
                dataRow[7] = activity.LastCheckedInComboBox;

                dataTable.Rows.Add(dataRow);
            }
            dataTable.TableName = "ActivityRecord";
            dataTable.WriteXml("MehrereFunktionenDataBase.xml", XmlWriteMode.WriteSchema);
        }
        //---------------------------------------------------------------------------
        private void DisableAlreadyCheckedComboBoxes() {
            //wenn ich es könnte besser sein? 
            foreach (Activity activity in collectionActivities) {
                //true if today's date is the same as date in Property 
                if(DateTime.Now.Date == activity.LastCheckedInComboBox) {
                    foreach (DataGridViewRow row in dgvImplementingActivities.Rows) {
                        var firstCell = (DataGridViewTextBoxCell)row.Cells[0];

                        //comparsion by string (I have mere idea how to do it better)
                        if (activity.CoreDescription == firstCell.Value) {
                            var secondCell = (DataGridViewComboBoxCell)row.Cells[1];
                            secondCell.FlatStyle = FlatStyle.Popup; //changes ComboBox appearance
                            secondCell.Style.BackColor = System.Drawing.Color.LimeGreen; //changes color
                            secondCell.ReadOnly = true; //disables further modification     
                        }
                    }
                }
            }
        }

        #endregion
    }
}