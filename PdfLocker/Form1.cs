using System;
using System.IO;
using System.Windows.Forms;

namespace PdfLocker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(LockPasswordTextBox.Text != "")
            {
                Clipboard.SetText(LockPasswordTextBox.Text);
            }

        }

        private void LockInputFileButton_Click(object sender, EventArgs e)
        {
            // Créer une boîte de dialogue pour sélectionner un fichier
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Sélectionnez un fichier";
            openFileDialog.Filter = "Fichiers PDF|*.pdf|Tous les fichiers|*.*";  // Exemple de filtre pour PDF

            // Si l'utilisateur sélectionne un fichier
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Le chemin du fichier sélectionné
                string selectedFilePath = openFileDialog.FileName;

                // Afficher un message avec le chemin du fichier sélectionné
                LockInputFileTextBox.Text = selectedFilePath;
            }
        }

        private void LockOutputFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Choisissez un emplacement pour enregistrer le fichier PDF";
                    saveFileDialog.Filter = "Fichiers PDF (*.pdf)|*.pdf";
                    saveFileDialog.DefaultExt = "pdf";
                    saveFileDialog.FileName = "NouveauFichier.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedPath = saveFileDialog.FileName;

                        // Vérifier si le fichier existe et le libérer si nécessaire
                        if (File.Exists(selectedPath))
                        {
                            try
                            {
                                using (FileStream fs = File.Open(selectedPath, FileMode.Open, FileAccess.Read, FileShare.Read))
                                {
                                    // Si aucune exception, le fichier est accessible
                                }
                            }
                            catch (IOException ex)
                            {
                                MessageBox.Show($"Le fichier est déjà utilisé par un autre processus : {ex.Message}");
                                return; // Arrêter le processus si le fichier est verrouillé
                            }
                        }

                        LockOutputFileTextBox.Text = selectedPath;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}");
            }

        }

        private void LockProcessButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupérer le chemin du fichier d'entrée et de sortie
                string inputFilePath = LockInputFileTextBox.Text; // Chemin du fichier PDF existant
                string outputFilePath = LockOutputFileTextBox.Text;     // Chemin de sortie pour le nouveau fichier PDF
                string password = LockPasswordTextBox.Text;          // Mot de passe
                Tools.PDFManager pdfManager = new Tools.PDFManager();

                if (string.IsNullOrEmpty(inputFilePath) || string.IsNullOrEmpty(outputFilePath) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Vérifier si le fichier d'entrée existe

                if (!File.Exists(inputFilePath))
                {
                    MessageBox.Show("Le fichier d'entrée n'existe pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Appeler la méthode pour protéger le PDF avec un mot de passe
                pdfManager.LockPDF(inputFilePath, outputFilePath, password);

                MessageBox.Show("Le fichier PDF a été protégé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionnel : Ouvrir le PDF généré
                if (MessageBox.Show("Voulez-vous ouvrir le fichier PDF ?", "Ouvrir PDF", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("explorer.exe", outputFilePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur est survenue : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UnLockInputFileButton_Click(object sender, EventArgs e)
        {

            // Créer une boîte de dialogue pour sélectionner un fichier
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Sélectionnez un fichier";
            openFileDialog.Filter = "Fichiers PDF|*.pdf|Tous les fichiers|*.*";  // Exemple de filtre pour PDF

            // Si l'utilisateur sélectionne un fichier
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Le chemin du fichier sélectionné
                string selectedFilePath = openFileDialog.FileName;

                // Afficher un message avec le chemin du fichier sélectionné
                UnlockInputFileTextBox.Text = selectedFilePath;
            }
        }

        private void UnLockOutputFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Choisissez un emplacement pour enregistrer le fichier PDF";
                    saveFileDialog.Filter = "Fichiers PDF (*.pdf)|*.pdf";
                    saveFileDialog.DefaultExt = "pdf";
                    saveFileDialog.FileName = "NouveauFichier.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedPath = saveFileDialog.FileName;

                        // Vérifier si le fichier existe et le libérer si nécessaire
                        if (File.Exists(selectedPath))
                        {
                            try
                            {
                                using (FileStream fs = File.Open(selectedPath, FileMode.Open, FileAccess.Read, FileShare.Read))
                                {
                                    // Si aucune exception, le fichier est accessible
                                }
                            }
                            catch (IOException ex)
                            {
                                MessageBox.Show($"Le fichier est déjà utilisé par un autre processus : {ex.Message}");
                                return; // Arrêter le processus si le fichier est verrouillé
                            }
                        }

                        UnlockOutputFileTextBox.Text = selectedPath;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}");
            }

        }

        private void UnlockProcessButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupérer le chemin du fichier d'entrée et de sortie
                string inputFilePath = UnlockInputFileTextBox.Text; // Chemin du fichier PDF existant
                string outputFilePath = UnlockOutputFileTextBox.Text;     // Chemin de sortie pour le nouveau fichier PDF
                string password = UnlockPasswordTextBox.Text;          // Mot de passe
                Tools.PDFManager pdfManager = new Tools.PDFManager();

                if (string.IsNullOrEmpty(inputFilePath) || string.IsNullOrEmpty(outputFilePath) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Vérifier si le fichier d'entrée existe

                if (!File.Exists(inputFilePath))
                {
                    MessageBox.Show("Le fichier d'entrée n'existe pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Appeler la méthode pour protéger le PDF avec un mot de passe
                pdfManager.UnlockPdf(inputFilePath, outputFilePath, password);

                MessageBox.Show("Le fichier PDF a été dévérouillé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionnel : Ouvrir le PDF généré
                if (MessageBox.Show("Voulez-vous ouvrir le fichier PDF ?", "Ouvrir PDF", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("explorer.exe", outputFilePath);
                }
            }
            catch { }
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            // Vérifier si le presse-papiers contient du texte
            if (Clipboard.ContainsText())
            {
                // Récupérer le texte du presse-papiers et le placer dans le TextBox
                UnlockPasswordTextBox.Text = Clipboard.GetText();
            }
        }

        private void lockPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTab(this.tabControl1 , 0);
        }

        private void ShowTab(TabControl tabControl, int tabIndex)
        {
            // Assurer que le TabControl est visible
            //tabControl.Visible = true;

            // Sélectionner l'onglet en fonction de l'indice
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
    }
}
