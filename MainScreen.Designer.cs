
namespace CalorieCalculator
{
    partial class MainScreen
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
            this.buttonAddFood = new System.Windows.Forms.Button();
            this.buttonWeekSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddFood
            // 
            this.buttonAddFood.Location = new System.Drawing.Point(309, 91);
            this.buttonAddFood.Name = "buttonAddFood";
            this.buttonAddFood.Size = new System.Drawing.Size(182, 36);
            this.buttonAddFood.TabIndex = 1;
            this.buttonAddFood.Text = "Add Food";
            this.buttonAddFood.UseVisualStyleBackColor = true;
            this.buttonAddFood.Click += new System.EventHandler(this.buttonAddFood_Click);
            // 
            // buttonWeekSum
            // 
            this.buttonWeekSum.Location = new System.Drawing.Point(309, 286);
            this.buttonWeekSum.Name = "buttonWeekSum";
            this.buttonWeekSum.Size = new System.Drawing.Size(182, 40);
            this.buttonWeekSum.TabIndex = 2;
            this.buttonWeekSum.Text = "Weekly Summary";
            this.buttonWeekSum.UseVisualStyleBackColor = true;
            this.buttonWeekSum.Click += new System.EventHandler(this.buttonWeekSum_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonWeekSum);
            this.Controls.Add(this.buttonAddFood);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddFood;
        private System.Windows.Forms.Button buttonWeekSum;
    }
}