namespace W3ProgrammingExercise3
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
            this.button1 = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxToLower = new System.Windows.Forms.ListBox();
            this.labelParsedFile = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxAlphabet = new System.Windows.Forms.ListBox();
            this.listBoxLongestWord = new System.Windows.Forms.ListBox();
            this.labelAlphabet = new System.Windows.Forms.Label();
            this.labelLongestWord = new System.Windows.Forms.Label();
            this.listBoxMostVowels = new System.Windows.Forms.ListBox();
            this.labelMostVowels = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "open file (button1)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 54);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(194, 82);
            this.listBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Given File:";
            // 
            // listBoxToLower
            // 
            this.listBoxToLower.FormattingEnabled = true;
            this.listBoxToLower.Location = new System.Drawing.Point(12, 184);
            this.listBoxToLower.Name = "listBoxToLower";
            this.listBoxToLower.Size = new System.Drawing.Size(194, 69);
            this.listBoxToLower.TabIndex = 3;
            // 
            // labelParsedFile
            // 
            this.labelParsedFile.AutoSize = true;
            this.labelParsedFile.Location = new System.Drawing.Point(12, 168);
            this.labelParsedFile.Name = "labelParsedFile";
            this.labelParsedFile.Size = new System.Drawing.Size(62, 13);
            this.labelParsedFile.TabIndex = 4;
            this.labelParsedFile.Text = "Parsed File:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Parse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBoxAlphabet
            // 
            this.listBoxAlphabet.FormattingEnabled = true;
            this.listBoxAlphabet.Location = new System.Drawing.Point(12, 272);
            this.listBoxAlphabet.Name = "listBoxAlphabet";
            this.listBoxAlphabet.Size = new System.Drawing.Size(194, 56);
            this.listBoxAlphabet.TabIndex = 6;
            // 
            // listBoxLongestWord
            // 
            this.listBoxLongestWord.FormattingEnabled = true;
            this.listBoxLongestWord.Location = new System.Drawing.Point(12, 347);
            this.listBoxLongestWord.Name = "listBoxLongestWord";
            this.listBoxLongestWord.Size = new System.Drawing.Size(194, 30);
            this.listBoxLongestWord.TabIndex = 7;
            // 
            // labelAlphabet
            // 
            this.labelAlphabet.AutoSize = true;
            this.labelAlphabet.Location = new System.Drawing.Point(9, 256);
            this.labelAlphabet.Name = "labelAlphabet";
            this.labelAlphabet.Size = new System.Drawing.Size(167, 13);
            this.labelAlphabet.TabIndex = 8;
            this.labelAlphabet.Text = "First and Last Word Alphabetically";
            // 
            // labelLongestWord
            // 
            this.labelLongestWord.AutoSize = true;
            this.labelLongestWord.Location = new System.Drawing.Point(9, 331);
            this.labelLongestWord.Name = "labelLongestWord";
            this.labelLongestWord.Size = new System.Drawing.Size(74, 13);
            this.labelLongestWord.TabIndex = 9;
            this.labelLongestWord.Text = "Longest Word";
            // 
            // listBoxMostVowels
            // 
            this.listBoxMostVowels.FormattingEnabled = true;
            this.listBoxMostVowels.Location = new System.Drawing.Point(12, 395);
            this.listBoxMostVowels.Name = "listBoxMostVowels";
            this.listBoxMostVowels.Size = new System.Drawing.Size(194, 30);
            this.listBoxMostVowels.TabIndex = 10;
            // 
            // labelMostVowels
            // 
            this.labelMostVowels.AutoSize = true;
            this.labelMostVowels.Location = new System.Drawing.Point(9, 380);
            this.labelMostVowels.Name = "labelMostVowels";
            this.labelMostVowels.Size = new System.Drawing.Size(67, 13);
            this.labelMostVowels.TabIndex = 11;
            this.labelMostVowels.Text = "Most Vowels";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.labelMostVowels);
            this.Controls.Add(this.listBoxMostVowels);
            this.Controls.Add(this.labelLongestWord);
            this.Controls.Add(this.labelAlphabet);
            this.Controls.Add(this.listBoxLongestWord);
            this.Controls.Add(this.listBoxAlphabet);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelParsedFile);
            this.Controls.Add(this.listBoxToLower);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxToLower;
        private System.Windows.Forms.Label labelParsedFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxAlphabet;
        private System.Windows.Forms.ListBox listBoxLongestWord;
        private System.Windows.Forms.Label labelAlphabet;
        private System.Windows.Forms.Label labelLongestWord;
        private System.Windows.Forms.ListBox listBoxMostVowels;
        private System.Windows.Forms.Label labelMostVowels;
    }
}

