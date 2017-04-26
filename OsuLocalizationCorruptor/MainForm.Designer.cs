namespace OsuLocalizationCorruptor
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
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.wordMessActivate = new System.Windows.Forms.CheckBox();
            this.wordMessGroupBox = new System.Windows.Forms.GroupBox();
            this.wordMessLabelTries = new System.Windows.Forms.Label();
            this.wordMessTextBoxTries = new System.Windows.Forms.TextBox();
            this.wordMessLabelPercent = new System.Windows.Forms.Label();
            this.wordMessTextBoxPercent = new System.Windows.Forms.TextBox();
            this.shuffleGroupBox = new System.Windows.Forms.GroupBox();
            this.ShuffleLabelPercent = new System.Windows.Forms.Label();
            this.shuffleTextBoxPercent = new System.Windows.Forms.TextBox();
            this.shuffleActivate = new System.Windows.Forms.CheckBox();
            this.startButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileLabel = new System.Windows.Forms.Label();
            this.replaceGroupBox = new System.Windows.Forms.GroupBox();
            this.replaceLabel = new System.Windows.Forms.Label();
            this.replaceTextBox = new System.Windows.Forms.TextBox();
            this.replaceActivateCheckBox = new System.Windows.Forms.CheckBox();
            this.wordMessGroupBox.SuspendLayout();
            this.shuffleGroupBox.SuspendLayout();
            this.replaceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(12, 25);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(425, 20);
            this.fileTextBox.TabIndex = 0;
            this.fileTextBox.Click += new System.EventHandler(this.fileTextBox_Click);
            // 
            // wordMessActivate
            // 
            this.wordMessActivate.AutoSize = true;
            this.wordMessActivate.Location = new System.Drawing.Point(6, 19);
            this.wordMessActivate.Name = "wordMessActivate";
            this.wordMessActivate.Size = new System.Drawing.Size(65, 17);
            this.wordMessActivate.TabIndex = 1;
            this.wordMessActivate.Text = "Activate";
            this.wordMessActivate.UseVisualStyleBackColor = true;
            // 
            // wordMessGroupBox
            // 
            this.wordMessGroupBox.Controls.Add(this.wordMessLabelTries);
            this.wordMessGroupBox.Controls.Add(this.wordMessTextBoxTries);
            this.wordMessGroupBox.Controls.Add(this.wordMessLabelPercent);
            this.wordMessGroupBox.Controls.Add(this.wordMessTextBoxPercent);
            this.wordMessGroupBox.Controls.Add(this.wordMessActivate);
            this.wordMessGroupBox.Location = new System.Drawing.Point(12, 70);
            this.wordMessGroupBox.Name = "wordMessGroupBox";
            this.wordMessGroupBox.Size = new System.Drawing.Size(200, 172);
            this.wordMessGroupBox.TabIndex = 3;
            this.wordMessGroupBox.TabStop = false;
            this.wordMessGroupBox.Text = "WordMessEngine";
            // 
            // wordMessLabelTries
            // 
            this.wordMessLabelTries.AutoSize = true;
            this.wordMessLabelTries.Location = new System.Drawing.Point(6, 122);
            this.wordMessLabelTries.Name = "wordMessLabelTries";
            this.wordMessLabelTries.Size = new System.Drawing.Size(33, 13);
            this.wordMessLabelTries.TabIndex = 5;
            this.wordMessLabelTries.Text = "Tries:";
            // 
            // wordMessTextBoxTries
            // 
            this.wordMessTextBoxTries.Location = new System.Drawing.Point(6, 138);
            this.wordMessTextBoxTries.Name = "wordMessTextBoxTries";
            this.wordMessTextBoxTries.Size = new System.Drawing.Size(188, 20);
            this.wordMessTextBoxTries.TabIndex = 4;
            this.wordMessTextBoxTries.Text = "3";
            // 
            // wordMessLabelPercent
            // 
            this.wordMessLabelPercent.AutoSize = true;
            this.wordMessLabelPercent.Location = new System.Drawing.Point(6, 54);
            this.wordMessLabelPercent.Name = "wordMessLabelPercent";
            this.wordMessLabelPercent.Size = new System.Drawing.Size(47, 13);
            this.wordMessLabelPercent.TabIndex = 3;
            this.wordMessLabelPercent.Text = "Percent:";
            // 
            // wordMessTextBoxPercent
            // 
            this.wordMessTextBoxPercent.Location = new System.Drawing.Point(6, 70);
            this.wordMessTextBoxPercent.Name = "wordMessTextBoxPercent";
            this.wordMessTextBoxPercent.Size = new System.Drawing.Size(188, 20);
            this.wordMessTextBoxPercent.TabIndex = 2;
            this.wordMessTextBoxPercent.Text = "100";
            // 
            // shuffleGroupBox
            // 
            this.shuffleGroupBox.Controls.Add(this.ShuffleLabelPercent);
            this.shuffleGroupBox.Controls.Add(this.shuffleTextBoxPercent);
            this.shuffleGroupBox.Controls.Add(this.shuffleActivate);
            this.shuffleGroupBox.Location = new System.Drawing.Point(237, 70);
            this.shuffleGroupBox.Name = "shuffleGroupBox";
            this.shuffleGroupBox.Size = new System.Drawing.Size(200, 99);
            this.shuffleGroupBox.TabIndex = 4;
            this.shuffleGroupBox.TabStop = false;
            this.shuffleGroupBox.Text = "ShuffleEngine";
            // 
            // ShuffleLabelPercent
            // 
            this.ShuffleLabelPercent.AutoSize = true;
            this.ShuffleLabelPercent.Location = new System.Drawing.Point(6, 54);
            this.ShuffleLabelPercent.Name = "ShuffleLabelPercent";
            this.ShuffleLabelPercent.Size = new System.Drawing.Size(47, 13);
            this.ShuffleLabelPercent.TabIndex = 5;
            this.ShuffleLabelPercent.Text = "Percent:";
            // 
            // shuffleTextBoxPercent
            // 
            this.shuffleTextBoxPercent.Location = new System.Drawing.Point(6, 70);
            this.shuffleTextBoxPercent.Name = "shuffleTextBoxPercent";
            this.shuffleTextBoxPercent.Size = new System.Drawing.Size(188, 20);
            this.shuffleTextBoxPercent.TabIndex = 4;
            this.shuffleTextBoxPercent.Text = "100";
            // 
            // shuffleActivate
            // 
            this.shuffleActivate.AutoSize = true;
            this.shuffleActivate.Location = new System.Drawing.Point(6, 19);
            this.shuffleActivate.Name = "shuffleActivate";
            this.shuffleActivate.Size = new System.Drawing.Size(65, 17);
            this.shuffleActivate.TabIndex = 1;
            this.shuffleActivate.Text = "Activate";
            this.shuffleActivate.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(190, 327);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "GO";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "osu! Localisation File|*.txt";
            this.openFileDialog1.InitialDirectory = "%localappdata%";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Choose a Localisation File (in osu!/Localisation)";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(9, 9);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(26, 13);
            this.fileLabel.TabIndex = 6;
            this.fileLabel.Text = "File:";
            // 
            // replaceGroupBox
            // 
            this.replaceGroupBox.Controls.Add(this.replaceLabel);
            this.replaceGroupBox.Controls.Add(this.replaceTextBox);
            this.replaceGroupBox.Controls.Add(this.replaceActivateCheckBox);
            this.replaceGroupBox.Location = new System.Drawing.Point(237, 175);
            this.replaceGroupBox.Name = "replaceGroupBox";
            this.replaceGroupBox.Size = new System.Drawing.Size(200, 99);
            this.replaceGroupBox.TabIndex = 6;
            this.replaceGroupBox.TabStop = false;
            this.replaceGroupBox.Text = "ReplaceEngine";
            // 
            // replaceLabel
            // 
            this.replaceLabel.AutoSize = true;
            this.replaceLabel.Location = new System.Drawing.Point(6, 54);
            this.replaceLabel.Name = "replaceLabel";
            this.replaceLabel.Size = new System.Drawing.Size(31, 13);
            this.replaceLabel.TabIndex = 5;
            this.replaceLabel.Text = "Text:";
            // 
            // replaceTextBox
            // 
            this.replaceTextBox.Location = new System.Drawing.Point(6, 70);
            this.replaceTextBox.Name = "replaceTextBox";
            this.replaceTextBox.Size = new System.Drawing.Size(188, 20);
            this.replaceTextBox.TabIndex = 4;
            // 
            // replaceActivateCheckBox
            // 
            this.replaceActivateCheckBox.AutoSize = true;
            this.replaceActivateCheckBox.Location = new System.Drawing.Point(6, 19);
            this.replaceActivateCheckBox.Name = "replaceActivateCheckBox";
            this.replaceActivateCheckBox.Size = new System.Drawing.Size(65, 17);
            this.replaceActivateCheckBox.TabIndex = 1;
            this.replaceActivateCheckBox.Text = "Activate";
            this.replaceActivateCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AcceptButton = this.startButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 362);
            this.Controls.Add(this.replaceGroupBox);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.shuffleGroupBox);
            this.Controls.Add(this.wordMessGroupBox);
            this.Controls.Add(this.fileTextBox);
            this.Name = "MainForm";
            this.Text = "OsuLocalisationCorruptor";
            this.wordMessGroupBox.ResumeLayout(false);
            this.wordMessGroupBox.PerformLayout();
            this.shuffleGroupBox.ResumeLayout(false);
            this.shuffleGroupBox.PerformLayout();
            this.replaceGroupBox.ResumeLayout(false);
            this.replaceGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.CheckBox wordMessActivate;
        private System.Windows.Forms.GroupBox wordMessGroupBox;
        private System.Windows.Forms.Label wordMessLabelTries;
        private System.Windows.Forms.TextBox wordMessTextBoxTries;
        private System.Windows.Forms.Label wordMessLabelPercent;
        private System.Windows.Forms.TextBox wordMessTextBoxPercent;
        private System.Windows.Forms.GroupBox shuffleGroupBox;
        private System.Windows.Forms.CheckBox shuffleActivate;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label ShuffleLabelPercent;
        private System.Windows.Forms.TextBox shuffleTextBoxPercent;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.GroupBox replaceGroupBox;
        private System.Windows.Forms.Label replaceLabel;
        private System.Windows.Forms.TextBox replaceTextBox;
        private System.Windows.Forms.CheckBox replaceActivateCheckBox;
    }
}

