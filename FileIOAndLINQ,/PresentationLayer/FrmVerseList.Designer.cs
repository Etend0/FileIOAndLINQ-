namespace FileIOAndLINQ.PresentationLayer
{
    partial class FrmVerseList
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
            mnsFileActions = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            grpAddVerse = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbVerseBook = new ComboBox();
            txtVerseChapter = new TextBox();
            txtVerseVerse = new TextBox();
            txtVerseText = new TextBox();
            txtVerseMeaning = new TextBox();
            nudVerseImportance = new NumericUpDown();
            btnAddVerse = new Button();
            lblBookError = new Label();
            lblChapterError = new Label();
            lblVerseError = new Label();
            lblTextError = new Label();
            lblMeaningError = new Label();
            lblImportanceError = new Label();
            grpFilterSort = new GroupBox();
            rdoShowAll = new RadioButton();
            rdoShowLeastValuable = new RadioButton();
            rdoShowMostValuable = new RadioButton();
            trbNumberToShow = new TrackBar();
            dgvVerseDisplay = new DataGridView();
            mnsFileActions.SuspendLayout();
            grpAddVerse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudVerseImportance).BeginInit();
            grpFilterSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbNumberToShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVerseDisplay).BeginInit();
            SuspendLayout();
            // 
            // mnsFileActions
            // 
            mnsFileActions.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            mnsFileActions.Location = new Point(0, 0);
            mnsFileActions.Name = "mnsFileActions";
            mnsFileActions.Size = new Size(981, 24);
            mnsFileActions.TabIndex = 0;
            mnsFileActions.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(180, 22);
            loadToolStripMenuItem.Text = "Load";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // grpAddVerse
            // 
            grpAddVerse.Controls.Add(lblImportanceError);
            grpAddVerse.Controls.Add(lblMeaningError);
            grpAddVerse.Controls.Add(lblTextError);
            grpAddVerse.Controls.Add(lblVerseError);
            grpAddVerse.Controls.Add(lblChapterError);
            grpAddVerse.Controls.Add(lblBookError);
            grpAddVerse.Controls.Add(btnAddVerse);
            grpAddVerse.Controls.Add(nudVerseImportance);
            grpAddVerse.Controls.Add(txtVerseMeaning);
            grpAddVerse.Controls.Add(txtVerseText);
            grpAddVerse.Controls.Add(txtVerseVerse);
            grpAddVerse.Controls.Add(txtVerseChapter);
            grpAddVerse.Controls.Add(cmbVerseBook);
            grpAddVerse.Controls.Add(label5);
            grpAddVerse.Controls.Add(label6);
            grpAddVerse.Controls.Add(label3);
            grpAddVerse.Controls.Add(label4);
            grpAddVerse.Controls.Add(label2);
            grpAddVerse.Controls.Add(label1);
            grpAddVerse.Location = new Point(12, 27);
            grpAddVerse.Name = "grpAddVerse";
            grpAddVerse.Size = new Size(300, 469);
            grpAddVerse.TabIndex = 1;
            grpAddVerse.TabStop = false;
            grpAddVerse.Text = "Add A Bible Verse";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 38);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Book:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 91);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Chapter:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 189);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 3;
            label3.Text = "Text:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 143);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 2;
            label4.Text = "Verse:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 397);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 5;
            label5.Text = "Importance:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 295);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 4;
            label6.Text = "Meaning:";
            // 
            // cmbVerseBook
            // 
            cmbVerseBook.FormattingEnabled = true;
            cmbVerseBook.Location = new Point(86, 35);
            cmbVerseBook.Name = "cmbVerseBook";
            cmbVerseBook.Size = new Size(203, 23);
            cmbVerseBook.TabIndex = 6;
            // 
            // txtVerseChapter
            // 
            txtVerseChapter.Location = new Point(86, 88);
            txtVerseChapter.Name = "txtVerseChapter";
            txtVerseChapter.Size = new Size(204, 23);
            txtVerseChapter.TabIndex = 7;
            // 
            // txtVerseVerse
            // 
            txtVerseVerse.Location = new Point(85, 140);
            txtVerseVerse.Name = "txtVerseVerse";
            txtVerseVerse.Size = new Size(204, 23);
            txtVerseVerse.TabIndex = 8;
            // 
            // txtVerseText
            // 
            txtVerseText.Location = new Point(85, 189);
            txtVerseText.Multiline = true;
            txtVerseText.Name = "txtVerseText";
            txtVerseText.Size = new Size(204, 73);
            txtVerseText.TabIndex = 9;
            // 
            // txtVerseMeaning
            // 
            txtVerseMeaning.Location = new Point(85, 292);
            txtVerseMeaning.Multiline = true;
            txtVerseMeaning.Name = "txtVerseMeaning";
            txtVerseMeaning.Size = new Size(204, 76);
            txtVerseMeaning.TabIndex = 10;
            // 
            // nudVerseImportance
            // 
            nudVerseImportance.Location = new Point(85, 395);
            nudVerseImportance.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudVerseImportance.Name = "nudVerseImportance";
            nudVerseImportance.Size = new Size(203, 23);
            nudVerseImportance.TabIndex = 11;
            // 
            // btnAddVerse
            // 
            btnAddVerse.Location = new Point(107, 439);
            btnAddVerse.Name = "btnAddVerse";
            btnAddVerse.Size = new Size(75, 23);
            btnAddVerse.TabIndex = 12;
            btnAddVerse.Text = "button1";
            btnAddVerse.UseVisualStyleBackColor = true;
            // 
            // lblBookError
            // 
            lblBookError.AutoSize = true;
            lblBookError.BackColor = SystemColors.Control;
            lblBookError.ForeColor = Color.Red;
            lblBookError.Location = new Point(88, 61);
            lblBookError.Name = "lblBookError";
            lblBookError.Size = new Size(62, 15);
            lblBookError.TabIndex = 13;
            lblBookError.Text = "Book Error";
            // 
            // lblChapterError
            // 
            lblChapterError.AutoSize = true;
            lblChapterError.BackColor = SystemColors.Control;
            lblChapterError.ForeColor = Color.Red;
            lblChapterError.Location = new Point(85, 114);
            lblChapterError.Name = "lblChapterError";
            lblChapterError.Size = new Size(77, 15);
            lblChapterError.TabIndex = 14;
            lblChapterError.Text = "Chapter Error";
            // 
            // lblVerseError
            // 
            lblVerseError.AutoSize = true;
            lblVerseError.BackColor = SystemColors.Control;
            lblVerseError.ForeColor = Color.Red;
            lblVerseError.Location = new Point(85, 166);
            lblVerseError.Name = "lblVerseError";
            lblVerseError.Size = new Size(62, 15);
            lblVerseError.TabIndex = 15;
            lblVerseError.Text = "Verse Error";
            // 
            // lblTextError
            // 
            lblTextError.AutoSize = true;
            lblTextError.BackColor = SystemColors.Control;
            lblTextError.ForeColor = Color.Red;
            lblTextError.Location = new Point(85, 265);
            lblTextError.Name = "lblTextError";
            lblTextError.Size = new Size(56, 15);
            lblTextError.TabIndex = 16;
            lblTextError.Text = "Text Error";
            // 
            // lblMeaningError
            // 
            lblMeaningError.AutoSize = true;
            lblMeaningError.BackColor = SystemColors.Control;
            lblMeaningError.ForeColor = Color.Red;
            lblMeaningError.Location = new Point(85, 371);
            lblMeaningError.Name = "lblMeaningError";
            lblMeaningError.Size = new Size(82, 15);
            lblMeaningError.TabIndex = 17;
            lblMeaningError.Text = "Meaning Error";
            // 
            // lblImportanceError
            // 
            lblImportanceError.AutoSize = true;
            lblImportanceError.BackColor = SystemColors.Control;
            lblImportanceError.ForeColor = Color.Red;
            lblImportanceError.Location = new Point(86, 421);
            lblImportanceError.Name = "lblImportanceError";
            lblImportanceError.Size = new Size(96, 15);
            lblImportanceError.TabIndex = 18;
            lblImportanceError.Text = "Importance Error";
            // 
            // grpFilterSort
            // 
            grpFilterSort.Controls.Add(rdoShowMostValuable);
            grpFilterSort.Controls.Add(rdoShowLeastValuable);
            grpFilterSort.Controls.Add(rdoShowAll);
            grpFilterSort.Location = new Point(12, 502);
            grpFilterSort.Name = "grpFilterSort";
            grpFilterSort.Size = new Size(300, 117);
            grpFilterSort.TabIndex = 2;
            grpFilterSort.TabStop = false;
            grpFilterSort.Text = "Filter And Sort";
            // 
            // rdoShowAll
            // 
            rdoShowAll.AutoSize = true;
            rdoShowAll.Location = new Point(10, 31);
            rdoShowAll.Name = "rdoShowAll";
            rdoShowAll.Size = new Size(71, 19);
            rdoShowAll.TabIndex = 0;
            rdoShowAll.TabStop = true;
            rdoShowAll.Text = "Show All";
            rdoShowAll.UseVisualStyleBackColor = true;
            // 
            // rdoShowLeastValuable
            // 
            rdoShowLeastValuable.AutoSize = true;
            rdoShowLeastValuable.Location = new Point(11, 56);
            rdoShowLeastValuable.Name = "rdoShowLeastValuable";
            rdoShowLeastValuable.Size = new Size(140, 19);
            rdoShowLeastValuable.TabIndex = 1;
            rdoShowLeastValuable.TabStop = true;
            rdoShowLeastValuable.Text = "Show Least Important";
            rdoShowLeastValuable.UseVisualStyleBackColor = true;
            // 
            // rdoShowMostValuable
            // 
            rdoShowMostValuable.AutoSize = true;
            rdoShowMostValuable.Location = new Point(11, 81);
            rdoShowMostValuable.Name = "rdoShowMostValuable";
            rdoShowMostValuable.Size = new Size(140, 19);
            rdoShowMostValuable.TabIndex = 2;
            rdoShowMostValuable.TabStop = true;
            rdoShowMostValuable.Text = "Show Most Important";
            rdoShowMostValuable.UseVisualStyleBackColor = true;
            // 
            // trbNumberToShow
            // 
            trbNumberToShow.Location = new Point(12, 625);
            trbNumberToShow.Name = "trbNumberToShow";
            trbNumberToShow.Size = new Size(300, 45);
            trbNumberToShow.TabIndex = 3;
            // 
            // dgvVerseDisplay
            // 
            dgvVerseDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVerseDisplay.Location = new Point(318, 35);
            dgvVerseDisplay.Name = "dgvVerseDisplay";
            dgvVerseDisplay.Size = new Size(651, 517);
            dgvVerseDisplay.TabIndex = 4;
            // 
            // FrmVerseList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 679);
            Controls.Add(dgvVerseDisplay);
            Controls.Add(trbNumberToShow);
            Controls.Add(grpFilterSort);
            Controls.Add(grpAddVerse);
            Controls.Add(mnsFileActions);
            MainMenuStrip = mnsFileActions;
            Name = "FrmVerseList";
            Text = "Bible Verses";
            mnsFileActions.ResumeLayout(false);
            mnsFileActions.PerformLayout();
            grpAddVerse.ResumeLayout(false);
            grpAddVerse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudVerseImportance).EndInit();
            grpFilterSort.ResumeLayout(false);
            grpFilterSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trbNumberToShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVerseDisplay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsFileActions;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private GroupBox grpAddVerse;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private ComboBox cmbVerseBook;
        private Label label5;
        private Label label6;
        private NumericUpDown nudVerseImportance;
        private TextBox txtVerseMeaning;
        private TextBox txtVerseText;
        private TextBox txtVerseVerse;
        private TextBox txtVerseChapter;
        private Label lblTextError;
        private Label lblVerseError;
        private Label lblChapterError;
        private Label lblBookError;
        private Button btnAddVerse;
        private Label lblImportanceError;
        private Label lblMeaningError;
        private GroupBox grpFilterSort;
        private RadioButton rdoShowMostValuable;
        private RadioButton rdoShowLeastValuable;
        private RadioButton rdoShowAll;
        private TrackBar trbNumberToShow;
        private DataGridView dgvVerseDisplay;
    }
}