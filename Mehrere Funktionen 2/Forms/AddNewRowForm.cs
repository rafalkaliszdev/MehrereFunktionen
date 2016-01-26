using System.Windows.Forms;
using Mehrere_Funktionen_2.ImplementingActivitiesModule;

namespace Mehrere_Funktionen_2 {
    public partial class AddNewRowForm : Form {
        public Activity NewActivity { get; set; }
        public AddNewRowForm() {
            InitializeComponent();

            // even with these commands below, CTRL+A doesn't work
            tbFullDescription.ShortcutsEnabled = true;
            tbReasonOfNotDoing.ShortcutsEnabled = true;
            tbPossibleSolution.ShortcutsEnabled = true;

            //wenn ich es könnte besser sein?
            cbFrequency.Items.Add(Activity.ActivityFrequency.NOT_DOING);
            cbFrequency.Items.Add(Activity.ActivityFrequency.TOO_LITTLE);
            cbFrequency.Items.Add(Activity.ActivityFrequency.SATYSFYING);
            cbFrequency.Items.Add(Activity.ActivityFrequency.ALWAYS);

            cbCategory.Items.Add(Activity.ActivityCategory.DISCIPLINE);
            cbCategory.Items.Add(Activity.ActivityCategory.TO_BE_ELIMINATED);
            cbCategory.Items.Add(Activity.ActivityCategory.EXCUSES);
            cbCategory.Items.Add(Activity.ActivityCategory.DAY_CYCLE);
            cbCategory.Items.Add(Activity.ActivityCategory.LIFESTYLE);
            cbCategory.Items.Add(Activity.ActivityCategory.PHYSICAL_ACTIVITY);
            cbCategory.Items.Add(Activity.ActivityCategory.ENVIRONMENT);
            cbCategory.Items.Add(Activity.ActivityCategory.DIET);
            cbCategory.Items.Add(Activity.ActivityCategory.NEGATIVE_HABITS);
            cbCategory.Items.Add(Activity.ActivityCategory.POSITIVE_HABITS);

            cbCommonDenominator.Items.Add(Activity.ActivityCommonDenominatorCategory.NOT_SPECIFIED);
            cbCommonDenominator.Items.Add(Activity.ActivityCommonDenominatorCategory.BOULDER);
            cbCommonDenominator.Items.Add(Activity.ActivityCommonDenominatorCategory.EINESPUR);
            cbCommonDenominator.Items.Add(Activity.ActivityCommonDenominatorCategory.ENSO);
        }
        //---------------------------------------------------------------------------
        private void AddNewRowForm_FormClosing(object sender, FormClosingEventArgs e) {

            DialogResult dialogResult = MessageBox.Show(
                "Save object?",
                " ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

            if (dialogResult == DialogResult.Yes) {
                NewActivity.CoreDescription = tbCoreDescription.Text;
                if (tbCoreDescription.Text == string.Empty || tbCoreDescription.Text == "") {
                    MessageBox.Show("Core Description is the only property that can't be empty", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                }

                try {
                    NewActivity.Frequency = (Activity.ActivityFrequency)cbFrequency.SelectedItem;
                    NewActivity.Category = (Activity.ActivityCategory)cbCategory.SelectedItem;
                    NewActivity.CommonDenominator = (Activity.ActivityCommonDenominatorCategory)cbCommonDenominator.SelectedItem;
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
                NewActivity.FullDescription = tbFullDescription.Text;
                NewActivity.ReasonOfNotDoing = tbReasonOfNotDoing.Text;
                NewActivity.PossibleSolution = tbPossibleSolution.Text;
            }
            if (dialogResult == DialogResult.No) {
                NewActivity = null;
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
