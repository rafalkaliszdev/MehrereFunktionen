using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehrere_Funktionen_2 {
    /// <summary>
    /// Stores profound information about one Activity
    /// </summary>
    public class Activity {
        // visible in DataGridView and under button
        public string CoreDescription { get; set; }
        public ActivityFrequency Frequency { get; set; }
        public ActivityCategory Category { get; set; }
        public ActivityCommonDenominatorCategory CommonDenominator { get; set; }    // should be nullable
                                                                                    // only under button
        public string FullDescription { get; set; }
        public string ReasonOfNotDoing { get; set; }    // should be nullable
        public string PossibleSolution { get; set; }    // should be nullable
        public DateTime LastCheckedInComboBox { get; set; } //shouldn't be readonly ?
                                                            //---------------------------------------------------------------------------
        public enum ActivityFrequency {
            NOT_DOING = 0,
            TOO_LITTLE = 1,
            SATYSFYING = 2,
            ALWAYS = 3
        }
        //---------------------------------------------------------------------------
        public enum ActivityCategory {
            //don't remove anything - add note "obsolete" and just add at end new category     
            DISCIPLINE = 0, //mnich mode? //obsolete
                            //TO_BE_ELIMINATED, //obsolete
                            //EXCUSES, //obsolete
            DAY_CYCLE = 3,
            LIFESTYLE = 4,
            PHYSICAL_ACTIVITY = 5,
            //ENVIRONMENT, //obsolete
            DIET = 6,
            SUPPLEMENTS = 7,
            //NEGATIVE_HABITS, //obsolete
            //POSITIVE_HABITS, //obsolete
            BOULDER = 10
        }
        //---------------------------------------------------------------------------
        public enum ActivityCommonDenominatorCategory {
            NOT_SPECIFIED,
            ENSO,
            BOULDER,
            EINESPUR
        }
        //Constructor ---------------------------------------------------------------
        public Activity() {
            //values of these Properties can be as default null 
            //user do not  need to write into them anything - it is optional
            FullDescription = string.Empty;
            ReasonOfNotDoing = string.Empty;
            PossibleSolution = string.Empty;

            LastCheckedInComboBox = DateTime.MinValue;
        }
    }
}
