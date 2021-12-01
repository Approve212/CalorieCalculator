
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelProtein = new System.Windows.Forms.Label();
            this.labelCarb = new System.Windows.Forms.Label();
            this.labelFat = new System.Windows.Forms.Label();
            this.textBoxProtein = new System.Windows.Forms.TextBox();
            this.textBoxCarb = new System.Windows.Forms.TextBox();
            this.textBoxFat = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelProtein
            // 
            this.labelProtein.AutoSize = true;
            this.labelProtein.Location = new System.Drawing.Point(214, 113);
            this.labelProtein.Name = "labelProtein";
            this.labelProtein.Size = new System.Drawing.Size(56, 20);
            this.labelProtein.TabIndex = 2;
            this.labelProtein.Text = "Protein";
            // 
            // labelCarb
            // 
            this.labelCarb.AutoSize = true;
            this.labelCarb.Location = new System.Drawing.Point(370, 113);
            this.labelCarb.Name = "labelCarb";
            this.labelCarb.Size = new System.Drawing.Size(40, 20);
            this.labelCarb.TabIndex = 3;
            this.labelCarb.Text = "Carb";
            // 
            // labelFat
            // 
            this.labelFat.AutoSize = true;
            this.labelFat.Location = new System.Drawing.Point(531, 113);
            this.labelFat.Name = "labelFat";
            this.labelFat.Size = new System.Drawing.Size(28, 20);
            this.labelFat.TabIndex = 4;
            this.labelFat.Text = "Fat";
            // 
            // textBoxProtein
            // 
            this.textBoxProtein.Location = new System.Drawing.Point(202, 144);
            this.textBoxProtein.Name = "textBoxProtein";
            this.textBoxProtein.Size = new System.Drawing.Size(81, 27);
            this.textBoxProtein.TabIndex = 6;
            // 
            // textBoxCarb
            // 
            this.textBoxCarb.Location = new System.Drawing.Point(349, 144);
            this.textBoxCarb.Name = "textBoxCarb";
            this.textBoxCarb.Size = new System.Drawing.Size(81, 27);
            this.textBoxCarb.TabIndex = 7;
            // 
            // textBoxFat
            // 
            this.textBoxFat.Location = new System.Drawing.Point(502, 144);
            this.textBoxFat.Name = "textBoxFat";
            this.textBoxFat.Size = new System.Drawing.Size(81, 27);
            this.textBoxFat.TabIndex = 8;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotal.Location = new System.Drawing.Point(322, 357);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(132, 28);
            this.labelTotal.TabIndex = 9;
            this.labelTotal.Text = "Total Calories:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.textBoxFat);
            this.Controls.Add(this.textBoxCarb);
            this.Controls.Add(this.textBoxProtein);
            this.Controls.Add(this.labelFat);
            this.Controls.Add(this.labelCarb);
            this.Controls.Add(this.labelProtein);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTotal;
    }
}

