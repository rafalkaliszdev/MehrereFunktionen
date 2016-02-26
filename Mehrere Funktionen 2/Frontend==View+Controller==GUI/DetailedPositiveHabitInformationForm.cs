using System.Windows.Forms;

namespace Mehrere_Funktionen_2 {
    public partial class DetailedPositiveHabitInformationForm : Form {
        // wenn ich es könnte besser sein? 
        PositiveHabit currentActiveAction;

        //---------------------------------------------------------------------------
        public DetailedPositiveHabitInformationForm() {
            InitializeComponent();
            // even with these commands below, CTRL+A doesn't work
            tbFullDescription.ShortcutsEnabled = true;
            tbReasonOfNotDoing.ShortcutsEnabled = true;
            tbPossibleSolution.ShortcutsEnabled = true;
        }
        //---------------------------------------------------------------------------
        public void SendCurrentInformations(PositiveHabit dataAboutParticularAction) {
            //this method is called >>before<< .ShowDialog() so I can send object
            //whose Properties are used below
            lCoreDescription.Text = "core description....." + dataAboutParticularAction.CoreDescription;
            lFrequency.Text = "current frequency...." + dataAboutParticularAction.Frequency;
            lCategory.Text = "category............." + dataAboutParticularAction.Category;
            lCommonDenominator.Text = "common denominator..."+ dataAboutParticularAction.CommonDenominator;

            lLastChecked.Text = "last checked at......" + dataAboutParticularAction.LastCheckedInComboBox.ToShortDateString();

            tbFullDescription.Text = dataAboutParticularAction.FullDescription;
            tbReasonOfNotDoing.Text = dataAboutParticularAction.ReasonOfNotDoing;
            tbPossibleSolution.Text = dataAboutParticularAction.PossibleSolution;
            

            currentActiveAction = dataAboutParticularAction;
        }
        //---------------------------------------------------------------------------
        private void DetailedPositiveHabitInformationForm_FormClosing(object sender, FormClosingEventArgs e) {
            currentActiveAction.FullDescription = tbFullDescription.Text;
            currentActiveAction.ReasonOfNotDoing = tbReasonOfNotDoing.Text;
            currentActiveAction.PossibleSolution = tbPossibleSolution.Text;
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
