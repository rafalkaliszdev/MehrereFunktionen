namespace Mehrere_Funktionen_2 {
    partial class DetailedActivityInformationForm {
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
            this.tbFullDescription = new System.Windows.Forms.TextBox();
            this.tbReasonOfNotDoing = new System.Windows.Forms.TextBox();
            this.tbPossibleSolution = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lCoreDescription = new System.Windows.Forms.Label();
            this.lCategory = new System.Windows.Forms.Label();
            this.lCommonDenominator = new System.Windows.Forms.Label();
            this.lFrequency = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbFullDescription
            // 
            this.tbFullDescription.Location = new System.Drawing.Point(12, 124);
            this.tbFullDescription.Multiline = true;
            this.tbFullDescription.Name = "tbFullDescription";
            this.tbFullDescription.Size = new System.Drawing.Size(388, 62);
            this.tbFullDescription.TabIndex = 0;
            this.tbFullDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EveryTextBox_KeyDown);
            // 
            // tbReasonOfNotDoing
            // 
            this.tbReasonOfNotDoing.Location = new System.Drawing.Point(12, 211);
            this.tbReasonOfNotDoing.Multiline = true;
            this.tbReasonOfNotDoing.Name = "tbReasonOfNotDoing";
            this.tbReasonOfNotDoing.Size = new System.Drawing.Size(388, 62);
            this.tbReasonOfNotDoing.TabIndex = 1;
            this.tbReasonOfNotDoing.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EveryTextBox_KeyDown);
            // 
            // tbPossibleSolution
            // 
            this.tbPossibleSolution.Location = new System.Drawing.Point(12, 298);
            this.tbPossibleSolution.Multiline = true;
            this.tbPossibleSolution.Name = "tbPossibleSolution";
            this.tbPossibleSolution.Size = new System.Drawing.Size(388, 62);
            this.tbPossibleSolution.TabIndex = 2;
            this.tbPossibleSolution.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EveryTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(21, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "full description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(21, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "reason of not doing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(21, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "possible solution";
            // 
            // lCoreDescription
            // 
            this.lCoreDescription.AutoSize = true;
            this.lCoreDescription.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lCoreDescription.Location = new System.Drawing.Point(21, 9);
            this.lCoreDescription.Name = "lCoreDescription";
            this.lCoreDescription.Size = new System.Drawing.Size(198, 19);
            this.lCoreDescription.TabIndex = 6;
            this.lCoreDescription.Text = "core description.....";
            // 
            // lCategory
            // 
            this.lCategory.AutoSize = true;
            this.lCategory.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lCategory.Location = new System.Drawing.Point(21, 47);
            this.lCategory.Name = "lCategory";
            this.lCategory.Size = new System.Drawing.Size(198, 19);
            this.lCategory.TabIndex = 7;
            this.lCategory.Text = "category.............";
            // 
            // lCommonDenominator
            // 
            this.lCommonDenominator.AutoSize = true;
            this.lCommonDenominator.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lCommonDenominator.Location = new System.Drawing.Point(21, 66);
            this.lCommonDenominator.Name = "lCommonDenominator";
            this.lCommonDenominator.Size = new System.Drawing.Size(198, 19);
            this.lCommonDenominator.TabIndex = 8;
            this.lCommonDenominator.Text = "common denominator...";
            // 
            // lFrequency
            // 
            this.lFrequency.AutoSize = true;
            this.lFrequency.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lFrequency.Location = new System.Drawing.Point(21, 28);
            this.lFrequency.Name = "lFrequency";
            this.lFrequency.Size = new System.Drawing.Size(198, 19);
            this.lFrequency.TabIndex = 9;
            this.lFrequency.Text = "current frequency....";
            // 
            // DetailedActivityInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 368);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DetailedActivityInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailedActivityInformationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DetailedActivityInformationForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFullDescription;
        private System.Windows.Forms.TextBox tbReasonOfNotDoing;
        private System.Windows.Forms.TextBox tbPossibleSolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lCoreDescription;
        private System.Windows.Forms.Label lCategory;
        private System.Windows.Forms.Label lCommonDenominator;
        private System.Windows.Forms.Label lFrequency;
    }
}