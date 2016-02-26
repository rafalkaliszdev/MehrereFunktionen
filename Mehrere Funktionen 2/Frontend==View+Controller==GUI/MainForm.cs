using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Globalization; //CultureInfo
using System.IO;

namespace Mehrere_Funktionen_2 {
    public partial class MainForm : Form {
        //wenn ich es könnte besser sein? 
        public List<PositiveHabit> positiveHabitCollection;
        
        //Constructor ---------------------------------------------------------------
        public MainForm() {
            InitializeComponent();
        }
        #region EventHanlders
        //Standard (UI) Event Handlers ----------------------------------------------
        private void MainForm_Load(object sender, EventArgs e) {
            // better in MainForm_Load() than constructor MainForm()
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us"); //exceptions in eng

            tabControl1.SelectedIndex = 1;

            //collection initialization 
            positiveHabitCollection = new List<PositiveHabit>();

            //properties
            dgvPositiveHabits.EditMode = DataGridViewEditMode.EditOnEnter; //ComboBox responds on 1-click
            dgvPositiveHabits.AllowUserToAddRows = false; //removes blank row on bottom

            // events
            dgvPositiveHabits.CellContentClick += DgvPositiveHabits_CellContentClick;
            dgvPositiveHabits.CellValueChanged += DgvPositiveHabits_CellValueChanged;
            dgvPositiveHabits.CurrentCellDirtyStateChanged += DgvPositiveHabits_CurrentCellDirtyStateChanged;

            BusinessLogic.LoadDgvScheme(dgvPositiveHabits);
            BusinessLogic.LoadXmltoList(positiveHabitCollection);
            UpdateDgvRecordsFromCollection();
        }
        //---------------------------------------------------------------------------
        /// <summary>
        /// EH firing closing methods
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            DataTable tempDataTable = BusinessLogic.LoadDataTableColumns();
            BusinessLogic.LoadDataTableRowsAndSaveXml(tempDataTable, positiveHabitCollection);
        }
        //---------------------------------------------------------------------------
        /// <summary>
        /// EH handling adding new record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bAddNewRecord_Click(object sender, EventArgs e) {
            AddNewPositiveHabitForm addNewRowForm = new AddNewPositiveHabitForm();

            PositiveHabit tempPositiveHabit = new PositiveHabit();
            addNewRowForm.NewPositiveHabit = tempPositiveHabit;
            this.Hide();
            DialogResult dialogResult = addNewRowForm.ShowDialog();

            if (dialogResult == DialogResult.Yes) {
                //MessageBox.Show("Successfully created new PositiveHabit !"); //test
                positiveHabitCollection.Add(tempPositiveHabit);
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
        private void bRemovePositiveHabit_Click(object sender, EventArgs e) {
            DialogResult tempDialogResult = MessageBox.Show(
                "For sure ?",
                "Delete selected record",
                MessageBoxButtons.YesNo
                );
            if (tempDialogResult == DialogResult.Yes) {
                //wenn ich es könnte besser sein?
                foreach (DataGridViewRow row in this.dgvPositiveHabits.SelectedRows) {
                    for (int i = 0; i < positiveHabitCollection.Count; ++i) {
                        if (positiveHabitCollection[i].CoreDescription == (string)row.Cells[0].Value) {
                            positiveHabitCollection.Remove(positiveHabitCollection[i]);
                        }
                    }
                    UpdateDgvRecordsFromCollection();
                }
            }
        }
        //Customized Event Handlers -------------------------------------------------
        private void DgvPositiveHabits_CurrentCellDirtyStateChanged(object sender, EventArgs e) {
            // this EH fires 1st, then again 3rd
            if (this.dgvPositiveHabits.IsCurrentCellDirty) {
                // this metod fires EH DgvPositiveHabits_CellValueChanged() (directly below)
                dgvPositiveHabits.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        //---------------------------------------------------------------------------
        /// <summary>
        /// EH changing ComboBoxCell value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvPositiveHabits_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            // this EH fires as 2nd
            DataGridViewComboBoxCell dgvComboBoxCell = (DataGridViewComboBoxCell)dgvPositiveHabits.Rows[e.RowIndex].Cells[1];
            if (dgvComboBoxCell != null) {
                try {
                    PositiveHabitFrequency tempFrequency = (PositiveHabitFrequency)dgvComboBoxCell.Value;

                    positiveHabitCollection[e.RowIndex].Frequency = tempFrequency; //one of enum value
                    positiveHabitCollection[e.RowIndex].LastCheckedInComboBox = DateTime.Now.Date; //today's date

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
        private void DgvPositiveHabits_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            DataGridView senderObject = (DataGridView)sender;
            // 1st condition checks whether clicked column has correct type
            // 2nd condition insists that row must be equal or bigger than 0
            if (senderObject.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) {
                DetailedPositiveHabitInformationForm detailedForm = new DetailedPositiveHabitInformationForm();

                try {
                    detailedForm.SendCurrentInformations(positiveHabitCollection[e.RowIndex]);
                    this.Hide();
                    detailedForm.ShowDialog();
                }
                catch (System.ArgumentOutOfRangeException ex) {
                    MessageBox.Show("just clicked on this record with blank values, eh?" + ex.Message);
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
        #endregion
        #region Methods (non EventHandlers)
        private void UpdateDgvRecordsFromCollection() {
            //can't locate this into business logic - because this method modyify control
            dgvPositiveHabits.Rows.Clear();
            foreach (PositiveHabit positiveHabit in positiveHabitCollection) {
                if(positiveHabit.LastCheckedInComboBox == DateTime.Now.Date) {
                    dgvPositiveHabits.Rows.Add(positiveHabit.CoreDescription, positiveHabit.Frequency, positiveHabit.Category, positiveHabit.CommonDenominator);
                }
                else {
                    //if it is first application open today, it will assign null - so user can choose his own value
                    dgvPositiveHabits.Rows.Add(positiveHabit.CoreDescription, null, positiveHabit.Category, positiveHabit.CommonDenominator);
                }

            }
            DisableAlreadyCheckedComboBoxes(); //need to disable again ComboBoxes
        }
        private void DisableAlreadyCheckedComboBoxes() {
            //can't locate this into business logic - because this method modyify control
            //wenn ich es könnte besser sein? 
            foreach (PositiveHabit PositiveHabit in positiveHabitCollection) {
                //true if today's date is the same as date in Property 
                if (DateTime.Now.Date == PositiveHabit.LastCheckedInComboBox) {
                    foreach (DataGridViewRow row in dgvPositiveHabits.Rows) {
                        var firstCell = (DataGridViewTextBoxCell)row.Cells[0];

                        //comparsion by string (I have mere idea how to do it better)
                        if (PositiveHabit.CoreDescription == (string)firstCell.Value) {
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