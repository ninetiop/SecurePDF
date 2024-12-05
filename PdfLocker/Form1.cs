using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PdfLocker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (ThemeManager.IsDarkTheme)
            {
                ThemeManager.ApplyCyberpunkTheme(this, false);
            }
            else
            {
                ThemeManager.ApplyLightTheme(this);
            }
        }

        private void ShowCopyToolTip(Control control, string message)
        {
            // Calculate the position to display the tooltip
            int toolTipX = control.Width / 2; // Center horizontally relative to the control
            int toolTipY = -20;               // Offset above the control

            // Show the tooltip above the control
            this.toolTip1.Show(message, control, toolTipX, toolTipY, 2000); // Show for 2 seconds
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LockPasswordTextBox.Text != "")
            {
                Clipboard.SetText(LockPasswordTextBox.Text);
                ShowCopyToolTip(this.buttonCopy, "Copied to clipboard!");
            }
        }

        private void LockInputFileButton_Click(object sender, EventArgs e)
        {
            // Create a dialog box to select a file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a file";
            openFileDialog.Filter = "PDF Files|*.pdf|All files|*.*";  // Example filter for PDFs

            // If the user selects a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // The selected file path
                string selectedFilePath = openFileDialog.FileName;

                // Display a message with the selected file path
                LockInputFileTextBox.Text = selectedFilePath;
            }
        }

        private void LockOutputFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Choose a location to save the PDF file";
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.DefaultExt = "pdf";
                    saveFileDialog.FileName = "NewFile.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedPath = saveFileDialog.FileName;

                        // Check if the file exists and release it if necessary
                        if (File.Exists(selectedPath))
                        {
                            try
                            {
                                using (FileStream fs = File.Open(selectedPath, FileMode.Open, FileAccess.Read, FileShare.Read))
                                {
                                    // If no exception, the file is accessible
                                }
                            }
                            catch (IOException ex)
                            {
                                MessageBox.Show($"The file is already in use by another process: {ex.Message}");
                                return; // Stop the process if the file is locked
                            }
                        }

                        LockOutputFileTextBox.Text = selectedPath;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void LockProcessButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the input and output file paths
                string inputFilePath = LockInputFileTextBox.Text; // Path of the existing PDF file
                string outputFilePath = LockOutputFileTextBox.Text;     // Output path for the new PDF file
                string password = LockPasswordTextBox.Text;          // Password
                Tools.PDFManager pdfManager = new Tools.PDFManager();

                if (string.IsNullOrEmpty(inputFilePath) || string.IsNullOrEmpty(outputFilePath) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if the input file exists

                if (!File.Exists(inputFilePath))
                {
                    MessageBox.Show("The input file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Call the method to lock the PDF with a password
                pdfManager.LockPDF(inputFilePath, outputFilePath, password);

                MessageBox.Show("The PDF file has been successfully protected!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally: Open the generated PDF
                if (MessageBox.Show("Do you want to open the PDF file?", "Open PDF", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("explorer.exe", outputFilePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UnLockInputFileButton_Click(object sender, EventArgs e)
        {
            // Create a dialog box to select a file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a file";
            openFileDialog.Filter = "PDF Files|*.pdf|All files|*.*";  // Example filter for PDFs

            // If the user selects a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // The selected file path
                string selectedFilePath = openFileDialog.FileName;

                // Display a message with the selected file path
                UnlockInputFileTextBox.Text = selectedFilePath;
            }
        }

        private void UnLockOutputFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Choose a location to save the PDF file";
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.DefaultExt = "pdf";
                    saveFileDialog.FileName = "NewFile.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedPath = saveFileDialog.FileName;

                        // Check if the file exists and release it if necessary
                        if (File.Exists(selectedPath))
                        {
                            try
                            {
                                using (FileStream fs = File.Open(selectedPath, FileMode.Open, FileAccess.Read, FileShare.Read))
                                {
                                    // If no exception, the file is accessible
                                }
                            }
                            catch (IOException ex)
                            {
                                MessageBox.Show($"The file is already in use by another process: {ex.Message}");
                                return; // Stop the process if the file is locked
                            }
                        }

                        UnlockOutputFileTextBox.Text = selectedPath;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void UnlockProcessButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the input and output file paths
                string inputFilePath = UnlockInputFileTextBox.Text; // Path of the existing PDF file
                string outputFilePath = UnlockOutputFileTextBox.Text;     // Output path for the new PDF file
                string password = UnlockPasswordTextBox.Text;          // Password
                Tools.PDFManager pdfManager = new Tools.PDFManager();

                if (string.IsNullOrEmpty(inputFilePath) || string.IsNullOrEmpty(outputFilePath) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if the input file exists

                if (!File.Exists(inputFilePath))
                {
                    MessageBox.Show("The input file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Call the method to unlock the PDF with the password
                pdfManager.UnlockPdf(inputFilePath, outputFilePath, password);

                MessageBox.Show("The PDF file has been successfully unlocked!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally: Open the generated PDF
                if (MessageBox.Show("Do you want to open the PDF file?", "Open PDF", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("explorer.exe", outputFilePath);
                }
            }
            catch { }
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            // Check if the clipboard contains text
            if (Clipboard.ContainsText())
            {
                // Get the text from the clipboard and place it in the TextBox
                UnlockPasswordTextBox.Text = Clipboard.GetText();
            }
        }

        private void lockPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTab(this.tabControl1, 0);
        }

        private void ShowTab(TabControl tabControl, int tabIndex)
        {
            // Ensure the TabControl is visible
            //tabControl.Visible = true;

            // Select the tab based on the index
            tabControl.SelectedIndex = tabIndex;
        }

        private void unlockPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTab(this.tabControl1, 1);
        }

        private void buttonVisiblePassword_Click(object sender, EventArgs e)
        {
            this.LockVisiblePasswordButton.Enabled = false;
            this.LockVisiblePasswordButton.Visible = false;
            this.LockInvisiblePasswordButton.Enabled = true;
            this.LockInvisiblePasswordButton.Visible = true;
            this.LockPasswordTextBox.PasswordChar = '\0';
        }

        private void buttonInvisiblePassword_Click(object sender, EventArgs e)
        {
            this.LockInvisiblePasswordButton.Enabled = false;
            this.LockInvisiblePasswordButton.Visible = false;
            this.LockVisiblePasswordButton.Enabled = true;
            this.LockVisiblePasswordButton.Visible = true;
            this.LockPasswordTextBox.PasswordChar = '\u25CF';
        }

        private void UnlockVisiblePasswordButton_Click(object sender, EventArgs e)
        {
            this.UnlockVisiblePasswordButton.Enabled = false;
            this.UnlockVisiblePasswordButton.Visible = false;
            this.UnlockInvisiblePasswordButton.Enabled = true;
            this.UnlockInvisiblePasswordButton.Visible = true;
            this.UnlockPasswordTextBox.PasswordChar = '\0';
        }

        private void UnlockInvisiblePasswordButton_Click(object sender, EventArgs e)
        {
            this.UnlockInvisiblePasswordButton.Enabled = false;
            this.UnlockInvisiblePasswordButton.Visible = false;
            this.UnlockVisiblePasswordButton.Enabled = true;
            this.UnlockVisiblePasswordButton.Visible = true;
            this.UnlockPasswordTextBox.PasswordChar = '\u25CF';
        }

        private void checkBoxUppercasePassword_CheckedChanged(object sender, EventArgs e)
        {
            Tools.PasswordGenerator passwordGenerator = new Tools.PasswordGenerator();
            this.LockPasswordTextBox.Text = passwordGenerator.GeneratePwd(trackBar1.Value,
                checkBoxLowercasePassword.Checked,
                checkBoxUppercasePassword.Checked,
                checkBoxNumberPassword.Checked,
                checkBoxSymbolPassword.Checked
            );
        }

        private void checkBoxLowercasePassword_CheckedChanged(object sender, EventArgs e)
        {
            Tools.PasswordGenerator passwordGenerator = new Tools.PasswordGenerator();
            this.LockPasswordTextBox.Text = passwordGenerator.GeneratePwd(trackBar1.Value,
                checkBoxLowercasePassword.Checked,
                checkBoxUppercasePassword.Checked,
                checkBoxNumberPassword.Checked,
                checkBoxSymbolPassword.Checked
            );
        }

        private void checkBoxNumberPassword_CheckedChanged(object sender, EventArgs e)
        {
            Tools.PasswordGenerator passwordGenerator = new Tools.PasswordGenerator();
            this.LockPasswordTextBox.Text = passwordGenerator.GeneratePwd(trackBar1.Value,
                checkBoxLowercasePassword.Checked,
                checkBoxUppercasePassword.Checked,
                checkBoxNumberPassword.Checked,
                checkBoxSymbolPassword.Checked
            );
        }

        private void checkBoxSymbolPassword_CheckedChanged(object sender, EventArgs e)
        {
            Tools.PasswordGenerator passwordGenerator = new Tools.PasswordGenerator();
            this.LockPasswordTextBox.Text = passwordGenerator.GeneratePwd(trackBar1.Value,
                checkBoxLowercasePassword.Checked,
                checkBoxUppercasePassword.Checked,
                checkBoxNumberPassword.Checked,
                checkBoxSymbolPassword.Checked
            );
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.LabelPasswordNumberLength.Text = trackBar1.Value.ToString();
            Tools.PasswordGenerator passwordGenerator = new Tools.PasswordGenerator();
            this.LockPasswordTextBox.Text = passwordGenerator.GeneratePwd(trackBar1.Value,
                checkBoxLowercasePassword.Checked,
                checkBoxUppercasePassword.Checked,
                checkBoxNumberPassword.Checked,
                checkBoxSymbolPassword.Checked
            );
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }


        private void metroToggle1_CheckedChanged_1(object sender, EventArgs e)
        {
            var toggle = sender as MetroFramework.Controls.MetroToggle;

            if (toggle != null)
            {
                // Mise à jour du texte en fonction de l'état du toggle
                toggle.Text = toggle.Checked ? "Cyberpunk" : "Light"; // Texte dynamique

                // Applique le thème en fonction de l'état du toggle
                if (toggle.Checked)
                    ThemeManager.ApplyCyberpunkTheme(this); // Applique le thème Cyberpunk
                else
                    ThemeManager.ApplyLightTheme(this); // Applique le thème Light
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ThemeManager.ApplyLightTheme(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemeManager.ApplyCyberpunkTheme(this);
        }
    }
}
