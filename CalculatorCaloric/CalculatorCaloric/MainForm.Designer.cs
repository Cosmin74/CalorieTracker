namespace CalculatorCaloric
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonLoseWeight = new System.Windows.Forms.RadioButton();
            this.radioButtonGainWeight = new System.Windows.Forms.RadioButton();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonAddMeal = new System.Windows.Forms.Button();
            this.textBoxMealsList = new System.Windows.Forms.TextBox();
            this.buttonShowProgress = new System.Windows.Forms.Button();
            this.groupBoxAddMeal = new System.Windows.Forms.GroupBox();
            this.comboBoxMealType = new System.Windows.Forms.ComboBox();
            this.labelMealType = new System.Windows.Forms.Label();
            this.labelCaloriesCount = new System.Windows.Forms.Label();
            this.textBoxAddCalories = new System.Windows.Forms.TextBox();
            this.groupBoxProgress = new System.Windows.Forms.GroupBox();
            this.labelDayCalories = new System.Windows.Forms.Label();
            this.textBoxDayCalories = new System.Windows.Forms.TextBox();
            this.textBoxCaloriesToTarget = new System.Windows.Forms.TextBox();
            this.labelCaloriesToTarget = new System.Windows.Forms.Label();
            this.groupBoxCalorieCount = new System.Windows.Forms.GroupBox();
            this.textBoxTargetCalories = new System.Windows.Forms.TextBox();
            this.labelTargetCalories = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddDayButon = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxResults.SuspendLayout();
            this.groupBoxAddMeal.SuspendLayout();
            this.groupBoxProgress.SuspendLayout();
            this.groupBoxCalorieCount.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonLoseWeight
            // 
            this.radioButtonLoseWeight.AutoSize = true;
            this.radioButtonLoseWeight.Checked = true;
            this.radioButtonLoseWeight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonLoseWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLoseWeight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonLoseWeight.Location = new System.Drawing.Point(43, 38);
            this.radioButtonLoseWeight.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonLoseWeight.Name = "radioButtonLoseWeight";
            this.radioButtonLoseWeight.Size = new System.Drawing.Size(142, 21);
            this.radioButtonLoseWeight.TabIndex = 0;
            this.radioButtonLoseWeight.TabStop = true;
            this.radioButtonLoseWeight.Text = "Pierde greutate";
            this.radioButtonLoseWeight.UseVisualStyleBackColor = true;
            // 
            // radioButtonGainWeight
            // 
            this.radioButtonGainWeight.AutoSize = true;
            this.radioButtonGainWeight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonGainWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGainWeight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonGainWeight.Location = new System.Drawing.Point(193, 39);
            this.radioButtonGainWeight.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonGainWeight.Name = "radioButtonGainWeight";
            this.radioButtonGainWeight.Size = new System.Drawing.Size(160, 21);
            this.radioButtonGainWeight.TabIndex = 1;
            this.radioButtonGainWeight.Text = "Crește în greutate";
            this.radioButtonGainWeight.UseVisualStyleBackColor = true;
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Controls.Add(this.buttonCalculate);
            this.groupBoxResults.Controls.Add(this.textBoxResult);
            this.groupBoxResults.Controls.Add(this.radioButtonGainWeight);
            this.groupBoxResults.Controls.Add(this.radioButtonLoseWeight);
            this.groupBoxResults.Location = new System.Drawing.Point(27, 31);
            this.groupBoxResults.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxResults.Size = new System.Drawing.Size(365, 462);
            this.groupBoxResults.TabIndex = 2;
            this.groupBoxResults.TabStop = false;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalculate.ForeColor = System.Drawing.Color.Blue;
            this.buttonCalculate.Location = new System.Drawing.Point(88, 107);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(201, 31);
            this.buttonCalculate.TabIndex = 13;
            this.buttonCalculate.Text = "Calculează";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxResult.ForeColor = System.Drawing.Color.Blue;
            this.textBoxResult.Location = new System.Drawing.Point(43, 160);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(292, 276);
            this.textBoxResult.TabIndex = 2;
            // 
            // buttonAddMeal
            // 
            this.buttonAddMeal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonAddMeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddMeal.ForeColor = System.Drawing.Color.Blue;
            this.buttonAddMeal.Location = new System.Drawing.Point(101, 107);
            this.buttonAddMeal.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddMeal.Name = "buttonAddMeal";
            this.buttonAddMeal.Size = new System.Drawing.Size(143, 31);
            this.buttonAddMeal.TabIndex = 3;
            this.buttonAddMeal.Text = "Adaugă masă";
            this.buttonAddMeal.UseVisualStyleBackColor = false;
            this.buttonAddMeal.Click += new System.EventHandler(this.buttonAddMeal_Click);
            // 
            // textBoxMealsList
            // 
            this.textBoxMealsList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxMealsList.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxMealsList.ForeColor = System.Drawing.Color.Blue;
            this.textBoxMealsList.Location = new System.Drawing.Point(27, 160);
            this.textBoxMealsList.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMealsList.Multiline = true;
            this.textBoxMealsList.Name = "textBoxMealsList";
            this.textBoxMealsList.ReadOnly = true;
            this.textBoxMealsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMealsList.Size = new System.Drawing.Size(283, 276);
            this.textBoxMealsList.TabIndex = 4;
            // 
            // buttonShowProgress
            // 
            this.buttonShowProgress.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonShowProgress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowProgress.ForeColor = System.Drawing.Color.Blue;
            this.buttonShowProgress.Location = new System.Drawing.Point(33, 11);
            this.buttonShowProgress.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowProgress.Name = "buttonShowProgress";
            this.buttonShowProgress.Size = new System.Drawing.Size(209, 53);
            this.buttonShowProgress.TabIndex = 5;
            this.buttonShowProgress.Text = "Vezi progres";
            this.buttonShowProgress.UseVisualStyleBackColor = false;
            this.buttonShowProgress.Click += new System.EventHandler(this.buttonShowProgress_Click);
            // 
            // groupBoxAddMeal
            // 
            this.groupBoxAddMeal.Controls.Add(this.comboBoxMealType);
            this.groupBoxAddMeal.Controls.Add(this.labelMealType);
            this.groupBoxAddMeal.Controls.Add(this.labelCaloriesCount);
            this.groupBoxAddMeal.Controls.Add(this.textBoxAddCalories);
            this.groupBoxAddMeal.Controls.Add(this.textBoxMealsList);
            this.groupBoxAddMeal.Controls.Add(this.buttonAddMeal);
            this.groupBoxAddMeal.Location = new System.Drawing.Point(413, 31);
            this.groupBoxAddMeal.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAddMeal.Name = "groupBoxAddMeal";
            this.groupBoxAddMeal.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAddMeal.Size = new System.Drawing.Size(337, 462);
            this.groupBoxAddMeal.TabIndex = 6;
            this.groupBoxAddMeal.TabStop = false;
            // 
            // comboBoxMealType
            // 
            this.comboBoxMealType.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBoxMealType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxMealType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMealType.ForeColor = System.Drawing.Color.Blue;
            this.comboBoxMealType.FormattingEnabled = true;
            this.comboBoxMealType.Items.AddRange(new object[] {
            "Mic dejun",
            "Prânz",
            "Cină",
            "Gustare"});
            this.comboBoxMealType.Location = new System.Drawing.Point(123, 33);
            this.comboBoxMealType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMealType.Name = "comboBoxMealType";
            this.comboBoxMealType.Size = new System.Drawing.Size(176, 24);
            this.comboBoxMealType.TabIndex = 14;
            this.comboBoxMealType.SelectedIndexChanged += new System.EventHandler(this.comboBoxMealType_SelectedIndexChanged);
            // 
            // labelMealType
            // 
            this.labelMealType.AutoSize = true;
            this.labelMealType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMealType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMealType.Location = new System.Drawing.Point(44, 38);
            this.labelMealType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMealType.Name = "labelMealType";
            this.labelMealType.Size = new System.Drawing.Size(79, 17);
            this.labelMealType.TabIndex = 13;
            this.labelMealType.Text = "Tip masă:";
            // 
            // labelCaloriesCount
            // 
            this.labelCaloriesCount.AutoSize = true;
            this.labelCaloriesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaloriesCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCaloriesCount.Location = new System.Drawing.Point(24, 74);
            this.labelCaloriesCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCaloriesCount.Name = "labelCaloriesCount";
            this.labelCaloriesCount.Size = new System.Drawing.Size(150, 17);
            this.labelCaloriesCount.TabIndex = 12;
            this.labelCaloriesCount.Text = "Calorii ultima masă:";
            // 
            // textBoxAddCalories
            // 
            this.textBoxAddCalories.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxAddCalories.ForeColor = System.Drawing.Color.Blue;
            this.textBoxAddCalories.Location = new System.Drawing.Point(180, 71);
            this.textBoxAddCalories.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddCalories.Name = "textBoxAddCalories";
            this.textBoxAddCalories.Size = new System.Drawing.Size(119, 22);
            this.textBoxAddCalories.TabIndex = 12;
            this.textBoxAddCalories.TextChanged += new System.EventHandler(this.textBoxAddCalories_TextChanged);
            // 
            // groupBoxProgress
            // 
            this.groupBoxProgress.Controls.Add(this.buttonShowProgress);
            this.groupBoxProgress.Location = new System.Drawing.Point(773, 263);
            this.groupBoxProgress.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxProgress.Name = "groupBoxProgress";
            this.groupBoxProgress.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxProgress.Size = new System.Drawing.Size(281, 72);
            this.groupBoxProgress.TabIndex = 7;
            this.groupBoxProgress.TabStop = false;
            // 
            // labelDayCalories
            // 
            this.labelDayCalories.AutoSize = true;
            this.labelDayCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDayCalories.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDayCalories.Location = new System.Drawing.Point(8, 42);
            this.labelDayCalories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDayCalories.Name = "labelDayCalories";
            this.labelDayCalories.Size = new System.Drawing.Size(125, 17);
            this.labelDayCalories.TabIndex = 8;
            this.labelDayCalories.Text = "Total calorii azi:";
            // 
            // textBoxDayCalories
            // 
            this.textBoxDayCalories.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxDayCalories.ForeColor = System.Drawing.Color.Blue;
            this.textBoxDayCalories.Location = new System.Drawing.Point(129, 39);
            this.textBoxDayCalories.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDayCalories.Name = "textBoxDayCalories";
            this.textBoxDayCalories.ReadOnly = true;
            this.textBoxDayCalories.Size = new System.Drawing.Size(152, 22);
            this.textBoxDayCalories.TabIndex = 9;
            this.textBoxDayCalories.Text = "0";
            // 
            // textBoxCaloriesToTarget
            // 
            this.textBoxCaloriesToTarget.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxCaloriesToTarget.ForeColor = System.Drawing.Color.Blue;
            this.textBoxCaloriesToTarget.Location = new System.Drawing.Point(168, 132);
            this.textBoxCaloriesToTarget.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCaloriesToTarget.Name = "textBoxCaloriesToTarget";
            this.textBoxCaloriesToTarget.ReadOnly = true;
            this.textBoxCaloriesToTarget.Size = new System.Drawing.Size(105, 22);
            this.textBoxCaloriesToTarget.TabIndex = 11;
            // 
            // labelCaloriesToTarget
            // 
            this.labelCaloriesToTarget.AutoSize = true;
            this.labelCaloriesToTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaloriesToTarget.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCaloriesToTarget.Location = new System.Drawing.Point(8, 135);
            this.labelCaloriesToTarget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCaloriesToTarget.Name = "labelCaloriesToTarget";
            this.labelCaloriesToTarget.Size = new System.Drawing.Size(166, 17);
            this.labelCaloriesToTarget.TabIndex = 10;
            this.labelCaloriesToTarget.Text = "Calorii până la target:";
            // 
            // groupBoxCalorieCount
            // 
            this.groupBoxCalorieCount.Controls.Add(this.textBoxTargetCalories);
            this.groupBoxCalorieCount.Controls.Add(this.labelTargetCalories);
            this.groupBoxCalorieCount.Controls.Add(this.textBoxCaloriesToTarget);
            this.groupBoxCalorieCount.Controls.Add(this.labelCaloriesToTarget);
            this.groupBoxCalorieCount.Controls.Add(this.textBoxDayCalories);
            this.groupBoxCalorieCount.Controls.Add(this.labelDayCalories);
            this.groupBoxCalorieCount.Location = new System.Drawing.Point(773, 31);
            this.groupBoxCalorieCount.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCalorieCount.Name = "groupBoxCalorieCount";
            this.groupBoxCalorieCount.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCalorieCount.Size = new System.Drawing.Size(281, 225);
            this.groupBoxCalorieCount.TabIndex = 12;
            this.groupBoxCalorieCount.TabStop = false;
            // 
            // textBoxTargetCalories
            // 
            this.textBoxTargetCalories.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxTargetCalories.ForeColor = System.Drawing.Color.Blue;
            this.textBoxTargetCalories.Location = new System.Drawing.Point(71, 87);
            this.textBoxTargetCalories.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTargetCalories.Name = "textBoxTargetCalories";
            this.textBoxTargetCalories.Size = new System.Drawing.Size(152, 22);
            this.textBoxTargetCalories.TabIndex = 13;
            this.textBoxTargetCalories.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxTargetCalories_KeyUp);
            // 
            // labelTargetCalories
            // 
            this.labelTargetCalories.AutoSize = true;
            this.labelTargetCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTargetCalories.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTargetCalories.Location = new System.Drawing.Point(8, 91);
            this.labelTargetCalories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTargetCalories.Name = "labelTargetCalories";
            this.labelTargetCalories.Size = new System.Drawing.Size(61, 17);
            this.labelTargetCalories.TabIndex = 12;
            this.labelTargetCalories.Text = "Target:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddDayButon);
            this.groupBox1.Location = new System.Drawing.Point(773, 356);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(281, 73);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // AddDayButon
            // 
            this.AddDayButon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AddDayButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddDayButon.ForeColor = System.Drawing.Color.Blue;
            this.AddDayButon.Location = new System.Drawing.Point(33, 23);
            this.AddDayButon.Margin = new System.Windows.Forms.Padding(4);
            this.AddDayButon.Name = "AddDayButon";
            this.AddDayButon.Size = new System.Drawing.Size(209, 42);
            this.AddDayButon.TabIndex = 5;
            this.AddDayButon.Text = "Adaugă zi";
            this.AddDayButon.UseVisualStyleBackColor = false;
            this.AddDayButon.Click += new System.EventHandler(this.AddDayButon_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(773, 437);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(281, 64);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(33, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Adaugă target";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1087, 507);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxCalorieCount);
            this.Controls.Add(this.groupBoxProgress);
            this.Controls.Add(this.groupBoxAddMeal);
            this.Controls.Add(this.groupBoxResults);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "App";
            this.groupBoxResults.ResumeLayout(false);
            this.groupBoxResults.PerformLayout();
            this.groupBoxAddMeal.ResumeLayout(false);
            this.groupBoxAddMeal.PerformLayout();
            this.groupBoxProgress.ResumeLayout(false);
            this.groupBoxCalorieCount.ResumeLayout(false);
            this.groupBoxCalorieCount.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonLoseWeight;
        private System.Windows.Forms.RadioButton radioButtonGainWeight;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonAddMeal;
        private System.Windows.Forms.TextBox textBoxMealsList;
        private System.Windows.Forms.Button buttonShowProgress;
        private System.Windows.Forms.GroupBox groupBoxAddMeal;
        private System.Windows.Forms.GroupBox groupBoxProgress;
        private System.Windows.Forms.Label labelDayCalories;
        private System.Windows.Forms.TextBox textBoxDayCalories;
        private System.Windows.Forms.TextBox textBoxCaloriesToTarget;
        private System.Windows.Forms.Label labelCaloriesToTarget;
        private System.Windows.Forms.GroupBox groupBoxCalorieCount;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxAddCalories;
        private System.Windows.Forms.Label labelCaloriesCount;
        private System.Windows.Forms.ComboBox comboBoxMealType;
        private System.Windows.Forms.Label labelMealType;
        private System.Windows.Forms.Label labelTargetCalories;
        private System.Windows.Forms.TextBox textBoxTargetCalories;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddDayButon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}

