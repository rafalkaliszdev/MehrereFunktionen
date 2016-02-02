namespace Mehrere_Funktionen_2 {
    partial class AddNewRowForm {
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
            this.lFrequency = new System.Windows.Forms.Label();
            this.lCommonDenominator = new System.Windows.Forms.Label();
            this.lCategory = new System.Windows.Forms.Label();
            this.lCoreDescription = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPossibleSolution = new System.Windows.Forms.TextBox();
            this.tbReasonOfNotDoing = new System.Windows.Forms.TextBox();
            this.tbFullDescription = new System.Windows.Forms.TextBox();
            this.tbCoreDescription = new System.Windows.Forms.TextBox();
            this.cbFrequency = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbCommonDenominator = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lFrequency
            // 
            this.lFrequency.AutoSize = true;
            this.lFrequency.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lFrequency.Location = new System.Drawing.Point(21, 28);
            this.lFrequency.Name = "lFrequency";
            this.lFrequency.Size = new System.Drawing.Size(198, 19);
            this.lFrequency.TabIndex = 19;
            this.lFrequency.Text = "current frequency....";
            // 
            // lCommonDenominator
            // 
            this.lCommonDenominator.AutoSize = true;
            this.lCommonDenominator.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lCommonDenominator.Location = new System.Drawing.Point(21, 66);
            this.lCommonDenominator.Name = "lCommonDenominator";
            this.lCommonDenominator.Size = new System.Drawing.Size(198, 19);
            this.lCommonDenominator.TabIndex = 18;
            this.lCommonDenominator.Text = "common denominator...";
            // 
            // lCategory
            // 
            this.lCategory.AutoSize = true;
            this.lCategory.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lCategory.Location = new System.Drawing.Point(21, 47);
            this.lCategory.Name = "lCategory";
            this.lCategory.Size = new System.Drawing.Size(198, 19);
            this.lCategory.TabIndex = 17;
            this.lCategory.Text = "category.............";
            // 
            // lCoreDescription
            // 
            this.lCoreDescription.AutoSize = true;
            this.lCoreDescription.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lCoreDescription.Location = new System.Drawing.Point(21, 9);
            this.lCoreDescription.Name = "lCoreDescription";
            this.lCoreDescription.Size = new System.Drawing.Size(198, 19);
            this.lCoreDescription.TabIndex = 16;
            this.lCoreDescription.Text = "core description.....";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(21, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "possible solution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(21, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "reason of not doing";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(21, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "full description";
            // 
            // tbPossibleSolution
            // 
            this.tbPossibleSolution.Location = new System.Drawing.Point(12, 298);
            this.tbPossibleSolution.Multiline = true;
            this.tbPossibleSolution.Name = "tbPossibleSolution";
            this.tbPossibleSolution.Size = new System.Drawing.Size(388, 62);
            this.tbPossibleSolution.TabIndex = 7;
            this.tbPossibleSolution.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EveryTextBox_KeyDown);
            // 
            // tbReasonOfNotDoing
            // 
            this.tbReasonOfNotDoing.Location = new System.Drawing.Point(12, 211);
            this.tbReasonOfNotDoing.Multiline = true;
            this.tbReasonOfNotDoing.Name = "tbReasonOfNotDoing";
            this.tbReasonOfNotDoing.Size = new System.Drawing.Size(388, 62);
            this.tbReasonOfNotDoing.TabIndex = 6;
            this.tbReasonOfNotDoing.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EveryTextBox_KeyDown);
            // 
            // tbFullDescription
            // 
            this.tbFullDescription.Location = new System.Drawing.Point(12, 124);
            this.tbFullDescription.Multiline = true;
            this.tbFullDescription.Name = "tbFullDescription";
            this.tbFullDescription.Size = new System.Drawing.Size(388, 62);
            this.tbFullDescription.TabIndex = 5;
            this.tbFullDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EveryTextBox_KeyDown);
            // 
            // tbCoreDescription
            // 
            this.tbCoreDescription.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCoreDescription.Location = new System.Drawing.Point(225, 10);
            this.tbCoreDescription.Name = "tbCoreDescription";
            this.tbCoreDescription.Size = new System.Drawing.Size(134, 20);
            this.tbCoreDescription.TabIndex = 1;
            // 
            // cbFrequency
            // 
            this.cbFrequency.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbFrequency.FormattingEnabled = true;
            this.cbFrequency.Location = new System.Drawing.Point(225, 29);
            this.cbFrequency.Name = "cbFrequency";
            this.cbFrequency.Size = new System.Drawing.Size(134, 21);
            this.cbFrequency.TabIndex = 2;
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(225, 48);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(134, 21);
            this.cbCategory.TabIndex = 3;
            // 
            // cbCommonDenominator
            // 
            this.cbCommonDenominator.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbCommonDenominator.FormattingEnabled = true;
            this.cbCommonDenominator.Location = new System.Drawing.Point(225, 67);
            this.cbCommonDenominator.Name = "cbCommonDenominator";
            this.cbCommonDenominator.Size = new System.Drawing.Size(134, 21);
            this.cbCommonDenominator.TabIndex = 4;
            // 
            // AddNewRowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 368);
            this.Controls.Add(this.cbCommonDenominator);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.cbFrequency);
            this.Controls.Add(this.tbCoreDescription);
            this.Controls.Add(this.lFrequency);
            this.Controls.Add(this.lCommonDenominator);
            this.Controls.Add(this.lCategory);
            this.Controls.Add(this.lCoreDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPossibleSolution);
            this.Controls.Add(this.tbReasonOfNotDoing);
            this.Controls.Add(this.tbFullDescription);
            this.Name = "AddNewRowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Activity (==positive habit)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNewRowForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lFrequency;
        private System.Windows.Forms.Label lCommonDenominator;
        private System.Windows.Forms.Label lCategory;
        private System.Windows.Forms.Label lCoreDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPossibleSolution;
        private System.Windows.Forms.TextBox tbReasonOfNotDoing;
        private System.Windows.Forms.TextBox tbFullDescription;
        private System.Windows.Forms.TextBox tbCoreDescription;
        private System.Windows.Forms.ComboBox cbFrequency;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbCommonDenominator;
    }
}