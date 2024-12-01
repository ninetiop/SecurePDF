using System.Drawing;
using System.Windows.Forms;

namespace PdfLocker
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LabelPasswordNumberLength = new System.Windows.Forms.Label();
            this.LengthPasswordLabel = new System.Windows.Forms.Label();
            this.checkBoxSymbolPassword = new System.Windows.Forms.CheckBox();
            this.checkBoxNumberPassword = new System.Windows.Forms.CheckBox();
            this.checkBoxLowercasePassword = new System.Windows.Forms.CheckBox();
            this.checkBoxUppercasePassword = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.LockVisiblePasswordButton = new System.Windows.Forms.Button();
            this.LockInvisiblePasswordButton = new System.Windows.Forms.Button();
            this.buttonIconLock = new System.Windows.Forms.Button();
            this.LockOutputFileLabel = new System.Windows.Forms.Label();
            this.LockProcessButton = new System.Windows.Forms.Button();
            this.LockFileInputLabel = new System.Windows.Forms.Label();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.LockOutputFileButton = new System.Windows.Forms.Button();
            this.LockInputFileTextBox = new System.Windows.Forms.TextBox();
            this.LockOutputFileTextBox = new System.Windows.Forms.TextBox();
            this.LockInputFileButton = new System.Windows.Forms.Button();
            this.LockPasswordLabel = new System.Windows.Forms.Label();
            this.LockPasswordTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.UnlockInvisiblePasswordButton = new System.Windows.Forms.Button();
            this.UnlockVisiblePasswordButton = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonPaste = new System.Windows.Forms.Button();
            this.UnlockOutputFileLabel = new System.Windows.Forms.Label();
            this.UnlockProcessButton = new System.Windows.Forms.Button();
            this.UnLockOutputFileButton = new System.Windows.Forms.Button();
            this.UnlockOutputFileTextBox = new System.Windows.Forms.TextBox();
            this.UnlockPasswordLabel = new System.Windows.Forms.Label();
            this.UnlockPasswordTextBox = new System.Windows.Forms.TextBox();
            this.UnLockInputFileButton = new System.Windows.Forms.Button();
            this.UnlockInputFileTextBox = new System.Windows.Forms.TextBox();
            this.UnlockInputFileLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lockPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unlockPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(0, 37);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1168, 769);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.LabelPasswordNumberLength);
            this.tabPage1.Controls.Add(this.LengthPasswordLabel);
            this.tabPage1.Controls.Add(this.checkBoxSymbolPassword);
            this.tabPage1.Controls.Add(this.checkBoxNumberPassword);
            this.tabPage1.Controls.Add(this.checkBoxLowercasePassword);
            this.tabPage1.Controls.Add(this.checkBoxUppercasePassword);
            this.tabPage1.Controls.Add(this.trackBar1);
            this.tabPage1.Controls.Add(this.LockVisiblePasswordButton);
            this.tabPage1.Controls.Add(this.LockInvisiblePasswordButton);
            this.tabPage1.Controls.Add(this.buttonIconLock);
            this.tabPage1.Controls.Add(this.LockOutputFileLabel);
            this.tabPage1.Controls.Add(this.LockProcessButton);
            this.tabPage1.Controls.Add(this.LockFileInputLabel);
            this.tabPage1.Controls.Add(this.buttonCopy);
            this.tabPage1.Controls.Add(this.LockOutputFileButton);
            this.tabPage1.Controls.Add(this.LockInputFileTextBox);
            this.tabPage1.Controls.Add(this.LockOutputFileTextBox);
            this.tabPage1.Controls.Add(this.LockInputFileButton);
            this.tabPage1.Controls.Add(this.LockPasswordLabel);
            this.tabPage1.Controls.Add(this.LockPasswordTextBox);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(1160, 760);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PDF Locker";
            // 
            // LabelPasswordNumberLength
            // 
            this.LabelPasswordNumberLength.AutoSize = true;
            this.LabelPasswordNumberLength.Location = new System.Drawing.Point(991, 350);
            this.LabelPasswordNumberLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPasswordNumberLength.Name = "LabelPasswordNumberLength";
            this.LabelPasswordNumberLength.Size = new System.Drawing.Size(36, 25);
            this.LabelPasswordNumberLength.TabIndex = 27;
            this.LabelPasswordNumberLength.Text = "12";
            // 
            // LengthPasswordLabel
            // 
            this.LengthPasswordLabel.AutoSize = true;
            this.LengthPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.LengthPasswordLabel.Location = new System.Drawing.Point(788, 352);
            this.LengthPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LengthPasswordLabel.Name = "LengthPasswordLabel";
            this.LengthPasswordLabel.Size = new System.Drawing.Size(181, 24);
            this.LengthPasswordLabel.TabIndex = 26;
            this.LengthPasswordLabel.Text = "Length password :";
            // 
            // checkBoxSymbolPassword
            // 
            this.checkBoxSymbolPassword.AutoSize = true;
            this.checkBoxSymbolPassword.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxSymbolPassword.Checked = true;
            this.checkBoxSymbolPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSymbolPassword.Location = new System.Drawing.Point(1047, 431);
            this.checkBoxSymbolPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxSymbolPassword.Name = "checkBoxSymbolPassword";
            this.checkBoxSymbolPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxSymbolPassword.Size = new System.Drawing.Size(58, 29);
            this.checkBoxSymbolPassword.TabIndex = 25;
            this.checkBoxSymbolPassword.Text = "#$&";
            this.checkBoxSymbolPassword.UseVisualStyleBackColor = true;
            this.checkBoxSymbolPassword.CheckedChanged += new System.EventHandler(this.checkBoxSymbolPassword_CheckedChanged);
            // 
            // checkBoxNumberPassword
            // 
            this.checkBoxNumberPassword.AutoSize = true;
            this.checkBoxNumberPassword.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxNumberPassword.Checked = true;
            this.checkBoxNumberPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNumberPassword.Location = new System.Drawing.Point(964, 431);
            this.checkBoxNumberPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxNumberPassword.Name = "checkBoxNumberPassword";
            this.checkBoxNumberPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxNumberPassword.Size = new System.Drawing.Size(70, 29);
            this.checkBoxNumberPassword.TabIndex = 24;
            this.checkBoxNumberPassword.Text = "123";
            this.checkBoxNumberPassword.UseVisualStyleBackColor = true;
            this.checkBoxNumberPassword.CheckedChanged += new System.EventHandler(this.checkBoxNumberPassword_CheckedChanged);
            // 
            // checkBoxLowercasePassword
            // 
            this.checkBoxLowercasePassword.AutoSize = true;
            this.checkBoxLowercasePassword.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxLowercasePassword.Checked = true;
            this.checkBoxLowercasePassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLowercasePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxLowercasePassword.Location = new System.Drawing.Point(883, 431);
            this.checkBoxLowercasePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxLowercasePassword.Name = "checkBoxLowercasePassword";
            this.checkBoxLowercasePassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxLowercasePassword.Size = new System.Drawing.Size(69, 29);
            this.checkBoxLowercasePassword.TabIndex = 23;
            this.checkBoxLowercasePassword.Text = "abc";
            this.checkBoxLowercasePassword.UseVisualStyleBackColor = true;
            this.checkBoxLowercasePassword.CheckedChanged += new System.EventHandler(this.checkBoxLowercasePassword_CheckedChanged);
            // 
            // checkBoxUppercasePassword
            // 
            this.checkBoxUppercasePassword.AutoSize = true;
            this.checkBoxUppercasePassword.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxUppercasePassword.Checked = true;
            this.checkBoxUppercasePassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUppercasePassword.Location = new System.Drawing.Point(792, 431);
            this.checkBoxUppercasePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxUppercasePassword.Name = "checkBoxUppercasePassword";
            this.checkBoxUppercasePassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxUppercasePassword.Size = new System.Drawing.Size(79, 29);
            this.checkBoxUppercasePassword.TabIndex = 22;
            this.checkBoxUppercasePassword.Text = "ABC";
            this.checkBoxUppercasePassword.UseVisualStyleBackColor = true;
            this.checkBoxUppercasePassword.CheckedChanged += new System.EventHandler(this.checkBoxUppercasePassword_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.Location = new System.Drawing.Point(779, 391);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeftLayout = true;
            this.trackBar1.Size = new System.Drawing.Size(251, 56);
            this.trackBar1.TabIndex = 21;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 12;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // LockVisiblePasswordButton
            // 
            this.LockVisiblePasswordButton.FlatAppearance.BorderSize = 0;
            this.LockVisiblePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LockVisiblePasswordButton.Image = global::PdfLocker.Properties.Resources.show1;
            this.LockVisiblePasswordButton.Location = new System.Drawing.Point(397, 340);
            this.LockVisiblePasswordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LockVisiblePasswordButton.Name = "LockVisiblePasswordButton";
            this.LockVisiblePasswordButton.Size = new System.Drawing.Size(45, 33);
            this.LockVisiblePasswordButton.TabIndex = 20;
            this.LockVisiblePasswordButton.UseVisualStyleBackColor = true;
            this.LockVisiblePasswordButton.Click += new System.EventHandler(this.buttonVisiblePassword_Click);
            // 
            // LockInvisiblePasswordButton
            // 
            this.LockInvisiblePasswordButton.BackColor = System.Drawing.Color.White;
            this.LockInvisiblePasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LockInvisiblePasswordButton.FlatAppearance.BorderSize = 0;
            this.LockInvisiblePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LockInvisiblePasswordButton.ForeColor = System.Drawing.Color.White;
            this.LockInvisiblePasswordButton.Image = global::PdfLocker.Properties.Resources.invisible;
            this.LockInvisiblePasswordButton.Location = new System.Drawing.Point(397, 341);
            this.LockInvisiblePasswordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LockInvisiblePasswordButton.Name = "LockInvisiblePasswordButton";
            this.LockInvisiblePasswordButton.Size = new System.Drawing.Size(45, 33);
            this.LockInvisiblePasswordButton.TabIndex = 19;
            this.LockInvisiblePasswordButton.UseVisualStyleBackColor = false;
            this.LockInvisiblePasswordButton.Visible = false;
            this.LockInvisiblePasswordButton.Click += new System.EventHandler(this.buttonInvisiblePassword_Click);
            // 
            // buttonIconLock
            // 
            this.buttonIconLock.FlatAppearance.BorderSize = 0;
            this.buttonIconLock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonIconLock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonIconLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIconLock.Image = global::PdfLocker.Properties.Resources.image;
            this.buttonIconLock.Location = new System.Drawing.Point(448, 53);
            this.buttonIconLock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIconLock.Name = "buttonIconLock";
            this.buttonIconLock.Size = new System.Drawing.Size(157, 138);
            this.buttonIconLock.TabIndex = 18;
            this.buttonIconLock.UseVisualStyleBackColor = true;
            // 
            // LockOutputFileLabel
            // 
            this.LockOutputFileLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.LockOutputFileLabel.ForeColor = System.Drawing.Color.Black;
            this.LockOutputFileLabel.Location = new System.Drawing.Point(283, 454);
            this.LockOutputFileLabel.Name = "LockOutputFileLabel";
            this.LockOutputFileLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LockOutputFileLabel.Size = new System.Drawing.Size(129, 37);
            this.LockOutputFileLabel.TabIndex = 5;
            this.LockOutputFileLabel.Text = "Output";
            this.LockOutputFileLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LockProcessButton
            // 
            this.LockProcessButton.BackColor = System.Drawing.Color.ForestGreen;
            this.LockProcessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LockProcessButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.LockProcessButton.ForeColor = System.Drawing.Color.White;
            this.LockProcessButton.Location = new System.Drawing.Point(288, 607);
            this.LockProcessButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LockProcessButton.Name = "LockProcessButton";
            this.LockProcessButton.Size = new System.Drawing.Size(451, 50);
            this.LockProcessButton.TabIndex = 16;
            this.LockProcessButton.Text = "Process";
            this.LockProcessButton.UseVisualStyleBackColor = false;
            this.LockProcessButton.Click += new System.EventHandler(this.LockProcessButton_Click);
            // 
            // LockFileInputLabel
            // 
            this.LockFileInputLabel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LockFileInputLabel.Location = new System.Drawing.Point(283, 222);
            this.LockFileInputLabel.Name = "LockFileInputLabel";
            this.LockFileInputLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LockFileInputLabel.Size = new System.Drawing.Size(129, 37);
            this.LockFileInputLabel.TabIndex = 3;
            this.LockFileInputLabel.Text = "Input PDF";
            this.LockFileInputLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // buttonCopy
            // 
            this.buttonCopy.FlatAppearance.BorderSize = 0;
            this.buttonCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopy.Image = global::PdfLocker.Resource1.copy;
            this.buttonCopy.Location = new System.Drawing.Point(448, 336);
            this.buttonCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(53, 50);
            this.buttonCopy.TabIndex = 12;
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.button1_Click);
            // 
            // LockOutputFileButton
            // 
            this.LockOutputFileButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.LockOutputFileButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.LockOutputFileButton.FlatAppearance.BorderSize = 0;
            this.LockOutputFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LockOutputFileButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LockOutputFileButton.ForeColor = System.Drawing.Color.White;
            this.LockOutputFileButton.Location = new System.Drawing.Point(792, 508);
            this.LockOutputFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LockOutputFileButton.Name = "LockOutputFileButton";
            this.LockOutputFileButton.Size = new System.Drawing.Size(141, 39);
            this.LockOutputFileButton.TabIndex = 15;
            this.LockOutputFileButton.Text = "Choose Path";
            this.LockOutputFileButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LockOutputFileButton.UseVisualStyleBackColor = false;
            this.LockOutputFileButton.Click += new System.EventHandler(this.LockOutputFileButton_Click);
            // 
            // LockInputFileTextBox
            // 
            this.LockInputFileTextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.LockInputFileTextBox.Location = new System.Drawing.Point(288, 261);
            this.LockInputFileTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LockInputFileTextBox.Name = "LockInputFileTextBox";
            this.LockInputFileTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LockInputFileTextBox.Size = new System.Drawing.Size(449, 34);
            this.LockInputFileTextBox.TabIndex = 0;
            // 
            // LockOutputFileTextBox
            // 
            this.LockOutputFileTextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.LockOutputFileTextBox.Location = new System.Drawing.Point(288, 508);
            this.LockOutputFileTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LockOutputFileTextBox.Name = "LockOutputFileTextBox";
            this.LockOutputFileTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LockOutputFileTextBox.Size = new System.Drawing.Size(449, 34);
            this.LockOutputFileTextBox.TabIndex = 2;
            // 
            // LockInputFileButton
            // 
            this.LockInputFileButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.LockInputFileButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.LockInputFileButton.FlatAppearance.BorderSize = 0;
            this.LockInputFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LockInputFileButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.LockInputFileButton.ForeColor = System.Drawing.Color.White;
            this.LockInputFileButton.Location = new System.Drawing.Point(792, 256);
            this.LockInputFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LockInputFileButton.Name = "LockInputFileButton";
            this.LockInputFileButton.Size = new System.Drawing.Size(141, 39);
            this.LockInputFileButton.TabIndex = 13;
            this.LockInputFileButton.Text = "Upload";
            this.LockInputFileButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LockInputFileButton.UseVisualStyleBackColor = false;
            this.LockInputFileButton.Click += new System.EventHandler(this.LockInputFileButton_Click);
            // 
            // LockPasswordLabel
            // 
            this.LockPasswordLabel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LockPasswordLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LockPasswordLabel.Location = new System.Drawing.Point(283, 336);
            this.LockPasswordLabel.Name = "LockPasswordLabel";
            this.LockPasswordLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LockPasswordLabel.Size = new System.Drawing.Size(129, 37);
            this.LockPasswordLabel.TabIndex = 4;
            this.LockPasswordLabel.Text = "Password";
            this.LockPasswordLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LockPasswordTextBox
            // 
            this.LockPasswordTextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.LockPasswordTextBox.Location = new System.Drawing.Point(288, 391);
            this.LockPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LockPasswordTextBox.Name = "LockPasswordTextBox";
            this.LockPasswordTextBox.PasswordChar = '*';
            this.LockPasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LockPasswordTextBox.Size = new System.Drawing.Size(449, 34);
            this.LockPasswordTextBox.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.UnlockInvisiblePasswordButton);
            this.tabPage2.Controls.Add(this.UnlockVisiblePasswordButton);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.buttonPaste);
            this.tabPage2.Controls.Add(this.UnlockOutputFileLabel);
            this.tabPage2.Controls.Add(this.UnlockProcessButton);
            this.tabPage2.Controls.Add(this.UnLockOutputFileButton);
            this.tabPage2.Controls.Add(this.UnlockOutputFileTextBox);
            this.tabPage2.Controls.Add(this.UnlockPasswordLabel);
            this.tabPage2.Controls.Add(this.UnlockPasswordTextBox);
            this.tabPage2.Controls.Add(this.UnLockInputFileButton);
            this.tabPage2.Controls.Add(this.UnlockInputFileTextBox);
            this.tabPage2.Controls.Add(this.UnlockInputFileLabel);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage2.Size = new System.Drawing.Size(1160, 760);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PDF Unlocker";
            // 
            // UnlockInvisiblePasswordButton
            // 
            this.UnlockInvisiblePasswordButton.BackColor = System.Drawing.Color.White;
            this.UnlockInvisiblePasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.UnlockInvisiblePasswordButton.FlatAppearance.BorderSize = 0;
            this.UnlockInvisiblePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnlockInvisiblePasswordButton.ForeColor = System.Drawing.Color.White;
            this.UnlockInvisiblePasswordButton.Image = global::PdfLocker.Properties.Resources.invisible;
            this.UnlockInvisiblePasswordButton.Location = new System.Drawing.Point(792, 393);
            this.UnlockInvisiblePasswordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnlockInvisiblePasswordButton.Name = "UnlockInvisiblePasswordButton";
            this.UnlockInvisiblePasswordButton.Size = new System.Drawing.Size(45, 33);
            this.UnlockInvisiblePasswordButton.TabIndex = 27;
            this.UnlockInvisiblePasswordButton.UseVisualStyleBackColor = false;
            this.UnlockInvisiblePasswordButton.Visible = false;
            this.UnlockInvisiblePasswordButton.Click += new System.EventHandler(this.UnlockInvisiblePasswordButton_Click);
            // 
            // UnlockVisiblePasswordButton
            // 
            this.UnlockVisiblePasswordButton.FlatAppearance.BorderSize = 0;
            this.UnlockVisiblePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnlockVisiblePasswordButton.Image = global::PdfLocker.Properties.Resources.show1;
            this.UnlockVisiblePasswordButton.Location = new System.Drawing.Point(792, 390);
            this.UnlockVisiblePasswordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnlockVisiblePasswordButton.Name = "UnlockVisiblePasswordButton";
            this.UnlockVisiblePasswordButton.Size = new System.Drawing.Size(45, 33);
            this.UnlockVisiblePasswordButton.TabIndex = 26;
            this.UnlockVisiblePasswordButton.UseVisualStyleBackColor = true;
            this.UnlockVisiblePasswordButton.Click += new System.EventHandler(this.UnlockVisiblePasswordButton_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = global::PdfLocker.Properties.Resources.unlocked;
            this.button8.Location = new System.Drawing.Point(448, 53);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(157, 138);
            this.button8.TabIndex = 25;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // buttonPaste
            // 
            this.buttonPaste.Image = global::PdfLocker.Resource1.paste;
            this.buttonPaste.Location = new System.Drawing.Point(417, 340);
            this.buttonPaste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(35, 36);
            this.buttonPaste.TabIndex = 24;
            this.buttonPaste.UseVisualStyleBackColor = true;
            this.buttonPaste.Click += new System.EventHandler(this.buttonPaste_Click);
            // 
            // UnlockOutputFileLabel
            // 
            this.UnlockOutputFileLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.UnlockOutputFileLabel.ForeColor = System.Drawing.Color.Black;
            this.UnlockOutputFileLabel.Location = new System.Drawing.Point(283, 454);
            this.UnlockOutputFileLabel.Name = "UnlockOutputFileLabel";
            this.UnlockOutputFileLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UnlockOutputFileLabel.Size = new System.Drawing.Size(129, 37);
            this.UnlockOutputFileLabel.TabIndex = 20;
            this.UnlockOutputFileLabel.Text = "Output";
            this.UnlockOutputFileLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // UnlockProcessButton
            // 
            this.UnlockProcessButton.BackColor = System.Drawing.Color.ForestGreen;
            this.UnlockProcessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnlockProcessButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.UnlockProcessButton.ForeColor = System.Drawing.Color.White;
            this.UnlockProcessButton.Location = new System.Drawing.Point(288, 607);
            this.UnlockProcessButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnlockProcessButton.Name = "UnlockProcessButton";
            this.UnlockProcessButton.Size = new System.Drawing.Size(451, 50);
            this.UnlockProcessButton.TabIndex = 23;
            this.UnlockProcessButton.Text = "Process";
            this.UnlockProcessButton.UseVisualStyleBackColor = false;
            this.UnlockProcessButton.Click += new System.EventHandler(this.UnlockProcessButton_Click);
            // 
            // UnLockOutputFileButton
            // 
            this.UnLockOutputFileButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.UnLockOutputFileButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.UnLockOutputFileButton.FlatAppearance.BorderSize = 0;
            this.UnLockOutputFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnLockOutputFileButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnLockOutputFileButton.ForeColor = System.Drawing.Color.White;
            this.UnLockOutputFileButton.Location = new System.Drawing.Point(792, 508);
            this.UnLockOutputFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnLockOutputFileButton.Name = "UnLockOutputFileButton";
            this.UnLockOutputFileButton.Size = new System.Drawing.Size(141, 39);
            this.UnLockOutputFileButton.TabIndex = 22;
            this.UnLockOutputFileButton.Text = "Choose Path";
            this.UnLockOutputFileButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UnLockOutputFileButton.UseVisualStyleBackColor = false;
            this.UnLockOutputFileButton.Click += new System.EventHandler(this.UnLockOutputFileButton_Click);
            // 
            // UnlockOutputFileTextBox
            // 
            this.UnlockOutputFileTextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.UnlockOutputFileTextBox.Location = new System.Drawing.Point(288, 508);
            this.UnlockOutputFileTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnlockOutputFileTextBox.Name = "UnlockOutputFileTextBox";
            this.UnlockOutputFileTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UnlockOutputFileTextBox.Size = new System.Drawing.Size(449, 34);
            this.UnlockOutputFileTextBox.TabIndex = 18;
            // 
            // UnlockPasswordLabel
            // 
            this.UnlockPasswordLabel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnlockPasswordLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.UnlockPasswordLabel.Location = new System.Drawing.Point(283, 336);
            this.UnlockPasswordLabel.Name = "UnlockPasswordLabel";
            this.UnlockPasswordLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UnlockPasswordLabel.Size = new System.Drawing.Size(129, 37);
            this.UnlockPasswordLabel.TabIndex = 19;
            this.UnlockPasswordLabel.Text = "Password";
            this.UnlockPasswordLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // UnlockPasswordTextBox
            // 
            this.UnlockPasswordTextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.UnlockPasswordTextBox.Location = new System.Drawing.Point(288, 391);
            this.UnlockPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnlockPasswordTextBox.Name = "UnlockPasswordTextBox";
            this.UnlockPasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UnlockPasswordTextBox.Size = new System.Drawing.Size(449, 34);
            this.UnlockPasswordTextBox.TabIndex = 17;
            // 
            // UnLockInputFileButton
            // 
            this.UnLockInputFileButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.UnLockInputFileButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.UnLockInputFileButton.FlatAppearance.BorderSize = 0;
            this.UnLockInputFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnLockInputFileButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.UnLockInputFileButton.ForeColor = System.Drawing.Color.White;
            this.UnLockInputFileButton.Location = new System.Drawing.Point(792, 256);
            this.UnLockInputFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnLockInputFileButton.Name = "UnLockInputFileButton";
            this.UnLockInputFileButton.Size = new System.Drawing.Size(141, 39);
            this.UnLockInputFileButton.TabIndex = 14;
            this.UnLockInputFileButton.Text = "Upload";
            this.UnLockInputFileButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UnLockInputFileButton.UseVisualStyleBackColor = false;
            this.UnLockInputFileButton.Click += new System.EventHandler(this.UnLockInputFileButton_Click);
            // 
            // UnlockInputFileTextBox
            // 
            this.UnlockInputFileTextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.UnlockInputFileTextBox.Location = new System.Drawing.Point(288, 261);
            this.UnlockInputFileTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnlockInputFileTextBox.Name = "UnlockInputFileTextBox";
            this.UnlockInputFileTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UnlockInputFileTextBox.Size = new System.Drawing.Size(425, 34);
            this.UnlockInputFileTextBox.TabIndex = 5;
            // 
            // UnlockInputFileLabel
            // 
            this.UnlockInputFileLabel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnlockInputFileLabel.Location = new System.Drawing.Point(283, 222);
            this.UnlockInputFileLabel.Name = "UnlockInputFileLabel";
            this.UnlockInputFileLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UnlockInputFileLabel.Size = new System.Drawing.Size(129, 37);
            this.UnlockInputFileLabel.TabIndex = 4;
            this.UnlockInputFileLabel.Text = "Input PDF";
            this.UnlockInputFileLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockPDFToolStripMenuItem,
            this.unlockPDFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1168, 30);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lockPDFToolStripMenuItem
            // 
            this.lockPDFToolStripMenuItem.Image = global::PdfLocker.Properties.Resources.image;
            this.lockPDFToolStripMenuItem.Name = "lockPDFToolStripMenuItem";
            this.lockPDFToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.lockPDFToolStripMenuItem.Text = "LockPDF";
            this.lockPDFToolStripMenuItem.Click += new System.EventHandler(this.lockPDFToolStripMenuItem_Click);
            // 
            // unlockPDFToolStripMenuItem
            // 
            this.unlockPDFToolStripMenuItem.Image = global::PdfLocker.Properties.Resources.unlocked;
            this.unlockPDFToolStripMenuItem.Name = "unlockPDFToolStripMenuItem";
            this.unlockPDFToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.unlockPDFToolStripMenuItem.Text = "UnlockPDF";
            this.unlockPDFToolStripMenuItem.Click += new System.EventHandler(this.unlockPDFToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1168, 752);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label LockOutputFileLabel;
        private System.Windows.Forms.Button LockProcessButton;
        private System.Windows.Forms.Label LockFileInputLabel;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button LockOutputFileButton;
        private System.Windows.Forms.TextBox LockInputFileTextBox;
        private System.Windows.Forms.TextBox LockOutputFileTextBox;
        private System.Windows.Forms.Button LockInputFileButton;
        private System.Windows.Forms.Label LockPasswordLabel;
        private System.Windows.Forms.TextBox LockPasswordTextBox;
        private System.Windows.Forms.Button buttonIconLock;
        private System.Windows.Forms.Button UnLockInputFileButton;
        private System.Windows.Forms.TextBox UnlockInputFileTextBox;
        private System.Windows.Forms.Label UnlockInputFileLabel;
        private System.Windows.Forms.Label UnlockOutputFileLabel;
        private System.Windows.Forms.Button UnlockProcessButton;
        private System.Windows.Forms.Button UnLockOutputFileButton;
        private System.Windows.Forms.TextBox UnlockOutputFileTextBox;
        private System.Windows.Forms.Label UnlockPasswordLabel;
        private System.Windows.Forms.TextBox UnlockPasswordTextBox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button buttonPaste;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem lockPDFToolStripMenuItem;
        private ToolStripMenuItem unlockPDFToolStripMenuItem;
        private Button LockInvisiblePasswordButton;
        private Button LockVisiblePasswordButton;
        private TrackBar trackBar1;
        private CheckBox checkBoxLowercasePassword;
        private CheckBox checkBoxUppercasePassword;
        private CheckBox checkBoxNumberPassword;
        private CheckBox checkBoxSymbolPassword;
        private Label LengthPasswordLabel;
        private Label LabelPasswordNumberLength;
        private Button UnlockVisiblePasswordButton;
        private Button UnlockInvisiblePasswordButton;
    }
}

