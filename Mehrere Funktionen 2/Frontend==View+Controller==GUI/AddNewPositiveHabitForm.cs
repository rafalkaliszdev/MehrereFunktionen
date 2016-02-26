using System.Windows.Forms;
using System;

namespace Mehrere_Funktionen_2 {
    public partial class AddNewPositiveHabitForm : Form {
        public PositiveHabit NewPositiveHabit { get; set; }
        public AddNewPositiveHabitForm() {
            InitializeComponent();

            // even with these commands below, CTRL+A doesn't work
            tbFullDescription.ShortcutsEnabled = true;
            tbReasonOfNotDoing.ShortcutsEnabled = true;
            tbPossibleSolution.ShortcutsEnabled = true;

            //previously I added manually values into ComboBoxes, now I have nice foreach
            //for ComboBox Frequency
            foreach (var value in Enum.GetValues(typeof(PositiveHabitFrequency))) {
                cbFrequency.Items.Add(value);
            }
            //for ComboBox Category
            foreach (var value in Enum.GetValues(typeof(PositiveHabitCategory))) {
                cbCategory.Items.Add(value);
            }
            //for ComboBox CommonDenominaotr
            foreach (var value in Enum.GetValues(typeof(PositiveHabitCommonDenominatorCategory))) {
                cbCommonDenominator.Items.Add(value);
            }
            cbCommonDenominator.SelectedItem = PositiveHabitCommonDenominatorCategory.NOT_SPECIFIED;
        }
        //---------------------------------------------------------------------------
        private void AddNewPositiveHabitForm_FormClosing(object sender, FormClosingEventArgs e) {
            //saving a file fill be done when user exits Form
            DialogResult dialogResult = MessageBox.Show(
                "Save object?",
                " ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

            if (dialogResult == DialogResult.Yes) {
                NewPositiveHabit.CoreDescription = tbCoreDescription.Text;
                if (tbCoreDescription.Text == string.Empty || tbCoreDescription.Text == "") {
                    MessageBox.Show("Core Description is the only property that can't be empty", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                }

                try {
                    NewPositiveHabit.Frequency = (PositiveHabitFrequency)cbFrequency.SelectedItem;
                    NewPositiveHabit.Category = (PositiveHabitCategory)cbCategory.SelectedItem;
                    NewPositiveHabit.CommonDenominator = (PositiveHabitCommonDenominatorCategory)cbCommonDenominator.SelectedItem;
                }
                catch {
                    if (cbFrequency.SelectedIndex == -1) {
                        MessageBox.Show("Frequency needs to be selected", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        e.Cancel = true;
                    }
                    if (cbCategory.SelectedIndex == -1) {
                        MessageBox.Show("Category needs to be selected", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        e.Cancel = true;
                    }
                    if (cbCommonDenominator.SelectedIndex == -1) {
                        MessageBox.Show("Common denominator needs to be selected", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        e.Cancel = true;
                    }
                }
                NewPositiveHabit.FullDescription = tbFullDescription.Text;
                NewPositiveHabit.ReasonOfNotDoing = tbReasonOfNotDoing.Text;
                NewPositiveHabit.PossibleSolution = tbPossibleSolution.Text;

                this.DialogResult = DialogResult.Yes; //refers to THIS Form (AddNewRowForm)
            }
            else {
                NewPositiveHabit = null;
                this.DialogResult = DialogResult.No; //refers to THIS Form (AddNewRowForm)
            }
        }
        //---------------------------------------------------------------------------
        /// <summary>
        /// this Event Handler makes CTRL+A possible in TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EveryTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.Control && (e.KeyCode == Keys.A)) {
                if (sender != null) // this condition isn't necessary
                    ((TextBox)sender).SelectAll();
                e.Handled = true; // it is just information Property
                e.SuppressKeyPress = true; // thanks to this, annoying warning sounds doesn't appear
            }
        }
    }
}
