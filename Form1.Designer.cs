
namespace CalorieCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCalc = new System.Windows.Forms.Button();
            this.labelProtein = new System.Windows.Forms.Label();
            this.labelCarb = new System.Windows.Forms.Label();
            this.labelFat = new System.Windows.Forms.Label();
            this.textBoxProtein = new System.Windows.Forms.TextBox();
            this.textBoxCarb = new System.Windows.Forms.TextBox();
            this.textBoxFat = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelServ = new System.Windows.Forms.Label();
            this.textBoxServ = new System.Windows.Forms.TextBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.dateTimePickerDay = new System.Windows.Forms.DateTimePicker();
            this.labelCalc = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(312, 250);
            this.buttonCalc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(82, 22);
            this.buttonCalc.TabIndex = 0;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // labelProtein
            // 
            this.labelProtein.AutoSize = true;
            this.labelProtein.Location = new System.Drawing.Point(385, 85);
            this.labelProtein.Name = "labelProtein";
            this.labelProtein.Size = new System.Drawing.Size(45, 15);
            this.labelProtein.TabIndex = 2;
            this.labelProtein.Text = "Protein";
            // 
            // labelCarb
            // 
            this.labelCarb.AutoSize = true;
            this.labelCarb.Location = new System.Drawing.Point(385, 122);
            this.labelCarb.Name = "labelCarb";
            this.labelCarb.Size = new System.Drawing.Size(32, 15);
            this.labelCarb.TabIndex = 3;
            this.labelCarb.Text = "Carb";
            // 
            // labelFat
            // 
            this.labelFat.AutoSize = true;
            this.labelFat.Location = new System.Drawing.Point(385, 158);
            this.labelFat.Name = "labelFat";
            this.labelFat.Size = new System.Drawing.Size(23, 15);
            this.labelFat.TabIndex = 4;
            this.labelFat.Text = "Fat";
            // 
            // textBoxProtein
            // 
            this.textBoxProtein.Location = new System.Drawing.Point(439, 80);
            this.textBoxProtein.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxProtein.Name = "textBoxProtein";
            this.textBoxProtein.Size = new System.Drawing.Size(71, 23);
            this.textBoxProtein.TabIndex = 6;
            // 
            // textBoxCarb
            // 
            this.textBoxCarb.Location = new System.Drawing.Point(439, 119);
            this.textBoxCarb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCarb.Name = "textBoxCarb";
            this.textBoxCarb.Size = new System.Drawing.Size(71, 23);
            this.textBoxCarb.TabIndex = 7;
            // 
            // textBoxFat
            // 
            this.textBoxFat.Location = new System.Drawing.Point(439, 158);
            this.textBoxFat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFat.Name = "textBoxFat";
            this.textBoxFat.Size = new System.Drawing.Size(71, 23);
            this.textBoxFat.TabIndex = 8;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Vegetable",
            "Fruit",
            "Grains",
            "Nuts",
            "Dairy",
            "Meat",
            "Fish",
            "Junk",
            "Other"});
            this.comboBoxType.Location = new System.Drawing.Point(158, 80);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 23);
            this.comboBoxType.TabIndex = 10;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(98, 85);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 15);
            this.labelType.TabIndex = 11;
            this.labelType.Text = "Type";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(158, 119);
            this.textName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(71, 23);
            this.textName.TabIndex = 12;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(98, 122);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 15);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Name";
            // 
            // labelServ
            // 
            this.labelServ.AutoSize = true;
            this.labelServ.Location = new System.Drawing.Point(98, 158);
            this.labelServ.Name = "labelServ";
            this.labelServ.Size = new System.Drawing.Size(51, 15);
            this.labelServ.TabIndex = 14;
            this.labelServ.Text = "Servings";
            // 
            // textBoxServ
            // 
            this.textBoxServ.Location = new System.Drawing.Point(158, 158);
            this.textBoxServ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxServ.Name = "textBoxServ";
            this.textBoxServ.Size = new System.Drawing.Size(71, 23);
            this.textBoxServ.TabIndex = 15;
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(102, 198);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(27, 15);
            this.labelDay.TabIndex = 16;
            this.labelDay.Text = "Day";
            // 
            // dateTimePickerDay
            // 
            this.dateTimePickerDay.Location = new System.Drawing.Point(158, 198);
            this.dateTimePickerDay.Name = "dateTimePickerDay";
            this.dateTimePickerDay.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerDay.TabIndex = 17;
            // 
            // labelCalc
            // 
            this.labelCalc.AutoSize = true;
            this.labelCalc.Location = new System.Drawing.Point(261, 296);
            this.labelCalc.Name = "labelCalc";
            this.labelCalc.Size = new System.Drawing.Size(0, 15);
            this.labelCalc.TabIndex = 18;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(546, 283);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(104, 23);
            this.buttonClose.TabIndex = 19;
            this.buttonClose.Text = "Close Window";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelCalc);
            this.Controls.Add(this.dateTimePickerDay);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.textBoxServ);
            this.Controls.Add(this.labelServ);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxFat);
            this.Controls.Add(this.textBoxCarb);
            this.Controls.Add(this.textBoxProtein);
            this.Controls.Add(this.labelFat);
            this.Controls.Add(this.labelCarb);
            this.Controls.Add(this.labelProtein);
            this.Controls.Add(this.buttonCalc);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelProtein;
        private System.Windows.Forms.Label labelCarb;
        private System.Windows.Forms.Label labelFat;
        private System.Windows.Forms.TextBox textBoxProtein;
        private System.Windows.Forms.TextBox textBoxCarb;
        private System.Windows.Forms.TextBox textBoxFat;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelServ;
        private System.Windows.Forms.TextBox textBoxServ;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.DateTimePicker dateTimePickerDay;
        private System.Windows.Forms.Label labelCalc;
        private System.Windows.Forms.Button buttonClose;
    }
}

