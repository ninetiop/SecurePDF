using System;
using System.Drawing;
using System.IO;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UnlockInvisiblePasswordButton = new System.Windows.Forms.Button();
            this.UnlockVisiblePasswordButton = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
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
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
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
            this.tabControl1.Size = new System.Drawing.Size(1168, 865);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
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
            this.tabPage1.Size = new System.Drawing.Size(1160, 856);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PDF Locker";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(911, 664);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "Choose a path !";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(898, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 18);
            this.label6.TabIndex = 32;
            this.label6.Text = "Upload or drag here! ";
            // 
            // LabelPasswordNumberLength
            // 
            this.LabelPasswordNumberLength.AutoSize = true;
            this.LabelPasswordNumberLength.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LabelPasswordNumberLength.Location = new System.Drawing.Point(1066, 385);
            this.LabelPasswordNumberLength.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelPasswordNumberLength.Name = "LabelPasswordNumberLength";
            this.LabelPasswordNumberLength.Size = new System.Drawing.Size(32, 23);
            this.LabelPasswordNumberLength.TabIndex = 27;
            this.LabelPasswordNumberLength.Text = "12";
            // 
            // LengthPasswordLabel
            // 
            this.LengthPasswordLabel.AutoSize = true;
            this.LengthPasswordLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic);
            this.LengthPasswordLabel.Location = new System.Drawing.Point(847, 386);
            this.LengthPasswordLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LengthPasswordLabel.Name = "LengthPasswordLabel";
            this.LengthPasswordLabel.Size = new System.Drawing.Size(197, 23);
            this.LengthPasswordLabel.TabIndex = 26;
            this.LengthPasswordLabel.Text = "Length password :";
            // 
            // checkBoxSymbolPassword
            // 
            this.checkBoxSymbolPassword.AutoSize = true;
            this.checkBoxSymbolPassword.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxSymbolPassword.Checked = true;
            this.checkBoxSymbolPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSymbolPassword.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic);
            this.checkBoxSymbolPassword.Location = new System.Drawing.Point(1079, 465);
            this.checkBoxSymbolPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxSymbolPassword.Name = "checkBoxSymbolPassword";
            this.checkBoxSymbolPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxSymbolPassword.Size = new System.Drawing.Size(65, 27);
            this.checkBoxSymbolPassword.TabIndex = 25;
            this.checkBoxSymbolPassword.Text = "#$?";
            this.checkBoxSymbolPassword.UseVisualStyleBackColor = true;
            this.checkBoxSymbolPassword.CheckedChanged += new System.EventHandler(this.checkBoxSymbolPassword_CheckedChanged);
            // 
            // checkBoxNumberPassword
            // 
            this.checkBoxNumberPassword.AutoSize = true;
            this.checkBoxNumberPassword.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxNumberPassword.Checked = true;
            this.checkBoxNumberPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNumberPassword.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic);
            this.checkBoxNumberPassword.Location = new System.Drawing.Point(997, 465);
            this.checkBoxNumberPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxNumberPassword.Name = "checkBoxNumberPassword";
            this.checkBoxNumberPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxNumberPassword.Size = new System.Drawing.Size(65, 27);
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
            this.checkBoxLowercasePassword.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic);
            this.checkBoxLowercasePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxLowercasePassword.Location = new System.Drawing.Point(914, 465);
            this.checkBoxLowercasePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxLowercasePassword.Name = "checkBoxLowercasePassword";
            this.checkBoxLowercasePassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxLowercasePassword.Size = new System.Drawing.Size(65, 27);
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
            this.checkBoxUppercasePassword.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic);
            this.checkBoxUppercasePassword.Location = new System.Drawing.Point(842, 466);
            this.checkBoxUppercasePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxUppercasePassword.Name = "checkBoxUppercasePassword";
            this.checkBoxUppercasePassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxUppercasePassword.Size = new System.Drawing.Size(65, 27);
            this.checkBoxUppercasePassword.TabIndex = 22;
            this.checkBoxUppercasePassword.Text = "ABC";
            this.checkBoxUppercasePassword.UseVisualStyleBackColor = true;
            this.checkBoxUppercasePassword.CheckedChanged += new System.EventHandler(this.checkBoxUppercasePassword_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.Location = new System.Drawing.Point(842, 417);
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
            this.LockVisiblePasswordButton.Location = new System.Drawing.Point(476, 379);
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
            this.LockInvisiblePasswordButton.Location = new System.Drawing.Point(476, 378);
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
            this.buttonIconLock.Location = new System.Drawing.Point(501, 51);
            this.buttonIconLock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIconLock.Name = "buttonIconLock";
            this.buttonIconLock.Size = new System.Drawing.Size(157, 138);
            this.buttonIconLock.TabIndex = 18;
            this.buttonIconLock.UseVisualStyleBackColor = true;
            // 
            // LockOutputFileLabel
            // 
            this.LockOutputFileLabel.Font = new System.Drawing.Font("Consolas", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LockOutputFileLabel.ForeColor = System.Drawing.Color.Black;
            this.LockOutputFileLabel.Location = new System.Drawing.Point(334, 532);
            this.LockOutputFileLabel.Name = "LockOutputFileLabel";
            this.LockOutputFileLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LockOutputFileLabel.Size = new System.Drawing.Size(129, 37);
            this.LockOutputFileLabel.TabIndex = 5;
            this.LockOutputFileLabel.Text = "Output PDF";
            this.LockOutputFileLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LockProcessButton
            // 
            this.LockProcessButton.BackColor = System.Drawing.Color.GhostWhite;
            this.LockProcessButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.LockProcessButton.ForeColor = System.Drawing.Color.White;
            this.LockProcessButton.Image = global::PdfLocker.Properties.Resources.process1;
            this.LockProcessButton.Location = new System.Drawing.Point(338, 704);
            this.LockProcessButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LockProcessButton.Name = "LockProcessButton";
            this.LockProcessButton.Size = new System.Drawing.Size(449, 118);
            this.LockProcessButton.TabIndex = 16;
            this.LockProcessButton.UseVisualStyleBackColor = false;
            this.LockProcessButton.Click += new System.EventHandler(this.LockProcessButton_Click);
            // 
            // LockFileInputLabel
            // 
            this.LockFileInputLabel.Font = new System.Drawing.Font("Consolas", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LockFileInputLabel.Location = new System.Drawing.Point(334, 212);
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
            this.buttonCopy.Location = new System.Drawing.Point(552, 377);
            this.buttonCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(27, 35);
            this.buttonCopy.TabIndex = 12;
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.button1_Click);
            // 
            // LockOutputFileButton
            // 
            this.LockOutputFileButton.BackColor = System.Drawing.Color.Transparent;
            this.LockOutputFileButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.LockOutputFileButton.FlatAppearance.BorderSize = 0;
            this.LockOutputFileButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LockOutputFileButton.ForeColor = System.Drawing.Color.White;
            this.LockOutputFileButton.Image = global::PdfLocker.Properties.Resources.export_pdf;
            this.LockOutputFileButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LockOutputFileButton.Location = new System.Drawing.Point(851, 542);
            this.LockOutputFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LockOutputFileButton.Name = "LockOutputFileButton";
            this.LockOutputFileButton.Size = new System.Drawing.Size(257, 120);
            this.LockOutputFileButton.TabIndex = 15;
            this.LockOutputFileButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LockOutputFileButton.UseVisualStyleBackColor = false;
            this.LockOutputFileButton.Click += new System.EventHandler(this.LockOutputFileButton_Click);
            // 
            // LockInputFileTextBox
            // 
            this.LockInputFileTextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.LockInputFileTextBox.Location = new System.Drawing.Point(338, 261);
            this.LockInputFileTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LockInputFileTextBox.Name = "LockInputFileTextBox";
            this.LockInputFileTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LockInputFileTextBox.Size = new System.Drawing.Size(449, 34);
            this.LockInputFileTextBox.TabIndex = 0;
            // 
            // LockOutputFileTextBox
            // 
            this.LockOutputFileTextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.LockOutputFileTextBox.Location = new System.Drawing.Point(338, 583);
            this.LockOutputFileTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LockOutputFileTextBox.Name = "LockOutputFileTextBox";
            this.LockOutputFileTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LockOutputFileTextBox.Size = new System.Drawing.Size(449, 34);
            this.LockOutputFileTextBox.TabIndex = 2;
            // 
            // LockInputFileButton
            // 
            this.LockInputFileButton.AllowDrop = true;
            this.LockInputFileButton.BackColor = System.Drawing.Color.Transparent;
            this.LockInputFileButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.LockInputFileButton.FlatAppearance.BorderSize = 0;
            this.LockInputFileButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.LockInputFileButton.ForeColor = System.Drawing.Color.White;
            this.LockInputFileButton.Image = global::PdfLocker.Properties.Resources.icons8_upload_64;
            this.LockInputFileButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LockInputFileButton.Location = new System.Drawing.Point(851, 222);
            this.LockInputFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LockInputFileButton.Name = "LockInputFileButton";
            this.LockInputFileButton.Size = new System.Drawing.Size(257, 120);
            this.LockInputFileButton.TabIndex = 13;
            this.LockInputFileButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LockInputFileButton.UseVisualStyleBackColor = false;
            this.LockInputFileButton.Click += new System.EventHandler(this.LockInputFileButton_Click);
            this.LockInputFileButton.DragDrop += new System.Windows.Forms.DragEventHandler(this.LockInputFileButton_DragDrop);
            this.LockInputFileButton.DragEnter += new System.Windows.Forms.DragEventHandler(this.LockInputFileButton_DragEnter);
            // 
            // LockPasswordLabel
            // 
            this.LockPasswordLabel.Font = new System.Drawing.Font("Consolas", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LockPasswordLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LockPasswordLabel.Location = new System.Drawing.Point(334, 370);
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
            this.LockPasswordTextBox.Location = new System.Drawing.Point(338, 417);
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
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.UnlockInvisiblePasswordButton);
            this.tabPage2.Controls.Add(this.UnlockVisiblePasswordButton);
            this.tabPage2.Controls.Add(this.button8);
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
            this.tabPage2.Size = new System.Drawing.Size(1160, 856);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PDF Unlocker";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(911, 664);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 18);
            this.label8.TabIndex = 34;
            this.label8.Text = "Choose a path !";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(898, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Upload or drag here! ";
            // 
            // UnlockInvisiblePasswordButton
            // 
            this.UnlockInvisiblePasswordButton.BackColor = System.Drawing.Color.White;
            this.UnlockInvisiblePasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.UnlockInvisiblePasswordButton.FlatAppearance.BorderSize = 0;
            this.UnlockInvisiblePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnlockInvisiblePasswordButton.ForeColor = System.Drawing.Color.White;
            this.UnlockInvisiblePasswordButton.Image = global::PdfLocker.Properties.Resources.invisible;
            this.UnlockInvisiblePasswordButton.Location = new System.Drawing.Point(476, 379);
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
            this.UnlockVisiblePasswordButton.Location = new System.Drawing.Point(476, 379);
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
            this.button8.Location = new System.Drawing.Point(501, 51);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(157, 138);
            this.button8.TabIndex = 25;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // UnlockOutputFileLabel
            // 
            this.UnlockOutputFileLabel.Font = new System.Drawing.Font("Consolas", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.UnlockOutputFileLabel.ForeColor = System.Drawing.Color.Black;
            this.UnlockOutputFileLabel.Location = new System.Drawing.Point(334, 532);
            this.UnlockOutputFileLabel.Name = "UnlockOutputFileLabel";
            this.UnlockOutputFileLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UnlockOutputFileLabel.Size = new System.Drawing.Size(129, 37);
            this.UnlockOutputFileLabel.TabIndex = 20;
            this.UnlockOutputFileLabel.Text = "Output PDF";
            this.UnlockOutputFileLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // UnlockProcessButton
            // 
            this.UnlockProcessButton.BackColor = System.Drawing.Color.GhostWhite;
            this.UnlockProcessButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.UnlockProcessButton.ForeColor = System.Drawing.Color.White;
            this.UnlockProcessButton.Image = global::PdfLocker.Properties.Resources.process1;
            this.UnlockProcessButton.Location = new System.Drawing.Point(339, 704);
            this.UnlockProcessButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnlockProcessButton.Name = "UnlockProcessButton";
            this.UnlockProcessButton.Size = new System.Drawing.Size(448, 118);
            this.UnlockProcessButton.TabIndex = 23;
            this.UnlockProcessButton.UseVisualStyleBackColor = false;
            this.UnlockProcessButton.Click += new System.EventHandler(this.UnlockProcessButton_Click);
            // 
            // UnLockOutputFileButton
            // 
            this.UnLockOutputFileButton.BackColor = System.Drawing.Color.Transparent;
            this.UnLockOutputFileButton.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.UnLockOutputFileButton.FlatAppearance.BorderSize = 0;
            this.UnLockOutputFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.UnLockOutputFileButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnLockOutputFileButton.ForeColor = System.Drawing.Color.White;
            this.UnLockOutputFileButton.Image = global::PdfLocker.Properties.Resources.export_pdf;
            this.UnLockOutputFileButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UnLockOutputFileButton.Location = new System.Drawing.Point(851, 542);
            this.UnLockOutputFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnLockOutputFileButton.Name = "UnLockOutputFileButton";
            this.UnLockOutputFileButton.Size = new System.Drawing.Size(257, 120);
            this.UnLockOutputFileButton.TabIndex = 22;
            this.UnLockOutputFileButton.UseVisualStyleBackColor = false;
            this.UnLockOutputFileButton.Click += new System.EventHandler(this.UnLockOutputFileButton_Click);
            // 
            // UnlockOutputFileTextBox
            // 
            this.UnlockOutputFileTextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.UnlockOutputFileTextBox.Location = new System.Drawing.Point(338, 583);
            this.UnlockOutputFileTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnlockOutputFileTextBox.Name = "UnlockOutputFileTextBox";
            this.UnlockOutputFileTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UnlockOutputFileTextBox.Size = new System.Drawing.Size(449, 34);
            this.UnlockOutputFileTextBox.TabIndex = 18;
            // 
            // UnlockPasswordLabel
            // 
            this.UnlockPasswordLabel.Font = new System.Drawing.Font("Consolas", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.UnlockPasswordLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.UnlockPasswordLabel.Location = new System.Drawing.Point(334, 370);
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
            this.UnlockPasswordTextBox.Location = new System.Drawing.Point(338, 417);
            this.UnlockPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnlockPasswordTextBox.Name = "UnlockPasswordTextBox";
            this.UnlockPasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UnlockPasswordTextBox.Size = new System.Drawing.Size(449, 34);
            this.UnlockPasswordTextBox.TabIndex = 17;
            // 
            // UnLockInputFileButton
            // 
            this.UnLockInputFileButton.AllowDrop = true;
            this.UnLockInputFileButton.BackColor = System.Drawing.Color.Transparent;
            this.UnLockInputFileButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.UnLockInputFileButton.FlatAppearance.BorderSize = 0;
            this.UnLockInputFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.UnLockInputFileButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.UnLockInputFileButton.ForeColor = System.Drawing.Color.Black;
            this.UnLockInputFileButton.Image = global::PdfLocker.Properties.Resources.icons8_upload_64;
            this.UnLockInputFileButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UnLockInputFileButton.Location = new System.Drawing.Point(851, 222);
            this.UnLockInputFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnLockInputFileButton.Name = "UnLockInputFileButton";
            this.UnLockInputFileButton.Size = new System.Drawing.Size(257, 120);
            this.UnLockInputFileButton.TabIndex = 14;
            this.UnLockInputFileButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UnLockInputFileButton.UseVisualStyleBackColor = false;
            this.UnLockInputFileButton.Click += new System.EventHandler(this.UnLockInputFileButton_Click);
            this.UnLockInputFileButton.DragDrop += new System.Windows.Forms.DragEventHandler(this.UnlockInputFileButton_DragDrop);
            this.UnLockInputFileButton.DragEnter += new System.Windows.Forms.DragEventHandler(this.UnlockInputFileButton_DragEnter);
            // 
            // UnlockInputFileTextBox
            // 
            this.UnlockInputFileTextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.UnlockInputFileTextBox.Location = new System.Drawing.Point(338, 261);
            this.UnlockInputFileTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnlockInputFileTextBox.Name = "UnlockInputFileTextBox";
            this.UnlockInputFileTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UnlockInputFileTextBox.Size = new System.Drawing.Size(425, 34);
            this.UnlockInputFileTextBox.TabIndex = 5;
            // 
            // UnlockInputFileLabel
            // 
            this.UnlockInputFileLabel.Font = new System.Drawing.Font("Consolas", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.UnlockInputFileLabel.Location = new System.Drawing.Point(334, 212);
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
            this.unlockPDFToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1168, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lockPDFToolStripMenuItem
            // 
            this.lockPDFToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lockPDFToolStripMenuItem.Image = global::PdfLocker.Properties.Resources.image;
            this.lockPDFToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lockPDFToolStripMenuItem.Name = "lockPDFToolStripMenuItem";
            this.lockPDFToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.lockPDFToolStripMenuItem.Text = "LockPDF";
            this.lockPDFToolStripMenuItem.Click += new System.EventHandler(this.lockPDFToolStripMenuItem_Click);
            // 
            // unlockPDFToolStripMenuItem
            // 
            this.unlockPDFToolStripMenuItem.Image = global::PdfLocker.Properties.Resources.unlocked;
            this.unlockPDFToolStripMenuItem.Margin = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.unlockPDFToolStripMenuItem.Name = "unlockPDFToolStripMenuItem";
            this.unlockPDFToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.unlockPDFToolStripMenuItem.Text = "UnlockPDF";
            this.unlockPDFToolStripMenuItem.Click += new System.EventHandler(this.unlockPDFToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::PdfLocker.Properties.Resources.about;
            this.aboutToolStripMenuItem.Margin = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1168, 899);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SecurePDF";
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

        private void UnlockInputFileButton_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the dragged item is a file
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                // Check if the file has a .pdf extension
                if (files.Length > 0 && Path.GetExtension(files[0]).Equals(".pdf", StringComparison.OrdinalIgnoreCase))
                {
                    e.Effect = DragDropEffects.Copy; // Allow drag-and-drop if the file is a PDF
                }
                else
                {
                    e.Effect = DragDropEffects.None; // Reject if the file is not a PDF
                }
            }
            else
            {
                e.Effect = DragDropEffects.None; // Reject if the dragged item is not a file
            }
        }

        private void UnlockInputFileButton_DragDrop(object sender, DragEventArgs e)
        {
            // Retrieve the file path of the dropped file
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                string filePath = files[0];

                // Display the file path in the text box
                this.UnlockInputFileTextBox.Text = filePath;
                // MessageBox.Show($"Selected file: {filePath}");
            }
        }

        private void LockInputFileButton_DragDrop(object sender, DragEventArgs e)
        {
            // Retrieve the file path of the dropped file
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                string filePath = files[0];

                // Display the file path in the text box
                this.LockInputFileTextBox.Text = filePath;
                //MessageBox.Show($"Selected file: {filePath}");
            }
        }

        private void LockInputFileButton_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the dragged item is a file
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                // Check if the file has a .pdf extension
                if (files.Length > 0 && Path.GetExtension(files[0]).Equals(".pdf", StringComparison.OrdinalIgnoreCase))
                {
                    e.Effect = DragDropEffects.Copy; // Allow drag-and-drop if the file is a PDF
                }
                else
                {
                    e.Effect = DragDropEffects.None; // Reject if the file is not a PDF
                }
            }
            else
            {
                e.Effect = DragDropEffects.None; // Reject if the dragged item is not a file
            }
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
        private System.Windows.Forms.TextBox UnlockInputFileTextBox;
        private System.Windows.Forms.Label UnlockInputFileLabel;
        private System.Windows.Forms.Label UnlockOutputFileLabel;
        private System.Windows.Forms.Button UnlockProcessButton;
        private System.Windows.Forms.Button UnLockOutputFileButton;
        private System.Windows.Forms.TextBox UnlockOutputFileTextBox;
        private System.Windows.Forms.Label UnlockPasswordLabel;
        private System.Windows.Forms.TextBox UnlockPasswordTextBox;
        private System.Windows.Forms.Button button8;
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
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button UnLockInputFileButton;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label8;
        private ToolTip toolTip1;
        private NotifyIcon notifyIcon1;
    }
}

