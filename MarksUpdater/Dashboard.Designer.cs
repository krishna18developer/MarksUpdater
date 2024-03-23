namespace MarksUpdater
{
    partial class Dashboard
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
            this.presetComboBox = new System.Windows.Forms.ComboBox();
            this.presetLabel = new System.Windows.Forms.Label();
            this.rollNumberPrototypeLabel = new System.Windows.Forms.Label();
            this.rollNumberPrototypeBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // presetComboBox
            // 
            this.presetComboBox.FormattingEnabled = true;
            this.presetComboBox.Items.AddRange(new object[] {
            "Mid Exam 1",
            "Mid Exam 2",
            "Lab Internal",
            "Lab External",
            "Semester External"});
            this.presetComboBox.Location = new System.Drawing.Point(91, 32);
            this.presetComboBox.Name = "presetComboBox";
            this.presetComboBox.Size = new System.Drawing.Size(153, 21);
            this.presetComboBox.TabIndex = 0;
            // 
            // presetLabel
            // 
            this.presetLabel.AutoSize = true;
            this.presetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presetLabel.Location = new System.Drawing.Point(12, 29);
            this.presetLabel.Name = "presetLabel";
            this.presetLabel.Size = new System.Drawing.Size(73, 24);
            this.presetLabel.TabIndex = 1;
            this.presetLabel.Text = "Preset :";
            // 
            // rollNumberPrototypeLabel
            // 
            this.rollNumberPrototypeLabel.AutoSize = true;
            this.rollNumberPrototypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollNumberPrototypeLabel.Location = new System.Drawing.Point(264, 29);
            this.rollNumberPrototypeLabel.Name = "rollNumberPrototypeLabel";
            this.rollNumberPrototypeLabel.Size = new System.Drawing.Size(210, 24);
            this.rollNumberPrototypeLabel.TabIndex = 2;
            this.rollNumberPrototypeLabel.Text = "Roll Number Prototype :";
            // 
            // rollNumberPrototypeBox
            // 
            this.rollNumberPrototypeBox.Location = new System.Drawing.Point(480, 32);
            this.rollNumberPrototypeBox.Name = "rollNumberPrototypeBox";
            this.rollNumberPrototypeBox.Size = new System.Drawing.Size(212, 20);
            this.rollNumberPrototypeBox.TabIndex = 3;
            this.rollNumberPrototypeBox.Text = "23EG";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(721, 29);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(106, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 84);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.rollNumberPrototypeBox);
            this.Controls.Add(this.rollNumberPrototypeLabel);
            this.Controls.Add(this.presetLabel);
            this.Controls.Add(this.presetComboBox);
            this.Name = "Dashboard";
            this.Text = "Marks Updater";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox presetComboBox;
        private System.Windows.Forms.Label presetLabel;
        private System.Windows.Forms.Label rollNumberPrototypeLabel;
        private System.Windows.Forms.TextBox rollNumberPrototypeBox;
        private System.Windows.Forms.Button startButton;
    }
}

