namespace Activity_7
{
    partial class ApproxPiForm
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
            this.iterationInputControl = new System.Windows.Forms.NumericUpDown();
            this.iterationLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.answerBox = new System.Windows.Forms.GroupBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iterationInputControl)).BeginInit();
            this.answerBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // iterationInputControl
            // 
            this.iterationInputControl.Location = new System.Drawing.Point(220, 12);
            this.iterationInputControl.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.iterationInputControl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iterationInputControl.Name = "iterationInputControl";
            this.iterationInputControl.Size = new System.Drawing.Size(120, 23);
            this.iterationInputControl.TabIndex = 0;
            this.iterationInputControl.ThousandsSeparator = true;
            this.iterationInputControl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // iterationLabel
            // 
            this.iterationLabel.AutoSize = true;
            this.iterationLabel.Location = new System.Drawing.Point(92, 14);
            this.iterationLabel.Name = "iterationLabel";
            this.iterationLabel.Size = new System.Drawing.Size(122, 15);
            this.iterationLabel.TabIndex = 1;
            this.iterationLabel.Text = "How many iterations?";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(220, 41);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(120, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate Approx Pi";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // answerBox
            // 
            this.answerBox.Controls.Add(this.answerTextBox);
            this.answerBox.Location = new System.Drawing.Point(12, 70);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(328, 100);
            this.answerBox.TabIndex = 3;
            this.answerBox.TabStop = false;
            this.answerBox.Text = "Approx Pi After ____ Iterations";
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerTextBox.Location = new System.Drawing.Point(6, 45);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(316, 30);
            this.answerTextBox.TabIndex = 0;
            this.answerTextBox.Text = "=";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(139, 176);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ApproxPiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 223);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.iterationLabel);
            this.Controls.Add(this.iterationInputControl);
            this.Name = "ApproxPiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Approximate Pi";
            ((System.ComponentModel.ISupportInitialize)(this.iterationInputControl)).EndInit();
            this.answerBox.ResumeLayout(false);
            this.answerBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown iterationInputControl;
        private Label iterationLabel;
        private Button calculateButton;
        private GroupBox answerBox;
        private TextBox answerTextBox;
        private Button exitButton;
    }
}