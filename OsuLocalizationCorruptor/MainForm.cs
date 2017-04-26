using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace OsuLocalizationCorruptor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                var l = LocalizationFile.Load(fileTextBox.Text);
                l.Restore();
                l.Backup();

                if(shuffleActivate.Checked)
                    l.Shuffle(int.Parse(shuffleTextBoxPercent.Text));

                if(wordMessActivate.Checked)
                    l.MessWords(int.Parse(wordMessTextBoxTries.Text), int.Parse(wordMessTextBoxPercent.Text));

                if(replaceActivateCheckBox.Checked && replaceTextBox.Text != "")
                    l.ReplaceAll(replaceTextBox.Text);
                
                l.Save();
                MessageBox.Show("Completed with Success!", "Operation Complete!");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show($"Could not be completed! ({ex.GetType().Name}: {ex.Message})", "An error Occured!");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            fileTextBox.Text = openFileDialog1.FileName;
        }

        private void fileTextBox_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
