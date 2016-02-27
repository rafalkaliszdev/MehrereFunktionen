using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Mehrere_Funktionen_2 {
    /// <summary>
    /// Stores profound information about one PositiveHabit
    /// </summary>
    public class PositiveHabit {
        // visible in DataGridView and under button
        public string CoreDescription { get; set; }
        public PositiveHabitFrequency Frequency { get; set; }
        public PositiveHabitCategory Category { get; set; }
        public PositiveHabitCommonDenominatorCategory CommonDenominator { get; set; }    // should be nullable
                                                                                         // only under button
        public string FullDescription { get; set; }
        public string ReasonOfNotDoing { get; set; }    // should be nullable
        public string PossibleSolution { get; set; }    // should be nullable
        public DateTime LastCheckedInComboBox { get; set; } //shouldn't be readonly ?

        //Constructor ---------------------------------------------------------------
        public PositiveHabit() {
            //values of these Properties can be as default null 
            //user do not  need to write into them anything - it is optional
            FullDescription = string.Empty;
            ReasonOfNotDoing = string.Empty;
            PossibleSolution = string.Empty;

            LastCheckedInComboBox = DateTime.MinValue;
        }
    }
    public class PositiveHabitCollection {
        // maybe someday
        /*
        kolekcja mogłaby implementować
        1. singleton
        2. własne metody
        3. miałbym
                PositiveHabit - na obiekty
                PositiveHabit - na kolekcję tych obiektów (tak samo w DataGridView)

        Porzuciłem pomysł zrobienia osobnej klasy PositiveHabitCollection, 
        bo między innymi: trzeba zaimplementować interfejs IEnumerable, 
        aby obiekt klasy można było przeiterować w foreach, 
        nie wiem jak dostać się do kontrolki DataGridView, z metody w innej klasie.
    
        private List<PositiveHabit> positiveHabitCollection;

        public PositiveHabitCollection() {
            positiveHabitCollection = new List<PositiveHabit>();
        }

        public void Add(PositiveHabit positiveHabit) {
            positiveHabitCollection.Add(positiveHabit); //yo dawg, you heard you like methods..
        }
        */
    }
    public class BusinessLogic {
        public static void LoadDgvScheme(DataGridView dgvPositiveHabits) {
            DataGridViewTextBoxColumn coreDescriptionColumn = new DataGridViewTextBoxColumn();
            {
                coreDescriptionColumn.HeaderText = "Core Description";
                coreDescriptionColumn.Visible = true;
                coreDescriptionColumn.Width = 120;      // 120px fits good
                coreDescriptionColumn.ReadOnly = true;
                coreDescriptionColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvPositiveHabits.Columns.Add(coreDescriptionColumn);
            }
            DataGridViewComboBoxColumn frequencyColumn = new DataGridViewComboBoxColumn();
            {
                frequencyColumn.HeaderText = "Frequency Estimation";
                frequencyColumn.Visible = true;
                // this first intruction solves DataGridView:System.ArgumentException: 
                // "DataGridViewComboBoxCell value is not valid."
                frequencyColumn.ValueType = typeof(PositiveHabitFrequency);
                foreach (PositiveHabitFrequency value in Enum.GetValues(typeof(PositiveHabitFrequency))) {
                    frequencyColumn.Items.Add(value);
                }
                //2 obsolete
                //frequencyColumn.Items.Add(PositiveHabit.PositiveHabitFrequency.NOT_DOING);
                //frequencyColumn.Items.Add(PositiveHabit.PositiveHabitFrequency.TOO_LITTLE);
                //frequencyColumn.Items.Add(PositiveHabit.PositiveHabitFrequency.SATYSFYING);
                //frequencyColumn.Items.Add(PositiveHabit.PositiveHabitFrequency.ALWAYS);
                frequencyColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvPositiveHabits.Columns.Add(frequencyColumn);
            }
            DataGridViewTextBoxColumn categoryColumn = new DataGridViewTextBoxColumn();
            {
                categoryColumn.HeaderText = "Category";
                categoryColumn.Visible = true;
                categoryColumn.Width = 150;
                categoryColumn.ReadOnly = true;
                categoryColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvPositiveHabits.Columns.Add(categoryColumn);
            }
            DataGridViewTextBoxColumn commonDenominatorColumn = new DataGridViewTextBoxColumn();
            {
                commonDenominatorColumn.HeaderText = "Common Denominator (Cause of Not Doing)";
                commonDenominatorColumn.Visible = true;
                commonDenominatorColumn.ReadOnly = true;
                commonDenominatorColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvPositiveHabits.Columns.Add(commonDenominatorColumn);
            }
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            {
                buttonColumn.HeaderText = "";
                buttonColumn.UseColumnTextForButtonValue = true; // all buttons will have the same Text
                buttonColumn.Text = "Full Info";
                buttonColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvPositiveHabits.Columns.Add(buttonColumn);
            }
        }
        public static void LoadXmltoList(List<PositiveHabit> positiveHabitCollection) {
            DataTable tableInsideXml = new DataTable();

            try {
                tableInsideXml.ReadXml("MehrereFunktionenDataBase.xml");
            }
            //wenn ich es könnte besser sein? 
            //these 2 exceptions WERE doubled
            catch (FileNotFoundException ex) {
                HandleLoadExceptions(ex, tableInsideXml);
                ////case: no file whatsoever
                //MessageBox.Show(ex.Message);
                //dataTable.TableName = "PositiveHabitRecord";
                //dataTable.WriteXml("MehrereFunktionenDataBase.xml", XmlWriteMode.WriteSchema);

                ////and try again, now it won't fire Exception
                //dataTable.ReadXml("MehrereFunktionenDataBase.xml");
            }
            catch (ArgumentException ex) {
                HandleLoadExceptions(ex, tableInsideXml);
                ////case: sometimes 
                //MessageBox.Show(ex.Message);
                //dataTable.TableName = "PositiveHabitRecord";
                //dataTable.WriteXml("MehrereFunktionenDataBase.xml", XmlWriteMode.WriteSchema);

                ////and try again, now it won't fire Exception
                //dataTable.ReadXml("MehrereFunktionenDataBase.xml");
            }

            foreach (DataRow dataRow in tableInsideXml.AsEnumerable()) {
                PositiveHabit PositiveHabit = new PositiveHabit();

                PositiveHabit.CoreDescription =
                    ((dataRow[0] == DBNull.Value /*null*/) ? string.Empty : (string)dataRow[0]);

                PositiveHabit.Frequency = (PositiveHabitFrequency)dataRow[1];
                PositiveHabit.Category = (PositiveHabitCategory)dataRow[2];
                PositiveHabit.CommonDenominator = (PositiveHabitCommonDenominatorCategory)dataRow[3];

                PositiveHabit.FullDescription =
                    ((dataRow[4] == DBNull.Value /*null*/) ? string.Empty : (string)dataRow[4]);
                PositiveHabit.ReasonOfNotDoing =
                    ((dataRow[5] == DBNull.Value /*null*/) ? string.Empty : (string)dataRow[5]);
                PositiveHabit.PossibleSolution =
                    ((dataRow[6] == DBNull.Value /*null*/) ? string.Empty : (string)dataRow[6]);

                PositiveHabit.LastCheckedInComboBox = (DateTime)dataRow[7];

                positiveHabitCollection.Add(PositiveHabit);
            }

        }
        public static DataTable LoadDataTableColumns() {
            // exit call stack 1/2
            DataTable dataTable = new DataTable();

            //wenn ich es könnte besser sein? 
            //nie wiem jak wydobyć typ i nazwę Właściwości klasy PositiveHabits

            //CoreDescription
            DataColumn dataColumn = new DataColumn();
            dataColumn.ColumnName = "CoreDescription";
            dataColumn.DataType = typeof(string);
            dataTable.Columns.Add(dataColumn);
            //Frequency
            DataColumn dataColumn1 = new DataColumn();
            dataColumn1.ColumnName = "Frequency";
            dataColumn1.DataType = typeof(PositiveHabitFrequency); //był string
            dataTable.Columns.Add(dataColumn1);
            //Category
            DataColumn dataColumn2 = new DataColumn();
            dataColumn2.ColumnName = "Category";
            dataColumn2.DataType = typeof(PositiveHabitCategory); //był string
            dataTable.Columns.Add(dataColumn2);
            //CommonDenominator
            DataColumn dataColumn3 = new DataColumn();
            dataColumn3.ColumnName = "CommonDenominator";
            dataColumn3.DataType = typeof(PositiveHabitCommonDenominatorCategory); //był string
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
        public static void LoadDataTableRowsAndSaveXml(DataTable dataTable, List<PositiveHabit> positiveHabitCollection) {
            // exit call stack 1/2

            //wenn ich es könnte besser sein?
            foreach (PositiveHabit PositiveHabit in positiveHabitCollection) {
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = PositiveHabit.CoreDescription;
                dataRow[1] = PositiveHabit.Frequency;
                dataRow[2] = PositiveHabit.Category;
                dataRow[3] = PositiveHabit.CommonDenominator;
                dataRow[4] = PositiveHabit.FullDescription;
                dataRow[5] = PositiveHabit.ReasonOfNotDoing;
                dataRow[6] = PositiveHabit.PossibleSolution;
                dataRow[7] = PositiveHabit.LastCheckedInComboBox;

                dataTable.Rows.Add(dataRow);
            }
            dataTable.TableName = "PositiveHabitRecord";
            dataTable.WriteXml("MehrereFunktionenDataBase.xml", XmlWriteMode.WriteSchema);
        }
        //chyba jedyna metoda private jaka dotychczas napisalem !! ^^
        private static void HandleLoadExceptions(Exception ex, DataTable dataTable) {
            //possible cases: no file whatsoever, wrong argument 
            MessageBox.Show(ex.Message);
            dataTable.TableName = "PositiveHabitRecord";
            dataTable.WriteXml("MehrereFunktionenDataBase.xml", XmlWriteMode.WriteSchema);

            //and try again, now it won't fire Exception
            dataTable.ReadXml("MehrereFunktionenDataBase.xml");
        }
    }
    public enum PositiveHabitFrequency {
        NOT_DOING = 0,
        TOO_LITTLE = 1,
        SATYSFYING = 2,
        ALWAYS = 3,
    }
    public enum PositiveHabitCategory {
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
        BOULDER = 10,
        MNICH_MODE = 11
    }
    public enum PositiveHabitCommonDenominatorCategory {
        NOT_SPECIFIED,
        ENSO,
        BOULDER,
        EINESPUR
    }
}
